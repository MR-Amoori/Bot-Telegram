using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class PasswordGenerateApi
    {
        public string PasswordGenerate()
        {
            string url = "http://api.codebazan.ir/password/?length=20";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }
    }
}
