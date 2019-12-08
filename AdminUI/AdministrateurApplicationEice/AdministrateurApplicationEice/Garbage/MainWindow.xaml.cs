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

namespace AdministrateurApplicationEice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Utilisateurs A = new Utilisateurs();
        Evenement B = new Evenement();
        JeuxVidéos C = new JeuxVidéos();
        JeuxDeSociétés D = new JeuxDeSociétés();

        public MainWindow()
        {
            InitializeComponent();
           
        } 
         
        private void Users_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            Contenu.Children.Add(A);
        }

        private void Evenement_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            Contenu.Children.Add(B);
        }

        private void VG_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            Contenu.Children.Add(C);
        }


        private void JeuxDeSociétés_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            Contenu.Children.Add(D);
        }

        private void Fermeture_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Deconnexion_Click(object sender, RoutedEventArgs e)
        {
            Connexion E = new Connexion();
            E.Show();
            this.Close();
        }
    }
}
