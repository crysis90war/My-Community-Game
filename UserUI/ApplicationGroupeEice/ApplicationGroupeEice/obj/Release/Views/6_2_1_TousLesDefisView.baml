   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  2    ,ApplicationGroupeEice.Views.TousLesDefisView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $��Cambria)�
�������$	��582��$
��1029��  � 	Resources   �� MergedDictionaries �� Source��  �� $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?��� $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�%    .���  � RowDefinitions �� $
��auto ��� $��* � � ColumnDefinitions �� $��* ��� $��4* ��� $��* �.+�]� $��0��$��1��.+��  �� $
��auto ��� $��* �.+��� -    ��Name$ label��$��0��$"��Les défis de la communauté��$��25(�$
��Bold"�$��10q��� -    ��Name$ 	UserGames��$��1��$��Stretch=�$��10q� �� SelectedItem �� *SelectedGame+���� .R�]� .+��� $
��Left=�$��40��$��Center=�$��5q�����  �� Path$ GameImageUrl��� $��Right=�$��5q�.+��� $
��Wrap=����� $ GameName��� ���� $ GameReleaseDate��� ���� $ AchievementsCount��� ���� $  NumberAchievementsAchieved��� $��1��$��1��$��10q�.���� -   	 ��Name$	 SelectedGame_GameDefis��$��0q�
������  �� *SelectedDefi+
 �� Mode$
 TwoWay=����� .R��� $��0 10 0 0q�.+��  �� $
��auto ��� $
��auto �.+�]� $��5q�$��1��.+��� .+��� $��0 0 0 10q�
�������$��Cambria)�$��14(�$
��Bold"����� $ DefiDisplayName��� $
��Wrap=�
�������$��Cambria)�$��12(�$
��Bold"����� $ DefiDescription��� 
�������$��Cambria)�$��14(�$
��Bold"�$��	100 0 0 0q����� $ ScoreToString�