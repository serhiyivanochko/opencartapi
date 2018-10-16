using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartAPITest
{
    class GlobalData
    {
        string username;
        string apitoken;
        string URL;

        public GlobalData() { }

        public string Getusername() {
            return this.username;
        }

        public string Getapitoken()
        {
            return this.apitoken;
        }

        public string GetURL()
        {
            return this.URL;
        }

        public void Setusername(string username)
        {
            this.username = username;
        }

        public string Setapitoken()
        {
            return this.apitoken;
        }

        public string SetURL()
        {
            return this.URL;
        }



    }
}
