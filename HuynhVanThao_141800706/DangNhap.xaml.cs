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
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        tblSinhVien sv = new tblSinhVien();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow form = new MainWindow();
            form.Show();

        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            QLTVDataContext database = new QLTVDataContext();
            List<tblThuThu> tt = database.tblThuThus.Where(item => item.MaTT == txtTaiKhoan.Text && item.MatKhauTT == txtMatKhau.Password.ToString()).ToList();
            List<tblSinhVien> sv = database.tblSinhViens.Where(item => item.MaSV == txtTaiKhoan.Text && item.MatKhauSV == txtMatKhau.Password.ToString()).ToList();
            {
                if(txtTaiKhoan.Text == "" || txtMatKhau.Password.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if(sv.Count > 0)
                    {
                        this.Close();
                        SinhVien form1 = new SinhVien(txtTaiKhoan.Text);
                        form1.ShowDialog();
                    }
                    else if(tt.Count > 0)
                    {
                        this.Close();
                        ThuThu form2 = new ThuThu();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. \n\n Vui lòng nhập lại.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtTaiKhoan.Focus();
                    }
                }
            }
        }

        
    }
}
