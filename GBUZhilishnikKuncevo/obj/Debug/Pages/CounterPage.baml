   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GBUZhilishnikKuncevo.PagesGBUZhilishnikKuncevo.Pages  5      ,    &GBUZhilishnikKuncevo.Pages.CounterPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GBUZhilishnikKuncevo.Pages     5        N� Title$  Счётчики��5	      .��5      � 
�������.+�5   
   �� -   5        $��	TxbSearch��5      $	��Top=�5      $
��Left=�5      $G��AВведите номер счётчика для поиска...��5         MaterialDesignTextBox#��[  5      $	��250��5       �� 
CaretBrush �	#FF0850A4 �� SelectionBrush �	#FF0850A45      �� 5   
   -   5        $��	BtnSearch��5      $��Искать��5      ���#0850A4  MaterialDesignFlatButton#��[ 5      $	��Top=�5      $
��Left=�5      $��260, 0, 0, 0q�5      �� 5   
   -   5        $��
BtnRefresh��5      $��Обновить��5      ���#0850A4#��[ 5!      $	��Top=�5"      $��Right=�5#      $��
0, 0, 0, 0q�5$       � Cursor$
 Hand��6%   �� 5%   
   -   5        $��BtnAdd��5%      $��Добавить��5'      ���#0850A4#��[ 5)      $	��Top=�5*      $��Right=�5+      $��0, 0, 90, 0q�5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��DataCounter��5-         AutoGenerateColumns .     
IsReadOnly . $��0, 40, 0, 0q�50         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 54   )   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 53   )   �� *id+54   )     55      $! Номер счётчика��6%   $ * 57   )   	 56   )   �� *counterNumber+57   )     58      $ Тип��6%   $ * 5:   )   	 59   )   �� *TypeOfCounter.counterName+5:   )   4  .System.Windows.Controls.DataGridTemplateColumn  5;      $ * 6)   
   CellTemplate
 5<      �� 5=      .R�5>      �� .+�5?   "   �� $��BtnShowInfo��6)   -   5        $��
Адрес��5A   %   ���#0850A4#��[ 5C   %   �� 5D   "   $��BtnEditInfo��6)   -   5        $ ��Редактировать��5F   %   ���#0850A4#��[ 5H   %   �� 5I   "   $��	BtnDelete��6)   -   5        $��Удалить��5K   %   ���#0850A4#��[ 5M   %   5N      5O      5Q      5S      5T      5U      