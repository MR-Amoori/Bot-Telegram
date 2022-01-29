using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_MyBot
{
    public class FindNumberApi
    {
        public string FindNumberByUserName(string id)
        {
            try
            {
                string link;
                try
                {
                    link = id.Remove(0, 5);
                }
                catch
                {
                    return "نتیجه ای برای این شماره پیدا نکردیم.";
                }

                string url = "https://ziroapi.xyz/Apis/number/?type=Find&username=" + link;
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result.ToString();
                    var deSerialize = JsonConvert.DeserializeObject<Root>(serialize);
                    StringBuilder sb = new StringBuilder();
                    if (deSerialize.InfoSearch == false)
                    {
                        sb.AppendLine("نتیجه ای برای این آیدی پیدا نکردیم.");
                    }
                    else
                    {
                        sb.AppendLine($"یوزرنیم شخص: {deSerialize.result.username}");
                        sb.AppendLine($"آیدی عددی شخص: {deSerialize.result.id}");
                        sb.AppendLine($"شماره تلفن شخص: {deSerialize.result.phone}");
                    }
                    return sb.ToString();
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }


        }

        public string FindNumberById(string id)
        {
            try
            {
                string link;
                try
                {
                    link = id.Remove(0, 5);
                }
                catch
                {
                    return "نتیجه ای برای این شماره پیدا نکردیم.";
                }
                string url = "https://ziroapi.xyz/Apis/number/?type=Find&id=" + link;
                using (var client = new HttpClient())
                {
                    var serialize = client.GetStringAsync(url).Result.ToString();
                    var deSerialize = JsonConvert.DeserializeObject<Root>(serialize);
                    StringBuilder sb = new StringBuilder();
                    if (deSerialize.InfoSearch == false)
                    {
                        sb.AppendLine("نتیجه ای برای این آیدی پیدا نکردیم.");
                    }
                    else
                    {
                        sb.AppendLine($"یوزرنیم شخص: {deSerialize.result.username}");
                        sb.AppendLine($"آیدی عددی شخص: {deSerialize.result.id}");
                        sb.AppendLine($"شماره تلفن شخص: {deSerialize.result.phone}");
                    }
                    return sb.ToString();
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }


        }

        public string InformationNumber(string number)
        {
            try
            {
                string link;
                try
                {
                    string text1 = number.Remove(0, 16);
                    string text2 = text1.Remove(12, 1);
                    string text3 = text2.Remove(0, 2);
                    link = text3.Insert(0, "0");
                }
                catch
                {
                    return "نتیجه ای برای این شماره پیدا نکردیم.";
                }

                string url = "https://ziroapi.xyz/Apis/irancell/?phone=" + link;
                using (var client = new HttpClient())
                {
                    string a;
                    try
                    {
                        a = client.GetStringAsync(url).Result.ToString();



                        var deSerialize = JsonConvert.DeserializeObject<Root2>(a);
                        StringBuilder sb = new StringBuilder();
                        if (deSerialize.InfoSearch == false)
                        {
                            sb.AppendLine("نتیجه ای برای این شماره پیدا نکردیم.");
                        }
                        else
                        {
                            sb.AppendLine($"نام: {deSerialize.result.first_name}");
                            sb.AppendLine($"نام خانوادگی: {deSerialize.result.last_name}");
                            sb.AppendLine($"شماره ملی: {deSerialize.result.ncode}");
                            sb.AppendLine($"شهر: {deSerialize.result.city}");
                            sb.AppendLine($"آدرس: {deSerialize.result.address}");
                            sb.AppendLine($"شماره همراه: {deSerialize.result.phone}");
                            sb.AppendLine($"شماره ثابت: {deSerialize.result.landphone}");
                            sb.AppendLine($"کد پستی: {deSerialize.result.zipcode}");
                        }
                        return sb.ToString();
                    }
                    catch
                    {
                        return "نتیجه ای برای این شماره پیدا نکردیم.";
                    }
                }

            }

            catch
            {
                return "نتیجه ای برای این عمل پیدا نکردیم.";
            }


        }

        public class Result2
        {
            public string phone
            {
                get; set;
            }
            public string first_name
            {
                get; set;
            }
            public string last_name
            {
                get; set;
            }
            public string ncode
            {
                get; set;
            }
            public string landphone
            {
                get; set;
            }
            public string zipcode
            {
                get; set;
            }
            public string city
            {
                get; set;
            }
            public string address
            {
                get; set;
            }
        }

        public class Root2
        {
            public string Creator
            {
                get; set;
            }

            [JsonProperty("info-search")]
            public bool InfoSearch
            {
                get; set;
            }
            public int code
            {
                get; set;
            }
            public Result2 result
            {
                get; set;
            }
        }


        public class Result
        {
            public string id
            {
                get; set;
            }
            public string username
            {
                get; set;
            }
            public string phone
            {
                get; set;
            }
        }

        public class Root
        {
            public string Creator
            {
                get; set;
            }

            [JsonProperty("info-search")]
            public bool InfoSearch
            {
                get; set;
            }
            public int code
            {
                get; set;
            }
            public Result result
            {
                get; set;
            }
        }


    }
}
