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
    /// Interaction logic for QuanLyPhieuMuon.xaml
    /// </summary>
    public partial class QuanLyPhieuMuon : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public string maTT = "";
        public QuanLyPhieuMuon()
        {
            InitializeComponent();
            LayDuLieu();
            cmbLSMaSV.ItemsSource = database.tblSinhViens.Select(item => item.MaSV);
        }
        public QuanLyPhieuMuon(string text) : this()
        {
            maTT = text;
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMuonMoi_Click(object sender, RoutedEventArgs e)
        {
            SetControlTrueMuon();
            btnMuonMoi.IsEnabled = false;
            btnChoMuon.IsEnabled = true;
            btnGiaHan.IsEnabled = false;
            btnHuyBo.IsEnabled = true;
            dtgMuonSach.IsEnabled = false;
            txtMaPM.Text = TangMaTuDong();
            cmbMaSV.ItemsSource = database.tblSinhViens.Select(item => item.MaSV);
            cmbMaSach.ItemsSource = database.tblSaches.Select(item => item.MaSach);
            txtNguoiLap.Text = maTT;
            cmbMaSV.Text = "";
            cmbMaSach.Text = "";
            txtSoLuongMuon.Clear();
            dpNgayMuon.Text = "";
            dpNgayTra.Text = "";
            txtGhiChu.Clear();
        }

        private void btnChoMuon_Click(object sender, RoutedEventArgs e)
        {
            if(KiemTraTrong() == true)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                ThemPhieuMuon();
                GiamSoLuongSach(cmbMaSach.Text, Convert.ToInt32(txtSoLuongMuon.Text));
                LayDuLieu();
                SetControlFalseMuon();
                btnMuonMoi.IsEnabled = true;
                btnChoMuon.IsEnabled = false;
                btnGiaHan.IsEnabled = false;
                btnHuyBo.IsEnabled = false;
                dtgMuonSach.IsEnabled = true;
            }
        }

        private void btnGiaHan_Click(object sender, RoutedEventArgs e)
        {
            btnMuonMoi.IsEnabled = false;
            btnGiaHan.IsEnabled = false;
            btnHoanTat.Visibility = Visibility.Visible;
            btnHuyBo.IsEnabled = true;
            dtgMuonSach.IsEnabled = false;
            dpNgayTra.IsEnabled = true;
        }
        private void btnHoanTat_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == true)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                GiaHanPhieuMuon();
                LayDuLieu();
                dpNgayTra.IsEnabled = false;
                btnMuonMoi.IsEnabled = true;
                btnChoMuon.IsEnabled = false;
                btnGiaHan.IsEnabled = false;
                btnHoanTat.Visibility = Visibility.Hidden;
                btnHuyBo.IsEnabled = false;
                dtgMuonSach.IsEnabled = true;
            }

        }
        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            SetControlFalseMuon();
            btnMuonMoi.IsEnabled = true;
            btnChoMuon.IsEnabled = false;
            btnGiaHan.IsEnabled = false;
            btnHoanTat.Visibility = Visibility.Hidden;
            btnHuyBo.IsEnabled = false;
            dtgMuonSach.IsEnabled = true;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dtgMuonSach.ItemsSource = database.sp_TimKiemTheoMa(txtTimKiem.Text);
        }

        private void btnTraSach_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn trả sách không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblPhieuMuon pm = database.tblPhieuMuons.Where(item => item.MaPhieuMuon == txtMaPM1.Text).SingleOrDefault();
                pm.NgayTra = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                pm.GhiChu = "Đã trả sách";
                database.SubmitChanges();
                TangSoLuongSach(cmbMaSach1.Text, Convert.ToInt32(txtSoLuongMuon1.Text));
                LayDuLieu();
                btnTraSach.IsEnabled = false;
                MessageBox.Show("Trả sách thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
        private void txtTimKiem1_KeyUp(object sender, KeyEventArgs e)
        {
            dtgTraSach.ItemsSource = database.sp_TimKiemTheoMa(txtTimKiem1.Text);
        }


        private void LayDuLieu()
        {
            dtgMuonSach.ItemsSource = database.tblPhieuMuons.Where(item => item.GhiChu != "Đã trả sách").Select(item => item);
            dtgTraSach.ItemsSource = database.tblPhieuMuons.Where(item => item.GhiChu != "Đã trả sách").Select(item => item);
        }

        private void dtgMuonSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgMuonSach.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                tblPhieuMuon pm = (tblPhieuMuon)dtgMuonSach.SelectedItem;
                txtMaPM.Text = pm.MaPhieuMuon.ToString();
                cmbMaSV.Text = pm.MaSV.ToString();
                cmbMaSach.Text = pm.MaSach.ToString();
                txtNguoiLap.Text = pm.NguoiLap.ToString();
                txtSoLuongMuon.Text = pm.SoLuong.ToString();
                dpNgayMuon.Text = pm.NgayMuon.ToString();
                dpNgayTra.Text = pm.NgayTra.ToString();
                txtGhiChu.Text = pm.GhiChu.ToString();

                txtTenSach.Text = database.tblSaches.Where(item => item.MaSach == cmbMaSach.Text).Select(item => item.TenSach).SingleOrDefault();
                txtChuDe.Text = database.tblSaches.Where(item => item.MaSach == cmbMaSach.Text).Select(item => item.ChuDe).SingleOrDefault();
                txtTacGia.Text = database.tblSaches.Where(item => item.MaSach == cmbMaSach.Text).Select(item => item.TacGia).SingleOrDefault();

                btnGiaHan.IsEnabled = true;
            }
        }
        private void dtgTraSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgTraSach.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                tblPhieuMuon pm = (tblPhieuMuon)dtgTraSach.SelectedItem;
                txtMaPM1.Text = pm.MaPhieuMuon.ToString();
                cmbMaSV1.Text = pm.MaSV.ToString();
                cmbMaSach1.Text = pm.MaSach.ToString();
                txtNguoiLap1.Text = pm.NguoiLap.ToString();
                txtSoLuongMuon1.Text = pm.SoLuong.ToString();
                dpNgayMuon1.Text = pm.NgayMuon.ToString();
                dpNgayTra1.Text = pm.NgayTra.ToString();
                txtGhiChu1.Text = pm.GhiChu.ToString();

                btnTraSach.IsEnabled = true;
            }
        }
        private void cmbLSMaSV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbLSMaSV.SelectedIndex >= 0)
            {
                tblSinhVien sv = database.tblSinhViens.Where(item => item.MaSV == cmbLSMaSV.SelectedItem as string).SingleOrDefault();
                txtLSTenSV.Text = sv.HoTenSV;

                dtgLSMuon.ItemsSource = from a in database.tblPhieuMuons
                                        join b in database.tblSaches on a.MaSach equals b.MaSach
                                        where a.MaSV == cmbLSMaSV.SelectedItem as string && a.GhiChu != "Đã trả sách"
                                        select new { a.MaPhieuMuon, a.MaSach, a.NgayMuon, b.TenSach };
                dtgLSTra.ItemsSource = from a in database.tblPhieuMuons
                                        join b in database.tblSaches on a.MaSach equals b.MaSach
                                        where a.MaSV == cmbLSMaSV.SelectedItem as string && a.GhiChu == "Đã trả sách"
                                        select new { a.MaPhieuMuon, a.MaSach, a.NgayTra, b.TenSach };
            }
            else
            {
                return;
            }
        }
        private void SetControlTrueMuon()
        {
            cmbMaSV.IsEnabled = true;
            cmbMaSach.IsEnabled = true;
            txtSoLuongMuon.IsEnabled = true;
            dpNgayMuon.IsEnabled = true;
            dpNgayTra.IsEnabled = true;
            txtGhiChu.IsEnabled = true;
        }
        private void SetControlFalseMuon()
        {
            cmbMaSV.IsEnabled = false;
            cmbMaSach.IsEnabled = false;
            txtSoLuongMuon.IsEnabled = false;
            dpNgayMuon.IsEnabled = false;
            dpNgayTra.IsEnabled = false;
            txtGhiChu.IsEnabled = false;
        }
        public string TangMaTuDong()
        {
            int count = database.tblPhieuMuons.Select(item => item).Count();
            string maTuDong = "";
            if (count <= 0)
            {
                maTuDong = "PM001";
            }
            else
            {
                maTuDong = "PM";
                int k = count + 1;
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
        private bool KiemTraTrong()
        {
            if(cmbMaSV.Text == "" || cmbMaSach.Text == "" || txtSoLuongMuon.Text == "" 
                || dpNgayMuon.Text == "" || dpNgayTra.Text == "" || txtGhiChu.Text == "")
            {
                return true;
            }
            return false;
        }
        private void ThemPhieuMuon()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu mượn mới không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblPhieuMuon pm = new tblPhieuMuon();
                pm.MaPhieuMuon = txtMaPM.Text;
                pm.MaSV = cmbMaSV.Text;
                pm.MaSach = cmbMaSach.Text;
                pm.NguoiLap = txtNguoiLap.Text;
                pm.SoLuong = txtSoLuongMuon.Text;
                pm.NgayMuon = Convert.ToDateTime(dpNgayMuon.Text);
                pm.NgayTra = Convert.ToDateTime(dpNgayTra.Text);
                pm.GhiChu = txtGhiChu.Text;
                database.tblPhieuMuons.InsertOnSubmit(pm);
                database.SubmitChanges();
                MessageBox.Show("Tạo phiếu mượn thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }           
        }
        private void GiaHanPhieuMuon()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn gia hạn không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblPhieuMuon pm = database.tblPhieuMuons.Single(item => item.MaPhieuMuon == txtMaPM.Text);
                pm.NgayTra = Convert.ToDateTime(dpNgayTra.Text);
                database.SubmitChanges();
                MessageBox.Show("Gia hạn thành công.", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void GiamSoLuongSach(string maSach,int soLuong)
        {
            tblSach sach = database.tblSaches.Single(item => item.MaSach == maSach);
            int slSach = Convert.ToInt32(sach.SoLuong) - soLuong;
            sach.SoLuong = Convert.ToString(slSach);
            database.SubmitChanges();
        }
        private void TangSoLuongSach(string maSach, int soLuong)
        {
            tblSach sach = database.tblSaches.Single(item => item.MaSach == maSach);
            int slSach = Convert.ToInt32(sach.SoLuong) + soLuong;
            sach.SoLuong = Convert.ToString(slSach);
            database.SubmitChanges();
        }
   

        
    }
}
