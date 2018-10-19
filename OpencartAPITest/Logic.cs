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
        public string GetResponceContent(string URLEnd, Method method, Dictionary<string, string> parameters = null) {
            var client = new RestClient(GlobalData.URL + URLEnd);

            var request = new RestRequest(method);

            foreach (var current in parameters) {
                request.AddParameter(current.Key, current.Value);
            }

            return client.Execute(request).Content;
        }


        public string GetApiToken() {

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("username",GlobalData.username);
            parameters.Add("key",GlobalData.key);

            LoginMessage login = JsonConvert.DeserializeObject<LoginMessage>(
                GetResponceContent("login", Method.POST, parameters)
                );
            return login.api_token;
        }

        public string ApiSetCurrency(string code) {
            return "";
        }

    }
}
