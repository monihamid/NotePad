   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	       WpfApplication2.Notepad   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	     � Title$  Notepad��5   	   $	��600��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
      �� 5   
   $
��200* �6   �� 5   
   $
��317* �6   .+�5      ]� $��2��6   .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5      6)   m� 5      -   5        $��_Open��5      6*   m� 5      -   5        $��_Save As��5      6-   �� 5      m� 5      -   5        $��_Close��5      6+   5      m� 5      $��_Option��6   m� 5      $��_Help��6   .@�5      m� -   5        $��_About��5      6+   5      5      �� 5    
   $��Bottom=�6   .@�5!      �� .��5#      �� -   5        $��	wordCount��5#      5$      5%      �� 5&   
   -   5         ��Name$ editBox1��5&      $
��Left=�6$   $	��522��6?   $��0,0,0,0q�6L    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��800��6�    �� AcceptsReturn . $��2��5'   J   $��Visible=�6^   5(      5)      5*      