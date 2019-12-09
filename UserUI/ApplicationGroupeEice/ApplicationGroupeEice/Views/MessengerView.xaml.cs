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
    /// Logique d'interaction pour MessengerView.xaml
    /// </summary>
    public partial class MessengerView : Window
    {
        public MessengerView()
        {
            InitializeComponent();
        }

        private void bouton_Envois_Click(object sender, RoutedEventArgs e)
        {

        }
        private void bouton_Actualiser_Click(object sender, RoutedEventArgs e)
        {

        }
        private void bouton_Clean_Click(object sender, RoutedEventArgs e)
        {
            TextBoxEnvois.Text = "";
        }
    }
}
