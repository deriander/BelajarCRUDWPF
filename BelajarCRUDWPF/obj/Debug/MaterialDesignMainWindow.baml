   M S B A M L   `   `   `  ����I  EBelajarCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BelajarCRUDWPFBelajarCRUDWPF  5   	   -    'BelajarCRUDWPF.MaterialDesignMainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:BelajarCRUDWPF  5   	   $	��600��5      $
��1000��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o    � 	Resources 5	         	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%\  &	        &	 �    �� 5
   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $	 250Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $	 250Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ 1Q�69   5      5      5       � Triggers 5      :� 5    
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonClose��66   .[�5!      �� -   5         ��Name$ CloseMenu_BeginStoryboard��5!      #��[  6A   5"      :� 5#   
   $	 ButtonBase.Click��6   $
 
ButtonOpen��66   .[�5$      �� #��[ 6   5%      .��5'      � .+�5(   
   � -   5         �Name$ GridBackground��5(      
������� J� Opacity$ 0Q�6>   �� 5)   
   -   5         ��Name$ 
ButtonOpen��5)      $
��Left=�6%   $	��Top=�6@   $��30��6�   $��30��6�   $��0q�6�   ��6X   Z� ��6n   Z� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6&   
����  �62   5+      � 5,   
   -   5        $ GridMenu��5,      $	��250��6!   $
��Left=�6-   $��
-250 0 0 0q�6H   
������� J� RenderTransformOrigin$ 0.5,0.5&�6o   z�5-      V� 5.      .~�5/      �� �� 50      �� 51      T� 52      53      .+�55      �� .+�56      �� $	��140��6   �� 57      
����  �$��Champagne & Limousines)�6-   $��18(�6U   .@�58      �� $��45��6#   $��0q�6/   .��59      ��  �� Orientation$ 
Horizontal=�6%   $
��10 0q�6>   .+�5:      �� $��Supplier��6(   $��10q�68   5;      5<      5=      �� 5>      
����  �$��Champagne & Limousines)�6-   $��18(�6U   .@�5?      �� $��45��6#   $��0q�6/   .��5@      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5A      �� $
��Item��6(   $��10q�64   5B      5C      5D      5E      �� 5F      -   5        $ ButtonClose��5F      $��Right=�6*   $	��Top=�6F   $��30��6�   $��30��6�   $��0q�6�   ��6^   Z� ��6t   Z� .��5G        $ Close=�6*   5H      5I      5J      5K      