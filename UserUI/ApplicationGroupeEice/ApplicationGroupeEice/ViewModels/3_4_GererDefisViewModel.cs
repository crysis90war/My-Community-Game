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
    public class GererDefisViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        List<GameModel> userGames;
        private string _warningMessage;
        private GameModel _selectedGame;
        private DefiModel _selectedDefi;
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
                SelectedDefi = value.GameDefi;
                NotifyOfPropertyChange(() => SelectedGame);
            }
        }

        public DefiModel SelectedDefi
        {
            get { return _selectedDefi; }
            set
            {
                _selectedDefi = value;
                SelectedGame.GameDefi = value;
                NotifyOfPropertyChange(() => SelectedDefi);
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

        #region Constructor
        public GererDefisViewModel(int userId)
        {
            UserId = userId;

            InitializeContent();
        }
        #endregion

        #region Others
        public void UpdateDefi()
        {
            // TODO - implémenter le bouton update défi
        }

        public void InitializeContent()
        {
            List<GameModel> userGames = new List<GameModel>();
            userGames = GlobalConfig.Connection.GetUserGames(UserId);
            UserGames = null;
            UserGames = new BindableCollection<GameModel>();

            foreach (var uGame in userGames)
            {
                UserGames.Add(uGame);
            }
        }
        #endregion
    }
}
