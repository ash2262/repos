using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Facebook;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Specialized;
namespace FBOAuth
{
    public partial class frmAccounts : Form
    {
        
        public frmAccounts()
        {
            //InitializeComponent();
            
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient _httpClient = new HttpClient();

                
                string AppId = "1335534790242626";
                string AppSecret = "35785f10c275f39e9b2e882b4bac0e72";
                //string AuthenticationUrlFormat =
                //"https://graph.facebook.com/oauth/access_token?client_id={0}&client_secret={1}&grant_type=client_credentials&scope=manage_pages,offline_access,publish_stream";
                string AuthenticationUrlFormat = "https://graph.facebook.com/v12.0/dialog/oauth?access_token?client_id={0}&display=popup&response_type=token&redirect_uri=ms-app://{package-security-identifier}";

                //string scope = "publish_stream,manage_pages";
                string url = string.Format(AuthenticationUrlFormat, AppId, AppSecret, "manage_pages,publish_stream");
                var response=  _httpClient.GetStringAsync(url);
                MessageBox.Show("Authenticating");
                MessageBox.Show(response.Result.ToString());
                //NameValueCollection query = HttpUtility.ParseQueryString(response.ToString());

                Dictionary<string, string> tokens = new Dictionary<string, string>();

                foreach (string token in response.Result.Split(','))
                {
                    tokens.Add(token.Substring(1, token.IndexOf(":")), token.Substring(token.IndexOf(":") + 1));
                }
                //var accessToken = "EAASZBqWzB8UIBANcu1WcrPcOsyYz1hBkyT1z7l65wxAcWYsV0TFAZBj2dgY5omEBYl4o9aklpbcZAObkJlZCU2b4roxIyjOPKCrIxArZA0YRMUpmzD2VVOoMFGmuqXsnj4CK8GcZB0vGZC4IG07xkiiaiIc8sYgCoNMlindA2RkzOxQQEdBOEH3qUlvU7RfPgG76QV05wFmogZDZD";
                // var accessToken = response.Result;
                
                var accessToken = tokens["\"access_token\":"];
                accessToken = accessToken.Substring(2, accessToken.Length - 3);
                var facebookclient = new FacebookClient();

            var facebookservice = new FacebookService(facebookclient);

            var getAccountTask = facebookservice.GetAccountAsync(accessToken);

            //Task.WaitAll(facebookclient.PostAsync(accessToken,"me", "hello from c#"));
            MessageBox.Show("getting details");
            
            var account = getAccountTask.Result;
            
            MessageBox.Show(account.Name);
                MessageBox.Show(account.Id);
                //Console.WriteLine($"{account.Id} {account.Name}");
                //var postOnWallTask = facebookservice.PostOnWallAsync(accessToken, "Hello from C# .NET Core!",account.Id);
                // Task.WaitAll(postOnWallTask);
                var fbclient = new Facebook.FacebookClient(accessToken);
                fbclient.Post("/me/feed", new { message = "Test from c#" });
                //fbclient.Post(new { Message = "Test from c#" });
                // MessageBox.Show(postOnWallTask.Id.ToString());
                MessageBox.Show("posted on FB page");
            }
            catch (Exception ex)
            {

                //throw;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("done");
            }
        }
    }
    
}
