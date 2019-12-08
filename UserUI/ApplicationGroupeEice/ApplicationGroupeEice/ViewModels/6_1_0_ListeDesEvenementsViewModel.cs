using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class ListeDesEvenementsViewModel : Conductor<object>
    {
        public ListeDesEvenementsViewModel()
        {
            ActivateItem(new TousLesEvenementsViewModel());
        }

        public void MI_VoirTousEvenements()
        {
            ActivateItem(new TousLesEvenementsViewModel());
        }

        public void MI_EvenementsDesAmis()
        {
            ActivateItem(new EvenementsAmisViewModel());
        }

        public void MI_VoirMesEvenements()
        {
            ActivateItem(new EvenementsParMoiViewModel());
        }
    }
}
