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
    public class DefisParMoiViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private BindableCollection<DefiModel> _userChallenges = new BindableCollection<DefiModel>();
        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BindableCollection<DefiModel> UserChallenges
        {
            get { return _userChallenges; }
            set { _userChallenges = value; NotifyOfPropertyChange(() => UserChallenges); }
        }
        #endregion

        #region Constructors
        public DefisParMoiViewModel(int userId)
        {
            UserId = userId;
            InitialiserDefis();
        }
        #endregion

        #region Others
        public void InitialiserDefis()
        {
            List<DefiModel> mesDefis = new List<DefiModel>();
            mesDefis = GlobalConfig.Connection.GetDefi_MesDefisApprouves(UserId);

            foreach (var defi in mesDefis)
            {
                UserChallenges.Add(defi);
            }
        }

        public void boutonRefresh()
        {
            UserChallenges = null;
            UserChallenges = new BindableCollection<DefiModel>();
            InitialiserDefis();
        }
        #endregion
    }
}
