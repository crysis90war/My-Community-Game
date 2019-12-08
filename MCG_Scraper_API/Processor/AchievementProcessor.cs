using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MCG_Scraper_API.Scraper;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace MCG_Scraper_API.Processor
{
    public class AchievementProcessor
    {
        public static async Task<AvailableGameStats> LoadAchievement(long gameAppId)
        {
            string url = $"http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key=99BF0E047D69B8C45E440C7302F1CD96&appid={ gameAppId }&l=french";

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var s = await response.Content.ReadAsStringAsync();
                        var r = AchievementScraper.FromJson(s);
                        return r.Game.AvailableGameStats;
                    }
                    else
                    {
                        Debug.WriteLine("LoadAppId() [1] => " + response.ReasonPhrase);
                        return new AvailableGameStats();
                    }
                }
            }
            catch (Exception Error)
            {
                Debug.WriteLine("LoadAppId() [2] => " + Error.Message);
                return new AvailableGameStats();
            }
        }

        public static AvailableGameStats LoadAchievements(long GameId)
        {
            var url = $"http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key=99BF0E047D69B8C45E440C7302F1CD96&appid={ GameId }&l=french";

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(url));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Debug.WriteLine(WebResp.StatusCode);
            Debug.WriteLine(WebResp.Server);

            string jsonString;

            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            var dict = JsonConvert.DeserializeObject<Dictionary<long, AvailableGameStats>>(jsonString);

            AvailableGameStats gameData = dict[GameId];

            return gameData;
        }
    }
}