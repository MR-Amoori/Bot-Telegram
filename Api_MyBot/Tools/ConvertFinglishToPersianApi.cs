using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class ConvertFinglishToPersianApi
    {
        public string FinglishToPersian(string text)
        {
            string url = "https://api.codebazan.ir/fintofa/?text="+text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                var deserialize = JsonConvert.DeserializeObject<Root>(serialize);
                return deserialize.result.ToString();
            }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public bool ok
            {
                get; set;
            }
            public string result
            {
                get; set;
            }
        }

    }

}
