using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class ListeDesDefisViewModel : Conductor<object>
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public ListeDesDefisViewModel(int userId)
        {
            UserId = userId;
            ActivateItem(new TousLesDefisViewModel(userId));
        }

        public void MI_VoirTousDefis()
        {
            ActivateItem(new TousLesDefisViewModel(UserId));
        }

        public void MI_DefisDesAmis()
        {
            ActivateItem(new DefisCreesParAmisViewModel());
        }

        public void MI_VoirMesDefis()
        {
            ActivateItem(new DefisParMoiViewModel(UserId));
        }
    }
}
