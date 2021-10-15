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
    /// Interaction logic for DangKy.xaml
    /// </summary>
    public partial class DangKy : Window
    {
        QLTVDataContext db = new QLTVDataContext();
        public DangKy()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            ManHinhChinh();
        }

        private void DangKy_Click(object sender, RoutedEventArgs e)
        {
            if (XacThucDangKy() == true)
            {
                ThemSinhVien();
                ManHinhChinh();
            }
        }

        private void ManHinhChinh()
        {
            this.Close();
            MainWindow form = new MainWindow();
            form.Show();
        }

        private Boolean XacThucDangKy()
        {
            if (txtMaSV.Text == "" ||
                txtHoTenSV.Text == "" ||
                txtLop.Text =="" ||
                txtGioiTinhSV.Text == "" ||
                txtNgaySinhSV.Text == "" ||
                txtSdtSV.Text == "" || 
                txtMatKhauSV.Password.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);            
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ThemSinhVien()
        {
            tblSinhVien sv = new tblSinhVien();
            sv.MaSV = txtMaSV.Text.Trim();
            sv.HoTenSV = txtHoTenSV.Text.Trim();
            sv.Lop = txtLop.Text.Trim();
            sv.GioiTinhSV = txtGioiTinhSV.Text.Trim();
            sv.NgaySinhSV = DateTime.Parse(txtNgaySinhSV.Text.Trim());
            sv.SdtSV = txtSdtSV.Text.Trim();
            sv.MatKhauSV = txtMatKhauSV.Password.Trim().ToString();
            db.tblSinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();
            MessageBox.Show("Đăng ký tài khoản thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
