   M S B A M L   `   `   `  ����C  ?demolast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:demolastdemolast  5          demolast.clubs   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:demolast     5      -   5          N� Title$  clubs��5	       N� ShowsNavigationUI .  .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��377* �6   �� 5      $	��73* �6   .+�5   
   �� 
������� �� Orientation$ 
Horizontal=�6,   .+�5      �� $=��7Введите название фитнес клуба��6   $��0��6=   $
��Left=�6J   5      �� 5      -   5         ��Name$ Search��5      $��0��6G   $��Right=�6T   6r   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��fitness_clubsDG��5         AutoGenerateColumns .  $��1��6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фитнес клуб��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *name+6_     5      $ Адресс��6%   $ * 6Q   	 65   �� *	address+6]     5      $! Номер телефона��6%   $ * 6X   	 6=   �� *number+6d     5      $ Бассейн��6%   $ * 6T   	 66   �� *	waterpool+6`     5      $ Начало работы��6%   $ * 6[   	 6<   �� *
start_work+6g     5      $ Веб-сайт��6%   $ * 6T   	 67   �� *
web_site+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5       $
 auto 6)   
   CellTemplate
 5!      �� 5"      .R�5#      �� $
��Edit��6=   -   5        $ ��Редактировать��5#   %   6^   5$      5&      5(      �� 5)   
   -   5        $	��Add��5)   X   $��Добавить��6   $��2��6$   $
��Left=�61   $	��400��6L   6w   �� 5*   
   -   5        $	��Del��5*   X   $��Удалить��6   $��2��6#   $��Right=�60   $	��400��6L   6w   5+      5,      