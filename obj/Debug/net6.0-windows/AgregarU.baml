   M S B A M L   `   `   `  ����@  <PRecu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PRecuPRecu  5   	       PRecu.AgregarU   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PRecu     5   	     � Title$  Agregar Mantenimiento��5   	   $	��570��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�6@   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #3E50B4��6    � Offset$ 0Q�6+   � 5      $ #8B5CF6��6   $ 1Q�6+   5       � 	Resources 5         
LabelStyle �� 
TargetType �� Property	 �� Value  TextBoxStyle  ButtonStyle
 �� Triggers P� Property P� Value��%�  &	        &	 �     &	 .    �� 5   
   " ��6#   .�5      ��  � ��
	 �����6+   �� 5       � ��$	 12(�6)   �� 5       � ��$	 Arial)�6+   �� 5       � ��$	 2q�6'   5      �� 5   
   " ��6%   .�5      ��  � ��$	 16(�6)   �� 5       � ��$	 32��6'   �� 5       � ��$		 200��6&   �� 5       � ��$	 Arial)�6+   �� 5       � ��
	 ���� 6+   �� 5       � ��
	 �����6+   �� 5       � ��
	 �����6,   �� 5       � ��$	 0 0 0 1q�60   �� 5        � ��$	 5q�6(   5!      �� 5"   
   " ��6$   .�5#      ��  � ��$	 16(�6)   �� 5$       � ��$
	 Bold"�6+   �� 5%       � ��$	 Arial)�6+   �� 5&       � ��$		 100��6&   �� 5'       � ��$	 28��6'   �� 5(       � ��$
	 0,10q�6'   �� 5)       � ��	 �	#FF032CFF6+   �� 5*       � ��
	 �����6+   �� 5+       � ��$	 1q�60   �� 5,       � ��
	 �����6,   �� 5-       � ��$	 Center=�64   �� 5.       � ��$	 Center=�62   
 5/      P� 50       �@J�IsMouseOver$
 True��61   . �51      ��  � ��
	 �����63   �� 52       � ��	 �	#FF032CFF63   53      55      56      .��58      �  � ColumnDefinitions 59   
   �� 5:      $
��551* �6   �� 5;      $
��240* �6    � RowDefinitions 5=   
   �� 5>      $��* �6   �� 5?      $
��Auto �6   .+�5B   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid_mantenimiento��5B   F      AutoGenerateColumns$ False��6      CanUserAddRows$ False��6/   
������ $��0,0,0,0q�6�   ��6   ��  �� Path$ LoadDataBinding�   Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      -   5        ColumnaIDMantenimiento��,  &System.Windows.Controls.DataGridColumn   Header$ No Mantenimiento��5D   n      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�      
IsReadOnly$
 True��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� $ NoMantenimiento�6�     5E      -   5        ColumnaDescripcion��$ Descripción��5E   f   $ * 6{   $
 True��6�    6A   �� $ descripcion�6�     5F      -   5        ColumnaCosto��$ Costo��5F   Z   $	 100 6i   $
 True��6u    6;   �� $ costo�6u     5G      -   5        ColumnaClienteID��$ 
ID Cliente��5G   k   $	 100 6   $
 True��6�    6?   �� $ CLIENTE_ID_cliente�6�   5I      �� 5J   
   $��Arial Black)�6   $��16(�6*   
�������$��MANTENIMIENTO��6K   $��25,24,24,423q�6c   $��1��6y   �� 5K   
    �� Orientation$ Vertical=�6   $��4,79,10,-59q�6-   $��2��6B   $��1��6S   .+�5M      �� -   5         ��Name$ LabelNoMantenimiento��5M      $��2q�62   $��Arial Black)�6=   $��16(�6V   
�������$��No Mantenimiento��6w   �� 5N      -   5         ��Name$ txtNoMantenimiento��5N      #��[ 62   $	��240��6X   $��32��6d   �� 5P      -   5        $ LabelDescripcion��5P      $��2q�6.   $��Arial Black)�69   $��16(�6R   
�������$��Descripción��6s   �� 5Q      -	   5        $ txtDescripcion��5Q      #��[ 6.   $	��240��6T   $��32��6`   �� 5S      -
   5        $ 
LabelCosto��5S      $��2q�6(   $��Arial Black)�63   $��16(�6L   
�������$��Costo��6m   �� 5T      -   5        $ txtCosto��5T      #��[ 6(   $	��240��6N   $��32��6Z   �� 5V      -   5        $ LabelClienteID��5V      $��2q�6,   $��Arial Black)�67   $��16(�6P   
�������$��
ID Cliente��6q   �� 5W      -   5        $ txtIDCliente��5W      #��[ 6,   $	��240��6R   $��32��6^   �� 5Y      -   5         ��Name$ BAgregar��5Y      $��50,10q�6'   $��16(�66   #��[ 6D   $��Agregar��6�   �� 5Z      -   5        $ BEditar��5Z      $��50,10q�6&   $��16(�65   #��[ 6C   $��Editar��6~   �� 5[      -   5        $ 	BEliminar��5[      $��50,10q�6(   $��16(�67   #��[ 6E   $��Eliminar��6�   �� 5\      -   5        $ BRegreso��5\      $��50,10q�6'   $��16(�66   #��[ 6D   $��Regresar��6�   5]      5^      5_      