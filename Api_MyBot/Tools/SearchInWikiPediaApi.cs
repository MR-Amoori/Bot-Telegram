using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class SearchInWikiPedia
    {
        public string Search(string text)
        {
            string url = "http://api.codebazan.ir/wiki/?search="+text;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize;
            }
        }

    }
}
