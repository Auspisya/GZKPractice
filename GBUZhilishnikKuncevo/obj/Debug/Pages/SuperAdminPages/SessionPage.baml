   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:GBUZhilishnikKuncevo.Pages.SuperAdminPages*GBUZhilishnikKuncevo.Pages.SuperAdminPages  5      <    6GBUZhilishnikKuncevo.Pages.SuperAdminPages.SessionPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:GBUZhilishnikKuncevo.Pages.SuperAdminPages     5        N� Title$  История входа��5	      .��5      � 
�������.+�5   
   �� -   5        $��	TxbSearch��5      $	��Top=�5      $
��Left=�5      $6��0Введите логин для поиска...��5         MaterialDesignTextBox#��[  5      $	��250��5       �� 
CaretBrush �	#FF0850A4 �� SelectionBrush �	#FF0850A45      �� 5   
   -   5        $��	BtnSearch��5      $��Искать��5      ���#0850A4  MaterialDesignFlatButton#��[ 5      $	��Top=�5      $
��Left=�5      $��260, 0, 0, 0q�5      �� 5   
   -   5        $��
BtnRefresh��5      $��Обновить��5      ���#0850A4#��[ 5!      $	��Top=�5"      $��Right=�5#      $��0, 0, 75, 0q�5$      �� 5%   
   -   5        $��BtnBack��5%      $��
Назад��5'      ���#0850A4#��[ 5)      $	��Top=�5*      $��Right=�5+      $��
0, 0, 0, 0q�5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��SessionData��5-         AutoGenerateColumns .     
IsReadOnly . $��0, 40, 0, 0q�50         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 55   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 54   %   �� *id+55   %     56      $ 
Логин��6%   $ * 58   %    57   %   �� *
User.login+58   %     59      $ Начало сессии��6%   $ * 5;   %    5:   %   �� *sessionStart+	 �� StringFormat$	 MM/dd/yyyy HH:mm:ss��5;   %     5<      $) #Количество попыток��6%   $ * 5>   %    5=   %   �� *authAttempts+5>   %   5@      5A      5B      