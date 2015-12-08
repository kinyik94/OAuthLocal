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
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }

        /*
         * Creates a post request to the provider to register an account.
         * 
         * Url: http://localhost:49600/api/account/register
         * 
         * Data: the username and password for the new account
         * If the request is OK, we get back to the default window
         */

        private void signup_button_Click(object sender, EventArgs e)
        {
            string url = Program.Base_URL + "api/account/register";

            string data = "{\"username\":\"" + signup_username_textbox.Text + "\"," +
                           "\"password\":\"" + signup_password_textbox.Text + "\"," +
                           "\"confirmpassword\":\"" + signup_password_textbox.Text + "\"}";
            try
            {
                string responseString = Program.SendRequest(url, data);
                Owner.Show();
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
