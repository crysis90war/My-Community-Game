   M S B A M L   `   `   `  ���� X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  8    2AdministrateurApplicationEice.Views.MainWindowView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:AdministrateurApplicationEice.Views     $	��700��$
��1201��  � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources  �� MergedDictionaries �� Source��  �� $A ;/AdministrateurApplicationEice;component/Styles/Button.xaml?�%    .��� ����  �� ImageSource$B </AdministrateurApplicationEice;component/Image/FondAppli.jpg�� � RowDefinitions �� $
��auto ��� $
��auto ��� $��* � � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��0��$��0��$��2��	 J� Opacity$		 0.9Q����	#FF1E4753
 �� Orientation$
 
Horizontal=�$��RightToLeft=�.+��� -   $��	Fermeture��$��X��   
mainBouton#��[  �� -   $��Deconnexion��$��Déconnexion��#��[  �� $		 0.9Q����	#FF94B7BF$��1��$��0��$��2��.+��� $��	230 0 0 5q�$
 
Horizontal=�.+��� $5��/Nombre total d'utilisateurs de l'application : ��$��cambria)�$
��Bold"�
�������$	��300���� $��cambria)�$
��Bold"�
�����������  �� Path$ NombreUtilisateurs��� $��	230 0 0 0q�$
 
Horizontal=�.+��� $/��)Nombre total d'utilisateurs connectés : ��$��cambria)�$
��Bold"�
�������$	��300���� $��cambria)�$
��Bold"�
����������� $ NombreUtilisateursEnLigne��� $��	230 5 0 0q�$
 
Horizontal=�.+��� $%��Nombre total de jeux vidéos : ��$��cambria)�$
��Bold"�
�������$	��300���� $��cambria)�$
��Bold"�
����������� $ 
NombreJeux��� $��2��$��0��.+�o� $��Stretch=�$��Stretch=�$	��605�����	#FF1E4753   MenuItemStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� %�  &	       �� " m�.���  � ��
 ���� ��  � ��$ 0q���  �@�Cursor$
 Hand����  � ��$
 Bold"���  � ��
 �������  � ��$ 20(���  � ��$ cambria)���  �@J�Opacity$	 0.9Q���  � �� �	#FF1E4753��  � ��$ 10 20q� P�  �@m�IsHighlighted . . ���  �@J�Opacity$	 0.5Q�P�  �@J�	IsFocused . . ���  �@J�Opacity$	 0.3Q�P�  �@J�IsMouseOver . . ���  � ��$ 0q�.@�m� -    m�Name$ MI_Utilisateurs��#��[ ���� $��Utilisateurs�� m� Icon �� $H��B/AdministrateurApplicationEice;component/Image/IconUtilisateur.png��$
��Fill=�$��15��m� -   $ 	MI_Events��#��[ ���� $��Événements�� �� $C��=/AdministrateurApplicationEice;component/Image/IconEvents.png��$
��Fill=�$��15��m� -   $ MI_VideoGame��#��[ ���� $��Jeux vidéos�� �� $@��:/AdministrateurApplicationEice;component/Image/IconJeu.png��$
��Fill=�$��15��m� -   $ MI_BoardGame��#��[ ���� $
��Wrap=�$��Jeux de sociétés�� �� $L��F/AdministrateurApplicationEice;component/Image/IconJeuDeSociétés.png��$
��Fill=�$��15��m� -   $ MI_Defis��#��[ ���� $
��Wrap=�$��Défis�� �� $C��=/AdministrateurApplicationEice;component/Image/LogoDéfis.png��$
��Fill=�$��15������ .R�$�  $� Orientation$ Vertical=��� -   $��
ActiveItem��$��2��$��1��$��Stretch=�$��Stretch=�