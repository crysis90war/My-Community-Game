   M S B A M L   `   `   `  ���� X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  :    4AdministrateurApplicationEice.Views.UtilisateursView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Clocal1clr-namespace:AdministrateurApplicationEice.Views     .���   � RowDefinitions  �� $
��auto ��� $��* �.+�]� $��0��.+��  � ColumnDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $��0��$��Classement joueur��$��20q�$��25(�$
��Bold"�$��Center=�
��������� $��1��$
��Wrap=�$��20q�$��25(�
���  ��$��Center=�$��Center=�����  �� Path$ Warning��� -    ��Name$ boutonBannir��$��2��$��5q�$��20q�$��	Ban/Unban��$��20(��� $��1��$��20q�.���� -    ��Name$ CommunityUsers��$��0q�
������  �� SelectedItem �� $ SelectedUser����� .R�]� $��5q�.+��  �� $
��auto ��� $
��auto �.+��� $��5q�$��1�� �� Orientation$ 
Horizontal=�.+��� $��50��$��20��$��Center=����� $ UserStatus.StatusIconUrl��� $��50��$��20������ $ UserRank.RankIconUrl��� $	��300��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ UserPublicName��� $	��150��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ 	UserScore��� $	��150��
�������$��Cambria)�$��20(�$��Center=�$
��Bold"����� $ IsBannedState�