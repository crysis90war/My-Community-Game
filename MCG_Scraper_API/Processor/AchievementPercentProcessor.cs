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
    public class AchievementPercentProcessor
    {
        public static async Task<Achievementpercentages> LoadAchievementPercentage(long gameAppId)
        {
            string url = $"https://api.steampowered.com/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v2/?gameid={ gameAppId }&l=french";

            try
            {
                using (HttpResponseMessage reponse = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (reponse.IsSuccessStatusCode)
                    {
                        var s = await reponse.Content.ReadAsStringAsync();
                        var r = AchievementPercentScraper.FromJson(s);
                        return r.Achievementpercentages;
                    }
                    else
                    {
                        Debug.WriteLine(reponse.ReasonPhrase);
                        return new Achievementpercentages();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new Achievementpercentages();
            }
        }
    }
}
