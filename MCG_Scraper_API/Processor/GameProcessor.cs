using MCG_Scraper_API.Scraper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MCG_Scraper_API.Processor
{
    public class GameProcessor
    {
        public static TheGameId GetGameData(int GameId)
        {
            var url = $"https://store.steampowered.com/api/appdetails/?appids={ GameId }&l=french";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(url));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            //Debug.WriteLine(WebResp.StatusCode);
            //Debug.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            var dict = JsonConvert.DeserializeObject<Dictionary<string, TheGameId>>(jsonString);

            TheGameId gameData = dict[GameId.ToString()];

            return gameData;
        }

        public static async Task<Data> LoadGameInfo()
        {
            int gameId = 271590;
            string url = $"https://store.steampowered.com/api/appdetails?appids={ gameId }";

            // var chrono = System.Diagnostics.Stopwatch.StartNew();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var s = await response.Content.ReadAsStringAsync();
                    var r = GameScraper.FromJson(s);
                    return r.TheGameId.Data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
