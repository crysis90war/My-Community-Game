﻿using System;
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

namespace AdministrateurApplicationEice
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Fermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void boutonConnexion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow A = new MainWindow();
            A.Show();
            this.Close();
        }
    }
}
