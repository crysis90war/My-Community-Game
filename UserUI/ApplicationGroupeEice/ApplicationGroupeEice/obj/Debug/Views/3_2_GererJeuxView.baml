   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      /    )ApplicationGroupeEice.Views.GererJeuxView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
   �� $��Mes jeux��6   $��0��6$   $��0��61   $��3��6A   $��20(�6U   
�������$��Center=�6v   $��Center=�6�   �� 5&   
   $��1��6   $��0��6$   $��3��64   $��20q�6H   .��5'      �� -   5         ��Name$ 	UserGames��5'       �� SelectedItem 6)   ��  �� Path$ SelectedUGame� �� Mode$ OneWayToSource=���5(      �� 5)      .R�5*      ]� .+�5+      �� $
��Left=�6$   $��40��6_   $��Center=�6k   $��5q�6�   ��6:   �� $ GameImageUrl�6�   �� 5,      $��Right=�6)   $��5q�6@   .+�5-   "   �� $
��Wrap=�6,   ��6@   �� $ GameName��� 5.   "   ��6,   �� $ GameReleaseDate��� 5/   "   ��6,   �� $ AchievementsCount��� 50   "   ��6,   �� $  NumberAchievementsAchieved�51      52      53      55      56      �� 58   
   -   5        	 ��Name$	 SupprimerJeu��58      $��	Supprimer��6'   $��8��6;   $��1��6H   $��20q�6X   �� 5:   
   $��Jeux de communauté��6   $��0��6.   $��4��6;   $��3��6K   $��20(�6_   
�������$��Center=�6�   $��Center=�6�   �� 5<   
   $��1��6   $��4��6$   $��3��64   $��20q�6H   .��5=      �� -   5        $ CommunityGames��5=       6.   �� $ SelectedCGame�$ OneWayToSource=���5>      �� 5?      .R�5@      ]� .+�5A      �� $
��Left=�6$   $��40��6_   $��Center=�6k   $��5q�6�   ��6:   �� $ GameImageUrl�6�   �� 5B      $��Right=�6)   $��5q�6@   .+�5C   "   �� $
��Wrap=�6,   ��6@   �� $ GameName��� 5D   "   ��6,   �� $ GameReleaseDate��� 5E   "   ��6,   �� $ AchievementsCount�5F      5G      5H      5J      5K      �� 5M   
   -   5        $	 
AjouterJeu��5M      $��Ajouter��6%   $��20(�67   $��8��6E   $��5��6R   $��20q�6b   �� 5O   
   $��7��64   $��2��6A   $��3��6Q   $��20q�6e   $
��Wrap=�6q   ��6   �� *WarningMessage+6q   5Q      5R      