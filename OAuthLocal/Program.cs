using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OAuthLocal
{

    public class AuthenticationObject
    {

        /*
         * This class responsible for store the authentication information
         * such as username, token, etc.
         */

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
        /// 
        
        /*
         * Set our user to null
         * Set the Base url
         * 
         * Send request method creates the responses to the server
         * 
         */

        public static AuthenticationObject User = null;
        public static string Base_URL = "http://localhost:49600/";

        public static string SendRequest(string url, string data,  string type = "application/json")
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";

            req.Credentials = CredentialCache.DefaultCredentials;
            req.UserAgent = ".NET Framework Example Client";
            req.ContentType = type;
            StringWriter responseString = new StringWriter();
            try
            {
                StreamWriter str = new StreamWriter(req.GetRequestStream());
                str.Write(data);
                str.Flush();
                str.Close();

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());

                responseString.Write(reader.ReadToEnd());
                if (resp.StatusCode == HttpStatusCode.OK)
                    return responseString.ToString();
                else throw new Exception("Bad Request");
                
            }
            finally
            {
                responseString.Close();
            }

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Oauth_Form());
        }
    }
}
