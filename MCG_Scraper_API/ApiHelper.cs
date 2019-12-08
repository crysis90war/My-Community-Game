using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MCG_Scraper_API.Scraper;
using MCG_Scraper_API.Processor;

namespace MCG_Scraper_API
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    public static class Serialize
    {
        public static string ToJson(this AppIdScraper self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this GameScraper self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this AchievementScraper self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this AchievementPercentScraper self) => JsonConvert.SerializeObject(self, Scraper.Converter.Settings);
    }
}
