using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGroupeEice.ViewModels
{
    public class AccueilViewModel : Conductor<object>
    {
        public AccueilViewModel()
        {
            ActivateItem(new VideoGameViewModel());
        }

        public void boutonVideoGame()
        {
            ActivateItem(new VideoGameViewModel());
        }

        public void boutonBoardGame()
        {

        }
    }
}
