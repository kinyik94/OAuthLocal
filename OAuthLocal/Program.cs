using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuthLocal
{

    public class AuthenticationObject
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
        public string Expire { get; set; }

        public AuthenticationObject(string token, string name, string type, string expire)
        {
            Token = token;
            UserName = name;
            Type = type;
            Expire = expire;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Oauth_Form());
        }
    }
}
