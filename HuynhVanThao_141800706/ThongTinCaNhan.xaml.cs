using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HuynhVanThao_141800706
{
    /// <summary>
    /// Interaction logic for ThongTinCaNhan.xaml
    /// </summary>
    public partial class ThongTinCaNhan : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public string maTT = "";
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ThongTinCaNhan(string text) : this()
        {
            maTT = text;
            LayDuLieu();

        }
        private void btnXacNhanDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            if ( txtMatKhauCu.Password.ToString() == "" || txtMatKhauMoi.Password.ToString() == "")
            {
                MessageBox.Show("Thông tin bị trống \n \n Vui lòng nhập lại thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                if ((from x in database.tblThuThus where x.MaTT == txtMaTT.Text && x.MatKhauTT == txtMatKhauCu.Password select x).Count() <= 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng \n \n Vui lòng nhập lại mật khẩu cũ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtMatKhauCu.Clear();
                    txtMatKhauCu.Focus();
                }
                else
                {
                    tblThuThu tt = database.tblThuThus.Single(item => item.MaTT == txtMaTT.Text);
                    tt.MatKhauTT = txtMatKhauMoi.Password.ToString();
                    database.SubmitChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                }
            }
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void LayDuLieu()
        {
            txtHienThiMaTT.Text = txtMaTT.Text = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.MaTT).SingleOrDefault();
            txtHienThiTenTT.Text = txtTenTT.Text = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.HoTenTT).SingleOrDefault();
            txtHienThiGioiTinh.Text = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.GioiTinhTT).SingleOrDefault();
            txtHienThiNgaySinh.Text = Convert.ToString(database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.NgaySinhTT).SingleOrDefault());
            txtHienThiSDT.Text = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.SdtTT).SingleOrDefault();
            txtHienThiDiaChi.Text = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.DiaChiTT).SingleOrDefault();
        
            
        }
    }
}
