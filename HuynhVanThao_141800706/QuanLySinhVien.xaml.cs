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
    /// Interaction logic for QuanLySinhVien.xaml
    /// </summary>
    public partial class QuanLySinhVien : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public string gender = "";
        public QuanLySinhVien()
        {
            InitializeComponent();
            LayDuLieu();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaSV.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
                txtLop.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);                
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn thêm không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ThemSinhVien();
                    MessageBox.Show("Thêm thông tin sinh viên thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }    
            }           
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaSV.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
                txtLop.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn sửa không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    SuaSinhVien();
                    MessageBox.Show("Sửa thông tin sinh viên thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }        
            }     
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaSV.Text == "" || txtHoTen.Text == "" || (rdbNam.IsChecked == false && rdbNu.IsChecked == false) ||
               txtLop.Text == "" || txtNgaySinh.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(result == MessageBoxResult.Yes)
                {
                    XoaSinhVien();
                    MessageBox.Show("Xóa thông tin sinh viên thành công", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information); ;
                    LayDuLieu();
                }           
            } 
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtLop.Text = "";
            rdbNam.IsChecked = false;
            rdbNu.IsChecked = false;
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtMaSV.Focus();
        }

        private void LayDuLieu()
        {
            dataGrid.ItemsSource = from sv in database.GetTable<tblSinhVien>() select sv;
        }

        private void rdbButton_Checked(object sender, RoutedEventArgs e)
        {
            var btn = sender as RadioButton;
            gender = btn.Content.ToString();
        }

        private void ThemSinhVien()
        {
            tblSinhVien sv = new tblSinhVien();
            sv.MaSV = txtMaSV.Text.Trim();
            sv.HoTenSV = txtHoTen.Text.Trim();
            sv.Lop = txtLop.Text.Trim();
            sv.GioiTinhSV = gender;
            sv.NgaySinhSV = DateTime.Parse(txtNgaySinh.Text);
            sv.SdtSV = txtSDT.Text.Trim();
            sv.MatKhauSV = txtMaSV.Text.Trim();
            database.tblSinhViens.InsertOnSubmit(sv);
            database.SubmitChanges();
        }

        private void SuaSinhVien()
        {
            tblSinhVien sv = database.tblSinhViens.Single(item => item.MaSV == txtMaSV.Text);
            sv.HoTenSV = txtHoTen.Text.Trim();
            sv.Lop = txtLop.Text.Trim();
            sv.GioiTinhSV = gender;
            sv.NgaySinhSV = DateTime.Parse(txtNgaySinh.Text);
            sv.SdtSV = txtSDT.Text.Trim();
            sv.MatKhauSV = txtMaSV.Text.Trim();
            database.SubmitChanges();
        }

        private void XoaSinhVien()
        {
            tblSinhVien sv = database.tblSinhViens.Single(item => item.MaSV == txtMaSV.Text);
            database.tblSinhViens.DeleteOnSubmit(sv);
            database.SubmitChanges();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dataGrid.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                //DataGrid dataGrid = sender as DataGrid;
                //DataRowView rowView = dataGrid.SelectedItem as DataRowView;
                //txtMaSV.Text = rowView.Row[0].ToString();

                tblSinhVien sv = (tblSinhVien)dataGrid.SelectedItem;
                txtMaSV.Text = sv.MaSV.ToString();
                txtHoTen.Text = sv.HoTenSV.ToString();
                txtLop.Text = sv.Lop.ToString();
                if (sv.GioiTinhSV == "Nam")
                {
                    rdbNam.IsChecked = true;
                    rdbNu.IsChecked = false;
                }
                else
                {
                    rdbNam.IsChecked = false;
                    rdbNu.IsChecked = true;
                }
                txtNgaySinh.Text = sv.NgaySinhSV.ToString();
                txtSDT.Text = sv.SdtSV.ToString();
                expSinhVien.IsExpanded = true;
            }
            
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            if(txtTKMaSV.Text != "" && txtTKHoTenSV.Text == "")
            {
                dataGrid.ItemsSource = database.tblSinhViens.Where(sv => sv.MaSV.Contains(txtTKMaSV.Text.Trim()));
                //dataGrid.ItemsSource = database.sp_TimKiemMaSV(txtTKMaSV.Text.Trim());
            }
            else if (txtTKMaSV.Text == "" && txtTKHoTenSV.Text != "")
            {
                dataGrid.ItemsSource = database.tblSinhViens.Where(sv => sv.HoTenSV.Contains(txtTKHoTenSV.Text.Trim()));
                //dataGrid.ItemsSource = database.sp_TimKiemHoTenSV(txtTKHoTenSV.Text.Trim());
            }
            else
            {
                dataGrid.ItemsSource = database.tblSinhViens.Where(sv => sv.MaSV.Contains(txtTKMaSV.Text.Trim()) && sv.HoTenSV.Contains(txtTKHoTenSV.Text.Trim()) );
                //dataGrid.ItemsSource = database.sp_TimKiemCa2(txtTKMaSV.Text.Trim(),txtTKHoTenSV.Text.Trim());
            }
        }
    }
}
