   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  4    .ApplicationGroupeEice.Views.CreerEvenementView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $��20(�$��Cambria)�
�������.���� $��3q�
�������._��   � RowDefinitions  �� $��20 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��20 � � ColumnDefinitions �� $��20 ��� $��* ��� $��* ��� $��20 �.+��� $��1��$��1��$��10q�.+��� $��Nom de l'évènement��$
��Bold"��� -    ��Name$ NomEvenement��
������ �� $��2��$��1��$��10q�.+��� $%��Choix du jeu pour l'évènement��$
��Bold"��� -   $��ListeJeu��
������ ���� *Jeu+�� $��3��$��1��$��10q�.+��� $��Description (Facultatif)��$
��Bold"��� -   $ TexteDescription��
�������
������ �� $��1��$��2��$��2��$��10q�.+���  �� Orientation$ 
Horizontal=�.+��� $!��Personne(s) à invité(é)s��
�������$
��Bold"��� -    ��Name$ 	ListeAmis��$��Afficher Ami(e)s��$��0q�
�������
������ �� -    ��Name$ PersonnesAInviter���� $��3��$��2��$��10q�.+��� $��Date de l'évènement��$
��Bold"�(  "System.Windows.Controls.DatePicker  -   $��DateEvenement��$��0q��� -   $ ConfirmerChoix��$��4��$��1��$��10q�$��2��
�������$��	Confirmer��$��25(�
������ 