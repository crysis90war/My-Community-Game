using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicationGroupeEice.Views
{
    /// <summary>
    /// Logique d'interaction pour ClassementView.xaml
    /// </summary>
    public partial class ClassementView : UserControl
    {
        public ClassementView()
        {
            InitializeComponent();
        }

        private void boutonAfficherProfil_Click(object sender, RoutedEventArgs e)
        {
            if (dpClassement.Height == 625 && dpAfficheProfil.Height == 0)
            {
                dpClassement.Height = 0;
                dpAfficheProfil.Height = 625;
            }
        }
        private void boutonRetourClassement_Click(object sender, RoutedEventArgs e)
        {
            if (dpClassement.Height == 0 && dpAfficheProfil.Height == 625)
            {
                dpClassement.Height = 625;
                dpAfficheProfil.Height = 0;
            }
        }
    }
}
