   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      2    ,ApplicationGroupeEice.Views.TousLesDefisView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $��Cambria)�5      
�������$	��582��5   8   $
��1029��6E     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   $��1��6!   .+�5       �  5!      �� 5"      $
��auto �6'   �� 5#      $��* �6'   .+�5&      �� -   5         ��Name$ label��5&   ,   $��0��6   $"��Les défis de la communauté��6;   $��25(�6^   $
��Bold"�6l   $��10q�6~   �� 5'      -   5         ��Name$ 	UserGames��5'   U   $��1��6   $��Stretch=�6+   $��10q�6I    �� SelectedItem 6h   �� *SelectedGame+��5(      �� 5)      .R�5*      ]� .+�5+   "   �� $
��Left=�6(   $��40��6c   $��Center=�6o   $��5q�6�   ��6>   ��  �� Path$ GameImageUrl�6�   �� 5,   "   $��Right=�6-   $��5q�6D   .+�5-   &   �� $
��Wrap=�60   ��6D   �� $ GameName��� 5.   &   ��60   �� $ GameReleaseDate��� 5/   &   ��60   �� $ AchievementsCount��� 50   &   ��60   �� $  NumberAchievementsAchieved�51   #   52      53      55      56      57      �� 59   
   $��1��6   $��1��6$   $��10q�64   .��5:      �� -   5        	 ��Name$	 SelectedGame_GameDefis��5:      $��0q�6j   
������  67   �� *SelectedDefi+
 �� Mode$
 TwoWay=���5;      �� 5<      .R�5=      �� $��0 10 0 0q�6%   .+�5>      �  5?   "   �� 5@   &   $
��auto �67   �� 5A   &   $
��auto �67   .+�5D   "   ]� $��5q�6,   $��1��67   .+�5E   &   �� .+�5F   *   �� $��0 0 0 10q�6Z   
�������$��Cambria)�6   $��14(�6�   $
��Bold"�6�   ��64   �� $ DefiDisplayName�6�   �� 5G   *   $
��Wrap=�6Z   
�������$��Cambria)�6�   $��12(�6�   $
��Bold"�6�   ��64   �� $ DefiDescription�6�   5H   '   �� 5J   &   
�������$��Cambria)�6g   $��14(�6|   $
��Bold"�6�   $��	100 0 0 0q�6�   ��60   �� $ ScoreToString�6�   5K   #   5L      5M      5N      5P      5Q      5R      5S      