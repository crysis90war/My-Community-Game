   M S B A M L   `   `   `  ����X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  5   	   8    2AdministrateurApplicationEice.Views.MainWindowView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:AdministrateurApplicationEice.Views     5   	   $	��700��5      $
��1201��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $A ;/AdministrateurApplicationEice;component/Styles/Button.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� ImageSource$B </AdministrateurApplicationEice;component/Image/FondAppli.jpg��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5"   
   �� $��0��6   $��0��6"   $��2��62   	 J� Opacity$		 0.9Q�6F   ���	#FF1E4753
 �� Orientation$
 
Horizontal=�6k   $��RightToLeft=�6�   .+�5#      �� -   5        $��	Fermeture��5#      $��X��6&      
mainBouton#��[  62   �� 5$      -   5        $��Deconnexion��5$      $��Déconnexion��6(   #��[  6>   5%      �� 5'   
   $		 0.9Q�6   ���	#FF94B7BF$��1��6:   $��0��6G   $��2��6W   .+�5(      �� $��	230 0 0 5q�6   $
 
Horizontal=�6,   .+�5)      �� $5��/Nombre total d'utilisateurs de l'application : ��6   $��cambria)�6S   $
��Bold"�6h   
�������$	��300��6�   �� 5*      $��cambria)�6@   $
��Bold"�6U   
���������6   ��  �� Path$ NumberOfUsers�6g   5+      �� 5,      $��	230 0 0 0q�6   $
 
Horizontal=�6,   .+�5-      �� $/��)Nombre total d'utilisateurs connectés : ��6   $��cambria)�6L   $
��Bold"�6a   
�������$	��300��6�   �� 5.      $��cambria)�6F   $
��Bold"�6[   
���������6   �� $ NumberOfUsersOnline�6m   5/      �� 50      $��	230 5 0 0q�6   $
 
Horizontal=�6,   .+�51      �� $%��Nombre total de jeux vidéos : ��6   $��cambria)�6B   $
��Bold"�6W   
�������$	��300��6}   �� 52      $��cambria)�6@   $
��Bold"�6U   
���������6   �� $ NumberOfGames�6g   53      54      �� 56   
   $��2��6   $��0��6"   .+�57      o� $��Stretch=�6   $��Stretch=�68   $	��605��6[   ���	#FF1E4753 58        MenuItemStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� 59      %�  &	       �� 5:      " m�66   .�5;      ��  � ��
 ���� 6<   �� 5<       � ��$ 0q�6@   �� 5=       �@�Cursor$
 Hand��67   �� 5>       � ��$
 Bold"�6;   �� 5?       � ��
 �����6;   �� 5@       � ��$ 20(�69   �� 5A       � ��$ cambria)�6;   �� 5B       �@J�Opacity$	 0.9Q�68   �� 5C       � �� �	#FF1E47536;   �� 5D       � ��$ 10 20q�67    5E      P� 5F   "    �@m�IsHighlighted . . �5G   &   ��  �@J�Opacity$	 0.5Q�6@   5H   #   P� 5I   "    �@J�	IsFocused . . �5J   &   ��  �@J�Opacity$	 0.3Q�6@   5K   #   P� 5L   "    �@J�IsMouseOver . . �5M   &   ��  � ��$ 0q�6H   5N   #   5P      5Q      .@�5T      m� -   5         m�Name$ MI_Utilisateurs��5T      #��[ 64   ��5U      �� 5V      $��Utilisateurs��6$    m� Icon 5X      �� 5Y      $H��B/AdministrateurApplicationEice;component/Image/IconUtilisateur.png��6    $
��Fill=�6l   $��15��6{   5[      m� 5]      -   5        $ 	MI_Events��5]      #��[ 6.   ��5^      �� 5_      $��Événements��6$    5a      �� 5b      $C��=/AdministrateurApplicationEice;component/Image/IconEvents.png��6    $
��Fill=�6g   $��15��6v   5d      m� 5f      -   5        $ MI_VideoGame��5f      #��[ 61   ��5g      �� 5h      $��Jeux vidéos��6$    5j      �� 5k      $@��:/AdministrateurApplicationEice;component/Image/IconJeu.png��6    $
��Fill=�6d   $��15��6s   5m      m� 5o      -   5        $ MI_BoardGame��5o      #��[ 61   ��5p      �� 5q      $
��Wrap=�6$   $��Jeux de sociétés��68    5s      �� 5t      $L��F/AdministrateurApplicationEice;component/Image/IconJeuDeSociétés.png��6    $
��Fill=�6n   $��15��6}   5v      m� 5x      -   5        $ MI_Defis��5x      #��[ 6-   ��5y      �� 5z      $
��Wrap=�6$   $��Défis��68    5|      �� 5}      $C��=/AdministrateurApplicationEice;component/Image/LogoDéfis.png��6    $
��Fill=�6f   $��15��6u   5      ��5�      �� 5�      .R�5�      $�  $� Orientation$ Vertical=�61   5�      5�      5�      �� 5�   
   -   5        $��
ActiveItem��5�      $��2��6+   $��1��68   $��Stretch=�6H   $��Stretch=�6f   5�      5�      