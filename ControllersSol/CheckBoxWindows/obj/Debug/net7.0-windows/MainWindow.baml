   M S B A M L   `   `   `  ����J  FCheckBoxWindows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CheckBoxWindowsCheckBoxWindows  5   	        CheckBoxWindows.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CheckBoxWindows     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� $��10q�6   .+�5
   
   �� $��CHECKBOX��6   $��	0,20,0,10q�6$   $��18(�67   $
��Bold"�6E   
����+��6W   �� 5   
   -   5         ��Name$ txtMyTextBlock1��5      $��Sin Seleccion aun.��6-   �� 5   
   -   5         ��Name$ chbMyCheckBox��5      $��20q�6*   $��CheckBox de 3 estado��66    d� IsThreeState$
 True��6U   5   W   �� 5   
   $��COMBOBOX��6   $��	0,20,0,10q�6$   $��18(�67   $
��Bold"�6E   
����+��6W   �� 5   
   ��6   ��  �� ElementName$ cmbMyComboBox�� �� Path$ SelectedItem��� 5   
   -   5        $��cmbMyComboBox��5       �� Text$ 	My Cities��6(    �� 
IsEditable$
 True��69    �� 
IsReadOnly$ False��6K   5      5      