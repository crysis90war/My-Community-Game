using Caliburn.Micro;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class ProfilViewModel : Conductor<object>
    {
        UserModel userData;

        public ProfilViewModel(UserModel modele)
        {
            userData = modele;
            ActivateItem(new ProfilUtilisateurViewModel(userData));
        }

        public void MI_MonProfil()
        {
            ActivateItem(new ProfilUtilisateurViewModel(userData));
        }

        public void MI_HistoriqueTrophee()
        {
            ActivateItem(new HistoriqueTropheeViewModel(userData.UserId));
        }

        public void MI_HistoriqueDefis()
        {
            ActivateItem(new HistoriqueDefisViewModel());
        }

        public void MI_HistoriqueEvenements()
        {
            ActivateItem(new HistoriqueEvenementsViewModel());
        }
    }
}
