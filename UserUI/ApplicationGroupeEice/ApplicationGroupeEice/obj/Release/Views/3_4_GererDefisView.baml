   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  0    *ApplicationGroupeEice.Views.GererDefisView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $	��580��$
��1201��  � 	Resources   �� MergedDictionaries �� Source��  �� $? 9/ApplicationGroupeEice;component/Styles/ScrollViewer.xaml?��� $9 3/ApplicationGroupeEice;component/Styles/Button.xaml?�%    .���  � RowDefinitions �� $��20 ��� $
��auto ��� $��4* ��� $��* ��� $��20 � � ColumnDefinitions �� $��20 ��� $��* ��� $��2* ��� $��20 �.+��� -    ��Name$ 	UserGames��$��1��$��1��$��2��$��150 10 150 10q� �� SelectedItem �� *SelectedGame+���� .R�]� .+��� $
��Left=�$��40��$��Center=�$��5q�����  �� Path$ GameImageUrl��� $��Right=�$��5q�.+��� $
��Wrap=����� $ GameName��� ���� $ GameReleaseDate��� ���� $ AchievementsCount��� ���� $  NumberAchievementsAchieved��� $��2��$��1��$��2��$��150 10 150 10q�.���� -    ��Name$ SelectedGame_GameDefis�� �� $ SelectedGame�	 �� Mode$	 OneWayToSource=����� .R�]� $��5q�$��1��.+��� .+��� $��0 0 0 10q�
���   �$��Cambria)�$��14(�$
��Bold"����� $ DefiDisplayName��� $
��Wrap=�
���   �$��Cambria)�$��12(�$
��Bold"����� $ DefiDescription��� 
���   �$��Cambria)�$��14(�$
��Bold"�$��	100 0 0 0q����� $ ScoreToString��� -   
 ��Name$
 
UpdateDefi��$��3��$��1��$��150 10 0 10q�$��Marquer réussi���� $��WarningMessage��$��3��$��2��$��Center=�$��Center=�$��20(�