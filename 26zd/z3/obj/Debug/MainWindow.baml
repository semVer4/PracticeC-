   M S B A M L   `   `   `  ����^  ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration  5   	   = 9z3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:z3z3 5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5	   	   m iSystem.Windows.Forms.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�mclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization/System.Windows.Forms.DataVisualization.Charting 5
   	      z3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _wfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5   	   "localclr-namespace:z3     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5	   	   chartmclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization     5
   	   8
syncfusion!http://schemas.syncfusion.com/wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � $��	0,0,10,-1q�6    J� RenderTransformOrigin$ 0.5,0.5&�6   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0Q�6"   T� 5      5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   $��151.04��6*   .+�5   
   7   1System.Windows.Forms.Integration.WindowsFormsHost  -   5          Name$ windowsFormsHost1��5      $��
0,-1,0,146q�6(   $��2��6<      Child. 5      ;  5System.Windows.Forms.DataVisualization.Charting.Chart  -   5        myChart��5      5      �� 5   
   -   5         ��Name$ button1��5#   	   $��1��5    	   $��Запустить��5!   	   $
��Left=�5"   
   $	��Top=�5$   
   $��50��5%       $��85��6,   $��	35,70,0,0q�67   �� 5'   
   -   5         ��Name$ textBox1��5'       �� TextWrapping$
 Wrap=�6$   $�� ��68   $��185,30,495,66q�6@   $��1��6W   �� 5(   
   -   5        $ textBox2��5(      $
 Wrap=�6$   $�� ��68   $��395,35,285,61q�6@   $��1��6W   �� 5)   
   -   5        $ textBox3��5)      $
 Wrap=�6$   $�� ��68   $��560,35,120,61q�6@   $��1��6W   5*      5-      