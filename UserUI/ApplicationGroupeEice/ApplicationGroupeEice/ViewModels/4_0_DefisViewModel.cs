using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class DefisViewModel : Conductor<object>
    {
        #region Private Fields
        private int _userId;
        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }
        #endregion

        #region Constructor
        public DefisViewModel(int userId)
        {
            UserId = userId;
            ActivateItem(new CreerDefisViewModel(userId));
        }
        #endregion

        #region Others
        public void MI_CreerNouveauDefi()
        {
            ActivateItem(new CreerDefisViewModel(UserId));
        }
        #endregion
    }
}
