   M S B A M L   `   `   `  ���� X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:AdministrateurApplicationEiceAdministrateurApplicationEice  .    (AdministrateurApplicationEice.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =local+clr-namespace:AdministrateurApplicationEice       � Title$  
MainWindow��$	��700��$
��1201�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�.��� ����  �� ImageSource$ Image\FondAppli.jpg��.+��� $	��800��$	��140��$
��Left=�.+�o� $��	0 100 0 0q� J� Opacity$	 0.9Q�$	��800��$
��Bold"�$	��Top=�$
��Left=�
������ $��Cambria)�
�������$��20(�$��0q����	#FF1E4753 � 	Resources    MenuItemStyle �� 
TargetType �� Property	 �� Value
 �� Triggers P� Property P� Value�� %�  &	        �� " m�.���  � ��
	 ���� ��  � ��$	 0q���  � ��$
	 Left=���  � ��$	 10q���  � ��$	 58����  � ��$		 145����  �@�Cursor$
	 Hand����  � ��$	 17(�
 P�  �@m�IsHighlighted . . ���  �@J�Opacity$		 0.5Q�P�  �@J�	IsFocused . . ���  �@J�Opacity$		 0.3Q�P�  �@J�IsMouseOver . . ���  � ��$	 0q�.@�m� -    m�Name$ Users��#��[  $��Bottom=����� $��Utilisateurs��$��	-10 0 0 0q� �� Padding$ 0 5 0 0q�$��30�� m� Icon �� $��Image/IconUtilisateur.png��$��30��$��30��m� -   $ 
JeuxVidéo��#��[  $��Bottom=����� $��Événements��$��	-10 0 0 0q�$ 0 5 0 0q�$��30�� �� $��Image/IconEvents.png��$��30��$��30��m� -   $ 	VideoGame��#��[  $��Bottom=����� $��Jeux vidéos��$��	-10 0 0 0q�$ 0 5 0 0q�$��30�� �� $��Image/IconJeu.png��$��30��$��30��m� -   $ JeuxDeSociété��#��[  $��Bottom=����� $
��Wrap=�$��Jeux de sociétés��$��	-10 0 0 0q�$��80�� �� $#��Image/IconJeuDeSociétés.png��$��30��$��30������ .R�$�  $� Orientation$ Vertical=��� -   $��Contenu��$��0,0,0,0q�$	��800��$
��1061��
������ $��Right=��� $��50��$	��Top=�$��0 30 0 0q�$	 0.9Q����	#FF94B7BF.+��� $5��/Nombre total d'utilisateurs de l'application : ��$��cambria)�$
��Left=�$��	150 0 0 0q�$	��255��$
��bold"�
��������� $/��)Nombre total d'utilisateurs connectés : ��$��cambria)�$��	150 0 0 0q�$
��bold"�
��������� $%��Nombre total de jeux vidéos : ��$��cambria)�
�������$��0 0 0 0q��� $��30��$	��Top=�$	 0.9Q����	#FF1E4753�� -   $��	Fermeture��$��30��$��30��$��X��
�������
������ 
������ $��0q�$��Right=�$	��Top=�$��cambria)�$
��Bold"�$��20(� � Cursor$
 Hand��#��[" ��� -   $��Deconnexion��$��30��$	��110��$��Déconnexion��
�������
������ 
������ $��0q�$��Right=�$	��Top=�$��cambria)�$
��Bold"�$��15(�$��0 0 30 0q�$
 Hand��#��[" �