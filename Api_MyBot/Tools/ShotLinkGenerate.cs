using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class ShotLinkGenerate
    {
        public string ShortLink(string link)
        {
            string url = "https://api.codebazan.ir/shortlink/index.php?url=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                var deserialize = JsonConvert.DeserializeObject<Root>(serialize);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Link 1 : {deserialize.result.bitly}");
                sb.AppendLine($"Link 2 : {deserialize.result.shortur}");
                sb.AppendLine($"Link 3 : {deserialize.result.isgd}");
                sb.AppendLine($"Link 4 : {deserialize.result.cutt}");
                sb.AppendLine($"QR Code : {deserialize.result.qr}");
                return sb.ToString();
            }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public string bitly
            {
                get; set;
            }
            public string shortur
            {
                get; set;
            }
            public string isgd
            {
                get; set;
            }
            public string cutt
            {
                get; set;
            }
            public string qr
            {
                get; set;
            }
        }
        public class Root
        {
            public bool ok
            {
                get; set;
            }
            public Result result
            {
                get; set;
            }
        }

    }
}
