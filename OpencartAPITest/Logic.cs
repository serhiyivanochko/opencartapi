using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace OpencartAPITest
{
    public class LoginMessage {

        [JsonProperty("success")]
        public string status { get; set; }
        [JsonProperty("api_token")]
        public string api_token { get; set; }
    }

    public class Logic
    {
        public string GetApiToken() {
            var client = new RestClient(GlobalData.URL + "login");

            var request = new RestRequest(Method.POST);
            request.AddParameter("username", GlobalData.username);
            request.AddParameter("key", GlobalData.key);

            var response = client.Execute(request);
            
            LoginMessage login = JsonConvert.DeserializeObject<LoginMessage>(response.Content);
            return login.api_token;
        }
    }
}
