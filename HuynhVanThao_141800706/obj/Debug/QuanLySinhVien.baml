   M S B A M L   `   `   `  ����Q  MHuynhVanThao_141800706, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HuynhVanThao_141800706HuynhVanThao_141800706  5   	   +    %HuynhVanThao_141800706.QuanLySinhVien   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HuynhVanThao_141800706     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Icon$  image/icon.png��5   
   $��Medium"�5
   	   $��16(�5   	   $��Sitka Subheading)�5   
    � Title$ Quản lý Sinh Viên��5   	   $	��800��6#   $
��1200��60    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   � ���	#FF0693F1$��50��6&   $	��Top=�62   .+�5      �� $��Quản Lý Sinh Viên��6   $��30(�60   ���#fff$��Center=�6P   $��Center=�6r   �� 5      $��image/dntu-logo.png��6   $
��Left=�61   �� 5      -   5         .  *MaterialDesignFloatingActionMiniDarkButton#��[  5       � ToolTip$ Thoát��5      $��40��5   �   $��40��6�   $��Right=�6�   $��0,5,10,5q�6�   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ LocationExit=�5      5      5      � 5   
   $��0,50,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGrid��5      $
   HorizontalScrollBarVisibility$
 Disabled=�6)   $��16(�6R      
IsReadOnly .    AutoGenerateColumns .  $��20,20,20,400q�6�   ���#ccc   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Sinh Viên��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *MaSV+  5"      $ 	Họ Tên��6)   $	 200 69    6E   �� *	HoTenSV+  5#      $ Lớp��6)   $	 150 66    6B   �� *Lop+  5$      $ Giới Tính��6)   $	 200 6<    6H   �� *
GioiTinhSV+  5%      $ 
Ngày Sinh��6)   $	 200 6<    6H   �� *
NgaySinhSV+ �� StringFormat$ 
dd/MM/yyyy��  5&      $ Số Điện Thoại��6)   $	 200 6@    6L   �� *SdtSV+5(      � 5*      ���#ccc$��100,370,100,290q�6&   .+�5+      �� -   5         ��Name$ 	txtTKMaSV��5+      $��20(�6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã số sinh viên��5,       % !MaterialDesignFloatingHintTextBox#��[ 5-      $��
20,10,0,20q�5.      $
��Left=�6+   $	��300��6F   �� 5/      -   5        $ txtTKHoTenSV��5/      $��20(�60   $ Tên sinh viên��50      #��[ 51      $��370,10,0,20q�52      $
��Left=�6,   $	��300��6G   %  MaterialDesignThemes.Wpf.Badged  53         BadgeColorZoneMode$ SecondaryMid=�55      $��Right=�64   $��
0,20,20,20q�6P   $��Stretch=�6d   $	��267��6�      Badge 54      0	  *MaterialDesignThemes.Wpf.PackIconExtension	  *AccountSearchOutline+.��56      �� -   5        $��Tìm kiếm��57      $��20(�6$   ���#fff$	��267��58   �   $��50��6�   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   59      5:      9� 5=      -   5         9�Name$ expSinhVien��5=   4   $��Thông tin sinh viên��6   $��20,480,20,20q�6J   ���#ccc$
��auto��6r   $
��auto��6   .��5>      � $��10q�6   .+�5?      � $��2,2,0,2q�6   $
��Left=�6,   $	��350��6G   .+�5@      �� $��Mã Sinh Viên :��6!   �� 5A      -   5        $ txtMaSV��5A   "   $��	120,0,0,0q�64   $
��Left=�6G   $	��200��6b   5B      � 5C      $��	402,2,0,2q�6   $
��Left=�6.   $	��350��6I   .+�5D      �� $��Họ Tên :��6!   �� 5E      -   5        $ txtHoTen��5E   "   $��	120,0,0,0q�65   $
��Left=�6H   $	��200��6c   5F      � 5G      $��	802,2,0,2q�6   $
��Left=�6.   $	��350��6I   .+�5H      �� $��Lớp :��6!   �� 5I      -	   5        $ txtLop��5I   "   $��	120,0,0,0q�63   $
��Left=�6F   $	��200��6a   5J      � 5L      $��
2,0,-2,-58q�6   $��Bottom=�60   .+�5M      �� $��Giới Tính :��6    	� 5N      -
   5         	�Name$ rdbNam��5N   &    	� 	GroupName$ gender��66   $	��Nam��6I   $��	140,0,0,0q�6W   6j   	� 5O      -   5        $ rdbNu��5O   &   $ gender��65   $
��Nữ��6H   $��	250,0,0,0q�6U   6h   5P      � 5R      $��402,0,-2,-58q�6   $��Bottom=�62   .+�5S      �� $��Ngày Sinh : ��6    (
  "System.Windows.Controls.DatePicker
  5T      -   5         
 Name$ txtNgaySinh��5T   %   $	��200��6<   $
��Left=�6H   $��	120,0,0,0q�6c   5U      � 5W      $��802,0,-2,-58q�6   $��Bottom=�62   .+�5X      �� $��Số Điện Thoại : ��6    �� 5Y      -   5        $ txtSDT��5Y   "   $��	120,0,0,0q�63   $
��Left=�6F   $	��200��6a   5Z      � 5]      $��Bottom=�6   $��2,0,-2,-127q�66   .+�5`        $ SecondaryMid=�5b      $��10,0,0,0q�6;    5a      	  *PlusCircleOutline+.��5c      �� -   5        $��Thêm��5d   !   $	��200��60   $��20(�6<   $��40��6J   ���#fff{�5e   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5f        5i      $ SecondaryMid=�5k      $��	310,0,0,0q�6;    5j      	  *CircleEditOutline+.��5l      �� -   5        $��Sửa��5m   !   $	��200��6/   $��20(�6;   $��40��6I   ���#fff{�5n   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5o        5r      $ SecondaryMid=�5t      $
��Left=�6;   $��	610,0,0,0q�6V    5s      	  *StickerRemoveOutline+.��5u      �� -   5        $
��Xóa��5v   !   $	��200��6/   $��20(�6;   $��40��6I   ���#fff{�5w   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5x        5{      $ SecondaryMid=�5}      $
��Left=�6;   $��	910,0,0,0q�6V    5|      	  *	Autorenew+.��5~      �� -   5        $��
Làm Mới��5   !   $	��200��63   $��20(�6?   $��40��6M   ���#fff{�5�   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5�      5�      5�      5�      5�      5�      5�      