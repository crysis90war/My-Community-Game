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
using System.Windows.Shapes;

namespace ApplicationGroupeEice.Views
{
    /// <summary>
    /// Logique d'interaction pour LoginRegisterView.xaml
    /// </summary>
    public partial class LoginRegisterView : Window
    {
        public LoginRegisterView()
        {
            InitializeComponent();
        }

        private void PasEncore_Click(object sender, RoutedEventArgs e)
        {
            Inscription.Width = 352;
        }

        private void boutonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Inscription.Width = 0;
        }
    }
}
