   M S B A M L   `   `   `  ����X  TAdministrateurApplicationEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:AdministrateurApplicationEice.Views#AdministrateurApplicationEice.Views  5      2    ,AdministrateurApplicationEice.Views.DefiView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:AdministrateurApplicationEice.Views     5      $	��605��5   8   $
��1002��6E   .��5	      �   � RowDefinitions  5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6!   $��Nouveaux defis��61   $��25(�6G   $��Center=�6U   
�������   28DaysLater#��[  6�   �� 5   
   $��1��6   $��3��6!   $��Defis approuves��61   $��25(�6H   $��Center=�6V   
�������#��[  6�   �� 5    
   $��2��6   $��1��6$   $��5q�64   .��5!      �� -   5         ��Name$ CommunityDefis��5!   0   
������ ��5"      �� 5#      .R�5$      �� $��5q�6%   .+�5%      ��  �� Orientation$ 
Horizontal=�6)   .+�5&   "   �� $��Created date : ��6,   $��cambria)�6C   
�������$��16(�6k   �� 5'   "   $��cambria)�6M   
�������$��16(�6u   ��6,   �� *DefiCreatedDate+6u   5(      �� 5)      $ 
Horizontal=�6)   .+�5*   "   �� $��cambria)�6F   
�������$��16(�6n   ��6,   �� *
DefiName+6n   �� 5+   "   $	�� - ��6,   $��cambria)�67   
�������$��16(�6_   �� 5,   "   $��cambria)�6M   
�������$��16(�6u   ��6,   �� *DefiDisplayName+6u   5-      �� 5.      $��cambria)�6I   
�������$��16(�6q   ��6(   �� *DefiDescription+6q   5/      50      52      53      �� 55   
   $��2��6   $��3��6$   $��5q�64   .��56      �� -   5        $ CommunityApprovedDefi��56   0   
������ ��57      �� 58      .R�59      �� $��5q�6%   .+�5:      �� $ 
Horizontal=�6)   .+�5;   "   �� $��Created date : ��6,   $��cambria)�6C   
�������$��16(�6k   �� 5<   "   $��cambria)�6M   
�������$��16(�6u   ��6,   �� *DefiCreatedDate+6u   5=      �� 5>      $ 
Horizontal=�6)   .+�5?   "   �� $��cambria)�6F   
�������$��16(�6n   ��6,   �� *
DefiName+6n   �� 5@   "   $	�� - ��6,   $��cambria)�67   
�������$��16(�6_   �� 5A   "   $��cambria)�6M   
�������$��16(�6u   ��6,   �� *DefiDisplayName+6u   5B      �� 5C      $��cambria)�6I   
�������$��16(�6q   ��6(   �� *DefiDescription+6q   5D      5E      5G      5H      ]� 5L   
   $��3��6   $��1��6!   .+�5M      �  5N      �� 5O      $��* �6'   �� 5P      $��* �6'   .+�5S      �� -   5         ��Name$ boutonApprouver��5S   )   $��0��6   $��5q�6B     boutonGlobal#��[ 6M   .��5T      �� $ 
Horizontal=�6!   .+�5U      �� $@��:/AdministrateurApplicationEice;component/Image/checked.png��6    $
��Fill=�6d   $��30��6s   $��30��6   $��0 0 10 0q�6�   �� 5V      $��	Approuver��6$   $��Center=�65   5W      5X      �� 5Y      -   5        $ boutonRefuser��5Y   )   $��1��6   $��5q�6@   #��[ 6K   .��5Z      �� $ 
Horizontal=�6!   .+�5[      �� $?��9/AdministrateurApplicationEice;component/Image/remove.png��6    $
��Fill=�6c   $��30��6r   $��30��6~   $��0 0 10 0q�6�   �� 5\      $��Refuser��6$   $��Center=�63   5]      5^      5_      5`      ]� 5b   
   $��3��6   $��3��6"   .+�5c      �  5d      �� 5e      $��* �6'   �� 5f      $��* �6'   .+�5i      �� -   5        $ boutonSupprimer��5i   )   $��1��6   $��5q�6B   #��[ 6M   ��5j      �� 5k      $ 
Horizontal=�6%   .+�5l      �� $?��9/AdministrateurApplicationEice;component/Image/remove.png��6$   $
��Fill=�6g   $��30��6v   $��30��6�   $��0 0 10 0q�6�   �� 5m      $��	Supprimer��6(   $��Center=�69   5n      5p      5q      5r      5t      5u      