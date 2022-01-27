using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class JokApi
    {
        public string Jok()
        {
            string url = "http://api.codebazan.ir/jok/";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string Khaterat()
        {
            string url = "http://api.codebazan.ir/jok/khatere";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string PaNaPa()
        {
            string url = "http://api.codebazan.ir/jok/pa-na-pa/";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

        public string AlakiMasalan()
        {
            string url = "http://api.codebazan.ir/jok/alaki-masalan/";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

    }
}
