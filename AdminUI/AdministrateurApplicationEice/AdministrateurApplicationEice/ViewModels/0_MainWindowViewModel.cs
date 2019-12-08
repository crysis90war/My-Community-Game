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
    public class MainWindowViewModel : Conductor<object>
    {
        #region Private Fields
        IWindowManager manager = new WindowManager();
        private int _userId;
        UserModel userData = new UserModel();
        private int _numberOfUsers;
        private int _numberOfUsersOnline;
        private int _numberOfGames;
        #endregion

        #region Public Properties
        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                NotifyOfPropertyChange(() => UserId);
            }
        }

        public int NumberOfUsers
        {
            get { return _numberOfUsers; }
            set { _numberOfUsers = value; NotifyOfPropertyChange(() => NumberOfUsers); }
        }

        public int NumberOfUsersOnline
        {
            get { return _numberOfUsersOnline; }
            set { _numberOfUsersOnline = value; NotifyOfPropertyChange(() => NumberOfUsersOnline); }
        }

        public int NumberOfGames
        {
            get { return _numberOfGames; }
            set { _numberOfGames = value; NotifyOfPropertyChange(() => NumberOfGames); }
        }
        #endregion

        #region Constructor
        public MainWindowViewModel(int userId)
        {
            UserId = userId;
            userData = GlobalConfig.Connection.GetUser_Info(userId);
            ActivateItem(new UtilisateursViewModel());
            NumberOfUsers = GlobalConfig.Connection.GetUser_Count();
            NumberOfUsersOnline = GlobalConfig.Connection.GetUser_OnlineCount();
            NumberOfGames = GlobalConfig.Connection.GetGame_Count();
        }
        #endregion

        #region Others
        public void MI_Utilisateurs()
        {
            ActivateItem(new UtilisateursViewModel());
        }

        public void MI_Events()
        {
            ActivateItem(new EventViewModel());
        }

        public void MI_VideoGame()
        {
            ActivateItem(new VideoGameViewModel());
        }

        public void MI_BoardGame()
        {
            ActivateItem(new BoardGameViewModel());
        }

        public void Deconnexion()
        {
            LoginViewModel A = new LoginViewModel();

            GlobalConfig.Connection.UpdateDeconnexionUtilisateur(userData);
            manager.ShowWindow(A);
            this.TryClose();
        }

        public void Fermeture()
        {
            GlobalConfig.Connection.UpdateDeconnexionUtilisateur(userData);
            this.TryClose();
        }


        public string NombreUtilisateurs
        {
            get
            {
                return $"{ NumberOfUsers }";
            }
        }

        public string NombreUtilisateursEnLigne
        {
            get
            {
                return $"{ NumberOfUsersOnline }";
            }
        }

        public string NombreJeux
        {
            get
            {
                return $"{ NumberOfGames }";
            }
        }
        #endregion
    }
}
