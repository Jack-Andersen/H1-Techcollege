   M S B A M L   `   `   `  ����A  =BankV2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BankV2BankV2  5      $    BankV2.TransactionOverViewPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:BankV2     5      $	��450��5      $	��800��6   .��5	      � .+�5
   
   �� $_��Yc:\users\elder\documents\github\jack_andersen\skp-h2\bankv2\bankv2\images\background.jfif��6   $
��Fill=�6s   �� 5   
   $��Center=�6   $��	0,35,0,10q�62   .+�5      �� $��25(�6   $��Oblique$�6"   $
��Bold"�66   $��	50,0,50,0q�6H   .��6[   	Balance  J� BitmapEffect  5      F� 5       F� Color$ Black��6-    F� 	Direction$	 320Q�6;    F� ShadowDepth$ 10Q�6K    F� Opacity$ .9Q�6\    F� Softness$ .5Q�6i   5      �� 5      ���#A0522D$��5q�6+    �� CornerRadius$ 5��6?   $	��200��6P   $��50��6\    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5      �� -   5        $��Balance��5      $�� ��6'   $��25(�62   
�������$��Right=�6S   6x   5      5      �� 5   
   $��Bottom=�6   $��Center=�60   $��0,0,0,30q�6M   .+�5      �� ���#A0522D$��5q�6+   $ 5��6?    5        5      ._�5      &   System.Windows.Controls.DataGrid  -   5        $��TransactionGrid��5      $	��250��62      AutoGenerateColumns$ False��6?   $��Center=�6[   	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Amount��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ Amount�6_     5"      $

 Note��6-    6;   �� $
 Note�6[     5#      $

 Date��6-    6;   �� $
 Date�6[     5$      $
 Balance��6-    6>   �� $ Bank_Account.Balance�6n   5&      5'      5(      �� 5*   
   $��650,395,0,0q�6   .+�5+      �� ���#A0522D$��5q�6+   $ 5��6?   $	��140��6P   $��50��6\    5,        5-      ._�5/      �� -   5        $��Back_Btn��5/   (   $
��Back��6   $	��130��68   
�������$
��Bold"�6W   $��Oblique$�6i   6�   50      51      52      53      