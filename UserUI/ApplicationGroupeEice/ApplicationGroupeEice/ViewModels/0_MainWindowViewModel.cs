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
    public class MainWindowViewModel : Conductor<object>
    {
        #region Friends
        private List<UserModel> myFriends;
        private BindableCollection<UserModel> _myFriends = new BindableCollection<UserModel>();
        private UserModel _selectedFriend;
        private List<UserModel> invitationFromMe;
        private BindableCollection<UserModel> _invitationFromMe = new BindableCollection<UserModel>();
        private UserModel _selectedInvitationFromMe;
        private List<UserModel> invitationFromOthers;
        private BindableCollection<UserModel> _invitationFromOthers = new BindableCollection<UserModel>();
        private UserModel _selectedInvitationFromOthers;

        public BindableCollection<UserModel> MyFriends
        {
            get { return _myFriends; }
            set { _myFriends = value; }
        }

        public UserModel SelectedFriend
        {
            get { return _selectedFriend; }
            set 
            { 
                _selectedFriend = value;
                NotifyOfPropertyChange(() => SelectedFriend);
            }
        }

        public BindableCollection<UserModel> InvitationFromMe
        {
            get { return _invitationFromMe; }
            set { _invitationFromMe = value; }
        }

        public UserModel SelectedInvitationFromMe
        {
            get { return _selectedInvitationFromMe; }
            set 
            { 
                _selectedInvitationFromMe = value;
                NotifyOfPropertyChange(() => SelectedInvitationFromMe);
            }
        }

        public BindableCollection<UserModel> InvitationFromOthers
        {
            get { return _invitationFromOthers; }
            set { _invitationFromOthers = value; }
        }


        public UserModel SelectedInvitationFromOthers
        {
            get { return _selectedInvitationFromOthers; }
            set 
            {
                _selectedInvitationFromOthers = value;
                NotifyOfPropertyChange(() => SelectedInvitationFromOthers);
            }
        }
        #endregion

        //private static MainWindowViewModel s_Instance = null;
        IWindowManager manager = new WindowManager();
        UserModel userData = new UserModel();
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set 
            {
                _userId = value;
                NotifyOfPropertyChange(() => UserId);
            }
        }

        public MainWindowViewModel(int userId)
        {
            //if (s_Instance == null)
            //{
            //    s_Instance = this;
            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine(string.Format("Another main Window : {0}", s_Instance.Equals(this)));
            //}


            UserId = userId;
            userData = GlobalConfig.Connection.GetUser_Info(userId);
            ActivateItem(new AccueilViewModel());

            myFriends = userData.UserFriends; //GlobalConfig.Connection.GetUserFriendship_Confirmed(UserId);
            invitationFromMe = userData.UserFriendRequest;
            invitationFromOthers = userData.UserFriendReceived;

            foreach (var friend in myFriends)
            {
                MyFriends.Add(friend);
            }

            foreach (var friendRequest in invitationFromMe)
            {
                InvitationFromMe.Add(friendRequest);
            }

            foreach (var requestReceived in invitationFromOthers)
            {
                InvitationFromOthers.Add(requestReceived);
            }
        }

        public void MI_Accueil()
        {
            userData = GlobalConfig.Connection.GetUser_Info(UserId);
            DeactivateItem(ActiveItem, true);
            ActivateItem(new AccueilViewModel());
        }

        public void MI_Profil()
        {
            userData = GlobalConfig.Connection.GetUser_Info(UserId);
            DeactivateItem(ActiveItem, true);
            ActivateItem(new ProfilViewModel(userData));
        }

        public void MI_Jeux()
        {
            userData = GlobalConfig.Connection.GetUser_Info(UserId);
            DeactivateItem(ActiveItem, true);
            ActivateItem(new GamesViewModel(userData));
        }

        public void MI_Defis()
        {
            DeactivateItem(ActiveItem, true);
            ActivateItem(new DefisViewModel(UserId));
        }

        public void MI_Evenements()
        {
            DeactivateItem(ActiveItem, true);
            ActivateItem(new EvenementsViewModel());
        }

        public void MI_Communaute()
        {
            userData = GlobalConfig.Connection.GetUser_Info(UserId);
            DeactivateItem(ActiveItem, true);
            ActivateItem(new CommunauteViewModel(UserId));
        }

        public void MI_Amis()
        {
  
        }

        public void MI_Deconnexion()
        {
            LoginRegisterViewModel A = new LoginRegisterViewModel();

            GlobalConfig.Connection.UpdateDeconnexionUtilisateur(userData);
            manager.ShowWindow(A);
            this.TryClose();
        }

        public void MI_Fermeture()
        {
            GlobalConfig.Connection.UpdateDeconnexionUtilisateur(userData);
            this.TryClose();
        }

        public void boutonEnvoyerMessage()
        {
            //ActivateItem(new MessengerViewModel( UserId, SelectedFriend.UserId));
            manager.ShowWindow(new MessengerViewModel(UserId, SelectedFriend.UserId));

            // this.TryClose();
            //pas de tryclose ici car on veut que les messagerie restent ouverte en meme temps (popup)
        }

        public void boutonSupprimerAmi()
        {

        }

        public void boutonAnnulerRequest()
        {

        }

        public void boutonAccepter()
        {
            try
            {
                GlobalConfig.Connection.UpdateFriendship_State(SelectedInvitationFromOthers.UserId, UserId);
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
            }
        }

        public void boutonRefuser()
        {

        }
    }
}
