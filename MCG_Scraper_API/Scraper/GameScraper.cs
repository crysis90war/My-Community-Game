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
    public partial class GameScraper
    {
        [JsonProperty("440", NullValueHandling = NullValueHandling.Ignore)]
        public TheGameId TheGameId { get; set; }
    }

    public partial class TheGameId
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("steam_appid", NullValueHandling = NullValueHandling.Ignore)]
        public long? SteamAppid { get; set; }

        [JsonProperty("required_age", NullValueHandling = NullValueHandling.Ignore)]
        public long? RequiredAge { get; set; }

        [JsonProperty("is_free", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        [JsonProperty("dlc", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Dlc { get; set; }

        [JsonProperty("detailed_description", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailedDescription { get; set; }

        [JsonProperty("about_the_game", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutTheGame { get; set; }

        [JsonProperty("short_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortDescription { get; set; }

        [JsonProperty("supported_languages", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportedLanguages { get; set; }

        [JsonProperty("header_image", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderImage { get; set; }

        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Website { get; set; }

        [JsonProperty("pc_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public PcRequirements PcRequirements { get; set; }

        [JsonProperty("mac_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public Requirements MacRequirements { get; set; }

        [JsonProperty("linux_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public Requirements LinuxRequirements { get; set; }

        [JsonProperty("developers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Developers { get; set; }

        [JsonProperty("publishers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Publishers { get; set; }

        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Packages { get; set; }

        [JsonProperty("package_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageGroup> PackageGroups { get; set; }

        [JsonProperty("platforms", NullValueHandling = NullValueHandling.Ignore)]
        public Platforms Platforms { get; set; }

        [JsonProperty("metacritic", NullValueHandling = NullValueHandling.Ignore)]
        public Metacritic Metacritic { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Category> Categories { get; set; }

        [JsonProperty("genres", NullValueHandling = NullValueHandling.Ignore)]
        public List<Genre> Genres { get; set; }

        [JsonProperty("screenshots", NullValueHandling = NullValueHandling.Ignore)]
        public List<Screenshot> Screenshots { get; set; }

        [JsonProperty("movies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Movie> Movies { get; set; }

        [JsonProperty("recommendations", NullValueHandling = NullValueHandling.Ignore)]
        public Recommendations Recommendations { get; set; }

        [JsonProperty("achievements", NullValueHandling = NullValueHandling.Ignore)]
        public Achievements Achievements { get; set; }

        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public ReleaseDate ReleaseDate { get; set; }

        [JsonProperty("support_info", NullValueHandling = NullValueHandling.Ignore)]
        public SupportInfo SupportInfo { get; set; }

        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Background { get; set; }

        [JsonProperty("content_descriptors", NullValueHandling = NullValueHandling.Ignore)]
        public ContentDescriptors ContentDescriptors { get; set; }
    }

    public partial class Achievements
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
        public List<Highlighted> Highlighted { get; set; }
    }

    public partial class Highlighted
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Path { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class ContentDescriptors
    {
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Ids { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }
    }

    public partial class Genre
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Requirements
    {
        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public string Minimum { get; set; }
    }

    public partial class Metacritic
    {
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public partial class Movie
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }

        [JsonProperty("webm", NullValueHandling = NullValueHandling.Ignore)]
        public Webm Webm { get; set; }

        [JsonProperty("highlight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Highlight { get; set; }
    }

    public partial class Webm
    {
        [JsonProperty("480", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The480 { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Max { get; set; }
    }

    public partial class PackageGroup
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("selection_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectionText { get; set; }

        [JsonProperty("save_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SaveText { get; set; }

        [JsonProperty("display_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? DisplayType { get; set; }

        [JsonProperty("is_recurring_subscription", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? IsRecurringSubscription { get; set; }

        [JsonProperty("subs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Sub> Subs { get; set; }
    }

    public partial class Sub
    {
        [JsonProperty("packageid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Packageid { get; set; }

        [JsonProperty("percent_savings_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PercentSavingsText { get; set; }

        [JsonProperty("percent_savings", NullValueHandling = NullValueHandling.Ignore)]
        public long? PercentSavings { get; set; }

        [JsonProperty("option_text", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionText { get; set; }

        [JsonProperty("option_description", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionDescription { get; set; }

        [JsonProperty("can_get_free_license", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? CanGetFreeLicense { get; set; }

        [JsonProperty("is_free_license", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFreeLicense { get; set; }

        [JsonProperty("price_in_cents_with_discount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceInCentsWithDiscount { get; set; }
    }

    public partial class PcRequirements
    {
        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public string Minimum { get; set; }

        [JsonProperty("recommended", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommended { get; set; }
    }

    public partial class Platforms
    {
        [JsonProperty("windows", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Windows { get; set; }

        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mac { get; set; }

        [JsonProperty("linux", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linux { get; set; }
    }

    public partial class Recommendations
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }
    }

    public partial class ReleaseDate
    {
        [JsonProperty("coming_soon", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ComingSoon { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }
    }

    public partial class Screenshot
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("path_thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PathThumbnail { get; set; }

        [JsonProperty("path_full", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PathFull { get; set; }
    }

    public partial class SupportInfo
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
    }

    public partial class GameScraper
    {
        public static GameScraper FromJson(string json) => JsonConvert.DeserializeObject<GameScraper>(json, Converter.Settings);
    }

    internal class PurpleParseStringConverter : JsonConverter
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

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }
}