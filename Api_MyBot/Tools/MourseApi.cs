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
            string link;
            try
            {
                link = text.Remove(0, 9);
            }
            catch
            {
                return "نتیجه ای برای این شماره پیدا نکردیم.";
            }
            string url = "http://api.codebazan.ir/mourse/?lang=fa&text=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishGenerate(string text)
        {
            string link;
            try
            {
                link = text.Remove(0, 8);
            }
            catch
            {
                return "نتیجه ای برای این شماره پیدا نکردیم.";
            }
            string url = "http://api.codebazan.ir/mourse/?lang=en&text=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MurosePersianReverse(string text)
        {
            string link;
            try
            {
                link = text.Remove(0, 22);
            }
            catch
            {
                return "نتیجه ای برای این شماره پیدا نکردیم.";
            }
            string url = "http://api.codebazan.ir/mourse/?lang=fa&mourse=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string MuroseEnglishReverse(string text)
        {
            string link;
            try
            {
                link = text.Remove(0, 21);
            }
            catch
            {
                return "نتیجه ای برای این شماره پیدا نکردیم.";
            }
            string url = "http://api.codebazan.ir/mourse/?lang=en&mourse=" + link;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

    }
}
