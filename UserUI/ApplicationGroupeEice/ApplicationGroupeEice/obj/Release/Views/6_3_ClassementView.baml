   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  0    *ApplicationGroupeEice.Views.ClassementView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $��Cambria)�
�������$	��625��$
��1029��  � 	Resources   �� MergedDictionaries �� Source��  �� $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?��� $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�%    .���  � RowDefinitions �� $
��auto ��� $
��auto �.+�]� -    ]�Name$ dpClassement��$��0��$	��625��.+�]� $	��Top=�.+��  � ColumnDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $��0��$��Classement joueur��$��20q�$��25(�$
��Bold"�$��Center=��� $��1��$
��Wrap=�$��20q�$��25(�
���  ��$��Center=�$��Center=�����  �� Path$ Warning��� $��2��.+��� -    ��Name$ boutonAfficherProfil��$��10q�$��100 10q�$��Afficher le profil��$��25(�   boutonsRetour#��[  �� -   $ 	AddFriend��$��Envoyer invitation��#��[  $��Center=��� $��Bottom=�$��20q�.���� -    ��Name$ UserClassement��$��0q�
������ 	 �� SelectedItem	 �� $ SelectedUser����� .R�]� $��5q�.+��  �� $
��auto ��� $
��auto �.+��� $��5q�$��1��
 �� Orientation$
 
Horizontal=�.+��� $��50��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ UserClassement��� $��50��$��20��$��Center=����� $ UserStatus.StatusIconUrl��� $��50��$��20������ $ UserRank.RankIconUrl��� $	��300��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ UserPublicName��� $	��150��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ 	UserScore��� $	��150��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ NumberOfTrophies�]� -   $ dpAfficheProfil��$��1��$��0��.+�]� $	��Top=�.+��  �� $��* ��� $
��auto �.+��� $��0��$��Profil��$��20q�$��25(�$
��Bold"��� -   $ boutonRetourClassement��$��1��$��10q�$��100 10q�$��Retour��$��25(�#��[  ]� .+��  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � �� $��20 ��� $��* ��� $��* ��� $��* ��� $��20 �.+��� $
 
Horizontal=�$��0��$��1��$��3��.+��� $��30������ $+ %SelectedUser.UserStatus.StatusIconUrl��� $��50������ $' !SelectedUser.UserRank.RankIconUrl��� 
�������$��40(�$��cambria)�$��20 0 0 0q�$��Center=����� $! SelectedUser.UserPublicName��� $
 
Horizontal=�$��1��$��1��$��3��.+��� $6��0/ApplicationGroupeEice;component/Image/Score.png��$
��Fill=��� $��Score :��
�������$��40(�$��Cambria)�$��Center=�$��10q�$��Center=��� -    ��Name$ SelectedUser_UserScore��
�������$��40(�$��cambria)�$��Center=�$��10q�$��Center=����� $ SelectedUser.UserScore��� $��2��$��1��$��3��$��Stretch=�$��Center=�.+��� $��	Trophées��
�������$��20(�$��Cambria)�$��Center=�$��10q��� 
�������$��20(�$��cambria)�$��Center=�$��10q����� $# SelectedUser.NumberOfTrophies��� $	��100��$	��100��$��10q�$U��O/ApplicationGroupeEice;component/Image/iconfinder_advantage_quality_1034364.png��$
��Fill=��� $��2��$��2��$��3��$��Stretch=�$��Center=�.+��� $
��Rang��
�������$��20(�$��Cambria)�$��Center=�$��10q��� 
�������$��20(�$��cambria)�$��Center=�$��10q����� $$ SelectedUser.UserRank.RankName��� $	��100��$	��100��$��10q�$5��//ApplicationGroupeEice;component/Image/Rank.png��$
��Fill=��� $��2��$��3��$��3��$��Stretch=�$��Center=�.+��� $��Défis réussis��
�������$��20(�$��Cambria)�$��Center=�$��10q��� $��0��
�������$��20(�$��cambria)�$��Center=�$��10q��� $	��100��$	��100��$��10q�$;��5/ApplicationGroupeEice;component/Image/LogoDéfis.png��$
��Fill=�