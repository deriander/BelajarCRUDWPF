   M S B A M L   `   `   `  ����I  EBelajarCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BelajarCRUDWPFBelajarCRUDWPF  5      $    BelajarCRUDWPF.UserControlItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:BelajarCRUDWPF     5      .��5	      � .+�5
   
   �� -   5          ��Name$  	txtIdItem��5
      {�.  $
��Left=�6[   $��23��6v   $��	85,56,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��151��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Id��6�   �� 5   
   -   5        $  txtStockItem��5      $
��Left=�6O   $��23��6j   $��288,131,0,0q�6v   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $  txtPriceItem��5      $
��Left=�6O   $��23��6j   $��
288,56,0,0q�6v   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $  txtNameItem��5      $
��Left=�6M   $��24��6h   $��
85,131,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5         ��Name$ 
cbSupplier��5       �� SelectedValuePath$ Id��6I    �� DisplayMemberPath$
 Name��6`   $
��Left=�6�   $��
85,198,0,0q�6�   $	��Top=�6�   $	��151��6�   ��6'   �� *	Suppliers+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblItem��5         AutoGenerateColumns .     
IsReadOnly . $
��Left=�5      $��250                   ��6.   $��
10,311,0,0q�5      $	��Top=�6)   $	��513��6A   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Name Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Id+6O     5      $
 	Name Item��6%    68   �� *Name+6S     5      $
 
Price Item��6%    69   �� *Price+6U     5      $
 
Stock Item��6%    69   �� *Stock+6U     5      $
 Supplier��6%    67   �� *Supplier.Name+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ btnDeleteRow��6%   -   5        $��Delete��5   V   5      5      5       �� 5!   
   $��Id��6   $
��Left=�6   $��	85,32,0,0q�68   $	��Top=�6K    J� RenderTransformOrigin$ 0.889,0.625&�6c   �� 5"   
   $
��Name��6   $
��Left=�6   $��
85,102,0,0q�6:   $	��Top=�6N   �� 5#   
   $��Price��6   $
��Left=�6    $��
288,32,0,0q�6;   $	��Top=�6O   �� 5$   
   $��Stock��6   $
��Left=�6    $��288,102,0,0q�6;   $	��Top=�6P   �� 5%   
   $��Supplier��6   $
��Left=�6#   $��
85,174,0,0q�6>   $	��Top=�6R   �� 5&   
   -   5        $ 
btnRefresh��5&   !   $��Clear��6   $
��Left=�6N   $��288,206,0,0q�6i   $	��Top=�6~   $	��151��6�   �� 5'   
   -	   5        $ btnSearchItem��5'      $��Search��6D   $
��Left=�6U   $��349,265,0,0q�6p   $	��Top=�6�   $��90��6�   �� 5(   
   -
   5        $  txtSearchItem��5(      $
��Left=�6)   $��32��6D   $��
85,265,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��240��6�   �� 5)   
   -   5        $ btnSaveItem��5)      $
��Save��6@   $
��Left=�6O   $��288,167,0,0q�6j   $	��Top=�6   $	��151��6�   5*      5+      