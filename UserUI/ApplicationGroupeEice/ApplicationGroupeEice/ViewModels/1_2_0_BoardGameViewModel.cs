using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class BoardGameViewModel : Conductor<object>
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BoardGameViewModel(int userId)
        {
            UserId = userId;
            //ActivateItem();
        }

        public void MI_MonJeu()
        {
            ActivateItem(new MyBoardGamesViewModel());
        }

        public void MI_GererJeu()
        {
            ActivateItem(new GererBoardGameViewModel(UserId));
        }

        public void MI_GererDefis()
        {
            ActivateItem(new GererDefisBoardGameViewModel());
        }
    }
}
