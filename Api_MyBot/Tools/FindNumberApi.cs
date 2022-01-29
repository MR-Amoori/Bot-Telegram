using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class FindNumberApi
    {
        public string FindNumberById(string id)
        {

            string url = "https://ziroapi.xyz/Apis/number/?type=Find&username="+id;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result.ToString();
                var deSerialize = JsonConvert.DeserializeObject<Root>(serialize);
                StringBuilder sb = new StringBuilder();
                if (deSerialize.InfoSearch == false)
                {
                    sb.AppendLine("نتیجه ای برای این آیدی پیدا نکردیم.");
                }
                else
                {
                    sb.AppendLine($"یوزرنیم شخص: {deSerialize.result.username}");
                    sb.AppendLine($"آیدی عددی شخص: {deSerialize.result.id}");
                    sb.AppendLine($"شماره تلفن شخص: {deSerialize.result.phone}");
                }
                return sb.ToString();
            }
        }

        
        public class Result
        {
            public string id
            {
                get; set;
            }
            public string username
            {
                get; set;
            }
            public string phone
            {
                get; set;
            }
        }

        public class Root
        {
            public string Creator
            {
                get; set;
            }

            [JsonProperty("info-search")]
            public bool InfoSearch
            {
                get; set;
            }
            public int code
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
