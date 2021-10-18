using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for QuanLyThuThu.xaml
    /// </summary>
    public partial class QuanLyThuThu : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public string gender = "";
        public QuanLyThuThu()
        {
            InitializeComponent();
            LayDuLieu();
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            txtMaTT.Text = TangMaTuDong();
            if (txtMaTT.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
                txtDiaChi.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn thêm không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ThemThuThu();
                    MessageBox.Show("Thêm thông tin thủ thư thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaTT.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
                 txtDiaChi.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn sửa không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    SuaThuThu();
                    MessageBox.Show("Sửa thông tin thủ thư thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaTT.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
                 txtDiaChi.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    XoaThuThu();
                    MessageBox.Show("Xóa thông tin thủ thư thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            rdbNam.IsChecked = false;
            rdbNu.IsChecked = false;
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtHoTen.Focus();
        }

        private void rdbButton_Checked(object sender, RoutedEventArgs e)
        {
            var btn = sender as RadioButton;
            gender = btn.Content.ToString();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dataGrid.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                tblThuThu tt = (tblThuThu)dataGrid.SelectedItem;
                txtMaTT.Text = tt.MaTT.ToString();
                txtHoTen.Text = tt.HoTenTT.ToString();
                if (tt.GioiTinhTT == "Nam")
                {
                    rdbNam.IsChecked = true;
                    rdbNu.IsChecked = false;
                }
                else
                {
                    rdbNam.IsChecked = false;
                    rdbNu.IsChecked = true;
                }
                txtNgaySinh.Text = tt.NgaySinhTT.ToString();
                txtSDT.Text = tt.SdtTT.ToString();
                txtDiaChi.Text = tt.DiaChiTT.ToString();
                expThuThu.IsExpanded = true;
            }
        }

        public string TangMaTuDong()
        {
            
            string maTuDong = "";
            if (dataGrid.Items.Count <= 0)
            {
                maTuDong = "TT001";
            }
            else
            {
                maTuDong = "TT";
                int k = dataGrid.Items.Count + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }
        private void LayDuLieu()
        {
            dataGrid.ItemsSource = database.tblThuThus.Select(item => item);
        }
        private void ThemThuThu()
        {
            tblThuThu tt = new tblThuThu();
            tt.MaTT = txtMaTT.Text.Trim();
            tt.HoTenTT = txtHoTen.Text.Trim();
            tt.GioiTinhTT = gender;
            tt.NgaySinhTT = DateTime.Parse(txtNgaySinh.Text);
            tt.SdtTT = txtSDT.Text.Trim();
            tt.DiaChiTT = txtDiaChi.Text.Trim();
            tt.MatKhauTT = txtMaTT.Text.Trim();
            database.tblThuThus.InsertOnSubmit(tt);
            database.SubmitChanges();
        }

        private void SuaThuThu()
        {
            tblThuThu tt = database.tblThuThus.Single(item => item.MaTT == txtMaTT.Text);
            tt.HoTenTT = txtHoTen.Text.Trim();
            tt.GioiTinhTT = gender;
            tt.NgaySinhTT = DateTime.Parse(txtNgaySinh.Text);
            tt.SdtTT = txtSDT.Text.Trim();
            tt.DiaChiTT = txtDiaChi.Text.Trim();
            tt.MatKhauTT = txtMaTT.Text.Trim();
            database.SubmitChanges();
        }

        private void XoaThuThu()
        {
            tblThuThu tt = database.tblThuThus.Single(item => item.MaTT == txtMaTT.Text);
            database.tblThuThus.DeleteOnSubmit(tt);
            database.SubmitChanges();
        }
    }
}
