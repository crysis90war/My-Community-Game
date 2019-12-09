using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class GererDefisViewModel : Screen
    {
        #region 
        private int _userId;
        #endregion

        #region
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }
        #endregion

        #region
        public GererDefisViewModel(int userId)
        {
            UserId = userId;
        }
        #endregion

        public void UpdateDefi()
        {

        }
    }
}
