   M S B A M L   `   `   `  ����P  LTRPO_220_Testirovanie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TRPO_220_TestirovanieTRPO_220_Testirovanie  5      $    TRPO_220_Testirovanie.Add_Edit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:TRPO_220_Testirovanie     5        N� Title$  Add_Edit��5	       N� 
Background
 �����.��5      � .+�5   
   �� $#��Группа студента��6   $��Bottom=�6*   $��Center=�6L   $��Center=�6g   $��50��6�   $	��200��6�   $��0,0,300,250q�6�   �� 5   
   -   5         ��Name$ groupChoise��5       �� Text$# Выберите группу��6(    �� 
IsEditable .  �� 
IsReadOnly .  �� DisplayMemberPath$ GroupNumber��6�    �� SelectedValuePath$ GroupNumber��6�   $��Center=�6�   $��Center=�6�   $��Center=�6   $��50��6"  $	��200��6.  $��0,0,300,150q�6:   �� SelectedItem 6c   �� *GroupNumber+6Q  �� 5   
   $��Имя студнта��6   $��Center=�6&   $��Bottom=�6A   $��Center=�6c   $��50��6�   $	��200��6�   $��
0,0,300,50q�6�   �� 5   
   -   5        	 ��Name$	 	FirstName��5      $��Center=�6%   $��Center=�6@   $��50��6]   $��Center=�6i   $	��200��6�   $��
0,50,300,0q�6�   6�   �� 5   
   $+��%Номер Студенческого��6   $��Center=�6.   $��Bottom=�6I   $��Center=�6k   $��50��6�   $	��200��6�   $��0,150,300,0q�6�   �� 5   
   -   5        $	 StudID��5      $��Center=�6"   $��Center=�6=   $��50��6Z   $��Center=�6f   $	��200��6�   $��0,250,300,0q�6�   6�   �� 5   
   $%��Фамилия студента��6   $��Center=�6+   $��Bottom=�6F   $��Center=�6h   $��50��6�   $	��200��6�   $��300,0,0,250q�6�   �� 5   
   -   5        $	 
SecondName��5      $��Center=�6&   $��Center=�6A   $��50��6^   $��Center=�6j   $	��200��6�   $��300,0,0,150q�6�   6�   �� 5   
   $'��!Отчество студента��6   $��Center=�6,   $��Bottom=�6G   $��Center=�6i   $��50��6�   $	��200��6�   $��
300,0,0,50q�6�   �� 5   
   -   5        $	 
Patronymic��5      $��Center=�6&   $��Center=�6A   $��50��6^   $��Center=�6j   $	��200��6�   $��
300,50,0,0q�6�   6�   �� 5   
   -   5        $��Добавить��5      $��Center=�6$   $��Center=�6Q   $��50��6n   $��Center=�6z   $	��200��6�   $��300,250,0,0q�6�   6�   5      5      