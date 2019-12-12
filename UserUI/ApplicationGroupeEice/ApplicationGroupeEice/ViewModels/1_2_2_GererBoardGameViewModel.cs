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
    public class GererBoardGameViewModel : Screen
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

        #region Constructor
        public GererBoardGameViewModel(int userId)
        {
            UserId = userId;
            _ = Initialize();
        }
        #endregion

        #region Others
        public async Task Initialize()
        {
            List<GameModel> userGames = await Task.Run(() => GlobalConfig.Connection.GetUserBoardGames(UserId));
            List<GameModel> communityGames = await Task.Run(() => GlobalConfig.Connection.GetBoardGame_UserNotPossessed(UserId));

            UserGames = await Test(userGames);
            CommunityGames = await Test(communityGames);

            //foreach (var game in userGames)
            //{
            //    communityGames.RemoveAll(communityGame => communityGame.GameId.Equals(game.GameId));
            //}

            //foreach (var uGame in userGames)
            //{
            //    UserGames.Add(uGame);
            //}

            //foreach (var CGame in communityGames)
            //{
            //    CommunityGames.Add(CGame);
            //}
        }

        private async Task<BindableCollection<GameModel>> Test(List<GameModel> games)
        {
            BindableCollection<GameModel> output = new BindableCollection<GameModel>();

            foreach (var uGame in games)
            {
                await App.Current.Dispatcher.InvokeAsync(() =>
                {
                    output.Add(uGame);
                }, System.Windows.Threading.DispatcherPriority.ContextIdle);
            }

            return output;
        }
        #endregion
    }
}
