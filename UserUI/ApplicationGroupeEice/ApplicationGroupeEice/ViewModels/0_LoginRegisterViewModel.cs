using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;

namespace ApplicationGroupeEice.ViewModels
{
    public class LoginRegisterViewModel : Conductor<object>
    {
        #region Private Fields

        #region Connexion
        IWindowManager manager = new WindowManager();
        private UserModel userConnection = new UserModel();
        private string _login;
        private string _password;
        private string _errorMessage;
        private SolidColorBrush _theColor;
        #endregion

        #region Register
        private string _registerLogin;
        private string _registerPublicName;
        private string _registerEmail;
        private string _registerEmailConfirm;
        private string _registerPassword;
        private string _registerPasswordConfirm;
        private string _messageRegister;
        #endregion

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

        public SolidColorBrush TheColor
        {
            get { return _theColor; }
            set
            {
                _theColor = value;
                NotifyOfPropertyChange(() => TheColor);
            }
        }

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public string RegisterLogin
        {
            get { return _registerLogin; }
            set
            {
                _registerLogin = value;
                NotifyOfPropertyChange(() => RegisterLogin);
            }
        }

        public string RegisterPublicName
        {
            get { return _registerPublicName; }
            set
            {
                _registerPublicName = value;
                NotifyOfPropertyChange(() => RegisterPublicName);
            }
        }

        public string RegisterEmail
        {
            get { return _registerEmail; }
            set
            {
                _registerEmail = value;
                NotifyOfPropertyChange(() => RegisterEmail);
            }
        }

        public string RegisterEmailConfirm
        {
            get { return _registerEmailConfirm; }
            set
            {
                _registerEmailConfirm = value;
                NotifyOfPropertyChange(() => RegisterEmailConfirm);
            }
        }

        public string RegisterPassword
        {
            get { return _registerPassword; }
            set
            {
                _registerPassword = value;
                NotifyOfPropertyChange(() => RegisterPassword);
            }
        }

        public string RegisterPasswordConfirm
        {
            get { return _registerPasswordConfirm; }
            set
            {
                _registerPasswordConfirm = value;
                NotifyOfPropertyChange(() => RegisterPasswordConfirm);
            }
        }

        public string MessageRegister
        {
            get { return _messageRegister; }
            set
            {
                _messageRegister = value;
                NotifyOfPropertyChange(() => MessageRegister);
            }
        }
        #endregion

        public LoginRegisterViewModel()
        {
            GlobalConfig.InitializeConnection(ConnectionType.MySql);
        }

        public void boutonConnexion()
        {
            try
            {
                string username = Login;
                string password = Password;
                userConnection = GlobalConfig.Connection.GetUser_One(username.ToLower(), password);
                // GlobalConfig.Connection.GetUser_One(username.ToLower(), password);
                // GlobalConfig.Connection.GetUser_One("samadh90", "samadh90");

                /*"samadh90","samadh90"*/

                if (userConnection.UserExists == 1)
                {
                    GlobalConfig.Connection.UpdateConnexionUtilisateur(userConnection);
                    manager.ShowWindow(new MainWindowViewModel(userConnection.UserId));
                    this.TryClose();
                }

                else
                {
                    TheColor = Brushes.Orange;
                    ErrorMessage = "Le pseudo ou le mot de passe sont incorrectes !";
                }
            }

            catch (Exception error)
            {
                TheColor = Brushes.Red;
                //ErrorMessage = "Les deux champs doivent être remplis.";

                ErrorMessage = error.Message.ToString();
            }
        }

        public void boutonRegister()
        {
            try
            {
                UserModel userInscription = new UserModel();
                userInscription.UserLogin = RegisterLogin;
                userInscription.UserPublicName = RegisterPublicName;
                userInscription.UserEmail = RegisterEmail;
                userInscription.UserPassword = RegisterPassword;

                if (RegisterEmailConfirm.ToLower() == userInscription.UserEmail && RegisterPasswordConfirm == userInscription.UserPassword)
                {
                    GlobalConfig.Connection.CreerUtilisateur(userInscription);

                    ReinisialiserLesChamps();
                    TheColor = Brushes.DarkGreen;
                    MessageRegister = "Utilisateur créé avec succès";
                }

                else
                {
                    TheColor = Brushes.Orange;
                    MessageRegister = "Vérifiez les champs de confirmation";
                }
            }
            catch (Exception)
            {
                TheColor = Brushes.Red;
                /*
                    si champs vides
                    MessageRegister = "Veuillez rentrer tous les champs.";
                */
                MessageRegister = "Cette enregistrement existe déjà";
                ReinisialiserLesChamps();
            }
        }

        public void boutonAnnuler()
        {
            TheColor = Brushes.Black;
            ErrorMessage = "";
            ReinisialiserLesChamps();
        }

        public void Fermer()
        {
            this.TryClose();
        }

        private void ReinisialiserLesChamps()
        {
            RegisterLogin = "";
            RegisterPublicName = "";
            RegisterEmail = "";
            RegisterEmailConfirm = "";
            RegisterPassword = "";
            RegisterPasswordConfirm = "";
        }
                
    }
}
