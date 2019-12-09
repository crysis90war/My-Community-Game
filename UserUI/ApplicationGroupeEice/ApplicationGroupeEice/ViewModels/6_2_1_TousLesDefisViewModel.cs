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
    public class TousLesDefisViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private BindableCollection<GameModel> _userGames = new BindableCollection<GameModel>();
        private GameModel _selectedGame;

        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BindableCollection<GameModel> UserGames
        {
            get { return _userGames; }
            set { _userGames = value; NotifyOfPropertyChange(() => UserGames); }
        }

        public GameModel SelectedGame
        {
            get { return _selectedGame; }
            set { _selectedGame = value; NotifyOfPropertyChange(() => SelectedGame); }
        }
        #endregion

        #region Constructor
        public TousLesDefisViewModel(int userId)
        {
            UserId = userId;
            InitialiserContent();
        }
        #endregion


        #region Others
        public void InitialiserContent()
        {
            List<DefiModel> communitDefi = new List<DefiModel>();
            List<GameModel> userGames = new List<GameModel>();
            userGames = GlobalConfig.Connection.GetUserGames(UserId);

            foreach (var game in userGames)
            {
                UserGames.Add(game);
            }
        }

        public void boutonRefresh()
        {

        }
        #endregion
    }
}
