using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrateurApplicationEice.ViewModels
{
    public class BoardGameViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private BindableCollection<GameModel> _communityBoardGames = new BindableCollection<GameModel>();



        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BindableCollection<GameModel> CommunityBoardGames
        {
            get { return _communityBoardGames; }
            set { _communityBoardGames = value; NotifyOfPropertyChange(() => CommunityBoardGames); }
        }
        #endregion

        #region Constructor
        public BoardGameViewModel(int userId)
        {
            UserId = userId;
            _ = Initialize();
        }
        #endregion

        #region Others
        private async Task Initialize()
        {
            List<GameModel> communityBoardGames = new List<GameModel>();
            communityBoardGames = await Task.Run(()=> GlobalConfig.Connection.GetBoardGamesAll());

            CommunityBoardGames = await Test(communityBoardGames);
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
