   M S B A M L   `   `   `  ����I  EBelajarCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BelajarCRUDWPFBelajarCRUDWPF  5      (    "BelajarCRUDWPF.UserControlSupplier   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:BelajarCRUDWPF  5      .��5
      � .+�5   
   �� -   5          ��Name$  txtIdSupplier��5      {�.  $
��Left=�6c   $��23��6~   $��	93,81,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $  txtNameSupplier��5      $
��Left=�6U   $��23��6p   $��
280,81,0,0q�6|   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $  txtAddressSupplier��5      $
��Left=�6[   $��23��6v   $��
93,138,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $  txtEmailSupplier��5      $
��Left=�6W   $��23��6r   $��280,138,0,0q�6~   $
 Wrap=�6�   $	��Top=�6�   $	��151��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblSupplier��5       �� SelectedItem$ 
selectGrid��5         AutoGenerateColumns .     
IsReadOnly . $
��Left=�5      $	��251��6.   $��
10,310,0,0q�6;   $	��Top=�6O   $	��513��6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6J     5      $
 Name��6%    63   �� *Name+6N     5      $ Address��6%    66   �� *	Address+6T     5      $ Email��6%    64   �� *Email+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 btnDeleteRow��6%   -   5        $��Delete��5   V   5      5      5      5!      �� 5"   
   $��Id��6   $
��Left=�6   $��	93,52,0,0q�68   $	��Top=�6K   �� 5#   
   $
��Name��6   $
��Left=�6   $��
284,52,0,0q�6:   $	��Top=�6N   �� 5$   
   $��Address��6   $
��Left=�6"   $��
93,109,0,0q�6=   $	��Top=�6Q   �� 5%   
   $��Email��6   $
��Left=�6    $��284,109,0,0q�6;   $	��Top=�6P   �� 5&   
   -   5        $
 
btnRefresh��5&      $��Clear��6>   $
��Left=�6N   $��
93,182,0,0q�6i   $	��Top=�6}   $	��151��6�   �� 5'   
   -   5        $  txtSearchSupplier��5'      $
��Left=�6-   $��32��6H   $��
93,265,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��173��6�   �� 5(   
   -	   5        $
 btnSearchSupplier��5(      $��Search��6L   $
��Left=�6]   $��284,265,0,0q�6x   $	��Top=�6�   $	��151��6�   �� 5)   
   -
   5        $
 btnSaveSupplier��5)      $
��Save��6H   $
��Left=�6W   $��284,182,0,0q�6r   $	��Top=�6�   $	��151��6�   5*      5+      