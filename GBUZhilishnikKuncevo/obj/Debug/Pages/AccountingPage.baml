   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GBUZhilishnikKuncevo.PagesGBUZhilishnikKuncevo.Pages  5      /    )GBUZhilishnikKuncevo.Pages.AccountingPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GBUZhilishnikKuncevo.Pages     5        N� Title$  Показания��5	      .��5      � 
�������.+�5   
   �� -   5        $��	TxbSearch��5      $	��Top=�5      $
��Left=�5      $R��LВведите номер лицевого счёта для поиска...��5         MaterialDesignTextBox#��[  5      $	��250��5       �� 
CaretBrush �	#FF0850A4 �� SelectionBrush �	#FF0850A45      �� 5   
   -   5        $��	BtnSearch��5      $��Искать��5      ���#0850A4  MaterialDesignFlatButton#��[ 5      $	��Top=�5      $
��Left=�5      $��260, 0, 0, 0q�5      �� 5   
   -   5        $��
BtnRefresh��5      $��Обновить��5      ���#0850A4#��[ 5!      $	��Top=�5"      $��Right=�5#      $��
0, 0, 0, 0q�5$      �� 5%   
   -   5        $��BtnAdd��5%      $��Добавить��5'      ���#0850A4#��[ 5)      $	��Top=�5*      $��Right=�5+      $��0, 0, 90, 0q�5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��DataAccounting��5-         AutoGenerateColumns .     
IsReadOnly . $��0, 40, 0, 0q�50         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 54   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 53   %   �� *id+54   %     55      $
 ЛС��6%   $	 110 57   %    56   %   �� *BankBook.bankBookNumber+57   %     58      $ Счётчик��6%   $ * 5:   %    59   %   �� *Counter.counterNumber+5:   %     5;      $ Услуга��6%   $ * 5=   %    5<   %   �� *#!Service.TypeOfService.serviceName+5=   %     5>      $ Показание��6%   $ 99 5@   %    5?   %   �� *counterReading+5@   %     5A      $ Ед. изм.��6%   $ 80 5C   %    5B   %   �� *Service.unit+5C   %     5D      $ Начало��6%   $ * 5F   %    5E   %   �� *accountingStart+	 �� StringFormat$	 
dd/MM/yyyy��5F   %     5G      $ 
Конец��6%   $ * 5I   %    5H   %   �� *accountingEnd+$	 
dd/MM/yyyy��5I   %   4  .System.Windows.Controls.DataGridTemplateColumn  5J      $ * 6)   
   CellTemplate
 5K      �� 5L      .R�5M      �� .+�5N   "   �� $��BtnEditInfo��6)   -   5        $ ��Редактировать��5P   )   ���#0850A4#��[ 5R   )   5S      5T      5V      5X      5Y      5Z      