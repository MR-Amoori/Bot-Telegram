﻿using Newtonsoft.Json;
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
            link = link.Remove(0, 8);
            string url = "https://Okaliptoos-api.ir/nim/index.php?link=" + link;
            var client = new HttpClient();
            var serialize = client.GetStringAsync(url).Result;
            return serialize;
            var deSerialize = JsonConvert.DeserializeObject<Rootinm>(serialize);
            return deSerialize.Result.link;
            client.Dispose();
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
