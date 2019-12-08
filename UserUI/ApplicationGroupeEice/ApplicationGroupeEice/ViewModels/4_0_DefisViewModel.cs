using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class DefisViewModel : Conductor<object>
    {
        CreerDefisViewModel creerDefis = new CreerDefisViewModel();
        DefisLesMieuxNotesViewModel defisLesMieuxNotes = new DefisLesMieuxNotesViewModel();
        TousLesDefisViewModel tousLesDefis = new TousLesDefisViewModel();
        DefisCreesParAmisViewModel defisCreesParAmis = new DefisCreesParAmisViewModel();

        public DefisViewModel()
        {
            ActivateItem(creerDefis);
        }

        public void MI_CreerNouveauDefi()
        {
            ActivateItem(creerDefis);
        }

        public void MI_VoirDefisMieuxNotes()
        {
            ActivateItem(defisLesMieuxNotes);
        }
    }
}
