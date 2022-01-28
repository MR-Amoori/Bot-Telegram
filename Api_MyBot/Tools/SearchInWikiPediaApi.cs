using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class SearchInWikiPediaApi
    {
        public string Search(string textSearch)
        {
           string searchtext = textSearch.Remove(0, 4);
            string url = "http://api.codebazan.ir/wiki/?search="+searchtext;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result;
                return serialize.ToString();
            }
        }

    }
}
