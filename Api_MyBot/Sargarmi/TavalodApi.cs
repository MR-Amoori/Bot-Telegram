using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class Result
    {
        public string year
        {
            get; set;
        }
        public string month
        {
            get; set;
        }
        public string day
        {
            get; set;
        }
        public string days
        {
            get; set;
        }
        public string birthmiladi
        {
            get; set;
        }
        public object birthghamari
        {
            get; set;
        }
        public string year_name
        {
            get; set;
        }
        public string month_nemad
        {
            get; set;
        }
        public string to_birth
        {
            get; set;
        }
        public object birth_day
        {
            get; set;
        }
        public object birth_season
        {
            get; set;
        }
        public string g_month
        {
            get; set;
        }
        public string world_population
        {
            get; set;
        }
        public string sleep_time
        {
            get; set;
        }
        public string wc_hour
        {
            get; set;
        }
        public string bathroom_hour
        {
            get; set;
        }
        public string laughing
        {
            get; set;
        }
        public string Recreation
        {
            get; set;
        }
        public string eat_hour
        {
            get; set;
        }
        public string eat_Kg
        {
            get; set;
        }
        public string Meal
        {
            get; set;
        }
        public string Ordered
        {
            get; set;
        }
        public string stone_month
        {
            get; set;
        }
    }
    public class Root
    {
        public bool ok
        {
            get; set;
        }
        public Result result
        {
            get; set;
        }
    }

    public class Result2
    {
        public string birth_miladi
        {
            get; set;
        }
        public string birth_ghamari
        {
            get; set;
        }
        public string year
        {
            get; set;
        }
        public string month
        {
            get; set;
        }
        public string day
        {
            get; set;
        }
        public string days
        {
            get; set;
        }
        public string week_birth_day
        {
            get; set;
        }
        public string fasl
        {
            get; set;
        }
        public string animal
        {
            get; set;
        }
        public string namad
        {
            get; set;
        }
        public string ta_tavalod
        {
            get; set;
        }
        public string mah_be_dor_zamin
        {
            get; set;
        }
        public string world_population
        {
            get; set;
        }
        public string sleep_time
        {
            get; set;
        }
        public string vade_ghaza
        {
            get; set;
        }
        public string sang
        {
            get; set;
        }
    }

    public class Root2
    {
        public Result2 Result
        {
            get; set;
        }
    }



    public class TavalodApi
    {
        public string Tavalod(int year,int month,int day)
        {
            string url = "https://api.codebazan.ir/age/?year="+year+"&&month="+month+"&&day="+day;
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result.ToString();
                var deSerialize = JsonConvert.DeserializeObject<Root>(serialize);
                StringBuilder sb=new StringBuilder();
                sb.AppendLine($"تولد شما به میلادی : {deSerialize.result.birthmiladi}");
                sb.AppendLine($"تعداد روز هایی که زندگی کردید : {deSerialize.result.days}");
                sb.AppendLine($"تعداد ماه هایی که زندگی کردید : {deSerialize.result.g_month}");
                sb.AppendLine($"تعداد وعده غذا هایی که میل کردید : {deSerialize.result.Meal}");
                sb.AppendLine($"نام سال تولد : {deSerialize.result.year_name}");
                sb.AppendLine($"روز های باقی مانده تا سالگرد تولد شما : {deSerialize.result.to_birth}");
                return sb.ToString();
            }
        }

        public string Tavalod2(int year, int month, int day)
        {
            string url = $"https://Okaliptoos-api.ir/tavalod/index.php?year={year}&month={month}&day={day}";
            using (var client = new HttpClient())
            {
                var serialize = client.GetStringAsync(url).Result.ToString();
                var deSerialize = JsonConvert.DeserializeObject<Root2>(serialize);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"تولد شما به میلادی : {deSerialize.Result.birth_miladi}");
                sb.AppendLine($"تولد شما به قمری : {deSerialize.Result.birth_ghamari}");
                sb.AppendLine($"سال : {deSerialize.Result.year}");
                sb.AppendLine($"ماه : {deSerialize.Result.month}");
                sb.AppendLine($"روز : {deSerialize.Result.day}");
                sb.AppendLine($"تعداد روز هایی که زندگی کردید : {deSerialize.Result.days}");
                sb.AppendLine($"روز هفته تولد شما : {deSerialize.Result.week_birth_day}");
                sb.AppendLine($"فصل تولد : {deSerialize.Result.fasl}");
                sb.AppendLine($"حیوان : {deSerialize.Result.animal}");
                sb.AppendLine($"نماد : {deSerialize.Result.namad}");
                sb.AppendLine($"سنگ : {deSerialize.Result.sang}");
                sb.AppendLine($"روز های باقی مانده تا سالگرد تولد شما : {deSerialize.Result.ta_tavalod}");
                return sb.ToString();
            }
        }
    }
}
