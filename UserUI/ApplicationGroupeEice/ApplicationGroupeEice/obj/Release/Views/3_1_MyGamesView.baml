   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  -    'ApplicationGroupeEice.Views.MyGamesView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $	��580��$
��1201��  � 	Resources   �� MergedDictionaries �� Source��  �� $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?��� $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�%    .���  � ColumnDefinitions �� $��2* ��� $��3* �.+��� $��0��.+��� $
��Auto=�$��Disabled=�$	��580��.���� -    ��Name$ 	UserGames��
������ $��20q�$��0q� �� SelectedItem ��  �� Path$ SelectedGame� �� Mode$ OneWayToSource=�����  �� 
TargetType" ��.��� 	 �� Property	 � ��
 �� Value$
 Center=����� .R�A�  A� Columns$ 1������ .R��� $	��350��$��Center=�$��Stretch=�$��10q�.+��� ���� $ GameImageUrl��� $��1��$	��580��.���� $��20q�.+��� $��0 0 0 20q�.+��� -    ��Name$ 
LinkButton��$��0��$��0��   OptionButton#��[  .���� .�Actualité jeu�� $��Center=�$��10q�$��1��$��0��$��3��
���  ��$��Cambria)�$��15(�$
��Bold"����� $ ErrorMessage��� .+��  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� -    ��Name$ SelectedGame_GameName��$��0��$
��Wrap=�
�������$��Cambria)�$��25(�$
��Bold"�$��Center=��� $��1��$
��Fill=�$��	0 25 0 25q����� $ SelectedGame.GameImageUrl��� -   $" SelectedGame_GameDescription��$
��Wrap=�$��2��
�������$��Cambria)�$��15(�$��0 0 0 10q�$
��Bold"�$
��Left=��� $��3��.+��  �� $
��auto ��� $��* �.+��� -    ��Name$ SelectedGame_GameGenres��
������ $��1��$��0q����� .R���  �� Orientation$ 
Horizontal=�$
��Left=����� .R��� .+��� 
�������$��Cambria)�$��15(�$��	0 0 10 10q�$
��Bold"����� $ 	GenreName��� $��4��.+��  �� $
��auto ��� $��* �.+��� -   $! SelectedGame_GameDevelopers��
������ $��1��$��0q����� .R��� $ 
Horizontal=�$
��Left=����� .R��� .+��� 
�������$��Cambria)�$��15(�$��	0 0 10 10q�$
��Bold"����� $ DeveloperName��� -   $" SelectedGame_GameReleaseDate��$��5��$��0 0 0 10q�
�������$��Cambria)�$��15(�$
��Bold"�$
��Left=��� .+��� -    ��Name$# SelectedGame_GameAchievements��$��0q�
������ ���� .R��� $��0 10 0 0q�.+��  �� $
��auto ��� $
��auto �.+��� $��0��$��Center=�$��Center=�$��5q����� $ AchievementAchiedorNot��� $��5q�$��1��.+��� $��0 0 0 10q�
�������$��Cambria)�$��14(�$
��Bold"����� $ AchievementDisplayName��� $
��Wrap=�
�������$��Cambria)�$��12(�$
��Bold"����� $ AchievementDescription�