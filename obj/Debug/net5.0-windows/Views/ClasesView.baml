   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   B >Kalum21, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Kalum21Kalum21 5   	      Kalum21.Views.ClasesView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   'localclr-namespace:Kalum21     5   	     � Title$  Clases��5	   	   $	��450��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�61   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  $��20q�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         CanUserAddRows$ false��5      $��0��5      $��0��6      AutoGenerateColumns$ false��5       �� SelectedItem 5      �� *Seleccionado+��5      �� *Clases+   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn	   ElementStyle#	 �   5      
   EditingElementStyle#
 �   5      ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionado��5          Binding 5!      ��  �� RelativeSource ��  �� AncestorType DataGridRow �� Path$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5#      $ Descripcion��6E      
IsReadOnly$
 true��6Z    6%   �� *Descripcion+6Z     5$      $ Ciclo��6?   $
 true��6N    6%   �� *Ciclo+6N     5%      $ 
CupoMaximo��6D   $
 true��6X    6%   �� *
CupoMaximo+6X     5&      $ 
CupoMinimo��6D   $
 true��6X    6%   �� *
CupoMinimo+6X   5(      �� 5+   
   $��1��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5,      �� $��Eliminar��6   $��Eliminar��6F   $��10q�6b   ��6(   �� *	Instancia+6b   �� 5.      $��Nuevo��6   $��Nuevo��6C   $��10q�6\   ��6%   �� *	Instancia+6\   �� 50      $��	Modificar��6   $��	Modificar��6G   $��10q�6d   ��6)   �� *	Instancia+6d   51      53      54      