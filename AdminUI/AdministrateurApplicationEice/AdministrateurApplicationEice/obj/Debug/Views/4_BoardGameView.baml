   M S B A M L   `   `   `  ����X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  5      7    1AdministrateurApplicationEice.Views.BoardGameView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AdministrateurApplicationEice.Views     5      
�������$��16(�5   2   $��calibria)�6@   .��5	      �   � RowDefinitions  5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   �� $��1��6   $��1��6!   $��2��61   $,��&Ajouter ou supprimer un jeu de societe��6E      28DaysLater#��[  6s   
�������$��25(�6�   $��Center=�6�   �� 5   
   $��2��6   $��1��6"   $��10q�62   .+�5      �� $��Nouveau jeu de societe��6   #��[  66   
�������$��18(�6s   $��Center=�6�   �� 5       �� Padding$ 20q�6   $
��0 10q�6"    �� CornerRadius$ 10��60   $��2q�6B   ���	#FF1E4753._�5      �� .+�5       �� $��Nom du jeu de societe��6      Montague#��[ 6=   $	��0 5q�6d   �� 5!      -   5         ��Name$ GameName��5!      $	��0 5q�60   �� 5"      $��Description du jeu��6    #��[ 6:   $	��0 5q�6a   �� 5#      -   5        $ GameDescription��5#      $	��150��67    �� TextWrapping$
 Wrap=�6D   $	��0 5q�6X   �� 5$      $%��Image du jeu (url) (Facultatif)��6    #��[ 6G   $	��0 5q�6n   �� 5%      -   5        $ GameImageUrl��5%      $	��0 5q�64   5&      5'      5(      ]� 5*   
   $��2��6   $��2��6!   $��10q�61   .+�5+      �� $	��Top=�6   $��Nos jeux de societe��6-   #��[  6H   
�������$��18(�6�   $��Center=�6�   �� 5,      $��Bottom=�6   $
��0 10q�63   .��5-      �� -   5         ��Name$ CommunityBoardGames��5-      ��5.      �� 5/      .R�50      ]� .+�51   "   �� $
��Left=�6(   $��40��6_   $��Center=�6k   $��5q�6�   ��6>   ��  �� Path$ ImageUrl�6�   �� 52   "   $��Right=�6-   $��5q�6D   .+�53   &   �� $
��Wrap=�60   ��6D   �� $ GameName��� 54   &   ��60   �� $ 
DefisCount�55   #   56      57      59      5:      5;      �� 5=   
   -   5         ��Name$ Ajouter��5=   .   $��3��6   $��1��6   $��5q�6?     boutonGlobal#��[ 6J   .��5>      �� 	 �� Orientation$	 
Horizontal=�6   .+�5?      �� $@��:/AdministrateurApplicationEice;component/Image/checked.png��6   $
��Fill=�6\   $��30��6k   $��30��6w   $��0 0 10 0q�6�   �� 5@      $��Ajouter��6   $��Center=�6+   5A      5B      �� 5D   
   -   5        $ 	Supprimer��5D   .   $��3��6   $��2��6   $��5q�6A   #��[ 6L   .��5E      �� $	 
Horizontal=�6   .+�5F      �� $?��9/AdministrateurApplicationEice;component/Image/remove.png��6   $
��Fill=�6[   $��30��6j   $��30��6v   $��0 0 10 0q�6�   �� 5G      $��	Supprimer��6   $��Center=�6-   5H      5I      5J      5K      