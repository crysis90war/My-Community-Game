   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  0    *ApplicationGroupeEice.Views.MainWindowView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:ApplicationGroupeEice.Views     -     � Title$  My Community Game��$	��700��$
��1201�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�$��0q� � WindowStyle$
 None=� � Icon$S M/ApplicationGroupeEice;component/Image/iconfinder_gamer_titanfall_1536911.ico�� � 	Resources  �� MergedDictionaries �� Source��  �� $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?��� $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�%    .��� ����  �� ImageSource$5 //ApplicationGroupeEice;component/Image/Fond.jpg��	 � RowDefinitions	 �� $
��auto ��� $��* ��� $��20 �
 � ColumnDefinitions
 �� $��* ��� $
��auto �.+�o� $��0��$��0��$��2�� � Cursor$
 Hand��
������ $��Cambria)�
�������$
��Bold"�$��30(�$��0q����� .R�]� $��Stretch=����� $9 3/ApplicationGroupeEice;component/Image/BordHaut.png��    MenuItemStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� %�   &	        �� " m�.���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q� P�  �@m�IsHighlighted . . ���  � ��
 ��ح�P�  �@J�	IsFocused . . ���  � ��
 ��ح���  �@J�Opacity$	 0.8Q�.@�m� -    m�Name$ 
MI_Accueil��$��_Accueil��$��15 10q�#��[  m� -   $ 	MI_Profil��$��_Profil��$��15 10q�#��[  m� -   $ MI_Jeux��$��	_Mes jeux��$��15 10q�#��[  m� -   $ MI_Defis��$��_Défis��$��15 10q�#��[  m� -   $ MI_Evenements��$��_Événements��$��15 10q�#��[  m� -   $ MI_Communaute��$��_Communauté��$��15 10q�#��[  m� -   $ MI_Amis��$��_X��$��20 10q�$��15(�$��50 0 0 0q�
������ 
������ #��[  ���� $8 2/ApplicationGroupeEice;component/Image/IconAmi.png��m� -	   $ MI_Deconnexion��$��_Déconnexion��$��15(�$��20 10q�$��0 0 0 0q�#��[  m� -
   $ MI_Fermeture��$��X�� J� RenderTransformOrigin$ 0.713,0.463&�$��20 10q�$��0 0 0 0q�$
 Hand��$��15(�$
��Bold"�$��Cambria)�$��Right=�#��[  �� -   $��
ActiveItem��$��1��$��0��$��Stretch=�$��Stretch=�]� -    ]�Name$ dpListviewFriends��$��1��$��1��$��0��
�������.+�� 	 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�]� $��0��.+��� -    ��Name$ boutonEnvoyerMessage��$��Envoyer Message��
�����_��� -   $ boutonSupprimerAmi��$��	Supprimer��
���  ���� -   $ boutonAfficherAmis��$��Mes Amis���� -    ��Name$ 	spMesAmis��$��1��$	��562��.+��� .���� -    ��Name$ 	MyFriends�� �� SelectedItem �� *SelectedFriend+���� .R���  �� Orientation$ 
Horizontal=�.+��� $��50��$��15��$��Center=�����  �� Path$ UserStatus.StatusIconUrl��� $��Cambria)�$��15(�$
��Bold"�$��Center=����� $ UserPublicName��� $��15������ $ UserRank.RankIconUrl�]� $��2��.+��� -   $ boutonAnnulerRequest��$��Annuler��
���  ���� -   $! boutonAfficherFriendRequest��$��Invitation(s) envoyée(s)���� -   $ spInvitationEnvoyee��$��3��$��0��.+��� .���� -   $ InvitationFromMe�� �� *SelectedInvitationFromMe+���� .R��� $ 
Horizontal=�.+��� $��Cambria)�$��15(�$
��Bold"�$��Center=����� $ UserPublicName�]� $��4��.+��� -   $ boutonAccepter��$��Accepter��
��� � ��� -   $ boutonRefuser��$��Refuser��
���  ���� -   $" boutonAfficherFriendReceived��$��Invitation(s) recu(s)���� -   $ spInvitationRecu��$��5��$��0��.+��� .���� -   $ InvitationFromOthers�� �� *SelectedInvitationFromOthers+���� .R��� $ 
Horizontal=�.+��� $��Cambria)�$��20(�$
��Bold"����� $ UserPublicName��� $��2��$��0��$��2������ $8 2/ApplicationGroupeEice;component/Image/BordBas.png��