   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  FirstApp��5   	   $	��450��6   $	��800��6'   .��5,      �� $��15q�6   .+�5�   
   � .+�5�      �� $��Hello there!��6   $��32(�6,   $��Center=�6:   $��Center=�6W   ��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value
 � � �6G    �� Triggers 5�      P� 5�       P� Property �@J�IsMouseOver P� Value . . �5�   "   ��  � ��
 �  ��6M   �� 5�   "    � ��$ 	Underline{�6D   6X   5�      5�      5�      5�      � 5�   
   .+�5�      �� $��
Hello guy!��6   $��24(�6*   $��Center=�68   $��Center=�6U   ��5�      �� 5�      " ��6    5�      :� 5�       :� RoutedEvent$ 
MouseEnter��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W�  g� Duration$ 	0:0:0.500D�6>   	 �� TargetProperty$	 FontSize�5�   >   	
 W� To$
 72X�5�   >   5�   +   5�   '   5�      :� 5�      $ 
MouseLeave��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $ 	0:0:0.300D�6>   $	 FontSize�5�   >   $
 24X�5�   >   5�   +   5�   '   5�      5�      5�      5�      �� 5�   
   $��Center=�6   $��Center=�62   .+�5�      �� -   5        $��Hello��5�      $��Is someone there?��6$   �� 5�      $��36(�6   ��5�      �� 5�      " ��6   .�5�      ��  � ��$ No��61   �� 5�       � ��
 �  ��67    5�      �� 5�       �� Binding 6*   ��  �� ElementName$ Hello�� �� Path$ 	IsChecked� �� Value True6`   .a�5�   "   ��  � ��$ 
Of course!��69   �� 5�   "    � ��
 �����6?   5�      5�      5�      5�      �� 5�      $��Username��6   �� 5�      -   5        $��Username��5�      6(   �� 5�      $��Password��6   G� 5�       G� PasswordChar$ *��6   6-   �� 5�      -   5        $��5q�5�      $��Login��6    6I   5�      5�      