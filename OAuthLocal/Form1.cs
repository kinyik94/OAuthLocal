using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace OAuthLocal
{
    public partial class Form1 : Form
    {

        private string Base_URL = "http://localhost:49600/";

        public Form1()
        {
            InitializeComponent();
        }

        private void sendRequest(string url, string data, string type = "application/json")
        {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "POST";

            req.Credentials = CredentialCache.DefaultCredentials;
            req.UserAgent = ".NET Framework Example Client";
            req.ContentType = type;
            StreamWriter asd = new StreamWriter(req.GetRequestStream());
            asd.Write(data);
            asd.Flush();
            asd.Close();

            try
            {
                HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());

                StringWriter responseString = new StringWriter();
                responseString.Write(reader.ReadToEnd());
                ResponseBox.Text = responseString.ToString();

                responseString.Close();
            }
            catch (Exception ex)
            {
                ResponseBox.Text = ex.ToString();
            }

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string url = Base_URL + "token";

            string data = "grant_type=password" +
                           "&username=" + login_username_textbox.Text +
                           "&password=" + login_password_textbox.Text;

            sendRequest(url, data, "application/x-www-form-urlencoded");
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            string url = Base_URL +"api/account/register";

            string data = "{\"username\":\"" + signup_username_textbox.Text + "\"," +
                           "\"password\":\"" + signup_password_textbox.Text + "\"," +
                           "\"confirmpassword\":\"" + signup_password_textbox.Text + "\"}";

           sendRequest(url, data);
        }
    }
}
