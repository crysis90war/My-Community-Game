using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class GererAchievementViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        List<GameModel> userGames;
        private string _warningMessage;
        private GameModel _selectedGame;
        private AchievementModel _selectedAchievement;
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public string WarningMessage
        {
            get { return _warningMessage; }
            set
            {
                _warningMessage = value;
                NotifyOfPropertyChange(() => WarningMessage);
            }
        }

        public GameModel SelectedGame
        {
            get { return _selectedGame; }
            set 
            { 
                _selectedGame = value;
                SelectedAchievement = value.GameAchievement;
                NotifyOfPropertyChange(() => SelectedGame); 
            }
        }

        public AchievementModel SelectedAchievement
        {
            get { return _selectedAchievement; }
            set 
            {
                _selectedAchievement = value;
                SelectedGame.GameAchievement = value;
                NotifyOfPropertyChange(() => SelectedAchievement);
            }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set 
            {
                _userGames = value;
                NotifyOfPropertyChange(() => UserGames);
            }
        }
        #endregion

        #region Constructors
        public GererAchievementViewModel(int userId)
        {
            userGames = GlobalConfig.Connection.GetUserGames(userId);
            UserId = userId;

            foreach (var uGame in userGames)
            {
                UserGames.Add(uGame);
            }
        }
        #endregion

        #region Others
        public void UpdateAchievement()
        {
            try
            {
                UserGames = new BindableCollection<GameModel>();
                GlobalConfig.Connection.UpdateUserAchievement(UserId, SelectedAchievement.AchievementId);
                userGames = GlobalConfig.Connection.GetUserGames(UserId);
                
                int resultat = 0;

                foreach (var game in userGames)
                {
                    foreach (var achievement in game.GameAchievements)
                    {
                        if (achievement.AchievementAchieved == 1)
                        {
                            resultat += achievement.AchievementScore;
                        }
                        else
                        {
                            WarningMessage = "Achievement is already achieved";
                        }
                    }
                }

                UserModel userModel = GlobalConfig.Connection.GetUser_Info(UserId);

                if (userModel.UserScore != resultat)
                {
                    GlobalConfig.Connection.UpdateUser_Score(UserId, resultat);
                }

                foreach (var uGame in userGames)
                {
                    UserGames.Add(uGame);
                }

                GlobalConfig.Connection.UpdateUser_Rank(UserId);


            }
            catch (Exception error)
            {
                WarningMessage = error.Message;
            }
        }
        #endregion
    }
}
