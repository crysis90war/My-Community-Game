   M S B A M L   `   `   `  ����X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  5      :    4AdministrateurApplicationEice.Views.UtilisateursView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AdministrateurApplicationEice.Views     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'   �� 5      $
��auto �6'   .+�5      �� $��0��6   $��Classement joueur��6,   $��20q�6E   $��25(�6Q   $
��Bold"�6_   $��Center=�6q   
�������6�   �� 5      $��1��6   $
��Wrap=�6J   $��20q�6^   $��25(�6j   
���  ��$��Center=�6�   $��Center=�6�   ��6,   ��  �� Path$ Warning�6�   �� 5      -   5         ��Name$ boutonBannir��5   )   $��2��6   $��5q�6?   $��20q�6K   $��	Ban/Unban��6W   $��20(�6k   5      5      �� 5   
   $��1��6   $��20q�6$   .��5       �� -   5         ��Name$ CommunityUsers��5       $��0q�6Z   
������  �� SelectedItem 6/   �� $ SelectedUser���5!      �� 5"      .R�5#      ]� $��5q�6$   .+�5$      �  5%   "   �� 5&   &   $
��auto �67   �� 5'   &   $
��auto �67   .+�5*   "   �� $��5q�6-   $��1��68    �� Orientation$ 
Horizontal=�6H   .+�5+   &   �� $��50��6,   $��20��6h   $��Center=�6t   ��67   �� $ UserStatus.StatusIconUrl�6t   �� 5,   &   $��50��6,   $��20��6d   ��67   �� $ UserRank.RankIconUrl�6d   �� 5-   &   $	��300��60   
�������$��Cambria)�6t   $��20(�6�   $��Center=�6�   $
��Bold"�6�   ��6<   �� $ UserPublicName�6�   �� 5.   &   $	��150��60   
�������$��Cambria)�6o   $��20(�6�   $��Center=�6�   $
��Bold"�6�   ��6<   �� $ 	UserScore�6�   �� 5/   &   $	��150��60   
�������$��Cambria)�6s   $��20(�6�   $��Center=�6�   $
��Bold"�6�   ��6<   �� $ IsBannedState�6�   51   #   52      53      54      56      57      58      59      