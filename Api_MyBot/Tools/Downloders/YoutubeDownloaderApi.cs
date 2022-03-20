using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot.Tools.Downloders
{
    public class YoutubeDownloaderApi
    {

        public string Download(string link)
        {
            try
            {
                string url = "https://okaliptoos-api.ir/youtubedown/index.php?url=" + link;
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result;
                    var deSerialize = JsonConvert.DeserializeObject<Root>(serialize);
                    StringBuilder sb = new StringBuilder();

                    var a = deSerialize.Result.url.SingleOrDefault(y => y.quality=="720");
                    sb.AppendLine(a.url);
                    return sb.ToString();
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }

        }


        public class Meta
        {
            public string title { get; set; }
            public string source { get; set; }
            public string duration { get; set; }
            public string tags { get; set; }
        }

        public class Attr
        {
            public string title { get; set; }
            public string @class { get; set; }
        }

        public class Url
        {
            public string url { get; set; }
            public string name { get; set; }
            public string subname { get; set; }
            public string info_url { get; set; }
            public string type { get; set; }
            public string ext { get; set; }
            public bool downloadable { get; set; }
            public string quality { get; set; }
            public bool audio { get; set; }
            public bool no_audio { get; set; }
            public string itag { get; set; }
            public Attr attr { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public bool cipher { get; set; }
            public Meta meta { get; set; }
            public string thumb { get; set; }
            public List<string> itags { get; set; }
            public List<string> video_quality { get; set; }
            public List<Url> url { get; set; }
            public string hosting { get; set; }
            public object sd { get; set; }
            public object hd { get; set; }
            public int timestamp { get; set; }
        }

        public class Root
        {
            public bool ok { get; set; }
            public Result Result { get; set; }
        }
    }


}
