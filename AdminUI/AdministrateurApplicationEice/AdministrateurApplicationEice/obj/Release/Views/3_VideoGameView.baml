   M S B A M L   `   `   `  ���� X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  7    1AdministrateurApplicationEice.Views.VideoGameView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Clocal1clr-namespace:AdministrateurApplicationEice.Views       � 	Resources   �� MergedDictionaries �� Source��  �� $G A/AdministrateurApplicationEice;component/Styles/ScrollViewer.xaml?��� $A ;/AdministrateurApplicationEice;component/Styles/Button.xaml?�%    .���  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto � � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Jeux de communauté��$��0��$��0��$��3��$��20(�
�������$��Center=�$��Center=��� $��1��$��0��$��3��$��20q�.���� -    ��Name$ CommunityGames�� �� SelectedItem ��  �� Path$ SelectedCommunityGame� �� Mode$ OneWayToSource=����� .R�]� .+��� $��Right=�$��5q�.+��� $
��Wrap=����� $ GameName��� ���� $ GameReleaseDate��� ���� $ AchievementsCount��� -   	 ��Name$	 SupprimerJeu��$��	Supprimer��$��8��$��1��$��20q��� 
 �� Orientation$
 
Horizontal=�$��0��$��4��$��3��$��Right=�$��0 0 20 0q�.+��� $��Jeux sur STEAM : ��$��15(�
�������$��Center=�$��Center=��� -    ��Name$ 	SearchBox��$	��200��$��0 0 20 0q��� -   $	 Search��$��Chercher���� $��1��$��4��$��3��$��20q�.���� -   $ 
SteamGames�� �� $ SelectedSteamGame�$ OneWayToSource=����� .R�]� .+��� $��Right=�$��5q�.+��� $
 
Horizontal=�.+��� ���� $ 	GameAppId��� $	�� - ���� $
��Wrap=����� $ GameName��� -   $	 
AjouterJeu��$��Ajouter��$��20(�$��8��$��5��$��20q��� 
���  ��$��7��$��2��$��3��$��20q�$
��Wrap=����� *WarningMessage+