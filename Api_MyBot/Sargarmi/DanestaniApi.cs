using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class DanestaniApi
    {
        public string Danestani()
        {
            try
            {
                string url = "http://api.codebazan.ir/danestani/";
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result;
                    return serialize;
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }


        }
    }
}
