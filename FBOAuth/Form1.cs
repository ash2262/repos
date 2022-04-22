using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Facebook;



namespace FBOAuth
{
    public partial class Form1 : Form
    {
        public string AccessToken { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                HttpClient _httpClient = new HttpClient();


                string AppId = "673340473848510";
                string AppSecret = "bf3544963602f25506abf28ada75e7af";
                string AuthenticationUrlFormat =
                   "https://www.facebook.com/v12.0/dialog/oauth?response_type=token&display=popup&client_id=1335534790242626&redirect_uri=https%3A%2F%2Fdevelopers.facebook.com%2Ftools%2Fexplorer%2Fcallback&scope=pages_read_engagement";
                // "https://graph.facebook.com/oauth/access_token?client_id={0}&client_secret={1}&grant_type=client_credentials&scope=manage_pages,offline_access,publish_stream";
                //string AuthenticationUrlFormat = "https://graph.facebook.com/v12.0/dialog/oauth?access_token?client_id={0}&display=popup&response_type=token&redirect_uri=ms-app://{package-security-identifier}";

                //string scope = "publish_stream,manage_pages";
                string url = string.Format(AuthenticationUrlFormat, AppId, AppSecret, "manage_pages,publish_stream");
                webBrowser1.Navigate(new Uri (AuthenticationUrlFormat,UriKind.Absolute));

                var response = _httpClient.GetStringAsync(url);
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


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Inside Finally");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // MessageBox.Show(e.Url.Fragment);

        }
        private void webBrowser1_Navigated(object sender,
    WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            //MessageBox.Show(e.Url.Fragment);
            if((e.Url.Fragment.Split('&')[0].Replace("#access_token=", ""))!= ""){ 
            AccessToken = e.Url.Fragment.Split('&')[0].Replace("#access_token=", "");
                MessageBox.Show(AccessToken);
            }
        }
    }
}

