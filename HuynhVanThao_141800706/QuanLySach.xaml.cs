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
    /// Interaction logic for QuanLySach.xaml
    /// </summary>
    public partial class QuanLySach : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public QuanLySach()
        {
            InitializeComponent();
            LayDuLieu();
            cmbChuDe.ItemsSource = database.tblChuDes.Select(item => item.TenChuDe);
            cmbTacGia.ItemsSource = database.tblTacGias.Select(item => item.TenTacGia);
        }       

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LayDuLieu()
        {
            dtgSach.ItemsSource = from a in database.tblSaches
                                  join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                  select new { a.MaSach,a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB,a.SoLuong,a.DonGia,b.KhuVuc, b.KeSach, b.OSach };
            cmbMaSach.ItemsSource = database.tblSaches.Select(item => item.MaSach);
            cmbMaSach.SelectedIndex = 0;

        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbiMaSach.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.MaSach.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
            if (cbiTenSach.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.TenSach.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
            if (cbiChuDe.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.ChuDe.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
            if (cbiTacGia.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.TacGia.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
            if (cbiNhaXB.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.NhaXB.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
            if (cbiNamXB.IsSelected == true)
            {
                dtgSach.ItemsSource = from a in database.tblSaches
                                      join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                      where a.NamXB.Contains(txtTimKiem.Text)
                                      select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
            }
        }

        private void cmbTimKiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void SetControlOpen()
        {
            cmbMaSach.IsEnabled = true;
            txtTenSach.IsEnabled = true;
            cmbChuDe.IsEnabled = true;
            cmbTacGia.IsEnabled = true;
            txtNhaXuatBan.IsEnabled = true;
            txtNamXuatBan.IsEnabled = true;
            txtSoLuong.IsEnabled = true;
            txtDonGia.IsEnabled = true;
            txtMaViTri.IsEnabled = true;
            txtKhuVuc.IsEnabled = true;
            txtKeSach.IsEnabled = true;
            txtOSach.IsEnabled = true;
        }
        private void SetControlClose()
        {
            cmbMaSach.IsEnabled = false;
            txtTenSach.IsEnabled = false;
            cmbChuDe.IsEnabled = false;
            cmbTacGia.IsEnabled = false;
            txtNhaXuatBan.IsEnabled = false;
            txtNamXuatBan.IsEnabled = false;
            txtSoLuong.IsEnabled = false;
            txtDonGia.IsEnabled = false;
            txtMaViTri.IsEnabled = false;
            txtKhuVuc.IsEnabled = false;
            txtKeSach.IsEnabled = false;
            txtOSach.IsEnabled = false;
        }

        private void btnThemSach_Click(object sender, RoutedEventArgs e)
        {
            SetControlOpen();
            cmbMaSach.Text = TangMaSachTuDong();
            txtMaViTri.Text = TangMaViTriTuDong();
            cmbMaSach.IsEnabled = false;
            txtMaViTri.IsEnabled = false;
            btnLuuThemSach.Visibility = Visibility.Visible;
            btnThemSach.Visibility = Visibility.Hidden;
            btnSuaSach.IsEnabled = false;
            btnXoaSach.IsEnabled = false;
        }

        private void btnSuaSach_Click(object sender, RoutedEventArgs e)
        {
            SetControlOpen();
            btnLuuSuaSach.Visibility = Visibility.Visible;
            btnSuaSach.Visibility = Visibility.Hidden;
            btnThemSach.IsEnabled = false;
            btnXoaSach.IsEnabled = false;

        }

        private void btnXoaSach_Click(object sender, RoutedEventArgs e)
        {
            cmbMaSach.IsEnabled = true;
            btnLuuXoaSach.Visibility = Visibility.Visible;
            btnXoaSach.Visibility = Visibility.Hidden;
            btnSuaSach.IsEnabled = false;
            btnThemSach.IsEnabled = false;
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            SetControlClose();
            LamMoi();

        }

        private void cmbMaSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = cmbMaSach.SelectedItem as string;
            txtTenSach.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.TenSach).SingleOrDefault();
            cmbChuDe.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.ChuDe).SingleOrDefault();
            cmbTacGia.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.TacGia).SingleOrDefault();
            txtSoLuong.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.SoLuong).SingleOrDefault();
            txtNhaXuatBan.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.NhaXB).SingleOrDefault();
            txtNamXuatBan.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.NamXB).SingleOrDefault();
            txtDonGia.Text = database.tblSaches.Where(item => item.MaSach == value).Select(item => item.DonGia).SingleOrDefault();

            txtMaViTri.Text = database.tblViTriSaches.Where(item => item.MaSach == value).Select(item => item.MaViTri).SingleOrDefault();
            txtKhuVuc.Text = database.tblViTriSaches.Where(item => item.MaSach == value).Select(item => item.KhuVuc).SingleOrDefault();
            txtKeSach.Text = database.tblViTriSaches.Where(item => item.MaSach == value).Select(item => item.KeSach).SingleOrDefault();
            txtOSach.Text = database.tblViTriSaches.Where(item => item.MaSach == value).Select(item => item.OSach).SingleOrDefault();
           
        }

        private void btnLuuThemSach_Click(object sender, RoutedEventArgs e)
        {
            if(KiemTraTrong() == false)
            {
                ThemSach();
                LamMoi();
                SetControlClose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnLuuSuaSach_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == false)
            {
                SuaSach();
                LamMoi();
                SetControlClose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnLuuXoaSach_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == false)
            {
                XoaSach();
                LamMoi();
                SetControlClose();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private string TangMaSachTuDong()
        {

            string maTuDong = "";

            if (database.tblSaches.Count() <= 0)
            {
                maTuDong = "MS001";
            }
            else
            {
                maTuDong = "MS";
                int k = database.tblSaches.Count() + 1;
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
        private string TangMaViTriTuDong()
        {

            string maTuDong = "";

            if (database.tblSaches.Count() <= 0)
            {
                maTuDong = "VT001";
            }
            else
            {
                maTuDong = "VT";
                int k = database.tblSaches.Count() + 1;
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
        private void ThemSach()
        {     
            tblSach sach = new tblSach();
            sach.MaSach = cmbMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.ChuDe = cmbChuDe.Text;
            sach.TacGia = cmbTacGia.Text;
            sach.NhaXB = txtNhaXuatBan.Text;
            sach.NamXB = txtNamXuatBan.Text;
            sach.SoLuong = txtSoLuong.Text;
            sach.DonGia = txtDonGia.Text;

            tblViTriSach vt = new tblViTriSach();
            vt.MaViTri = txtMaViTri.Text;
            vt.MaSach = cmbMaSach.Text;
            vt.KhuVuc = txtKhuVuc.Text;
            vt.KeSach = txtKeSach.Text;
            vt.OSach = txtOSach.Text;

            database.tblSaches.InsertOnSubmit(sach);
            database.tblViTriSaches.InsertOnSubmit(vt);

            database.SubmitChanges();
            MessageBox.Show("Thêm thông tin sách thành công.", "Thông Báo",MessageBoxButton.OK,MessageBoxImage.Information);
            LayDuLieu();
        }

        private void SuaSach()
        {
            tblSach sach = database.tblSaches.Single(item => item.MaSach == cmbMaSach.Text);
            sach.MaSach = cmbMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.ChuDe = cmbChuDe.Text;
            sach.TacGia = cmbTacGia.Text;
            sach.NhaXB = txtNhaXuatBan.Text;
            sach.NamXB = txtNamXuatBan.Text;
            sach.SoLuong = txtSoLuong.Text;
            sach.DonGia = txtDonGia.Text;

            tblViTriSach vt = database.tblViTriSaches.Single(item => item.MaViTri == txtMaViTri.Text);
            vt.MaViTri = txtMaViTri.Text;
            vt.MaSach = cmbMaSach.Text;
            vt.KhuVuc = txtKhuVuc.Text;
            vt.KeSach = txtKeSach.Text;
            vt.OSach = txtOSach.Text;

            database.SubmitChanges();
            MessageBox.Show("Sửa thông tin sách thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LayDuLieu();
        }

        private void XoaSach()
        {
            tblSach sach = database.tblSaches.Single(item => item.MaSach == cmbMaSach.Text);
            tblViTriSach vt = database.tblViTriSaches.Single(item => item.MaViTri == txtMaViTri.Text);
            try
            {
                database.tblSaches.DeleteOnSubmit(sach);
                database.tblViTriSaches.DeleteOnSubmit(vt);
                database.SubmitChanges();
                MessageBox.Show("Xóa thông tin sách thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
                LayDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            
        }
        private bool KiemTraTrong()
        {
            if(cmbMaSach.Text == "" || txtTenSach.Text == "" || cmbChuDe.Text == "" || cmbTacGia.Text == "" 
                || txtSoLuong.Text == "" || txtNhaXuatBan.Text == "" || txtNamXuatBan.Text == "" || txtDonGia.Text == "")
            {
                return true;
            }
            return false;
        }

        private void LamMoi()
        {
            btnLuuThemSach.Visibility = Visibility.Hidden;
            btnLuuSuaSach.Visibility = Visibility.Hidden;
            btnLuuXoaSach.Visibility = Visibility.Hidden;
            btnThemSach.Visibility = Visibility.Visible;
            btnSuaSach.Visibility = Visibility.Visible;
            btnXoaSach.Visibility = Visibility.Visible;
            btnThemSach.IsEnabled = true;
            btnSuaSach.IsEnabled = true;
            btnXoaSach.IsEnabled = true;
            cmbMaSach.SelectedIndex = -1;
            txtTenSach.Clear();
            cmbChuDe.SelectedIndex = -1;
            cmbTacGia.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtNhaXuatBan.Clear();
            txtNamXuatBan.Clear();
            txtDonGia.Clear();
            txtMaViTri.Clear();
            txtKhuVuc.Clear();
            txtKeSach.Clear();
            txtOSach.Clear();
        }

       
    }
}
