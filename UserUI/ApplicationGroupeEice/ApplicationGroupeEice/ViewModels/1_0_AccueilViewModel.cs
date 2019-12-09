using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class AccueilViewModel : Conductor<object>
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public AccueilViewModel(int userId)
        {
            UserId = userId;
            ActivateItem(new VideoGameViewModel());
        }

        public void boutonVideoGame()
        {
            ActivateItem(new VideoGameViewModel());
        }

        public void boutonBoardGame()
        {
            ActivateItem(new BoardGameViewModel(UserId));
        }
    }
}
