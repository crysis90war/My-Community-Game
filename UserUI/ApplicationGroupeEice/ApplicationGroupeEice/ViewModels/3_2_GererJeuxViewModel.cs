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
    public class GererJeuxViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private string _warningMessage;

        public string WarningMessage
        {
            get { return _warningMessage; }
            set
            {
                _warningMessage = value;
                NotifyOfPropertyChange(() => WarningMessage);
            }
        }

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                NotifyOfPropertyChange(() => UserId);
            }
        }

        private GameModel _selectedUGame;
        private GameModel _selectedCGame;
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        private BindableCollection<GameModel> _communityGames = new BindableCollection<GameModel>();
        #endregion

        #region Public Properties
        public GameModel SelectedUGame
        {
            get { return _selectedUGame; }
            set
            {
                _selectedUGame = value;
                NotifyOfPropertyChange(() => SelectedUGame);
            }
        }

        public GameModel SelectedCGame
        {
            get { return _selectedCGame; }
            set
            {
                _selectedCGame = value;
                NotifyOfPropertyChange(() => SelectedCGame);
            }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; NotifyOfPropertyChange(() => UserGames); }
        }

        public BindableCollection<GameModel> CommunityGames
        {
            get { return _communityGames; }
            set { _communityGames = value; NotifyOfPropertyChange(() => CommunityGames); }
        }
        #endregion

        #region Constructors
        public GererJeuxViewModel(int userId)
        {
            UserId = userId;

            Initialize();
        }
        #endregion

        #region Others
        public void AjouterJeu()
        {
            try
            {
                UserModel userModel = new UserModel();
                userModel = GlobalConfig.Connection.GetUser_Info(UserId);
                GlobalConfig.Connection.CreerJeuUtilisateur(userModel, SelectedCGame.GameId);

                CommunityGames = new BindableCollection<GameModel>();
                UserGames = new BindableCollection<GameModel>();

                List<GameModel> userGames = GlobalConfig.Connection.GetUserGames(UserId);
                List<GameModel> communityGames = GlobalConfig.Connection.GetGame_UserNotPossessed(UserId);

                foreach (var game in userGames)
                {
                    communityGames.RemoveAll(communityGame => communityGame.GameId.Equals(game.GameId));
                }

                foreach (var uGame in userGames)
                {
                    UserGames.Add(uGame);
                }

                foreach (var CGame in communityGames)
                {
                    CommunityGames.Add(CGame);
                }

                WarningMessage = "Jeu ajouté avec succés";
            }
            catch (Exception error)
            {
                WarningMessage = error.Message;
            }
        }

        public void SupprimerJeu()
        {

        }

        private async Task Initialize()
        {
            List<GameModel> userGames = await Task.Run(() => GlobalConfig.Connection.GetUserGames(UserId));
            List<GameModel> communityGames = await Task.Run(() => GlobalConfig.Connection.GetGame_UserNotPossessed(UserId));

            foreach (var game in userGames)
            {
                communityGames.RemoveAll(communityGame => communityGame.GameId.Equals(game.GameId));
            }

            foreach (var uGame in userGames)
            {
                UserGames.Add(uGame);
            }

            foreach (var CGame in communityGames)
            {
                CommunityGames.Add(CGame);
            }
        }
        #endregion
    }
}
