   M S B A M L   `   `   `  ����J  FPolivanovZachet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PolivanovZachet.PageFPolivanovZachet.PageF  5      &     PolivanovZachet.PageF.DataStPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PolivanovZachet.PageF     5        N� Title$  
DataStPage��5	      .��5      � .+�5   
   �� -   5        $��btnBack��5      $��Right=�5      $	��Top=�5         btnStyle#��[  5      $��
Назад��5      $	��120��5      �� 5   
   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ 
Horizontal=�5      .+�5      �� -   5        $��cmbSort��5      $��5q�5      $��Calibri)�5      $��14(�5      $	��100��5      �� 5      -   5        $��btnSort��5"      $	��120��5       #��[  5!      $��Сортировать��5$      5%      5&      &   System.Windows.Controls.DataGrid  5'      -   5        $��dataSt��5)      $��5q�5(         AutoGenerateColumns .     
IsReadOnly . $��20(�5,      $��Calibri)�5-      $
��Bold"�5.      ���#013220   RowHeaderStyle 50      �� 51       �� 
TargetType:  4System.Windows.Controls.Primitives.DataGridRowHeader"  6   .�52      ��  �� Property � �� �� Value �#01322067   �� 53       � �� �	#FF05990567   54         RowStyle 56      �� 57      )  #System.Windows.Controls.DataGridRow"  6   .�58      ��  � �� �#01322067   �� 59       � �� �	#FF05990567   �� 5:       � ��$ 18(�65   �� 5;       � ��$ Light"�67   -   5        5=      	   Columns	 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ФИО��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
FullName+6S     5A      $#
 Год поступления��6)   $ * 6_    6B   �� *
DatePost+6_   5C      5D      5E      5F      