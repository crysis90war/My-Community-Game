   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      0    *ApplicationGroupeEice.Views.CreerDefisView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      
�������$��20(�5   2   $��Cambria)�6@   $
��Bold"�6U   $	��582��5   8   $
��1201��6E   .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"   $��20 10q�62   .+�5      �� $ ��Choix du jeu pour le défi��6   �� 5      -   5         ��Name$ 	UserGames��5      $��0 10 0 0q�6*    �� SelectedItem 6<   ��  �� Path$ SelectedGame� �� Mode$ TwoWay=���5      �� 5      .R�5      �� ��6$   �� *
GameName+5       5"      5#      �� 5%   
   $��1��6   $��0��6"   $��20 10q�62   .+�5&      �� $��Score du défi��6   �� 5'      -   5        $��ChallengeScore��5'      $��0 10 0 0q�6-    6?   �� $ SelectedChallengeScore�$ TwoWay=���5(      �� 5)      .R�5*      �� ��6$   �� *ScoreToString+5+      5-      5.      �� 50   
   $��2��6   $��0��6"   $��20 10q�62   .+�51      �� $��Nom du défi��6   �� 52      -   5         ��Name$ ChallengeName��52      
������ $��0 10 0 0q�6F   53      �� 55   
   $��3��6   $��0��6"   $��20 10q�62   .+�56      �� $��Nom d'affichage du défi��6   �� 57      -   5        $ ChallengeDisplayName��57      
������ $��0 10 0 0q�6M   58      �� 5:   
   $��4��6   $��0��6"   $��20 10q�62   .+�5;      �� $��Description (facultatif)��6   �� 5<      -   5        $ ChallengeDescription��5<      
�������
������  �� TextWrapping$
 Wrap=�6i   $��0 10 0 0q�6}   $��60��6�   5=      �� 5?   
   $��0��6   $��1��6"   $��5��62   $��20 10q�6C   5A      �� 5C   
   $��5��6   $��0��6!   $��2��61   $��Center=�6e   
��� �����6E   �� *WarningMessage+6�   �� 5E   
   -   5         ��Name$ boutonCreerDefi��5E   N   $��6��6   $��0��6   $��2��6.   $��20q�6B   $��Créer le défi��6g   
�������$��cambria)�6�   $��30(�6�   
������ 6�   5G      5H      