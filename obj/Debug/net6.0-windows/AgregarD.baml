   M S B A M L   `   `   `  ����@  <PRecu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PRecuPRecu  5   	       PRecu.AgregarD   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PRecu     5   	     � Title$  AgregarV��5   	   $	��570��6   $	��660��6'    � WindowStartupLocation$ CenterScreen=�63   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #3E50B4��6    � Offset$ 0Q�6+   � 5      $ #8B5CF6��6   $ 1Q�6+   5       � 	Resources 5         
LabelStyle �� 
TargetType �� Property	 �� Value  TextBoxStyle  ButtonStyle
 �� Triggers P� Property P� Value��%�  &	        &	 �     &	 0    �� 5   
   " ��6#   .�5      ��  � ��
	 �����6+   �� 5       � ��$	 16(�6)   �� 5       � ��$	 Arial)�6+   �� 5       � ��$		 0,5q�6'   5      �� 5   
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
   �� 5:      $	��410 �6   6-   �� 5;      6!   .+�5>   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid_vehiculo��5>   F      AutoGenerateColumns$ False��6      CanUserAddRows$ False��6/   
������ ��6z   ��  �� Path$ LoadDataBinding�   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Matrícula��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6[      
IsReadOnly$
 True��6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ 	matricula�6f     5A      $ Modelo��6E   $ 80 6U   $
 True��6`    6%   �� $ modelo�6`     5B      $ Marca��6D   $	 120 6S   $
 True��6_    6%   �� $ marca�6_     5C      $ 
ID Cliente��6Q   $ 90 6e   $
 True��6p    6%   �� $ CLIENTE_ID_cliente�6p   5E      �� 5G   
   $��1��6   $��10q�6%   .+�5H      �� $��Center=�6   $��20(�61   $��5q�6?   $��Arial)�6J   
�������$
��Bold"�6p   .��6�   Registrar Vehículo6�   �� 5J      $��2q�6   $��16(�6   $��Arial Black)�6-   
�������.��6Y   	Matricula6d   �� 5K      -   5         ��Name$ txtMatricula��5K      $��32��6,   #��[ 68   �� 5M      $��2q�6   $��16(�6   $��Arial Black)�6-   
�������.��6Y   Modelo6a   �� 5N      -   5        $ 	txtModelo��5N      $��32��6)   #��[ 65   �� 5P      $��5q�6   $��Arial Black)�6   $��16(�68   
�������.��6Y   Marca6`   �� 5Q      -   5        $ txtMarca��5Q      $��32��6(   #��[ 64   �� 5S      $��2q�6   $��Arial Black)�6   $��16(�68   
�������.��6Y   
ID Cliente6e   �� 5T      -   5        $ txtClienteID��5T      $��32��6,   #��[ 68   �� 5V      -   5         ��Name$ BAgregar��5V      $��50,10q�6'   #��[ 66   $��Agregar��6r   �� 5W      -   5        $ BEditar��5W      $��50,10q�6&   #��[ 65   $��Editar��6p   �� 5X      -   5        $ 	BEliminar��5X      $��50,10q�6(   #��[ 67   $��Eliminar��6t   �� 5Y      -	   5        $ BRegreso��5Y      $��50,10q�6'   #��[ 66   $��Regresar��6s   5Z      5[      5\      