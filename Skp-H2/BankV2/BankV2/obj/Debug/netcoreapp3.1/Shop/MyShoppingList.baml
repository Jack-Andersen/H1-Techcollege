   M S B A M L   `   `   `  ����A  =BankV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BankV2.ShopBankV2.Shop  5           BankV2.Shop.MyShoppingList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:BankV2.Shop     5      .��5	      � .+�5
   
   �� $_��Yc:\users\elder\documents\github\jack_andersen\skp-h2\bankv2\bankv2\images\background.jfif��6   $
��Fill=�6s   �� 5   
   .+�5      � -   5        $��Banner��5      $
��Left=�6!   $��
-20,15,0,0q�6<     J� RenderTransformOrigin$  0.5,0.5&�6P   $	��300��6p   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -30.00Q�6*   T� 5      5      .+�5      �� ���#A0522D$��5q�6/    �� CornerRadius$ 5��6C   $��70��6T   $��	-29,0,0,0q�6`    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5      �� ���#A0522D$��0,0,0,-5q�65   5      �� 5      $��25(�6   $��Oblique$�6&   $
��Bold"�6:   $��Center=�6L   $��Center=�6g   $��0,0,70,5q�6�   .��6�   My Shopping list J� BitmapEffect 5      F� 5       F� Color$ Black��61    F� 	Direction$	 320Q�6?    F� ShadowDepth$ 10Q�6O    F� Opacity$ .9Q�6`   	 F� Softness$	 .5Q�6m   5      5       5!      �� 5#   
   $��Center=�6   $��Center=�60   $��0,75,0,0q�6M   .+�5$      �� ���#A0522D$��5q�6+   $ 5��6?    5%        5&      ._�5(      &   System.Windows.Controls.DataGrid  -   5        $��ShoppingGrid��5(      $	��100��6/   
   AutoGenerateColumns$
 False��6<   $��35(�6X      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Apple��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ��  �� Path$ Apple�6]     5+      $ Bread��6-    6<   �� $ Bread�6]     5,      $ Donut��6-    6<   �� $ Dount�6]     5-      $
 Cost��6-    6;   �� $
 Cost�6[   5/      50      � 51      $��0,30,0,0q�6   .+�52      �� -   5        $��	BuyBorder��52      ���#A0522D$��5q�6@   $ 5��6T   $	��140��6e   $��50��6q    53        54      ._�56      �� -   5        $��Buy_Btn��56      $	��Buy��6,   $	��130��6:   $��25(�6F   
�������$��Oblique$�6g   6�   57      �� 58      -   5        $��
SellBorder��58      ���#A0522D$��5q�6A   $ 5��6U   $	��140��6f   $��50��6r   $y�	Collapsed=�6~    59        5:      ._�5<      �� -   5        $��Sell_Btn��5<      $
��Sell��6)   $	��130��68   $��25(�6D   
�������$��Oblique$�6e   $y�	Collapsed=�6y   6�   5=      5>      �� 5?      $��0,5,0,0q�6   .+�5@      �� ���#A0522D$��5q�6/   $ 5��6C   $	��200��6T   $��50��6`    5A        5B      ._�5D      �� -   5        $��	Clear_Btn��5D   2   $��
Clear List��6   $	��190��6C   $��25(�6O   
�������$��Oblique$�6p   6�   5E      5F      5G      �� 5I   
   $��650,395,0,0q�6   .+�5J      �� ���#A0522D$��5q�6+   $ 5��6?   $	��140��6P   $��50��6\    5K        5L      ._�5N      �� -   5        $��Back_Btn��5N   (   $
��Back��6   $��0,0,0,0q�68   $	��130��6I   
�������$
��Bold"�6h   $��Oblique$�6z   6�   5O      5P      5Q      5R      