   M S B A M L   `   `   `  ����X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  5      7    1AdministrateurApplicationEice.Views.VideoGameView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AdministrateurApplicationEice.Views     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $G A/AdministrateurApplicationEice;component/Styles/ScrollViewer.xaml?�6%   �� 5      $A ;/AdministrateurApplicationEice;component/Styles/Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   .+�5#   
   �� $��Jeux de communauté��6   $��0��6.   $��0��6;   $��3��6K   $��20(�6_   
�������$��Center=�6�   $��Center=�6�   �� 5%   
   $��1��6   $��0��6$   $��3��64   $��20q�6H   .��5&      �� -   5         ��Name$ CommunityGames��5&       �� SelectedItem 6.   ��  �� Path$ SelectedCommunityGame� �� Mode$ OneWayToSource=���5'      �� 5(      .R�5)      ]� .+�5*      �� $��Right=�6)   $��5q�6@   .+�5+   "   �� $
��Wrap=�6,   ��6@   �� $ GameName��� 5,   "   ��6,   �� $ GameReleaseDate��� 5-   "   ��6,   �� $ AchievementsCount�5.      5/      50      52      53      �� 55   
   -   5        	 ��Name$	 SupprimerJeu��55      $��	Supprimer��6'   $��8��6;   $��1��6H   $��20q�6X   �� 57   
   
 �� Orientation$
 
Horizontal=�6   $��0��6.   $��4��6;   $��3��6K   $��Right=�6_   $��0 0 20 0q�6{   .+�58      �� $��Jeux sur STEAM : ��6   $��15(�62   
�������$��Center=�6S   $��Center=�6p   �� 59      -   5         ��Name$ 	SearchBox��59      $	��200��6)   $��0 0 20 0q�65   �� 5:      -   5        $	 Search��5:      $��Chercher��6%   5;      �� 5=   
   $��1��6   $��4��6$   $��3��64   $��20q�6H   .��5>      �� -   5        $ 
SteamGames��5>       6*   �� $ SelectedSteamGame�$ OneWayToSource=���5?      �� 5@      .R�5A      ]� .+�5B      �� $��Right=�6)   $��5q�6@   .+�5C   "   �� $
 
Horizontal=�6-   .+�5D   &   �� ��60   �� $ 	GameAppId��� 5E   &   $	�� - ��60   �� 5F   &   $
��Wrap=�60   ��6D   �� $ GameName�5G   #   5H      5I      5J      5L      5M      �� 5O   
   -   5        $	 
AjouterJeu��5O      $��Ajouter��6%   $��20(�67   $��8��6E   $��5��6R   $��20q�6b   �� 5Q   
   
���  ��$��7��6E   $��2��6R   $��3��6b   $��20q�6v   $
��Wrap=�6�   ��6   �� *WarningMessage+6�   5S      5T      