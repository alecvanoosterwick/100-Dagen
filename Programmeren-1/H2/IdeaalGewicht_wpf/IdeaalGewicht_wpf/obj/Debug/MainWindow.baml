   M S B A M L   `   `   `  ����L  HIdeaalGewicht_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IdeaalGewicht_wpfIdeaalGewicht_wpf  5   	   "    IdeaalGewicht_wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:IdeaalGewicht_wpf     5   	   -   5          � Title$  
MainWindow��5   	   $	��400��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��75 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   .+�5   
   �� $��Geslacht��6   $��10q�6%   $��0��61   $��2��6>   .��5      �  � Orientation$ 
Horizontal=�6   .+�5      	� -   5        $��rbMan��5   8   $	��Man��6   $��10q�6,   6_   	� 5      -   5         	�Name$ rbVrouw��5   :   $��Vrouw��6   $��10q�6.   6g   5      5      �� 5   
   $��Lengte in cm��6   $��1��6'   $��0��64   $��10q�6D   6R   �� 5   
   $��Polsomtrek in cm��6   $��2��6+   $��0��68   $��10q�6H   6V   �� 5   
   $��Ideale gewicht in kg��6   $��3��6/   $��0��6<   $��10q�6L   6Z   �� 5    
   -   5         ��Name$ 	txtLengte��5       $��1��6%   $��1��62   $��10q�6B   6P   �� 5!   
   -   5        $ 	txtOmtrek��5!      $��2��6%   $��1��62   $��10q�6B   6P   �� 5"   
   -   5        $ 
txtGewicht��5"      $��3��6&   $��1��63   $��10q�6C   6Q   �� 5#   
   -   5         ��Name$ BtnBerekenen��5#      $��	Berekenen��6'   $��1��6;   $��4��6K   $��10q�6X   6�   �� 5$   
   -   5        $ 
BtnSluiten��5$      $��Sluiten��6%   $��1��67   $��5��6G   $��10q�6T   6{   5%      5&      