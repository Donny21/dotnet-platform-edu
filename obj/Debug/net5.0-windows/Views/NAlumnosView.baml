   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   fCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5   	   B >Kalum21, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Kalum21Kalum21 5   	       Kalum21.Views.NAlumnosView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5   	   'localclr-namespace:Kalum21     5   	   -   5        $��
FrmAlumnos��5
   `   $	��250��6"   $	��600��6/     � WindowStartupLocation$  CenterScreen=�6;   8   2MahApps.Metro.Controls.Dialogs.DialogParticipation   Register 5   \   ��  � Title 5
   	   �� *Titulo+.��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Carnet��6   $��0��6!   $��0��6.   $��	15,0,15,0q�6>   �� 5   
   $��0��6   $��1��6   $��0,5,20,0q�6/    �� 
IsReadOnly$
 True��6Y   ��6A   �� *Carnet+6Y   �� 5   
   $��
Expediente��6   $��1��6%   $��0��62   $��	15,0,15,0q�6B   �� 5   
   $��1��6   $��1��6   $��0,5,20,0q�6/   $
 True��6_   ��6A   �� *NoExpediente+6_   �� 5   
   $��	Apellidos��6   $��2��6$   $��0��61   $��	15,0,15,0q�6A   �� 5    
   $��2��6   $��1��6   $��0,5,20,0q�6/   ��6A   �� *	Apellidos+�� 5"   
   $��Nombres��6   $��3��6"   $��0��6/   $��	15,0,15,0q�6?   �� 5#   
   $��3��6   $��1��6   $��0,5,20,0q�6/   ��6A   �� *	Nombres+�� 5%   
   $��Email��6   $��4��6    $��0��6-   $��	15,0,15,0q�6=   �� 5&   
   $��4��6   $��1��6   $��0,5,20,0q�6/   ��6A   �� *Email+�� 5)   
   $��5��6   $��2��6"   $��10,20,10,20q�66    �� Orientation$ 
Horizontal=�6K   .+�5*      �� $��Guardar��6   $��Guardar��6E   ��6'   �� *	Instancia+6E   5+      5,      5-      