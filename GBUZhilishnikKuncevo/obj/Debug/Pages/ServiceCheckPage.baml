   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GBUZhilishnikKuncevo.PagesGBUZhilishnikKuncevo.Pages  5      1    +GBUZhilishnikKuncevo.Pages.ServiceCheckPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GBUZhilishnikKuncevo.Pages     5        N� Title$-  'К оплате за показания��5	      .��5      � 
�������.+�5   
   �� -   5        $��	TxbSearch��5      $	��Top=�5      $
��Left=�5      $R��LВведите номер лицевого счёта для поиска...��5         MaterialDesignTextBox#��[  5      $	��250��5       �� 
CaretBrush �	#FF0850A4 �� SelectionBrush �	#FF0850A45      �� 5   
   -   5        $��	BtnSearch��5      $��Искать��5      ���#0850A4  MaterialDesignFlatButton#��[ 5      $	��Top=�5      $
��Left=�5      $��260, 0, 0, 0q�5      �� 5   
   -   5        $��
BtnRefresh��5      $��Обновить��5      ���#0850A4#��[ 5!      $	��Top=�5"      $��Right=�5#      $��
0, 0, 0, 0q�5$      �� 5%   
   -   5        $��BtnTotalCheck��5%      $2��,Сумма к оплате за период��5&      ���#0850A4#��[ 5)      $	��Top=�5*      $��Right=�5+      $��0, 0, 90, 0q�5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��DataServiceCheck��5-         AutoGenerateColumns .     
IsReadOnly . $��0, 40, 0, 0q�50         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 54   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 53   %   �� *id+54   %     55      $
 ЛС��6%   $ * 57   %    56   %   �� *$"Accounting.BankBook.bankBookNumber+57   %     58      $ Услуга��6%   $ * 5:   %    59   %   �� *.,Accounting.Service.TypeOfService.serviceName+5:   %     5;      $ Начало��6%   $ * 5=   %    5<   %   �� *Accounting.accountingStart+	 �� StringFormat$	 
dd/MM/yyyy��5=   %     5>      $ 
Конец��6%   $ * 5@   %    5?   %   �� *Accounting.accountingEnd+$	 
dd/MM/yyyy��5@   %     5A      $ К оплате��6%   $ * 5C   %    5B   %   �� *totalPayble+5C   %   5E      5F      5G      