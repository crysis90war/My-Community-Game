   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  3    -ApplicationGroupeEice.Views.LoginRegisterView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:ApplicationGroupeEice.Views       � Title$  LoginRegisterView��$
��1100��$	��700�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�$��0q� � Icon$S M/ApplicationGroupeEice;component/Image/iconfinder_gamer_titanfall_1536911.ico��.��� ����  �� ImageSource$T N/ApplicationGroupeEice;component/Image/Dark-Souls-warrior-armour-suit-fire.jpg��.+��� -    ��Name$ Fermer�� � Cursor$
 Hand��$��X��
������ $��20(�$��Cambria)�$
��Bold"�
�������$��40��$��40��$��Right=�$	��Top=�$��10q� J� RenderTransformOrigin$ 0.713,0.463&�#��[" ��� $
��auto��	 J� Opacity$		 0.8Q�$
��Left=�
����� �.+��� $��My Community Game��
������ $��Cambria)�
�������$
��Bold"�$��30(�
 �� TextAlignment$
 Center=�$��30 120 30 100q�$��Stretch=�$ 
0.54,0.444&��� $��Login��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&��� -    ��Name$ Login��$��30��$	��300�� �� TextAlignment$ Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��30 10 30 10q�$��Stretch=��� $��Mot de passe��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&�G� -    G�Name$ Password��$��30��$	��300��$��Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��30 10 30 10q�$��Stretch=��� -    ��Name$ ErrorMessage��
������ $��	30 0 30 0q�$
 Center=�$��Stretch=�$ 
0.54,0.444&����� *ErrorMessage+���� *
TheColor+�� -   $ boutonConnexion��$��	Connexion��$
 Hand��$��17(�$
��Bold"�
�������$��Stretch=�$��Cambria)�
�������$		 0.9Q�$��100 30 100 0q��� -   $ 	PasEncore��$��Pas encore de compte ?��$
 Hand��$��12(�$��Cambria)�$
��Bold"�
�������
������ $��100 50 100 0q�$��Stretch=�$ 0.713,0.463&�#��[" ��� -    ��Name$ Inscription��$��0��$
��Left=�
����� �.+��� $��Registration��
������ $��Cambria)�
�������$
��Bold"�$��30 50 30 30q�$��30(�$
 Center=�$��Stretch=�$ 
0.54,0.444&��� $��Login��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&��� -   $ RegisterLogin��$��30��$	��300��$ Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� $��Nom d'affichage��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&��� -	   $ RegisterPublicName��$��30��$	��300��$ Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� $��Email��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&��� -
   $ RegisterEmail��$��30��$	��300��$ Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� $��Confirmer email��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&��� -   $ RegisterEmailConfirm��$��30��$	��300��$ Center=�$��Cambria)�$��20(�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� $��Mot de passe��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&�G� -   $ RegisterPassword��$��30��$	��300��$��Cambria)�$��Center=�$��20(�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� $��Confirmer le mot de passe��
������ $��Cambria)�
�������$
��Bold"�$��20(�$��	30 0 30 0q�$��Stretch=�$ 
0.54,0.444&�G� -   $ RegisterPasswordConfirm��$��30��$	��300��$��Cambria)�$��20(�$��Center=�
�������
�������$		 0.5Q�$��	30 5 30 5q�$��Stretch=��� -   $ MessageRegister��
������ $��	30 0 30 0q�$
 Center=�$��Stretch=�$ 
0.54,0.444&����� *
TheColor+����  �� Path$ MessageRegister�� $��0 30 0 0q� � ColumnDefinitions �� $��* ��� $��* �.+��� -   $ boutonRegister��$��0��$��	30 0 15 0q�$��
S'inscrire��$
 Hand��$��17(�$
��Bold"�
�������$��Cambria)�
�������$		 0.9Q��� -   $ boutonAnnuler��$��1��$��	15 0 30 0q�$��Annuler��$
 Hand��$��17(�$
��Bold"�
�������$��Cambria)�
�������$		 0.9Q�