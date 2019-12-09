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
    public class UtilisateursViewModel : Screen
    {
        #region Private Fields
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }


        private BindableCollection<UserModel> _communityUsers = new BindableCollection<UserModel>();
        private UserModel _selectedUser;

        private string _warning;

        public string Warning
        {
            get { return _warning; }
            set { _warning = value; NotifyOfPropertyChange(() => Warning); }
        }


        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set { _selectedUser = value; NotifyOfPropertyChange(() => SelectedUser); }
        }

        #endregion

        #region Public Properties
        public BindableCollection<UserModel> CommunityUsers
        {
            get { return _communityUsers; }
            set { _communityUsers = value; NotifyOfPropertyChange(() => CommunityUsers); }
        }
        #endregion

        #region Constructor
        public UtilisateursViewModel(int userId)
        {
            UserId = userId;
            Initializer();
        }
        #endregion

        #region Others
        public void Initializer()
        {
            List<UserModel> allUsers = new List<UserModel>();
            allUsers = GlobalConfig.Connection.GetUser_All();

            foreach (var user in allUsers)
            {
                CommunityUsers.Add(user);
            }
        }

        public void boutonBannir()
        {
            if (SelectedUser != null)
            {

                if (SelectedUser.UserId!=UserId)
                {
                    if (SelectedUser.UserIsBanned == 1)
                    {
                        // TODO - unban user if banned
                        // créer procedure pour update user is banned vers 1
                        //GlobalConfig
                        GlobalConfig.Connection.UpdateUser_Unban(SelectedUser.UserId);

                    }
                    else
                    {
                        // Ban user if not banned
                        // créer procédure pour update user is banned vers 0
                        GlobalConfig.Connection.UpdateUser_Ban(SelectedUser.UserId);
                    } 
                }
                else
                {
                    Warning = "Vous ne pouvez pas vous banir vous meme!";
                }
            }
            else
            {
                Warning = "Veuillez selectionner un utilisateur";
            }

            CommunityUsers = null;
            CommunityUsers = new BindableCollection<UserModel>();
            Initializer();
        }
        #endregion
    }
}
