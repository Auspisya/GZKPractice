   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GBUZhilishnikKuncevoGBUZhilishnikKuncevo  5   	   %    GBUZhilishnikKuncevo.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -gif#http://wpfanimatedgif.codeplex.com/  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GBUZhilishnikKuncevo     5   	   -   5          � Title$9  3ГБУ Жилищник Района Кунцево��5
   	   $	��600��6-   $
��1200��6=   $	��600��5   	   $
��1200��6    � Icon$% ./Icons/gerb_kuncevo_moskva.jpg��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#EFEFEF � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 1��6   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      Color$ 	LightGray��5   #      ShadowDepth$ 0Q�5   #   ._�5      �� 
�������	 �� Orientation$	 
Horizontal=�5      $��2q�5      .+�5      �� $%��./Icons/gerb_kuncevo_moskva.jpg��6   $��50��5      $��50��5       �� 5!          MaterialDesignBody1TextBlock#��[  5"      $��Center=�5#      $��30(�5$      ���#045E30��5!      �� 
 �� ElementName$
 	MainFrame�� �� Path$ Content.Title�5%      5&      5'      �� 5)   
   $��1��6   $��5q�5*      $
��Left=�5+      $	��250��5,      $	��480��5-      
�������$ 20��5/       50        51      $ 20Q�6#   $ 	LightGray��52   #   $ 0Q�53   #   ._�55       � -   5          �Name$ 	MenuFrame��55      $��6q�56        � NavigationUIVisibility$ Hidden=�57      58      �� 5:   
   $��1��6   $��5q�5;      $��Right=�5<      $	��900��5=      $	��480��5>      
�������$ 20��5@       5A        5B      $ 20Q�6#   $ 	LightGray��5C   #   $ 0Q�5D   #   ._�5F       � -   5        $ 	MainFrame��5F      $��6q�5G      $ Hidden=�5H      5I      5J      5K      