   M S B A M L   `   `   `  ����Q  MHuynhVanThao_141800706, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HuynhVanThao_141800706HuynhVanThao_141800706  5   	   #    HuynhVanThao_141800706.ThuThu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HuynhVanThao_141800706     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Icon$  image/icon.png��5   
   $��Medium"�5
   	   $��16(�5   	   $��Sitka Subheading)�5   	    � Title$ 
Thủ Thư��5   	   $	��700��6   $
��1200��6&    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   ��5      �� 5   
    �� ImageSource$ image/thuviengd.jpg��6    j� Stretch$ UniformToFill=�67   6Q    � 	Resources 5         MenuOpen �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  	MenuClose��%O  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 gridMenu��6a   .\�5        $
 	0:0:0:0.2��6'   $	 300Q�6;   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 gridMenu��6a   .\�5        $
 	0:0:0:0.2��6'   $ 70Q�6;   5       5!      5"       � Triggers 5%      :� 5&   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ btnOpenMenu��66   .[�5'      �� #��[  6   5(      :� 5)   
   $ ButtonBase.Click��6   $ btnCloseMenu��66   .[�5*      �� #��[ 6   5+      .��5.      � .+�5/   
   � ���	#FF0693F1$��50��6&   $	��Top=�62   .+�50      �� $)��#Phần Mềm Quản Lý Thư Viện��6   $��30(�68   ���#fff$��Center=�6X   $��Center=�6z   �� 51      $��image/dntu-logo.png��6   $
��Left=�61   �� 52      -   5         . *MaterialDesignFloatingActionMiniDarkButton#��[ 53       � ToolTip$ Đăng xuất��54      $��40��55   �   $��40��6�   $��Right=�6�    J� RenderTransformOrigin$ 
27.2,0.475&�6�   $��0,5,10,5q�6  {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��56      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ LocationExit=�57      58      59      #  MaterialDesignThemes.Wpf.Chip  5:   
   -   5          Name$
 chip��5:      $ Xin chào !��5;      $��Họ và tên��5<      
�������$
��Bold"�6J   $��Right=�6\   $��	0,55,10,0q�6x   $	��Top=�6�   $	��100��6�      Icon 5=      �� 5>      $��image/thuthu.png��6   5@      � 5A   
   -   5         �Name$ gridMenu��5A      $��1,50,0,0q�6!   $��70��63   ���	#FFFFF6F6$
��Left=�6U   .+�5B      �� .+�5C      � $��50��6   ���	#FF0066BE.+�5D      �� -   5         ��Name$ btnOpenMenu��5D      $��70��62   $��50��6=   ���	#FF0066BE$��0q�5E   4   $��Right=�5F      $��Center=�69   .��5G        
�������$
 Menu=�6E   $��Center=�6Q   $��Center=�6l   $��50��6�   $��50��6�   5H      �� 5I      -   5        $ btnCloseMenu��5I      $��70��63   $��50��6>   ���	#FF0066BE$��0q�5J   4   $��Center=�6H   $��Right=�5K      $y�	Collapsed=�69   .��5L        
�������$ ArrowLeftBottom=�6E   $��Center=�6\   $��Center=�6w   $��50��6�   $��40��6�   5M      5N      �� 5O      $��Disabled=�6   .@�5P      �� $��70��6#   .��5Q      ��  �� Orientation$ 
Horizontal=�6%   .+�5R        $ InformationOutline=�66   $��5q�6P   $��40��6[   $��40��6f   $��Center=�6r   �� 5S      -   5        $	��200��5S   8   $��Thông Tin Cá Nhân��6D   $��20 10q�6`   
�������$��Center=�6�   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   5T      5U      �� 5V      $��70��6#   .��5W      �� $ 
Horizontal=�6%   .+�5X        $ AccountStarOutline=�66   $��5q�6P   $��40��6[   $��40��6f   $��Center=�6r   �� 5Y      -   5        $	��200��5Y   8   $��Quản Lý Thủ Thư��6D   $��20 10q�6^   
�������$��Center=�6�   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   5Z      5[      5\      �� 5]      $��Disabled=�6   .@�5^      �� $��70��6#   .��5_      �� $ 
Horizontal=�6%   .+�5`        $ AccountOutline=�66   $��5q�6L   $��40��6W   $��40��6b   $��Center=�6n   �� 5a      -   5        $	��200��5a   8   $��Quản Lý Sinh Viên��6D   $��20 10q�6`   
�������$��Center=�6�   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   5b      5c      5d      �� 5e      $��Disabled=�6   .@�5f      �� $��70��6#   .��5g      �� $ 
Horizontal=�6%   .+�5h        $  BookOpenPageVariantOutline=�66   $��5q�6X   $��40��6c   $��40��6n   $��Center=�6z   �� 5i      -	   5        $	��200��5i   &   $��Quản Lý Sách��62   $��20 10q�6I   
�������$��Center=�6k   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   6�   5j      5k      5l      �� 5m      $��Disabled=�6   .@�5n      �� $��70��6#   .��5o      �� $ 
Horizontal=�6%   .+�5p        $ AccountEditOutline=�66   $��5q�6P   $��40��6[   $��40��6f   $��Center=�6r   �� 5q      -
   5        $	��200��5q   %   $��Quản Lý Tác Giả��61   $��20 10q�6K   
�������$��Center=�6m   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   6�   5r      5s      5t      �� 5u      $��Disabled=�6   .@�5v      �� $��70��6#   .��5w      �� $ 
Horizontal=�6%   .+�5x        $ ContentSaveEditOutline=�66   $��5q�6T   $��40��6_   $��40��6j   $��Center=�6v   �� 5y      -   5        $	��200��5y   %   $��Quản Lý Chủ Đề��61   $��20 10q�6J   
�������$��Center=�6l   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   6�   5z      5{      5|      �� 5}      $��Disabled=�6   .@�5~      �� $��70��6#   .��5      �� $ 
Horizontal=�6%   .+�5�        $ CardAccountDetailsOutline=�66   $��5q�6W   $��40��6b   $��40��6m   $��Center=�6y   �� 5�      -   5        $	��200��5�   %   $ ��Quản Lý Phiếu Mượn��61   $��20 10q�6N   
�������$��Center=�6p   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   6�   5�      5�      5�      �� 5�      $��Disabled=�6   .@�5�      �� $��70��6#   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ MicrosoftExcel=�66   $��5q�6L   $��40��6W   $��40��6b   $��Center=�6n   �� 5�      -   5        $	��200��5�   %   $��Thống Kê��61   $��20 10q�6D   
�������$��Center=�6f   $��Center=�6�   $��18(�6�   $��Center=�6�   $��Center=�6�   6�   5�      5�      5�      5�      5�      5�      5�      