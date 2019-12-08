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
    /// Logique d'interaction pour MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void MI_Amis_Click(object sender, RoutedEventArgs e)
        {
            if (dpListviewFriends.Width == 0)
            {
                dpListviewFriends.Width = 350;
            }
            else
            {
                dpListviewFriends.Width = 0;
            }
        }

        private void boutonAfficherAmis_Click(object sender, RoutedEventArgs e)
        {
            spMesAmis.Height = 562;
            spInvitationEnvoyee.Height = 0;
            spInvitationRecu.Height = 0;
        }

        private void boutonAfficherFriendRequest_Click(object sender, RoutedEventArgs e)
        {
            spMesAmis.Height = 0;
            spInvitationEnvoyee.Height = 562;
            spInvitationRecu.Height = 0;
        }

        private void boutonAfficherFriendReceived_Click(object sender, RoutedEventArgs e)
        {
            spMesAmis.Height = 0;
            spInvitationEnvoyee.Height = 0;
            spInvitationRecu.Height = 562;
        }
    }
}
