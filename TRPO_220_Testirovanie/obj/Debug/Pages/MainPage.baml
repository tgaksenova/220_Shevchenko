   M S B A M L   `   `   `  ����P  LTRPO_220_Testirovanie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TRPO_220_TestirovanieTRPO_220_Testirovanie  5      $    TRPO_220_Testirovanie.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:TRPO_220_Testirovanie     5        N� Title$  MainPage��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   � $��0��6   .+�5      �� $��1��6   .+�5      �� -   5         ��Name$ Search��5   <   $��Center=�6L   $��50��6n   $��
30,20,30,0q�6z   �� 5      -   5         ��Name$ Testbut��5      $��50��6*   $��
Тесты��66   $��
30,20,30,0q�6Z   �� 5      -   5        $ Questbut��5      $��50��6+   $��Вопросы��67   $��
30,20,30,0q�6a   �� 5      -   5        $ Studbut��5      $��50��6*   $��Студенты��66   $��
30,20,30,0q�6`   �� 5      -   5        $ Addbut��5      $��50��6)   $'��!Добавить студента��65   $��
30,70,30,0q�6c   5      5       � 5    
   -   5          �Name$ dbFrame��5       $��1��6!   $
��auto��61     � NavigationUIVisibility$ Hidden=�6?   5!      5"      