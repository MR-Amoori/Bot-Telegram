using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class NimBahaApi
    {
        public string NimBaha(string link)
        {
            string url = "https://Okaliptoos-api.ir/nim/index.php?link=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result.ToString();
                var deSerialize = JsonConvert.DeserializeObject<Rootinm>(serialize);
                return deSerialize.Result.link;
            }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Resultnim
        {
            public string link
            {
                get; set;
            }
        }

        public class Rootinm
        {
            public Resultnim Result
            {
                get; set;
            }
        }


    }
}
