using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCG_Library.Models;
using MCG_Library;

namespace ApplicationGroupeEice.ViewModels
{
    public class ClassementViewModel : Screen
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        private string _warning;

        public string Warning
        {
            get { return _warning; }
            set { _warning = value; NotifyOfPropertyChange(() => Warning); }
        }


        List<UserModel> userClassement;
        private UserModel _selectedUser;

        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                NotifyOfPropertyChange(() => SelectedUser);
            }
        }

        private BindableCollection<UserModel> _userClassement = new BindableCollection<UserModel>();

        public BindableCollection<UserModel> UserClassement
        {
            get { return _userClassement; }
            set 
            {
                _userClassement = value;
                NotifyOfPropertyChange(() => UserClassement); 
            }
        }

        public ClassementViewModel(int userId)
        {
            UserId = userId;
            userClassement = GlobalConfig.Connection.GetUser_Classement();
            foreach (var user in userClassement)
            {
                UserClassement.Add(user);
            }
        }

        public void AddFriend()
        {
            try
            {
                int myid = UserId;
                int targetid = SelectedUser.UserId;

                if (myid == targetid)
                {
                    Warning = "Vous ne pouvez pas vous envoyer l'invitation";
                }
                else
                {
                    GlobalConfig.Connection.CreerInvitationAmi(myid, targetid);
                    Warning = "Invitation envoyée avec succes";
                }

            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
                Warning = "Veuillez selectionner un utilisateur";
            }
        }
    }
}
