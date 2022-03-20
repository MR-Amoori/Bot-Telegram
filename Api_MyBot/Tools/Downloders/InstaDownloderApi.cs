using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class InstaDownloderApi
    {
        public string Download(string link)
        {
            try
            {
                string url = "https://Okaliptoos-api.ir/instadown/index.php?url=" + link;
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result;
                    var deSerialize = JsonConvert.DeserializeObject<Roott>(serialize);
                    return deSerialize.Result.Download.ToString();
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }

        }

        public class Resultbt
        {
            public string Download
            {
                get; set;
            }
        }

        public class Roott
        {
            public Resultbt Result
            {
                get; set;
            }
        }
    }
}
