   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      0    *ApplicationGroupeEice.Views.GererDefisView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $	��580��5   8   $
��1201��6E     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5       $��20 �6   .+�5#   
   �� -   5         ��Name$ 	UserGames��5#   D   $��1��6   $��1��6    $��2��60   $��150 10 150 10q�6}    �� SelectedItem 6W   �� *SelectedGame+��5$      �� 5%      .R�5&      ]� .+�5'      �� $
��Left=�6    $��40��6[   $��Center=�6g   $��5q�6�   ��66   ��  �� Path$ GameImageUrl�6�   �� 5(      $��Right=�6%   $��5q�6<   .+�5)      �� $
��Wrap=�6(   ��6<   �� $ GameName��� 5*      ��6(   �� $ GameReleaseDate��� 5+      ��6(   �� $ AchievementsCount��� 5,      ��6(   �� $  NumberAchievementsAchieved�5-      5.      5/      51      �� 53   
   $��2��6   $��1��6$   $��2��64   $��150 10 150 10q�6H   .��54      �� -   5         ��Name$ SelectedGame_GameDefis��54       66   �� $ SelectedGame�	 �� Mode$	 OneWayToSource=���55      �� 56      .R�58      ]� $��5q�6$   $��1��6/   .+�59      �� .+�5:   "   �� $��0 0 0 10q�6R   
���   �$��Cambria)�6w   $��14(�6�   $
��Bold"�6�   ��6,   �� $ DefiDisplayName�6�   �� 5;   "   $
��Wrap=�6R   
���   �$��Cambria)�6y   $��12(�6�   $
��Bold"�6�   ��6,   �� $ DefiDescription�6�   5<      �� 5>      
���   �$��Cambria)�6_   $��14(�6t   $
��Bold"�6�   $��	100 0 0 0q�6�   ��6(   �� $ ScoreToString�6�   5?      5@      5B      5C      �� 5E   
   -   5        
 ��Name$
 
UpdateDefi��5E      $��3��6%   $��1��62   $��150 10 0 10q�6B   $��Marquer réussi��6W   �� 5G   
   $��WarningMessage��6   $��3��6*   $��2��67   $��Center=�6G   $��Center=�6d   $��20(�6   5H      5I      