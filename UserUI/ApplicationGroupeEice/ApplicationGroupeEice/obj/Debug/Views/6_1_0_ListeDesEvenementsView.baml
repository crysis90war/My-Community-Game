   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      8    2ApplicationGroupeEice.Views.ListeDesEvenementsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $	��625��5   8   $
��1029��6E   .��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6    � Cursor$
 Hand��6   $��Center=�6*   $��Cambria)�6G   
�������$��20(�6o   $
��Bold"�6}   $��0q�6�   
������ ��5      �� 5      .R�5      ]� $��Stretch=�6    5       � 	Resources 5         MenuItemStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value�� 5      %�  &	        �� 5      " m�62   .�5      ��  � ��
 ���� 68   �� 5       � ��
 ���� 68   �� 5       � ��$ 0q�6<    5      P� 5        �@m�IsHighlighted . . �5!   "   ��  � ��
 ��ح�6?   5"      P� 5#       �@J�	IsFocused . . �5$   "   ��  � ��
 ��ح�6?   �� 5%   "    �@J�Opacity$	 0.8Q�6<   5&      5(      5)      .@�5,      m� -   5        	 m�Name$	 MI_VoirTousEvenements��5,      $!��_Voir tous les événements��66   $��20 10q�6Y   $��20 0 0 0q�6i   #��[  6{   m� 5-      -   5        $	 MI_EvenementsDesAmis��5-      $'��!_Événements crées par les amis��65   $��20 10q�6]   #��[  6m   m� 5.      -   5        $	 MI_VoirMesEvenements��5.      $"��_Événements crées par moi��65   $��20 0 0 0q�6X   #��[  6k   5/      �� 51   
   -   5        $��
ActiveItem��51      $��1��6+   $��Stretch=�68   $��Stretch=�6V   53      54      