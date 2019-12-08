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
    public partial class AchievementScraper
    {
        [JsonProperty("game", NullValueHandling = NullValueHandling.Ignore)]
        public Game Game { get; set; }
    }

    public partial class Game
    {
        [JsonProperty("gameName", NullValueHandling = NullValueHandling.Ignore)]
        public string GameName { get; set; }

        [JsonProperty("gameVersion", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? GameVersion { get; set; }

        [JsonProperty("availableGameStats", NullValueHandling = NullValueHandling.Ignore)]
        public AvailableGameStats AvailableGameStats { get; set; }
    }

    public partial class AvailableGameStats
    {
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stat> Stats { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Achievement> Achievements { get; set; }
    }

    public partial class Achievement
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("defaultvalue", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defaultvalue { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        [JsonProperty("hidden", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hidden { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("icongray", NullValueHandling = NullValueHandling.Ignore)]
        public string Icongray { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Stat
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("defaultvalue", NullValueHandling = NullValueHandling.Ignore)]
        public long? Defaultvalue { get; set; }

        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }
    }

    public partial class AchievementScraper
    {
        public static AchievementScraper FromJson(string json) => JsonConvert.DeserializeObject<AchievementScraper>(json, Converter.Settings);
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}