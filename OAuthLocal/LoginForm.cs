using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuthLocal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            /*
             * Send a http POST request to the provider.
             * The Url: http://localhost:49600/token
             * data contains the username and the password
             * in the response we get the authentication token 
             * if we have account with the username and password
             * 
             * Save the token for later requests
             * 
             * If we don't have account we get Error what we write out to the TextBox
             */

            string url = Program.Base_URL + "token";

            string data = "grant_type=password" +
                           "&username=" + login_username_textbox.Text +
                           "&password=" + login_password_textbox.Text;
            try
            {
                string responseString = Program.SendRequest(url, data, "application/x-www-form-urlencoded");
                string response = responseString;
                string[] attributes = response.Substring(1, response.Length - 2).Split(',');
                Dictionary<string, string> AttrValues = new Dictionary<string, string>();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string[] attr = attributes[i].Split(':');
                    AttrValues[attr[0].Substring(1, attr[0].Length - 2)] = attr[1].Substring(1, attr[1].Length - 2);
                }

                Program.User = new AuthenticationObject(AttrValues["access_token"], login_username_textbox.Text,
                    AttrValues["expires_in"], AttrValues["token_type"]);

                UserForm form = new UserForm();
                form.Owner = Owner;
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                ResponseBox.Text = ex.Message;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
