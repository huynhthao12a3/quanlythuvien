   M S B A M L   `   `   `  ����Q  MHuynhVanThao_141800706, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HuynhVanThao_141800706HuynhVanThao_141800706  5   	   )    #HuynhVanThao_141800706.QuanLyThuThu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HuynhVanThao_141800706     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Icon$  image/icon.png��5   
   $��Medium"�5
   	   $��16(�5   	   $��Sitka Subheading)�5   	    � Title$ Quản lý Thủ Thư��5   	   $	��800��6!   $
��1200��6.    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   � ���	#FF0693F1$��50��6&   $	��Top=�62   .+�5      �� $��Quản Lý Thủ Thư��6   $��30(�6.   ���#fff$��Center=�6N   $��Center=�6p   �� 5      $��image/dntu-logo.png��6   $
��Left=�61   �� 5      -   5         .  *MaterialDesignFloatingActionMiniDarkButton#��[  5       � ToolTip$ Thoát��5      $��40��5   �   $��40��6�   $��Right=�6�   $��0,5,10,5q�6�   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ LocationExit=�5      5      5      � 5   
   $��0,50,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataGrid��5      $��16(�6)   
   
IsReadOnly
 .    AutoGenerateColumns .  $��20,20,20,400q�6f   ���#ccc   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Số Thủ Thư��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *MaTT+  5"      $ 	Họ Tên��6)   $	 200 69    6E   �� *	HoTenTT+  5#      $ Giới Tính��6)   $	 150 6<    6H   �� *
GioiTinhTT+  5$      $ 
Ngày Sinh��6)   $	 150 6<    6H   �� *
NgaySinhTT+ �� StringFormat$ 
dd/MM/yyyy��  5%      $ Số Điện Thoại��6)   $	 150 6@    6L   �� *SdtTT+  5&      $ Địa Chỉ��6)    6;   �� *
DiaChiTT+5(      � 5*      ���#ccc$��100,370,100,290q�6&   .+�5+      �� -   5         ��Name$ 	txtTKMaTT��5+      $��20(�6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã số thủ thư��5,       % !MaterialDesignFloatingHintTextBox#��[ 5-      $��
20,10,0,20q�5.      $
��Left=�6+   $	��300��6F   �� 5/      -   5        $ txtTKHoTenTT��5/      $��20(�60   $ Tên thủ thư��50      #��[ 51      $��370,10,0,20q�52      $
��Left=�6,   $	��300��6G   %  MaterialDesignThemes.Wpf.Badged  53         BadgeColorZoneMode$ SecondaryMid=�55      $��Right=�64   $��
0,20,20,20q�6P   $��Stretch=�6d   $	��267��6�      Badge 54      0	  *MaterialDesignThemes.Wpf.PackIconExtension	  *AccountSearchOutline+.��56      �� -   5        $��Tìm kiếm��57      $��20(�6$   ���#fff$	��267��58   �   $��50��6�   {�6   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   59      5:      9� 5=      -   5         9�Name$ 	expThuThu��5=   2   $��Thông tin thủ thư��6   $��20,480,20,20q�6F   ���#ccc$
��auto��6n   $
��auto��6{   .��5>      � $��10q�6   .+�5?      � $��2,2,0,2q�6   $
��Left=�6,   $	��350��6G   .+�5@      �� $��Mã Thủ Thư :��6!   �� 5A      -   5        $ txtMaTT��5A   "    �� 
IsReadOnly . $��	120,0,0,0q�6F   $
��Left=�6Y   $	��200��6t   5B      � 5C      $��	402,2,0,2q�6   $
��Left=�6.   $	��350��6I   .+�5D      �� $��Họ Tên :��6!   �� 5E      -   5        $ txtHoTen��5E   "   $��	120,0,0,0q�65   $
��Left=�6H   $	��200��6c   5F      � 5I      $��	802,2,0,2q�6   $
��Left=�6/   $	��350��6J   .+�5J      �� $��Giới Tính :��6    	� 5K      -	   5         	�Name$ rdbNam��5K   &    	� 	GroupName$ gender��66   $	��Nam��6I   $��	140,0,0,0q�6W   6j   	� 5L      -
   5        $ rdbNu��5L   &   $ gender��65   $
��Nữ��6H   $��	250,0,0,0q�6U   6h   5M      � 5O      $��
2,0,-2,-58q�6   $��Bottom=�60   .+�5P      �� $��Ngày Sinh : ��6    (
  "System.Windows.Controls.DatePicker
  5Q      -   5         
 Name$ txtNgaySinh��5Q   %   $	��200��6<   $
��Left=�6H   $��	120,0,0,0q�6c   5R      � 5S      $��402,0,-2,-58q�6   $��Bottom=�61   .+�5T      �� $��Số Điện Thoại :��6!   �� 5U      -   5        $ txtSDT��5U   "   $��	120,0,0,0q�63   $
��Left=�6F   $	��200��6a   5V      � 5W      $��802,0,-2,-58q�6   $��Bottom=�62   .+�5X      �� $��Địa Chỉ : ��6    �� 5Y      -   5        $ 	txtDiaChi��5Y   "   $��	120,0,0,0q�66   $
��Left=�6I   $	��200��6d   5Z      � 5_      $��Bottom=�6   $��2,0,-2,-127q�66   .+�5b        $ SecondaryMid=�5d      $��10,0,0,0q�6;    5c      	  *PlusCircleOutline+.��5e      �� -   5        $��Thêm��5f   !   $	��200��60   $��20(�6<   $��40��6J   ���#fff{�5g   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5h        5k      $ SecondaryMid=�5m      $��	310,0,0,0q�6;    5l      	  *CircleEditOutline+.��5n      �� -   5        $��Sửa��5o   !   $	��200��6/   $��20(�6;   $��40��6I   ���#fff{�5p   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5q        5t      $ SecondaryMid=�5v      $
��Left=�6;   $��	610,0,0,0q�6V    5u      	  *StickerRemoveOutline+.��5w      �� -   5        $
��Xóa��5x   !   $	��200��6/   $��20(�6;   $��40��6I   ���#fff{�5y   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5z        5}      $ SecondaryMid=�5      $
��Left=�6;   $��	910,0,0,0q�6V    5~      	  *	Autorenew+.��5�      �� -   5        $��
Làm Mới��5�   !   $	��200��63   $��20(�6?   $��40��6M   ���#fff{�5�   !   �� *DataContext.ControlsEnabled+ �� *FindAncestor+$ WindowL�6�   5�      5�      5�      5�      5�      5�      5�      