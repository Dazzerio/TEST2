   M S B A M L   `   `   `  ����D  @framework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:framework	framework  5   	       framework.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:framework     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� -   5         ��Name$ addBtn��5      $��Создать��6%   $
��Left=�67   $��36��6R   $��	26,10,0,0q�6^   $	��Top=�6q   $��94��6�   6�   �� 5      -   5        $ editBtn��5      $ ��Редактировать��6&   $
��Left=�6>   $��36��6Y   $��
138,10,0,0q�6e   $	��Top=�6y   $	��111��6�   6�   �� 5      -   5        $ 	removeBtn��5      $��Удалить��6(   $
��Left=�6:   $��36��6U   $��
269,10,0,0q�6a   $	��Top=�6u   $	��131��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid��5   h   $��Stretch=�6   $��Stretch=�61   $��1��6M   $
��0 20q�6Z      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� 	 �� Path$
	 name�  5      $ 
Текст��6%    64   �� $
	 text�  5      $ 
Автор��6%    64   �� $	 	user.name�5      5       5!      