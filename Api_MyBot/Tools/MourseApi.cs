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
            string textFinal = text.Remove(0, 9);
            string url = "http://api.codebazan.ir/mourse/?lang=fa&text=" + textFinal;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishGenerate(string text)
        {
            string textFinal = text.Remove(0, 8);
            string url = "http://api.codebazan.ir/mourse/?lang=en&text=" + textFinal;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MurosePersianReverse(string text)
        {
            string textFinal = text.Remove(0, 22);
            string url = "http://api.codebazan.ir/mourse/?lang=fa&mourse=" + textFinal;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishReverse(string text)
        {
            string textFinal = text.Remove(0, 21);
            string url = "http://api.codebazan.ir/mourse/?lang=en&mourse=" + textFinal;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

    }
}
