   M S B A M L   `   `   `  ����P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  5      7    1ApplicationGroupeEice.Views.ProfilUtilisateurView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ApplicationGroupeEice.Views     5      $	��580��5   8   $
��1201��6E   .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��0��6   $��1��6"   $��6��62   $��2��6C   $��Stretch=�6W   $��Center=�6u   .+�5       ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� $��60 0 0 0q�6R   $��30��6d   ��6   ��  �� Path$' !UserData.UserStatus.StatusIconUrl�6d   �� 5$      $��50��6N   $��40 0 0 0q�6Z   ��6   �� $# UserData.UserRank.RankIconUrl�6Z   �� 5&      -   5         ��Name$ UserrData_UserPublicName��5&      
�������$��40(�6   $��cambria)�6�   $��20 0 0 0q�6�   $��Center=�6�   ��6>   �� $ UserData.UserPublicName�6�   5)      �� 5+      $	��400��6   $	��380��6!   $��20q�6-   $7��1/ApplicationGroupeEice;component/Image/crysis.png��69    J� Clip 5,      @� 5-       @� Center$ 170,170&�6&    @� RadiusX$	 150Q�67    @� RadiusY$	 170Q�6E   5/      51      �� 54   
   $ 
Horizontal=�6   $��1��6.   $��3��6;   $��3��6K   $��Center=�6_   .+�56      �� $6��0/ApplicationGroupeEice;component/Image/Score.png��6   $
��Fill=�6N   �� 58      $��Score :��6   
�������$��40(�6>   $��Cambria)�6L   $��Center=�6a   $��10q�6~   $��Center=�6�   �� 5:      
�������$��40(�6T   $��cambria)�6b   $��Center=�6w   $��10q�6�   $��Center=�6�   ��6   �� $ UserData.UserScore�6�   5<      �� 5?   
   $��3��6   $��3��6"   $��3��62   $��Stretch=�6C   $��Center=�6a   .+�5A      �� $��	Trophées��6   
�������$��20(�6?   $��Cambria)�6M   $��Center=�6b   $��10q�6   �� 5C      -   5        $��NombreTrophée��5C      
�������$��20(�6p   $��cambria)�6~   $��Center=�6�   $��10q�6�   ��6-   �� $ UserData.NumberOfTrophies�6�   �� 5E      $	��100��6   $	��100��6    $��10q�6-   $U��O/ApplicationGroupeEice;component/Image/iconfinder_advantage_quality_1034364.png��69   $
��Fill=�6�   5G      �� 5J   
   $��3��6   $��4��6"   $��3��62   $��Stretch=�6C   $��Center=�6a   .+�5L      �� $
��Rang��6   
�������$��20(�6;   $��Cambria)�6I   $��Center=�6^   $��10q�6{   �� 5N      -   5        $��
RangJoueur��5N      
�������$��20(�6n   $��cambria)�6|   $��Center=�6�   $��10q�6�   ��6*   �� $  UserData.UserRank.RankName�6�   �� 5P      $	��100��6   $	��100��6    $��10q�6-   $5��//ApplicationGroupeEice;component/Image/Rank.png��69   $
��Fill=�6r   5R      �� 5U   
   $��3��6   $��5��6"   $��3��62   $��Stretch=�6C   $��Center=�6a   .+�5W      �� $��Défis réussis��6   
�������$��20(�6D   $��Cambria)�6R   $��Center=�6g   $��10q�6�   �� 5Y      -   5        $ NombreDéfisRéussis��5Y      $��0��64   
�������$��20(�6P   $��cambria)�6^   $��Center=�6s   $��10q�6�   �� 5[      $	��100��6   $	��100��6    $��10q�6-   $;��5/ApplicationGroupeEice;component/Image/LogoDéfis.png��69   $
��Fill=�6w   5]      5_      5`      