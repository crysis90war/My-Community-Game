   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      4    .ApplicationGroupeEice.Views.GererBoardGameView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   .+�5#   
   �� $��Mes jeux de société��6   $��0��6/   $��0��6<   $��3��6L   $��20(�6`   
�������$��Center=�6�   $��Center=�6�   �� 5%   
   $��1��6   $��0��6$   $��3��64   $��20q�6H   .��5&      �� -   5         ��Name$ 	UserGames��5&       �� SelectedItem 6)   ��  �� Path$ SelectedUGame� �� Mode$ OneWayToSource=���5'      �� 5(      .R�5)      ]� .+�5*      �� $
��Left=�6$   $��40��6[   $��Center=�6g   $��5q�6�   ��6:   �� $ ImageUrl�6�   �� 5+      $��Right=�6)   $��5q�6@   .+�5,   "   �� $
��Wrap=�6,   ��6@   �� $ GameName��� 5-   "   ��6,   �� $ 
DefisCount��� 5.   "   ��6,   �� $ NumberDefisAchieved�5/      50      51      53      54      �� 56   
   -   5        	 ��Name$	 SupprimerJeu��56      $��	Supprimer��6'   $��8��6;   $��1��6H   $��20q�6X   �� 58   
   $��Jeux de communauté��6   $��0��6.   $��4��6;   $��3��6K   $��20(�6_   
�������$��Center=�6�   $��Center=�6�   �� 5:   
   $��1��6   $��4��6$   $��3��64   $��20q�6H   .��5;      �� -   5        $ CommunityGames��5;       6.   �� $ SelectedCGame�$ OneWayToSource=���5<      �� 5=      .R�5>      ]� .+�5?      �� $
��Left=�6$   $��40��6[   $��Center=�6g   $��5q�6�   ��6:   �� $ ImageUrl�6�   �� 5@      $��Right=�6)   $��5q�6@   .+�5A   "   �� $
��Wrap=�6,   ��6@   �� $ GameName��� 5B   "   ��6,   �� $ AchievementsCount�5C      5D      5E      5G      5H      �� 5J   
   -   5        $	 
AjouterJeu��5J      $��Ajouter��6%   $��20(�67   $��8��6E   $��5��6R   $��20q�6b   �� 5L   
   $��7��64   $��2��6A   $��3��6Q   $��20q�6e   $
��Wrap=�6q   ��6   �� *WarningMessage+6q   5N      5O      