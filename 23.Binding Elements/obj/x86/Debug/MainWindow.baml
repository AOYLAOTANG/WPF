   M S B A M L   `   `   `  ����  23.Binding Elements%    _23.Binding_Elements.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   �� $��5q�6   .+�5      �� -   5        $��slider1��5   #   $
��Auto��6   $��3q�62    � Minimum$ 1Q�5       � Maximum$ 50Q�6!    � Value$ 20Q�6.    �� TickPlacement$ TopLeft=�5	       �� TickFrequency$ 1Q�6-    �� IsSnapToTickEnabled . 6?   �� 5
      -   5        $��
textBlock1��5
   &   $
��Auto��6   $��测试文本��68   $��10q�6D   ��5      ��  �� ElementName$ listBox1�� �� Path$ SelectedItem.Tag��� 5      -   5        $��button1��5   A   $��5q�6   $��设置滑动条为30��6    $
��Auto��63   $
��Auto��6P   6]   �� 5      -   5        $��button2��5   =   $��5q�6   $��取消绑定��6    $
��Auto��6/   $
��Auto��6L   6Y   �� 5      -   5        $��listBox1��5   /   $��5q�6   $
��Auto��6!   $
��Auto��6?   .@�5      �� 
	 � Tag$		 Red��6   .��6(   Red6-   �� 5      $	 Green��6   .��6*   Green61   �� 5      $
	 Blue��6   .��6)   Blue6/   5      �� 5      -   5        $��textBox1��5   -   $��5q�6   $��23��6!   $
��Auto��6=   ��5      �� $ 
textBlock1��$ FontSize�
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      5      5      