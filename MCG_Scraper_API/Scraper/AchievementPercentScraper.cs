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
    public partial class AchievementPercentScraper
    {
        [JsonProperty("achievementpercentages", NullValueHandling = NullValueHandling.Ignore)]
        public Achievementpercentages Achievementpercentages { get; set; }
    }

    public partial class Achievementpercentages
    {
        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public List<AchievementInfo> Achievements { get; set; }
    }

    public partial class AchievementInfo
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; }
    }

    public partial class AchievementPercentScraper
    {
        public static AchievementPercentScraper FromJson(string json) => JsonConvert.DeserializeObject<AchievementPercentScraper>(json, MCG_Scraper_API.Scraper.Converter.Settings);
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
}