using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class CommunauteViewModel : Conductor<object>
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }


        public CommunauteViewModel(int userId)
        {
            UserId = userId;
        }

        public void boutonEvenements()
        {
            ActivateItem(new ListeDesEvenementsViewModel());
        }

        public void boutonDefis()
        {
            ActivateItem(new ListeDesDefisViewModel());
        }

        public void boutonClassement()
        {
            ActivateItem(new ClassementViewModel(UserId));
        }
    }
}
