   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      6    0ApplicationGroupeEice.Views.GererAchievementView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $	��580��5   8   $
��1201��6E     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5       $��20 �6   .+�5#   
   �� -   5         ��Name$ 	UserGames��5#   D   $��1��6   $��1��6    $��2��60   $��150 10 150 10q�6}    �� SelectedItem 6W   �� *SelectedGame+��5$      �� 5%      .R�5&      ]� .+�5'      �� $
��Left=�6    $��40��6[   $��Center=�6g   $��5q�6�   ��66   ��  �� Path$ GameImageUrl�6�   �� 5(      $��Right=�6%   $��5q�6<   .+�5)      �� $
��Wrap=�6(   ��6<   �� $ GameName��� 5*      ��6(   �� $ GameReleaseDate��� 5+      ��6(   �� $ AchievementsCount��� 5,      ��6(   �� $  NumberAchievementsAchieved�5-      5.      5/      51      �� 53   
   $��2��6   $��1��6$   $��2��64   $��150 10 150 10q�6H   .��54      �� -   5         ��Name$# SelectedGame_GameAchievements��54       6=   �� *SelectedAchievement+	 �� Mode$	 OneWayToSource=���55      �� 56      .R�57      �� $��0 10 0 0q�6%   .+�58      �  59   "   �� 5:   &   $
��auto �67   �� 5;   &   $
��auto �67   .+�5>   "   �� $��0��6W   $��Center=�6g   $��Center=�6�   $��5q�6�   ��6(   �� $ AchievementAchiedorNot�6�   �� 5@   "   $��5q�6-   $��1��68   .+�5A   &   �� $��0 0 0 10q�6]   $��Cambria)�6o   $��14(�6�   $
��Bold"�6�   ��60   �� $ AchievementDisplayName�6�   �� 5B   &   $
��Wrap=�6]   $��Cambria)�6q   $��12(�6�   $
��Bold"�6�   ��60   �� $ AchievementDescription�6�   5C   #   5D      5E      5F      5H      5I      �� 5K   
   -   5        
 ��Name$
 UpdateAchievement��5K      $��3��6,   $��1��69   $��150 10 0 10q�6I   $��Marquer réussi��6^   �� 5M   
   $��3��69   $��2��6F   $��Center=�6V   $��Center=�6s   $��20(�6�   ��6   �� $ WarningMessage�6�   5N      5O      