   M S B A M L   `   `   `  ����J  FMyCustomControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WeatherInfoCustomControlWeatherInfoCustomControl  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0897    1WeatherInfoCustomControl.BoolToVisibiltyConverter   boolToVisibiltyConverter*   $WeatherInfoCustomControl.WeatherInfo  �� 
TargetType �� BasedOn �� Property �� Value �� RelativeSource �� Path �� 
TargetType �� 	Converter �� ConverterParameter	 �� Orientation
   Temperature   Humidity   Label   City �� Triggers P� Property P� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0local&clr-namespace:WeatherInfoCustomControl  5      %
  &	        '       7d�7   7      5      6%   �� 5      "   6   8   .�5
   
   ��  � ��
 �z���6)   �� 5   
    � ��
 ��  �6)   �� 5   
    � ��$ 5q�6.   �� 5   
    � �� 6&   ��  �� *Self+$
 City��� 5   
    � ��$ 2q�6#   �� 5   
    � �� 5      �� 5      "  6"   .R�5      �� #��z��6   #��z��5      #��z��5      ._�5      �� .+�5      �� y�6)   �� *	IsChecked+8  $ False��.+�5   "   �� $	 
Horizontal=�6-   .+�5   &   �� #��z
 6,   6V   �� 5   &   $��C��6,   6:   5   #   �� 5   "   #��z 6(   6O   �� 5   "   #��z 6(   6L   5       �� 5!      y�6)   �� *	IsChecked+8  $
 True��.+�5"   "   �� #��z 6(   6K   5#      5$      5%      5&      5(       5*   
   P� 5+       �@d�	IsChecked$
 TrueY�6+   . �5,      ��  � ��
 � ���6@   5-      P� 5.       �@d�	IsChecked$ FalseY�6+   . �5/      ��  � ��
 � ���6@   50      52      53      