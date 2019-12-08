using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class GameModel
    {
        #region Private Fields
        private int _gameId;
        private int _gameAppId;
        private string _gameName;
        private string _gameDescription;
        private string _gameImageUrl;
        private string _gameReleaseDate;
        private int _isVideogame;
        private string _gameAddedDate;
        private List<DeveloperModel> _gameDevelopers = new List<DeveloperModel>();
        private List<GenreModel> _gameGenres = new List<GenreModel>();
        private List<AchievementModel> _gameAchievements = new List<AchievementModel>();
        private AchievementModel _gameAchievement;

        public AchievementModel GameAchievement
        {
            get { return _gameAchievement; }
            set { _gameAchievement = value; }
        }

        #endregion

        #region Public Properties
        public int GameId
        {
            get { return _gameId; }
            set { _gameId = value; }
        }

        public int GameAppId
        {
            get { return _gameAppId; }
            set { _gameAppId = value; }
        }

        public string GameName
        {
            get { return _gameName; }
            set { _gameName = value; }
        }

        public string GameDescription
        {
            get { return _gameDescription; }
            set { _gameDescription = value; }
        }

        public string GameImageUrl
        {
            get { return _gameImageUrl; }
            set { _gameImageUrl = value; }
        }

        public string GameReleaseDate
        {
            get { return _gameReleaseDate; }
            set { _gameReleaseDate = value; }
        }

        public string GameAddedDate
        {
            get { return _gameAddedDate; }
            set { _gameAddedDate = value; }
        }

        public int IsVideogame
        {
            get { return _isVideogame; }
            set { _isVideogame = value; }
        }

        public List<DeveloperModel> GameDevelopers
        {
            get { return _gameDevelopers; }
            set { _gameDevelopers = value; }
        }

        public List<GenreModel> GameGenres
        {
            get { return _gameGenres; }
            set { _gameGenres = value; }
        }

        public List<AchievementModel> GameAchievements
        {
            get { return _gameAchievements; }
            set { _gameAchievements = value; }
        }
        #endregion

        #region Constructors
        public GameModel()
        {

        }

        public GameModel(long? gameAppId, string gameName)
        {
            this.GameAppId = (int)gameAppId;
            this.GameName = gameName;
        }

        public GameModel(int gameId, int gameAppId, string gameName, string gameDescription, string gameImageUrl, string gameReleaseDate, List<DeveloperModel> gameDevelopers, List<GenreModel> gameGenres, List<AchievementModel> gameAchievements)
        {
            this.GameId = gameId;
            this.GameAppId = gameAppId;
            this.GameName = gameName;
            this.GameDescription = gameDescription;
            this.GameImageUrl = gameImageUrl;
            this.GameReleaseDate = gameReleaseDate;
            this.GameDevelopers = gameDevelopers;
            this.GameGenres = gameGenres;
            this.GameAchievements = gameAchievements;
        }

        public GameModel(string gameName, string gameDescription, string gameImageUrl, List<AchievementModel> gameAchievements)
        {
            this.GameName = gameName;
            this.GameDescription = gameDescription;
            this.GameImageUrl = gameImageUrl;
            this.GameAchievements = gameAchievements;
        }
        #endregion

        #region Others
        public string GameNews
        {
            get
            {
                return $"https://store.steampowered.com/news/?appids={ GameAppId }&l=french";
            }
        }

        public string AchievementsCount
        {
            get
            {
                return $"{ GameAchievements.Count } Achievements";
            }
        }

        public string NumberAchievementsAchieved
        {

            get
            {
                return $"{ GameAchievements.Where(x => x.AchievementAchieved == 1).Count() } Achieved";
            }
        }
        #endregion
    }
}
