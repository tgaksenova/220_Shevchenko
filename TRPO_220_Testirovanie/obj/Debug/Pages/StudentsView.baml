   M S B A M L   `   `   `  ����P  LTRPO_220_Testirovanie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TRPO_220_TestirovanieTRPO_220_Testirovanie  5      (    "TRPO_220_Testirovanie.StudentsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:TRPO_220_Testirovanie     5        N� Title$  StudentsView��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5         ��Name$ Filter��5   �   $��0��6>    �� 
IsEditable . $��18(�6]   $��Center=�6k    �� 
IsReadOnly .  �� Text$' !--Выберите группу--��6�   $
��Left=�6�   $	��200��6�    �� DisplayMemberPath$ GroupNumber��6   �� SelectedValuePath$ GroupNumber��66   �� SelectedItem 6�   �� *GroupNumber+6X  �� 5   
   -   5        	 ��Name$	 ExcelBTN��5      $��0��6:   $��18(�6G   $��Center=�6U   $	��200��6w   $!��Сохранить в Excel��6�   $��Right=�6�   6�   �� 5   
   -   5        
 ��Name$
 students��5      $��1��6%   $��0,0,0,0q�62    �� View 5      �� 5      .P�5      ��  �� CellTemplate 5      �� 5      .R�5   "   �� -   5        .+�5   &   ��  ��Name$ 	studentId��60   $��20(�6D   $
��Bold"�6R   $
��Left=�6d   ��6   �� *	StudentID+ �� StringFormat$0 *Номер студенческого: {0}���� 5   &   $��20(�61   $
��Bold"�6?   $
��Left=�6Q   ��6l   �� *Group.GroupNumber+$( "Группа студента: {0}���� 5   &   $��20(�61   $
��Bold"�6?   $
��Left=�6Q   ��6l   �� *	FirstName+$ Имя: {0}���� 5   &   $��20(�61   $
��Bold"�6?   $
��Left=�6Q   ��6l   �� *
SecondName+$ Фамилия: {0}���� 5   &   $��20(�61   $
��Bold"�6?   $
��Left=�6Q   ��6l   �� *
Patronymic+$ Отчество: {0}���� 5    &   -   5        $��50,0,0,0q�5    B   $
��auto��6T   $	��150��6b   $��Delete��6q   $��20(�6�   $
��Bold"�6�   $
��Left=�6�   6�   5!   #   5"      5$      5%      5'      5(      5)      