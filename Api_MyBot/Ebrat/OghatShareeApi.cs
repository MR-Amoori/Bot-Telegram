using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class OghatShareeApi
    {
        public string Oghat(string cityName)
        {

            try
            {

                string cityy;
                try
                {
                    cityy = cityName.Remove(0, 4);
                }
                catch
                {

                    return "نتیجه ای برای این عمل پیدا نکردیم.";
                }



                string url = "https://api.codebazan.ir/owghat/?city=" + cityy;
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result;
                    var deserialize = JsonConvert.DeserializeObject<Root>(serialize);

                    var city = deserialize.Result.Select(p => p.shahr).ToArray();
                    var date = deserialize.Result.Select(p => p.tarikh).ToArray();
                    var azanSobh = deserialize.Result.Select(p => p.azansobh).ToArray();
                    var toloAftab = deserialize.Result.Select(p => p.toloaftab).ToArray();
                    var azanZohr = deserialize.Result.Select(p => p.azanzohr).ToArray();
                    var ghorobAftab = deserialize.Result.Select(p => p.ghorubaftab).ToArray();
                    var azanMaghreb = deserialize.Result.Select(p => p.azanmaghreb).ToArray();
                    var nimeShab = deserialize.Result.Select(p => p.nimeshab).ToArray();


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"شهر : {city[0]}");
                    sb.AppendLine($"تاریخ : {date[0]}");
                    sb.AppendLine($"اذان صبح : {azanSobh[0]}");
                    sb.AppendLine($"طلوع افتاب : {toloAftab[0]}");
                    sb.AppendLine($"اذان ظهر : {azanZohr[0]}");
                    sb.AppendLine($"غروب آفتاب : {ghorobAftab[0]}");
                    sb.AppendLine($"اذان مغرب : {azanMaghreb[0]}");
                    sb.AppendLine($"نیمه شب شرعی : {nimeShab[0]}");

                    return sb.ToString();
                }
            }

            catch
            {

                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }

        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public string shahr
            {
                get; set;
            }
            public string tarikh
            {
                get; set;
            }
            public string azansobh
            {
                get; set;
            }
            public string toloaftab
            {
                get; set;
            }
            public string azanzohr
            {
                get; set;
            }
            public string ghorubaftab
            {
                get; set;
            }
            public string azanmaghreb
            {
                get; set;
            }
            public string nimeshab
            {
                get; set;
            }
        }
        public class Root
        {
            public bool Ok
            {
                get; set;
            }
            public List<Result> Result
            {
                get; set;
            }
        }
    }
}
