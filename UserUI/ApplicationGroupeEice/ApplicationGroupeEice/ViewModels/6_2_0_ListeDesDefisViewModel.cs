using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class ListeDesDefisViewModel : Conductor<object>
    {
        public ListeDesDefisViewModel()
        {
            ActivateItem(new TousLesDefisViewModel());
        }

        public void MI_VoirTousDefis()
        {
            ActivateItem(new TousLesDefisViewModel());
        }

        public void MI_DefisDesAmis()
        {
            ActivateItem(new DefisCreesParAmisViewModel());
        }

        public void MI_VoirMesDefis()
        {
            ActivateItem(new DefisParMoiViewModel());
        }
    }
}
