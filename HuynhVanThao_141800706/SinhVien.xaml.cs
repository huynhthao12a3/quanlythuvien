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
    /// Interaction logic for SinhVien.xaml
    /// </summary>
    public partial class SinhVien : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        DangNhap dn = new DangNhap();
        public SinhVien()
        {
            InitializeComponent();
            LayDuLieu();
        }
        public SinhVien(string text):this()
        {
            txtMaSV.Text = text;
            txtTenSV.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.HoTenSV).SingleOrDefault();
            LayThongTinSinhVien();

        }
        private void LayDuLieu()
        {
            dtgTimKiemSach.ItemsSource = from sach in database.tblSaches select sach;
        }
        private void LayThongTinSinhVien()
        {
            txtHienThiMaSV.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.MaSV).SingleOrDefault();
            txtHienThiTenSV.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.HoTenSV).SingleOrDefault();
            txtHienThiLop.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.Lop).SingleOrDefault();
            txtHienThiGioiTinh.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.GioiTinhSV).SingleOrDefault();
            txtHienThiNgaySinh.Text = Convert.ToString(database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.NgaySinhSV).SingleOrDefault());
            txtHienThiSDT.Text = database.tblSinhViens.Where(item => item.MaSV == txtMaSV.Text).Select(item => item.SdtSV).SingleOrDefault();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow form = new MainWindow();
            form.Show();
        }

        private void TimKiemTenSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKChuDe.Clear();
            txtTKTacGia.Clear();
            dtgTimKiemSach.ItemsSource = database.sp_TimKiemTenSach(txtTKTenSach.Text);
        }

        private void TimKiemChuDe_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKTenSach.Clear();
            txtTKTacGia.Clear();
            dtgTimKiemSach.ItemsSource = database.sp_TimKiemChuDe(txtTKChuDe.Text);
        }

        private void TimKiemTacGia_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKTenSach.Clear();
            txtTKChuDe.Clear();
            dtgTimKiemSach.ItemsSource = database.sp_TimKiemTacGia(txtTKTacGia.Text);
        }

        private void TimMaSinhVien_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnXacNhanDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {   
            if(txtMaSV.Text == "" || txtMatKhauCu.Password.ToString() == "" || txtMatKhauMoi.Password.ToString() == "")
            {
                MessageBox.Show("Thông tin bị trống \n \n Vui lòng nhập lại thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                if ((from x in database.tblSinhViens where x.MaSV == txtMaSV.Text && x.MatKhauSV == txtMatKhauCu.Password select x).Count() <= 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng \n \n Vui lòng nhập lại mật khẩu cũ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtMatKhauCu.Clear();
                    txtMatKhauCu.Focus();
                }
                else
                {
                    tblSinhVien sv = database.tblSinhViens.Single(item => item.MaSV == txtMaSV.Text);
                    sv.MaSV = txtMaSV.Text;
                    sv.MatKhauSV = txtMatKhauMoi.Password.ToString();
                    database.SubmitChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtMaSV.Clear();
                    txtTenSV.Clear();
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                }
            }
            
        }
    }
}
