using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBOAuth
{
public interface IFacebookService
    {
        Task<Account> GetAccountAsync(string accessToken);
        Task<Account> PostOnWallAsync(string accessToken, string message, string pageid);
    }

    public class FacebookService : IFacebookService
    {
        private readonly IFacebookClient _facebookClient;

        public FacebookService(IFacebookClient facebookClient)
        {
            _facebookClient = facebookClient;
        }

        public async Task<Account> GetAccountAsync(string accessToken)
        {
            var result = await _facebookClient.GetAsync<dynamic>(
                accessToken, "me", "fields=id%2Cname");
            //    accessToken, "me", "fields=id,name,email,first_name,last_name,age_range,birthday,gender,locale");


            if (result == null)
            {
                return new Account();
            }

            var account = new Account
            {
                Id = result.id,
                //Email = result.email,
                Name = result.name,
                //UserName = result.username,
                //FirstName = result.first_name,
                //LastName = result.last_name,
                //Locale = result.locale
            };

            return account;
        }

        public async Task<Account> PostOnWallAsync(string accessToken, string message, string pageid)
        {
            return await _facebookClient.PostAsync<dynamic>(accessToken, "feed?", message , pageid);
        }
    }

}
