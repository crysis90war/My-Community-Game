   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5   	   0    *ApplicationGroupeEice.Views.MainWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:ApplicationGroupeEice.Views     5   	   -   5          � Title$  My Community Game��5   	   $	��700��6#   $
��1201��60    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.   $��0q�6D    � WindowStyle$
 None=�5
   	    � Icon$S M/ApplicationGroupeEice;component/Image/iconfinder_gamer_titanfall_1536911.ico��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� ImageSource$5 //ApplicationGroupeEice;component/Image/Fond.jpg��6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   
 � ColumnDefinitions
 5    
   �� 5!      $��* �6   �� 5"      $
��auto �6   .+�5&   
   o� $��0��6   $��0��6   $��2��6,    � Cursor$
 Hand��6@   
������ $��Cambria)�6h   
�������$
��Bold"�6�   $��30(�6�   $��0q�6�   ��5(      �� 5)      .R�5*      ]� $��Stretch=�6    5+      ��5.      �� 5/      $9 3/ApplicationGroupeEice;component/Image/BordHaut.png��6    52         MenuItemStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� 53      %�  &	        �� 54      " m�62   .�55      ��  � ��
 ���� 68   �� 56       � ��
 ���� 68   �� 57       � ��$ 0q�6<    58      P� 59       �@m�IsHighlighted . . �5:   "   ��  � ��
 ��ح�6?   5;      P� 5<       �@J�	IsFocused . . �5=   "   ��  � ��
 ��ح�6?   �� 5>   "    �@J�Opacity$	 0.8Q�6<   5?      5A      5B      .@�5E      m� -   5         m�Name$ 
MI_Accueil��5E      $��_Accueil��6+   $��15 10q�6=   #��[  6M   m� 5G      -   5        $ 	MI_Profil��5G      $��_Profil��6*   $��15 10q�6;   #��[  6K   m� 5I      -   5        $ MI_Jeux��5I      $��	_Mes jeux��6(   $��15 10q�6;   #��[  6K   m� 5K      -   5        $ MI_Defis��5K      $��_Défis��6)   $��15 10q�69   #��[  6I   m� 5M      -   5        $ MI_Evenements��5M      $��_Événements��6.   $��15 10q�6C   #��[  6S   m� 5O      -   5        $ MI_Communaute��5O      $��_Communauté��6.   $��15 10q�6C   #��[  6S   m� 5Q      -   5        $ MI_Amis��5Q      $��_X��6(   $��20 10q�64   $��15(�6D   $��50 0 0 0q�6R   
������ 
������ #��[  6�   ��5R      �� 5S      $8 2/ApplicationGroupeEice;component/Image/IconAmi.png��6!   5U      m� 5W      -	   5        $ MI_Deconnexion��5W      $��_Déconnexion��6/   $��15(�6E   $��20 10q�6S   $��0 0 0 0q�6c   #��[  6t   m� 5Y      -
   5        $ MI_Fermeture��5Y      $��X��6-    J� RenderTransformOrigin$ 0.713,0.463&�68   $��20 10q�6\   $��0 0 0 0q�6l   $
 Hand��6}   $��15(�6�   $
��Bold"�6�   $��Cambria)�6�   $��Right=�6�   #��[  6�   5Z      �� 5^   
   -   5        $��
ActiveItem��5^      $��1��6+   $��0��68   $��Stretch=�6H   $��Stretch=�6f   ]� 5a   
   -   5         ]�Name$ dpListviewFriends��5a      $��1��6/   $��1��6<   $��0��6L   
�������.+�5b      � 	 5c      �� 5d      $
��auto �6$   �� 5e      $
��auto �6$   �� 5f      $
��auto �6$   �� 5g      $
��auto �6$   �� 5h      $
��auto �6$   �� 5i      $
��auto �6$   .+�5l      ]� $��0��6   .+�5m      �� -   5         ��Name$ boutonEnvoyerMessage��5m      $��Envoyer Message��6;   
�����_�6U   �� 5n      -   5        $ boutonSupprimerAmi��5n      $��	Supprimer��69   
���  ��6M   �� 5o      -   5        $ boutonAfficherAmis��5o      $��Mes Amis��6[   5p      �� 5q      -   5         ��Name$ 	spMesAmis��5q   *   $��1��6   $	��562��6=   .+�5r      �� .��5s      �� -   5         ��Name$ 	MyFriends��5s   #    �� SelectedItem 66   �� *SelectedFriend+��5t      �� 5u   "   .R�5v   &   ��  �� Orientation$ 
Horizontal=�61   .+�5w   *   �� $��50��60   $��15��6l   $��Center=�6x   ��6;   ��  �� Path$ UserStatus.StatusIconUrl�6x   �� 5x   *   $��Cambria)�6Y   $��15(�6n   $
��Bold"�6}   $��Center=�6�   ��64   �� $ UserPublicName�6�   �� 5y   *   $��15��6]   ��60   �� $ UserRank.RankIconUrl�6]   5z   '   5{   #   5}      5~      5      ]� 5�      $��2��6   .+�5�      �� -   5        $ boutonAnnulerRequest��5�      $��Annuler��6;   
���  ��6M   �� 5�      -   5        $! boutonAfficherFriendRequest��5�      $��Invitation(s) envoyée(s)��6l   5�      �� 5�      -   5        $ spInvitationEnvoyee��5�   *   $��3��6   $��0��6G   .+�5�      �� .��5�      �� -   5        $ InvitationFromMe��5�   #    6=   �� *SelectedInvitationFromMe+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $��Cambria)�6Y   $��15(�6n   $
��Bold"�6}   $��Center=�6�   ��64   �� $ UserPublicName�6�   5�   '   5�   #   5�      5�      5�      ]� 5�      $��4��6   .+�5�      �� -   5        $ boutonAccepter��5�      $��Accepter��65   
��� � �6H   �� 5�      -   5        $ boutonRefuser��5�      $��Refuser��64   
���  ��6F   �� 5�      -   5        $" boutonAfficherFriendReceived��5�      $��Invitation(s) recu(s)��6o   5�      �� 5�      -   5        $ spInvitationRecu��5�   *   $��5��6   $��0��6D   .+�5�      �� .��5�      �� -   5        $ InvitationFromOthers��5�   #    6A   �� *SelectedInvitationFromOthers+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $��Cambria)�6Y   $��20(�6n   $
��Bold"�6}   ��64   �� $ UserPublicName�6}   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�   
   $��2��6   $��0��6"   $��2��62   ��5�      �� 5�      $8 2/ApplicationGroupeEice;component/Image/BordBas.png��6   5�      5�      5�      