using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCG_Library.Models;

namespace ApplicationGroupeEice.ViewModels
{
    public class ProfilUtilisateurViewModel : Screen
    {
        private UserModel _userData;

        public UserModel UserData
        {
            get { return _userData; }
            set 
            {
                _userData = value;
                NotifyOfPropertyChange(() => UserData);
            }
        }

        public ProfilUtilisateurViewModel(UserModel modele)
        {
            UserData = modele;
        }
    }
}
