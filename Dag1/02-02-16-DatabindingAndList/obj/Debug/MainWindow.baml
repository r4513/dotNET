   M S B A M L   `   `   `  ����V  R02-02-16-DatabindingAndList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_02_02_16_DatabindingAndList_02_02_16_DatabindingAndList  5   	   -    '_02_02_16_DatabindingAndList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_02_02_16_DatabindingAndList     5   	   -   5          � Title$  
MainWindow��5   	   $	��400��6   $	��525��6)   .��5	      �� $
��Left=�6   $	��370��6,   $��0,0,0,0q�69   $	��Top=�6J    �� Orientation$ Vertical=�6b   .+�5
   
   �� $	��200��6   $ 
Horizontal=�6"   $��10,10,10,10q�6;   $	��495��6P   .+�5      �� -   5         ��Name$ lBoxPersons��5      $	��200��6+   $��10,10,10,10q�67   6L   �� 5      $	��100��6   $ Vertical=�6%   $��10,10,10,10q�6<   .+�5      �� -   5         ��Name$ 	AddButton��5      $	��Add��6,   6:   �� 5      -   5        $ DeleteFirstButton��5      $��Delete First��64   6K   �� 5      -   5        $ DeleteLastButton��5      $��Delete Last��63   6I   5      5      � 5   
   $	��130��6   $	��495��6   $��10,10,10,10q�6(    � ColumnDefinitions 5      �� 5      $	��100 �6#   5      �� 5      $��50 �6#   5      �� 5      $	��350 �6#   5      .+�5      �� -   5         ��Name$ 
FirstLabel��5      $��First name:��6(   $��90��6>   $
��Left=�6I   $��5,5,0,0q�6d   $	��Top=�6u   �� 5      -   5        $ 	LastLabel��5      $��
Last name:��6'   $��90��6<   $
��Left=�6G   $��5,40,0,0q�6b   $	��Top=�6t   �� 5       -   5        $ 	YearLabel��5       $��Year of birth:��6'   $��90��6@   $
��Left=�6K   $��5,75,0,0q�6f   $	��Top=�6x   �� 5!      -	   5         ��Name$ tBoxFirstName��5!      $��2��6-   $
��Left=�6=   $��23��6X   $��5,5,0,0q�6d    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��335��6�   �� 5"      -
   5        $ tBoxLastName��5"      $��2��6,   $
��Left=�6<   $��23��6W   $��5,40,0,0q�6c   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��335��6�   �� 5#      -   5        $ tBoxYear��5#      $��2��6(   $
��Left=�68   $��23��6S   $��5,75,0,0q�6_   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��335��6�   5$      5%      5'      