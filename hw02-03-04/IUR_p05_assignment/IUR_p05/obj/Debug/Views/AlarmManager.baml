   M S B A M L   `   `   `  ����B  >IUR_p05, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IUR_p05.ViewsIUR_p05.Views  5   	   7 clr-namespace:IUR_p05.ViewModelsIUR_p05.ViewModels  5   	        IUR_p05.Views.AlarmManager   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:IUR_p05.Views     5   	   7
viewModels clr-namespace:IUR_p05.ViewModels     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5      .  (IUR_p05.ViewModels.AlarmManagerViewModel   	ViewModel-   'IUR_p05.ViewModels.EnumBooleanConverter  enumBooleanConverter��%:   &	        &	        5   
   6+     5   
   6*   5      .��5      ]�  � DataContext# [  6   .+�5   
   � $
��Left=�6   $��5q�6%    � ColumnDefinitions 5      �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��auto �6    .+�5      �� $��0��6    �� DisplayMemberPath$ 	AlarmName��6�   ��6#   ��  �� Path$ 	AlarmList� �� SelectedIndex 6J   �� $ SelectedAlarmIndex� �� SelectedItem 6|   �� $ SelectedAlarmDetail�5      �� 5      	 �� Orientation$	 
Horizontal=�6   $��1��62   .+�5      �� $��5q�6   $��Nový��6$   ��63   �� *
AddCommand+�� 5      $��5q�6   $��Smazat��6$   ��65   �� *DeleteCommand+5       5!      �� 5"   
   
���   �$��1q�6%   $��Stretch=�69   $��Stretch=�6W   ._�5#      � $��5q�6   $��Stretch=�6   $��Stretch=�6<    5$      �� 5%      $
��auto �6'   �� 5&      $��* �6'   �� 5'      $
��auto �6'    5)      �� 5*      $
��auto �6$   �� 5+      $
��auto �6$   �� 5,      $
��auto �6$   �� 5-      $
��auto �6$   �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   .+�52      �� $��0��6   $��0��6%   $��
0, 2, 0, 0q�65   .��6I   Název alarmu:6X   �� 53      $��0��6   $��1��6'   $��2��67   $
��5, 0q�6K   $��Center=�6Y   ��6t   �� $# SelectedAlarmDetail.AlarmName�
 �� UpdateSourceTrigger$
 PropertyChanged=��� 55      $��1��6   $��0��6%   $��
0, 2, 0, 0q�65   .��6I   Typ alarmu:6V   �� 56      $��1��6   $��1��6*   $��2��6:   $	 
Horizontal=�6N   .+�57      	� $��Center=�6�   $��10, 5q�6�    d� 	IsChecked 6"   �� $ SelectedAlarmDetail.Type� �� 	Converter# [  �� ConverterParameter$	 MIN��.��6�   Min. teplota6�   	� 58      $��Center=�6�   $��10, 5q�6�    6"   �� $ SelectedAlarmDetail.Type�# [ $	 MAX��.��6�   Max. teplota6�   59      �� 5:      $��2��6   $��0��6%   $��
0, 2, 0, 0q�65   .��6I   
Hranice:6S   �� 5;      -   5         ��Name$ borderSlider��5;   �   $��2��6   $��1��6&   $��Stretch=�66   $��Center=�6T    � Minimum$	 -30Q�6o    � Maximum$ 50Q�6}    � Value 5<      �� *$"SelectedAlarmDetail.ThresholdValue+�� 5=      -   5         ��Name$ borderTexbox��5=   k   $��2��6   $��2��6'   $��40��67   $
��5, 0q�6B   $��Center=�6P   ��6�   �� *$"SelectedAlarmDetail.ThresholdValue+$
 PropertyChanged=�6�   �� 5?      $��3��6   $��0��6%   $��
0, 2, 0, 0q�65   .��6I   	Obrázek:6S   �� 5@      $��3��6   $��1��6(   $��5q�68   $	��Top=�6C   ��6[   �� * SelectedAlarmDetail.AlarmIcons+ 6�   �� $' !SelectedAlarmDetail.SelectedImage���5A      �� 5B      .R�5C      �� $	 
Horizontal=�6)   .+�5D   "   �� $��20��6;   $��20��6F   ��6(   �� 6F   �� 5E   "   ��6,   �� 5F      5G      5I      �� 5K      
���   �$��1q�6-   $��3��6A   $��2��6N   $��50��6^   $��50��6i   $��10, 5, 10, 6q�6u   $	��Top=�6�   ._�5L      �� ��6   �� $' !SelectedAlarmDetail.SelectedImage�$
 PropertyChanged=�5M      �� 5O      $��4��6   $��0��6%   $��
0, 2, 0, 0q�65   .��6I   
Zpráva:6R   �� 5P      $��4��6   $��1��6'   $��2��67   $
��5, 0q�6K   $��Center=�6Y   ��6t   �� $&  SelectedAlarmDetail.AlarmMessage�$
 PropertyChanged=�6�   5R      5S      5T      5U      