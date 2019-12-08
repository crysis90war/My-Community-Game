using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using MCG_Scraper_API.Processor;
using MCG_Scraper_API.Scraper;
using MCG_Scraper_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrateurApplicationEice.ViewModels
{
    public class VideoGameViewModel : Screen
    {
        #region Private Fields
        private string _searchBox;
        private BindableCollection<GameModel> _steamGames = new BindableCollection<GameModel>();
        private GameModel _selectedSteamGame;
        private BindableCollection<GameModel> _communityGames = new BindableCollection<GameModel>();
        private GameModel _selectedCommunityGame;
        private string _warningMessage;
        #endregion

        #region Public Properties
        public string SearchBox
        {
            get { return _searchBox; }
            set { _searchBox = value; NotifyOfPropertyChange(() => SearchBox); }
        }

        public BindableCollection<GameModel> SteamGames
        {
            get { return _steamGames; }
            set { _steamGames = value; NotifyOfPropertyChange(() => SteamGames); }
        }

        public GameModel SelectedSteamGame
        {
            get { return _selectedSteamGame; }
            set { _selectedSteamGame = value; NotifyOfPropertyChange(() => SelectedSteamGame); }
        }

        public GameModel SelectedCommunityGame
        {
            get { return _selectedCommunityGame; }
            set { _selectedCommunityGame = value; NotifyOfPropertyChange(() => SelectedCommunityGame); }
        }


        public BindableCollection<GameModel> CommunityGames
        {
            get { return _communityGames; }
            set { _communityGames = value; NotifyOfPropertyChange(() => CommunityGames); }
        }

        public string WarningMessage
        {
            get { return _warningMessage; }
            set { _warningMessage = value; NotifyOfPropertyChange(() => WarningMessage); }
        }
        #endregion

        #region Constructor
        public VideoGameViewModel()
        {
            ApiHelper.InitializeClient();
            List<GameModel> communityGames = new List<GameModel>();
            communityGames = GlobalConfig.Connection.GetGame_All();

            foreach (var communityGame in communityGames)
            {
                CommunityGames.Add(communityGame);
            }

            //var a = await AppIdProcessor.LoadAppId();
        }
        #endregion

        #region Others
        public async void Search()
        {
            // TODO - Continuer l'ajout du jeu
            // TODO - Attention pour la base de donnée

            string recherche = SearchBox;

            if (recherche != null && recherche.Length > 3)
            {
                var gameAppIds = await AppIdProcessor.LoadAppId();
                List<GameModel> applist = new List<GameModel>();
                SteamGames = new BindableCollection<GameModel>();

                for (int i = 0; i < gameAppIds.Apps.Count; i++)
                {
                    if (gameAppIds.Apps[i].Name.Contains(recherche))
                    {
                        long? gameAppId = gameAppIds.Apps[i].Appid;
                        string gameName = gameAppIds.Apps[i].Name;
                        applist.Add(new GameModel(gameAppId, gameName));
                    }
                }

                foreach (var app in applist)
                {
                    SteamGames.Add(app);
                }
            }
            else
            {
                WarningMessage = "Searchbox cannot be null or less than 4 characters";
            }
        }

        public async void AjouterJeu()
        {
            try
            {
                if (SelectedSteamGame != null)
                {
                    GameModel game = new GameModel();
                    game = await ChargerJeuFromJSON(SelectedSteamGame.GameAppId);

                    if (game != null)
                    {
                        GlobalConfig.Connection.CreerJeu(game);

                        List<GameModel> communityGames = new List<GameModel>();
                        communityGames = GlobalConfig.Connection.GetGame_All();

                        foreach (var communityGame in communityGames)
                        {
                            CommunityGames.Add(communityGame);
                        }
                    }
                    else
                    {
                        WarningMessage = "The selected item is not a game";
                    }
                }
                else
                {
                    WarningMessage = "Please select a game";
                }
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
                WarningMessage = "Aucune idée";
            }

        }

        public static async Task<GameModel> ChargerJeuFromJSON(int gameAppId)
        {
            GameModel output;

            List<DeveloperModel> gameDeveloper = new List<DeveloperModel>();
            List<GenreModel> listGameGenre = new List<GenreModel>();
            List<AchievementModel> achievementModels = new List<AchievementModel>();

            var gameInfo = GameProcessor.GetGameData(gameAppId);

            if (gameInfo != null)
            {
                if (gameInfo.Success != false)
                {
                    if (gameInfo.Data.Type == "game")
                    {
                        #region Chargement Achievements + Pourcentage
                        var listDesAchievements = new List<AvailableGameStats>();
                        var achievements = await AchievementProcessor.LoadAchievement(gameAppId);
                        listDesAchievements.Add(achievements);

                        var listDesAchievementsPercent = new List<Achievementpercentages>();
                        var achievementsPercent = await AchievementPercentProcessor.LoadAchievementPercentage(gameAppId);
                        listDesAchievementsPercent.Add(achievementsPercent);

                        for (int i = 0; i < listDesAchievements.Count; i++)
                        {
                            double achievementPercent;
                            for (int k = 0; k < listDesAchievements.Count; k++)
                            {
                                achievementPercent = (double)listDesAchievementsPercent[i].Achievements[k].Percent;
                                for (int j = 0; j < achievements.Achievements.Count; j++)
                                {
                                    string achievementName = listDesAchievements[k].Achievements[j].Name;
                                    string achievementDisplayName = listDesAchievements[k].Achievements[j].DisplayName;
                                    string achievementDescription = listDesAchievements[k].Achievements[j].Description == null ? "" : listDesAchievements[k].Achievements[j].Description;
                                    string achievementIconUrl = listDesAchievements[k].Achievements[j].Icon;
                                    string achievementIconGrayUrl = listDesAchievements[k].Achievements[j].Icongray;

                                    achievementModels.Add(new AchievementModel(
                                        achievementName,
                                        achievementDisplayName,
                                        achievementDescription,
                                        achievementIconUrl,
                                        achievementIconGrayUrl,
                                        achievementPercent));
                                }
                            }
                        }
                        #endregion

                        #region Ajout des genres dans la liste
                        int developerId = 1;
                        for (int i = 0; i < gameInfo.Data.Developers.Count; i++)
                        {
                            string developerName = gameInfo.Data.Developers[i];
                            gameDeveloper.Add(new DeveloperModel(developerId, developerName));
                            developerId++;
                        }
                        #endregion

                        #region Ajout de/des developer(s) dans la liste
                        int genreId = 1;
                        for (int i = 0; i < gameInfo.Data.Genres.Count; i++)
                        {
                            string genreName = gameInfo.Data.Genres[i].Description;
                            listGameGenre.Add(new GenreModel(genreId, genreName));
                            genreId++;
                        }
                        #endregion

                        // TODO - (2 - MEDIUM PRIORITY) Attention a l'ID lors d'insertion dans la base de donnée (peut fausser)
                        int idJeu = 1;
                        int appId = (int)gameInfo.Data.SteamAppid;
                        string nomJeu = gameInfo.Data.Name;
                        string descriptionJeu = gameInfo.Data.ShortDescription;
                        string urlImageJeu = gameInfo.Data.HeaderImage;
                        string dateSortieJeu = gameInfo.Data.ReleaseDate.Date.ToString();

                        output = new GameModel(idJeu, appId, nomJeu, descriptionJeu, urlImageJeu, dateSortieJeu, gameDeveloper, listGameGenre, achievementModels);

                        return output;
                    }
                    else
                    {
                        return output = null;
                    }
                }
                else
                {
                    return output = null;
                }
            }
            else
            {
                return output = null;
            }
        }
        #endregion
    }
}
