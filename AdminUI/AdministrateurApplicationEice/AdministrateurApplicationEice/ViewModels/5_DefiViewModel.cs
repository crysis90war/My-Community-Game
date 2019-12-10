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
    public class DefiViewModel : Screen
    {
        #region Private Fields
        private int _userId;
        private BindableCollection<DefiModel> _communityDefis = new BindableCollection<DefiModel>();
        private BindableCollection<DefiModel> _communityApprovedDefi = new BindableCollection<DefiModel>();
        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        public BindableCollection<DefiModel> CommunityDefis
        {
            get { return _communityDefis; }
            set { _communityDefis = value; NotifyOfPropertyChange(() => CommunityDefis); }
        }

        public BindableCollection<DefiModel> CommunityApprovedDefi
        {
            get { return _communityApprovedDefi; }
            set { _communityApprovedDefi = value; NotifyOfPropertyChange(() => CommunityApprovedDefi); }
        }
        #endregion

        #region Constructor
        public DefiViewModel(int userId)
        {
            UserId = userId;
            Initialiize();
        }
        #endregion

        #region Others
        public void boutonApprouver()
        {

        }

        public void boutonRefuser()
        {

        }

        public void boutonSupprimer()
        {

        }

        public void Initialiize()
        {
            List<DefiModel> newDefi = new List<DefiModel>();
            List<DefiModel> acceptedDefi = new List<DefiModel>();

            newDefi = GlobalConfig.Connection.GetDefi_NotApproved();
            foreach (var defi in newDefi)
            {
                CommunityDefis.Add(defi);
            }

            acceptedDefi = GlobalConfig.Connection.GetDefi_ApprovedAll();
            foreach (var defi in acceptedDefi)
            {
                CommunityApprovedDefi.Add(defi);
            }
        }

        public void ResetLesView()
        {
            CommunityDefis = null;
            CommunityDefis = new BindableCollection<DefiModel>();
            CommunityApprovedDefi = null;
            CommunityApprovedDefi = new BindableCollection<DefiModel>();
            Initialiize();
        }
        #endregion
    }
}
