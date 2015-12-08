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

    /*
     * Just a window what print out the username of the user who logged in.
     * 
     * If we on this window, we already have authentication token and we can send request
     * to the server and get data what we can reach.
     * 
     */

    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            user_username.Text = Program.User.UserName;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
