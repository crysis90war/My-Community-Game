   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  0    *ApplicationGroupeEice.Views.CreerDefisView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     
�������$��20(�$��Cambria)�$
��Bold"�$	��582��$
��1201��.���   � RowDefinitions  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��$��0��$��20 10q�.+��� $ ��Choix du jeu pour le défi���� -    ��Name$ 	UserGames��$��0 10 0 0q� �� SelectedItem ��  �� Path$ SelectedGame� �� Mode$ TwoWay=����� .R��� ���� *
GameName+�� $��1��$��0��$��20 10q�.+��� $��Score du défi���� -   $��ChallengeScore��$��0 10 0 0q� �� $ SelectedChallengeScore�$ TwoWay=����� .R��� ���� *ScoreToString+�� $��2��$��0��$��20 10q�.+��� $��Nom du défi���� -    ��Name$ ChallengeName��
������ $��0 10 0 0q��� $��3��$��0��$��20 10q�.+��� $��Nom d'affichage du défi���� -   $ ChallengeDisplayName��
������ $��0 10 0 0q��� $��4��$��0��$��20 10q�.+��� $��Description (facultatif)���� -   $ ChallengeDescription��
�������
������  �� TextWrapping$
 Wrap=�$��0 10 0 0q�$��60���� $��0��$��1��$��5��$��20 10q��� $��5��$��0��$��2��$��Center=�
��� ������� *WarningMessage+�� -    ��Name$ boutonCreerDefi��$��6��$��0��$��2��$��20q�$��Créer le défi��
�������$��cambria)�$��30(�
������ 