   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      4    .ApplicationGroupeEice.Views.CreerEvenementView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $��20(�5      $��Cambria)�6-   
�������.��5
      �� $��3q�6   
�������._�5   
   �   � RowDefinitions  5      �� 5      $��20 �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��20 �6#   .+�5      �� $��1��6   $��1��6&   $��10q�66   .+�5      �� $��Nom de l'évènement��6   $
��Bold"�66   �� 5      -   5         ��Name$ NomEvenement��5      
������ 60   5      �� 5!      $��2��6   $��1��6&   $��10q�66   .+�5"      �� $%��Choix du jeu pour l'évènement��6   $
��Bold"�6A   �� 5#      -   5        $��ListeJeu��5#      
������ ��6+   �� *Jeu+6G   5$      �� 5&      $��3��6   $��1��6&   $��10q�66   .+�5'      �� $��Description (Facultatif)��6   $
��Bold"�6<   �� 5(      -   5        $ TexteDescription��5(      
�������
������ 6P   5)      �� 5+      $��1��6   $��2��6&   $��2��66   $��10q�6G   .+�5,      ��  �� Orientation$ 
Horizontal=�6   .+�5-      �� $!��Personne(s) à invité(é)s��6   
�������$
��Bold"�6R   �� 5.      -   5         ��Name$ 	ListeAmis��5.      $��Afficher Ami(e)s��60   $��0q�6K   
�������
������ 6r   5/      �� 50      -   5         ��Name$ PersonnesAInviter��50      51      �� 53      $��3��6   $��2��6&   $��10q�66   .+�54      �� $��Date de l'évènement��6   $
��Bold"�67   (  "System.Windows.Controls.DatePicker  55      -   5        $��DateEvenement��55      $��0q�62   56      �� 58      -   5        $ ConfirmerChoix��58      $��4��6-   $��1��6:   $��10q�6J   $��2��6V   
�������$��	Confirmer��6}   $��25(�6�   
������ 6�   59      5:      5;      