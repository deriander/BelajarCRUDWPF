   M S B A M L   `   `   `  ����I  EBelajarCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BelajarCRUDWPFBelajarCRUDWPF  5   	       BelajarCRUDWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:BelajarCRUDWPF  5   	   $	��600��5      $	��533��6'     � WindowStartupLocation$  CenterScreen=�63    � 
ResizeMode$ NoResize=�6X    � 	Resources 5	         	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%\  &	        &	 �    �� 5
   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $	 250Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $	 250Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      5      5       � Triggers 5      :� 5    
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 ButtonClose��66   .[�5!      �� -   5        
 ��Name$
 CloseMenu_BeginStoryboard��5!      #��[  6A   5"      :� 5#   
   $ ButtonBase.Click��6   $	 
ButtonOpen��66   .[�5$      �� #��[ 6   5%      .��5'      � .+�5(   
   � -   5         �Name$ GridBackground��5(      
������� J� Opacity$ 0Q�6>   � 5)   
   .+�5*      � -   5        $ GridPrincipal��5*      5+      �� 5,   
   -   5         ��Name$ 
ButtonOpen��5,      $
��Left=�6%   $	��Top=�6@   $��30��6�   $��30��6�   $��0q�6�   ��6X   Z� ��6n   Z� .��5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6&   
����  �62   5.      � 5/   
   -   5        $ GridMenu��5/      $	��250��6!   $
��Left=�6-   $��
-250 0 0 0q�6H   
������� J� RenderTransformOrigin$ 0.5,0.5&�6o   z�50      V� 51      .~�52      �� �� 53      �� 54      T� 55      56      .+�58      �� .+�59      �� $	��140��6   $��Assets/building.jpg��6%   $
��Fill=�6B   �� 5:      -   5         ��Name$ ListViewMenu��5:      
����  �$��Champagne & Limousines)�6t   $��18(�6�   .@�5;      �� -   5         ��Name$ LVISupplier��5;   #   $��45��68   $��0q�6D   .��5<      ��  �� Orientation$ 
Horizontal=�6%   $
��10 0q�6>   .+�5=        $
 Edit=�66   $��20��6B   $��20��6M   ���	#FFE6A701$��5q�6p   $��Center=�6{   �� 5>      $��Supplier��6(   $��10q�68   5?      5@      �� 5A      -   5        $ LVIItem��5A   #   $��45��64   $��0q�6@   .��5B      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5C        $ Store=�66   $��20��6C   $��20��6N   
��� � �$��5q�6m   $��Center=�6x   �� 5D      $
��Item��6(   $��10q�64   5E      5F      �� 5G      -	   5        $ 	LVILogout��5G   #   $��45��66   $��0q�6B   .��5H      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5I        $ Logout=�66   $��20��6D   $��20��6O   
���   �$��5q�6n   $��Center=�6y   �� 5J      $��Logout��6(   $��10q�66   5K      5L      5M      5N      �� 5O      -
   5        $ ButtonClose��5O      
���   �$��Right=�6=   $	��Top=�6Y   $��30��6�   $��30��6�   $��0q�6�   ��6q   Z� ��6�   Z� .��5P        $ Close=�6*   5Q      5R      5S      5T      