using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AdministrateurApplicationEice.ViewModels
{
    public class LoginViewModel : Conductor<object>
    {
        #region Private Fields
        IWindowManager manager = new WindowManager();
        private UserModel userConnection = new UserModel();
        private string _login;
        private string _password;
        private string _warningMessage;
        #endregion

        #region Public Properties
        public string Login
        {
            get { return this._login; }
            set
            {
                // Implement with property changed handling for INotifyPropertyChanged
                if (!string.Equals(this._login, value))
                {
                    this._login = value;
                    this.NotifyOfPropertyChange(() => Login); // Method to raise the PropertyChanged event in your BaseViewModel class...
                }
            }
        }

        public string Password
        {
            get { return this._password; }
            set
            {
                // Implement with property changed handling for INotifyPropertyChanged
                if (!string.Equals(this._password, value))
                {
                    this._password = value;
                    this.NotifyOfPropertyChange(() => Password); // Method to raise the PropertyChanged event in your BaseViewModel class...
                }
            }
        }

        public string WarningMessage
        {
            get
            {
                return _warningMessage;
            }
            set
            {
                _warningMessage = value;
                NotifyOfPropertyChange(() => WarningMessage);
            }
        }
        #endregion

        #region Construtors
        public LoginViewModel()
        {
            GlobalConfig.InitializeConnection(ConnectionType.MySql);
        }
        #endregion

        #region Others
        public void boutonConnexion()
        {
            try
            {
                string username = Login;
                string password = Password;


                if (username.Length != 0 && password.Length != 0)
                {
                    userConnection = GlobalConfig.Connection.GetUser_One(username.ToLower(), password);
                    UserModel userData = GlobalConfig.Connection.GetUser_Info(userConnection.UserId);
                    // GlobalConfig.Connection.GetUser_One(username.ToLower(), password);
                    // GlobalConfig.Connection.GetUser_One("samadh90", "samadh90");

                    /*"samadh90","samadh90"*/

                    if (userConnection.UserExists == 1 && userConnection.UserRole.RoleName == "Administrateur")
                    {
                        GlobalConfig.Connection.UpdateConnexionUtilisateur(userConnection);
                        manager.ShowWindow(new MainWindowViewModel(userConnection.UserId));
                        this.TryClose();
                    }
                    else
                    {
                        WarningMessage = "Le pseudo ou le mot de passe sont incorrectes ou vous n'êtes pas Admin!";
                    }
                }
                else
                {
                    WarningMessage = "Les deux champs doivent être remplis.";
                }
            }

            catch (Exception error)
            {
                WarningMessage = error.Message;

                System.Diagnostics.Debug.WriteLine(error.Message);
            }
        }

        public void Fermer()
        {
            this.TryClose();
        }
        #endregion
    }
}
