   M S B A M L   `   `   `  ����I  ESQLLiteExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SQLLiteExampleSQLLiteExample  5   	       SQLLiteExample.CarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SQLLiteExample     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$-  'Добавление машин в БД��5   	   $	��550��6'   $	��300��64    � WindowStyle$
 None=�6@    � WindowStartupLocation$ CenterScreen=�6S   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $
��Auto �6   �� 5      �� 5      .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��5      $��2��5         Mode$ PrimaryLight=�5          CornerRadius$ 0��5!      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5"      .��5#      ��  �� Orientation$ 
Horizontal=�5$      .+�5%      �� -   5        $��24��5'      $��24��5(      $��5q�5)       . *MaterialDesignFloatingActionMiniDarkButton#��[ 5*       � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5+      .��5,      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Close=�5-      $��20��5.      $��20��5/      50      �� 51      $��Center=�52      $��16 0 0 0q�53      (&Добавление в каталог55      56      57      �� 58   
   $��	20 0 20 0q�6*   $��1��6>   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Модель��6L   ��6   �� *Model+6L   �� 59   
   $��	20 0 20 0q�5:      $��2��5;      $
 Привод��5<       �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 5>       �� Text 59      �� *	DriveUnit+.@�5?      �� $��Передний��6    �� 
IsSelected . 6.   �� 5@      $��Задний��6   �� 5A      $��Полный��6   5B      �� 5C   
   $��	20 0 20 0q�6/   $��3��5D      $
 Тип двигателя��5E       . #��[ 5G       5C      �� *
TypeEngine+.@�5H      �� $��Бензин��6    . 6,   �� 5I      $��Газ��6   �� 5J      $��Дизель��6   �� 5K      $��Электро��6   5L      �� 5M   
   $��	20 0 20 0q�5N      $��4��5O      $<
 6Коробка переключения передач��5P       . #��[ 5R       5M      �� *	TypeKPP+.@�5S      �� $��Автомат��6    . 6-   �� 5T      $��Ручная��6   5U      �� 5V   
   $��	20 0 20 0q�6+   $
 Компания��6?   $��5��6i   ��6   �� *	Company+6i   �� 5W   
   $��	20 0 20 0q�6)   $
 Цена��6<   $��6��6b   ��6   �� *Price+6b   �� 5X   
    ! MaterialDesignTextAreaTextBox#��[ 5Z      $��20,10,20,10q�5[      $	��Top=�5\      $	��100��5]      $��7��5^       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5`      " �� VerticalScrollBarVisibility$ Hidden=�5a      $-
 'Подробная информация��5b      ��5Y      �� *
GlobalInfo+5b      � 5d   
   $��8��6    � ColumnDefinitions 5e      �� 5f      �� 5g      $��55 �6#   .+�5i      �� -   5         ��Name$ PathName��5i   �   $��	20 0 10 0q�61   $"
 Путь к картинке��6E   $��0��6v   ��6   �� *	PathImage+6�   �� 5k      -   5        $��1��5l       / +MaterialDesignFloatingActionMiniLightButton#��[ 5m      $
��Left=�5o      $��8 0 8 0q�5p      $��35��5q      $��35��5r      $, &MaterialDesignFloatingActionMiniButton��5s      .��5t        $
	 Plus=�5u      $��20��5v      $��20��5w      5x      5y      �� 5|   
   $��Center=�6   $ 
Horizontal=�62   $��9��6K   $��2��6X   .+�5}      �� -   5         * &MaterialDesignFloatingActionMiniButton#��[ 5~       �� 	IsDefault . $
��Left=�5�      $��8 0 8 0q�5�      $��35��5�      $��35��5�      $, &MaterialDesignFloatingActionMiniButton��5�      .��5�        $!	 CheckboxMarkedCircleOutline=�5�      $��20��5�      $��20��5�      5�      �� 5�      #��[ 5�       �� IsCancel . $��35��5�      $��35��5�      $
��Left=�5�      $��8 0 8 0q�5�      $, &MaterialDesignFloatingActionMiniButton��5�      .��5�        $	 Cancel=�5�      $��20��5�      $��20��5�      5�      5�      5�      5�      