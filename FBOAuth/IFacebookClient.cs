using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Facebook;
namespace FBOAuth
{
    public interface IFacebookClient
    {
        Task<T> GetAsync<T>(string accessToken, string endpoint, string args = null);
        Task<T> PostAsync<T>(string accessToken, string endpoint, string pagid, object data, string args = null);
        
        
    }

    public class FacebookClient : IFacebookClient
    {
        private readonly HttpClient _httpClient;

        public FacebookClient()
        {
            _httpClient = new HttpClient
            {
                //BaseAddress = new Uri("https://graph.facebook.com/v12.0/")
                BaseAddress = new Uri("https://graph.facebook.com/v12.0/")
            };
            _httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetAsync<T>(string accessToken, string endpoint, string args = null)
        {
            
            //string response = await _httpClient.GetStringAsync("https://graph.facebook.com/v12.0/me?access_token=" + accessToken);
            //string response = await _httpClient.GetStringAsync("https://graph.facebook.com/v12.0/me?access_token=EAASZBqWzB8UIBAKZC5QHVzwCWnxlB5HYDgm311ZAViOZCkVI2DOZBY5AvhsqLS93cTuBgQv3c4fntCYwuhFg3lFCllY1rcUuZCZArZAypwqFR7jkseyAubgpYZCEANZAXnhJWH7ecG4YBCNNGRzNKCtWvkEnmV7QdWbGDAuvGDibrZAu528jajCRMS4eZACx9weM7YAZD");
            var response = await _httpClient.GetAsync($"{endpoint}?&{args}&access_token={accessToken}");
            //Console.WriteLine(response);
           // if (!response.IsSuccessStatusCode)
               // return default(T);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> PostAsync<T>(string accessToken, string endpoint, string pageid,object data, string args = null)
        {
            var payload = GetPayload(data);
            //var response= await _httpClient.PostAsync($"{endpoint}?access_token={accessToken}&{args}", payload);
            var URL= "https://graph.facebook.com/" + pageid + "/feed?message="+payload+"access_token="+accessToken;
            //var response = await _httpClient.PostAsync($"https://graph.facebook.com/"+pageid+"/access_token={accessToken}&{args}", payload);
            var response = await _httpClient.PostAsync(URL,payload);
            return JsonConvert.DeserializeObject<T>(response.ToString());
        }

        private static StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);

            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
