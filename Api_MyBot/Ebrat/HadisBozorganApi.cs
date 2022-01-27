using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    internal class HadisBozorganApi
    {
        public string Hadis()
        {
            string url = "http://api.codebazan.ir/hadis/";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }
    }
}
