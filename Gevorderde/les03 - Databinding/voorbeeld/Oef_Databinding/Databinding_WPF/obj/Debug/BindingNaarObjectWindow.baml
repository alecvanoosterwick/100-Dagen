   M S B A M L   `   `   `  ����J  FDatabinding_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Databinding_WPFDatabinding_WPF  5   	   -    'Databinding_WPF.BindingNaarObjectWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Databinding_WPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Databinding��5   	   $	��450��6   $	��800��6*   .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��0.2* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5    
   �� -   5         ��Name$ 
txtOrderID��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ OrderID��5!       % !MaterialDesignFloatingHintTextBox#��[ 5"      $��0��5#      $��0��6!   $��3��61   $��	5, 5,5,30q�6E   ��5    &   �� *	OrderID+ �� ValidatesOnDataErrors . 5#   E   �� 5&   
   -   5        	 ��Name$	 	btnZoeken��5&      $��Zoeken��6$   $��0��65   $��3��6B   $��5q�6R   6]   &   System.Windows.Controls.DataGrid  5(   
   -   5        
  Name$
 datagridOrderlijnen��5(         AutoGenerateColumns .  $��1��6L   $��0��6Y   $��3��5,      $��5q�6'   ��5)      �� *Orderlijnen+ .  �� SelectedItem 5*      �� *SelectedOrderlijn+ .    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ OrderID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	OrderID+6T     5/      $ Hoeveelheid��6E    6%   �� *Hoeveelheid+6\     50      $ Product��6F    6%   �� *Product.Naam+6Y   53      �� 54   
   -   5        $	 btnVerwijderen��54      $��Verwijderen��6)   $��1��6?   $��3��6L   $��5q�6\   $	��Top=�55   .   �� 58   
   -   5        $ txtHoeveelheid��58      $ Hoeveelheid��5:      #��[ 5;      $��2��5<      $��0��6   $��5,5,5,20q�6/   ��59      �� *OrderlijnRecord.Hoeveelheid+ . 5<   /   �� 5=   
   -   5         ��Name$ cmbProducten��5=       �� SelectedValuePath$ Nummer��5@      $ Product��5A       �� 
IsEditable . $��2��5B      $��1��6    $��5q�60   ��5>      �� *	Producten+ .  �� SelectedValue 5?      �� *OrderlijnRecord.Productnummer+ . {�5A   N   �� *ComboboxEnabled+5B   0   �� 5C   
   -   5        $	 btnToevoegen��5C      $��	Toevoegen��6'   $��2��6;   $��2��6H   $��5q�6X   6c   �� 5D   
   -	   5        $	 btnAanpassen��5D      $��	Aanpassen��6'   $��2��6;   $��3��6H   $��5q�6X   6c   �� 5E   
   -
   5        $	 btnAnnuleren��5E      $��	Annuleren��6'   $��3��6;   $��0��6H   $��4��6X   $��5q�6l   6w   �� 5G   
   $��0��60   $��3��6@   $��4��6T   $��5q�6a   
���  ����6   �� *Foutmelding+6l   5I      5J      