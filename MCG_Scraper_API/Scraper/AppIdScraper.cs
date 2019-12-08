using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MCG_Scraper_API.Scraper
{
    public partial class AppIdScraper
    {
        [JsonProperty("applist", NullValueHandling = NullValueHandling.Ignore)]
        public Applist Applist { get; set; }
    }

    public partial class Applist
    {
        [JsonProperty("apps", NullValueHandling = NullValueHandling.Ignore)]
        public List<App> Apps { get; set; }
    }

    public partial class App
    {
        [JsonProperty("appid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Appid { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class AppIdScraper
    {
        public static AppIdScraper FromJson(string json) => JsonConvert.DeserializeObject<AppIdScraper>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AppIdScraper self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
