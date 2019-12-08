using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class EvenementsViewModel : Conductor<object>
    {
        CreerEvenementViewModel creerEvenement = new CreerEvenementViewModel();

        public EvenementsViewModel()
        {
            ActivateItem(creerEvenement);
        }

        public void MI_CreerEvenement()
        {
            ActivateItem(creerEvenement);
        }
    }
}
