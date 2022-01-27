using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Api_MyBot
{
    public class DateApi
    {
        public string LongDate()
        {
            string url = "http://api.codebazan.ir/time-date/?td=all";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result.ToString();
                //  var deSerialize = JsonConvert.DeserializeObject<List<Root>>(serialize);
                return serialize;
            }
        }
    }
}
