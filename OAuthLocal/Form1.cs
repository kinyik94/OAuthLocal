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
    public partial class Oauth_Form : Form
    {

        private string Base_URL = "http://localhost:49600/";

        public AuthenticationObject User = null;

        public Oauth_Form()
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
            try
            {
                StreamWriter asd = new StreamWriter(req.GetRequestStream());
                asd.Write(data);
                asd.Flush();
                asd.Close();
            
                HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());

                StringWriter responseString = new StringWriter();
                responseString.Write(reader.ReadToEnd());
                ResponseBox.Text = responseString.ToString();

                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    string response = responseString.ToString();
                    string[] attributes = response.Substring(1, response.Length - 2).Split(',');
                    Dictionary<string, string> AttrValues = new Dictionary<string, string>();
                    for (int i = 0; i < attributes.Length; i++)
                    {
                        string[] attr = attributes[i].Split(':');
                        AttrValues[attr[0].Substring(1, attr[0].Length - 2)] = attr[1].Substring(1, attr[1].Length - 2);
                    }

                    User = new AuthenticationObject(AttrValues["access_token"], login_username_textbox.Text, AttrValues["expires_in"], AttrValues["token_type"]);

                    Token.Text = User.Token;
                    UserName.Text = User.UserName;
                }

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
