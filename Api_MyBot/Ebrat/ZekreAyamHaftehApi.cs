using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class ZekreAyamHaftehApi
    {
        public string Zekr()
        {
            string url = "http://api.codebazan.ir/zekr/";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }
    }
}
