using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class MourseApi
    {
        public string MurosePersianGenerate(string text)
        {
            string url = "http://api.codebazan.ir/mourse/?lang=fa&text=mamad" + text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishGenerate(string text)
        {
            string url = "http://api.codebazan.ir/mourse/?lang=en&text=mamad" + text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MurosePersianReverse(string text)
        {
            string url = "http://api.codebazan.ir/mourse/?lang=fa&mourse=" + text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishReverse(string text)
        {
            string url = "http://api.codebazan.ir/mourse/?lang=en&mourse=" + text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

    }
}
