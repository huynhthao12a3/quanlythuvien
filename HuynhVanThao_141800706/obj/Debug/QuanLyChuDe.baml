   M S B A M L   `   `   `  ����Q  MHuynhVanThao_141800706, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HuynhVanThao_141800706HuynhVanThao_141800706  5   	   (    "HuynhVanThao_141800706.QuanLyChuDe   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HuynhVanThao_141800706     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Icon$  image/icon.png��5   
   $��Medium"�5
   	   $��16(�5   	   $��Sitka Subheading)�5   
    � Title$ Quản Lý Chủ Đề��5   	   $	��700��6    $
��1200��6-    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   � ���	#FF0693F1$��50��6&   $	��Top=�62   .+�5      �� $��Quản Lý Chủ Đề��6   $��30(�6-   ���#fff$��Center=�6M   $��Center=�6o   �� 5      $��image/dntu-logo.png��6   $
��Left=�61   �� 5      -   5         .  *MaterialDesignFloatingActionMiniDarkButton#��[  5       � ToolTip$ Thoát��5      $��40��5   �   $��40��6�   $��Right=�6�   $��0,5,10,5q�6�   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ LocationExit=�5      5      5      � 5   
   $��0,50,0,0q�6   .+�5      �� .@�5       �� -   5        	 ��Name$	 tabThongTinChuDe��5       $	��200��64   $��40��6@   ��5!      �� 5"      
 �� Orientation$
 
Horizontal=�6%   .+�5#        $ InformationOutline=�66   ���	#CC0000FF$��30��6g   $��30��6r   �� 5$      $��Thông tin chủ đề��6$   $��20(�6?   5%      .��5'      � .+�5(      �� $��image/tieusutacgia.png��6    $
��Fill=�6@   &   System.Windows.Controls.DataGrid  5*      -   5          Name$ dtgChuDe��5*   1    � Cursor$
 Hand��6#   $��30(�6C   $   HorizontalScrollBarVisibility$ Hidden=�6R   $��688,100,170,100q�6y      AutoGenerateColumns .  
������    
IsReadOnly .    	CellStyle 5+      �� 5,   "    �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6(   .�5-   &   ��  �� Property � �� �� Value$ 50��6?   �� 5.   &    � ��
 ���� 6C   �� 5/   &    � �� �#0006C   �� 50   &    � ��$ 0q�6H   51   #      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Tên chủ đề��65      Width5  /System.Windows.Controls.DataGridLengthConverter$	 350 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *
TenChuDe+6f     55   "   $ Ghi chú��65    6F   �� *GhiChu+57      �� 58      -   5         ��Name$ lblTenCD��58       $��158,70,0,70q�62   $
��Left=�6G   $	��358��6b   .��59      �� -   5         ��Name$ txbTenCD��59   (   $
��Wrap=�6:   $��21(�6N   5:      5;      5<      �� 5?      -   5        $	 tabChinhSua��5?      $	��160��6/   $��40��6;   ��5@      �� 5A      $
 
Horizontal=�6%   .+�5B        $ FileDocumentEditOutline=�66   ���	#CC0000FF$��30��6l   $��30��6w   �� 5C      $��Chỉnh sửa��6$   $��20(�68   5D      .��5F      � .+�5G      �� $��image/tacgia.jpg��6    $
��Fill=�6:   �� 5H      -   5         ��Name$ cmbTenCD��5H   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên chủ đề��65    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 5I   #   $��24(�6_   $	��300��6m   $��70��6y   $
��Left=�6�   $��	50,50,0,0q�5J   #   $	��Top=�66   6p   �� 5K      -   5         ��Name$ 	txtGhiChu��5K   "   $��24(�5L      $ Ghi chú��5M       % !MaterialDesignFloatingHintTextBox#��[ 5N   !    �� TextWrapping$
 Wrap=�5O      $	��600��5P      $
��Left=�6+   $��50,165,0,150q�6a   � 5Q      $��
50,0,544,0q�6   $	��145��63   $��Bottom=�6@   .+�5R      �� -	   5         ��Name$ btnThem��5R   %   
��� � ����#ddd$��20(�6[   $	��150��6i   $��50��6u   $
��Left=�6�   $��5,0,0,0q�6�   .��5S   "   �� $
 
Horizontal=�6-   .+�5T   &     $ BookPlusOutline=�6>   $��35��6U   $��40��6`   �� 5U   &   $��Thêm��6,   $��24(�6;   ���	#CC0000FF6I   5V   #   5W      �� 5Y      -
   5        $ btnSua��5Y   %   ���#000���#ddd$��20(�6Y   $	��150��6g   $��50��6s   $
��Left=�6   $��	225,0,0,0q�6�   .��5Z   "   �� $
 
Horizontal=�6-   .+�5[   &     $ BookCogOutline=�6>   $��35��6T   $��40��6_   �� 5\   &   $��Sửa��6,   $��24(�6:   ���	#CC0000FF6H   5]   #   5^      �� 5`      -   5        $ btnXoa��5`   %   
���  �����#ddd$��20(�6X   $	��150��6f   $��50��6r   $
��Left=�6~   $��	445,0,0,0q�6�   .��5a   "   �� $
 
Horizontal=�6-   .+�5b   &     $ BookRemoveOutline=�6>   $��35��6W   $��40��6b   �� 5c   &   $
��Xóa��6,   $��24(�6:   ���	#CC0000FF6H   5d   #   5e      5h      5j      5k      5l      5m      5o      5p      