   M S B A M L   `   `   `  ����I  ESQLLiteExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SQLLiteExampleSQLLiteExample  5   	       SQLLiteExample.BuyWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SQLLiteExample     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$-  'Добавление машин в БД��5   	   $
��Auto��6'   $	��350��65    � WindowStyle$
 None=�6A    � WindowStartupLocation$ CenterScreen=�6T   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��0.3* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��5      $��2��5         Mode$ PrimaryLight=�5         CornerRadius$ 0��5      $��5q�5      $��0q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      .��5       ��  �� Orientation$ 
Horizontal=�5!      .+�5#      �� -   5        $��24��5%      $��24��5&      $��5q�5'       . *MaterialDesignFloatingActionMiniDarkButton#��[ 5(       � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5)      .��5*      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Close=�5+      $��20��5,      $��20��5-      5.      �� 50      $��Center=�51      $��16 0 0 0q�52      Купить54      56      58      �� 5:   
   $��1��6   $��10 10 10 10q�6   ��62   �� *	PathImage+� 5<   
   $��2��6    5>      �� 5@      $
��Auto �6    �� 5A      $
��Auto �6    �� 5B      $
��Auto �6    .+�5F      �� 
 �� TextAlignment$
 Center=�6/   $��30(�6F   ��6   �� *Model+6F   �� 5H      $��10 20 10 30q�64   $
��Wrap=�6I   $
 Center=�6]   $��15(�6t   $��1��6�   ��6   �� *
GlobalInfo+6�   � 5J      $��2��6    � ColumnDefinitions 5L      �� 5N      �� 5O      �� 5P       5T      �� 5V      �� 5W      .+�5[      �� $
 Center=�67   $��15(�6N   $��0��6\   ��6   �� *	DriveUnit+6\   �� 5]      $
 Center=�68   $��15(�6O   $��1��6]   ��6   �� *
TypeEngine+6]   �� 5_      $
 Center=�65   $��15(�6L   $��2��6Z   ��6   �� *	TypeKPP+6Z   � 5a      $��1��6   $��3��6$   $��Center=�68    5c      �� 5e      $
��Auto �6,   �� 5f      $
��Auto �6+   .+�5j      �� $��Center=�5k       $��Center=�5l       $
 Center=�5m       $��15(�5n       $��0��5o       ��5j       �� *Price+5o       �� 5q      $��$��6    $��5 0 0 0q�5r       $��Center=�5s       $��Center=�5t       $
 Center=�5u       $��15(�5v       $��1��5w       5y      5z      5{      �� 5~   
   $��3��6   .+�5      )  #MaterialDesignThemes.Wpf.DrawerHost  $	��340��5�      $��Center=�5�      $��Center=�5�         BottomDrawerContent 5�      �� 5�      $��	0 16 0 0 q�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� -   5         ��Name$ EmailBox��5�      $	��120��5�      $��4q�5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	ex@ml.com��5�      �� 5�      -   5         * &MaterialDesignFloatingActionMiniButton#��[ 5�      $��4q�5�      $��Center=�5�      .��5�        $
	 Cart=�5�   !   $��20��5�   !   $��20��5�   !   5�      �� 5�         CloseDrawerCommand#��Z 5�      "  System.Windows.Controls.Dock   Bottom#��Z 5�       / +MaterialDesignFloatingActionMiniLightButton#��[ 5�      $1 +MaterialDesignFloatingActionMiniLightButton��5�      $��4q�5�      $��Center=�5�      .��5�        $	 Close=�5�   !   $��20��5�   !   $��20��5�   !   5�      5�      .��5�      �  5�      �� 5�      �� 5�      .+�5�      � $��0��5�      $��Center=�5�      $��Center=�5�      .+�5�      ��    OpenDrawerCommand#��Z 5�      #��Z 5�      #��[ 5�      $��4q�5�      .��5�        $��0��5�   %   $
	 Cart=�5�   %   $��20��5�   %   $��20��5�   %   $��Center=�5�   %   5�      5�      5�      5�      5�      5�      5�      