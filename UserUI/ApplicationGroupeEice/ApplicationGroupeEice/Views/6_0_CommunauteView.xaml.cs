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
    /// Logique d'interaction pour CommunauteView.xaml
    /// </summary>
    public partial class CommunauteView : UserControl
    {
        public CommunauteView()
        {
            InitializeComponent();
        }

        private void boutonEvenements_Click(object sender, RoutedEventArgs e)
        {
            spBoutonsChoix.Height = 0;
            dpAffichage.Height = 625;
        }

        private void boutonDefis_Click(object sender, RoutedEventArgs e)
        {
            spBoutonsChoix.Height = 0;
            dpAffichage.Height = 625;
        }

        private void boutonClassement_Click(object sender, RoutedEventArgs e)
        {
            spBoutonsChoix.Height = 0;
            dpAffichage.Height = 625;
        }

        private void boutonRetour_Click(object sender, RoutedEventArgs e)
        {
            spBoutonsChoix.Height = 625;
            dpAffichage.Height = 0;
        }
    }
}
