   M S B A M L   `   `   `  ����J  FDatabinding_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Databinding_WPFDatabinding_WPF  5   	   1    +Databinding_WPF.BindingNaarCollectionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Databinding_WPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Binding naar Collection��5   	   $	��450��6)   $	��800��66   .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��0.2* �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� -   5         ��Name$ 
txtOrderID��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ OrderID��5"       % !MaterialDesignFloatingHintTextBox#��[ 5#      $��0��5$      $��0��6!   $��3��61   $��	5, 5,5,30q�6E   ��5!   &   �� *	OrderID+ �� ValidatesOnDataErrors . 5$   E   �� 5%   
   -   5        	 ��Name$	 	btnZoeken��5%      $��Zoeken��6$   $��0��65   $��3��6B   $��5q�6R   6]   &   System.Windows.Controls.DataGrid  5&   
   -   5        
  Name$
 datagridOrderlijnen��5&         AutoGenerateColumns .  $��1��6L   $��0��6Y      
IsReadOnly . $��3��5*      $��5q�6'    �� SelectedItem 5(      �� *SelectedOrderlijn+��5)      �� *Orderlijnen+   Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ OrderID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	OrderID+6T     5-      $ Hoeveelheid��6E    6%   �� *Hoeveelheid+6\     5.      $ Product��6F    6%   �� *Product.Naam+6Y   50      �� 51   
   -   5        $	 btnVerwijderen��51      $��Verwijderen��6)   $��1��6?   $��3��6L   $��5q�6\   $	��Top=�52      6*   �� 53   
   $��0��60   $��3��6@   $��4��6T   $��5q�6a   
���  ����6   �� *Foutmelding+54      58      59      