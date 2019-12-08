using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MCG_Scraper_API.Scraper;
using System.Diagnostics;

namespace MCG_Scraper_API.Processor
{
    public class AppIdProcessor
    {
        public static async Task<Applist> LoadAppId()
        {
            string url = "https://api.steampowered.com/ISteamApps/GetAppList/v2/";

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var s = await response.Content.ReadAsStringAsync();
                        var r = AppIdScraper.FromJson(s);
                        return r.Applist;
                    }
                    else
                    {
                        Debug.WriteLine("LoadAppId() [1] => " + response.ReasonPhrase);
                        return new Applist();
                    }
                }
            }
            catch (Exception Error)
            {
                Debug.WriteLine("LoadAppId() [2] => " + Error.Message);
                return new Applist();
            }
        }
    }
}
