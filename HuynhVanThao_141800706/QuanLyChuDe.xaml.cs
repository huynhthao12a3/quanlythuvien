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
    /// Interaction logic for QuanLyChuDe.xaml
    /// </summary>
    public partial class QuanLyChuDe : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public QuanLyChuDe()
        {
            InitializeComponent();
            dtgChuDe.ItemsSource = database.tblChuDes.Select(item => item);
            cmbTenCD.ItemsSource = database.tblChuDes.Select(item => item.TenChuDe);
        }
        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void dtgChuDe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tblChuDe cd = (tblChuDe)dtgChuDe.SelectedItem;
            txbTenCD.Text = cd.GhiChu;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == false)
            {
                ThemCD();
                LayDuLieu();
                cmbTenCD.Text = "";
                txtGhiChu.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == false)
            {
                SuaCD();
                LayDuLieu();
                cmbTenCD.Text = "";
                txtGhiChu.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraTrong() == false)
            {
                XoaCD();
                LayDuLieu();
                cmbTenCD.Text = "";
                txtGhiChu.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void cmbTenCD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTenCD.SelectedIndex >= 0)
            {
                tblChuDe cd = database.tblChuDes.Where(item => item.TenChuDe == cmbTenCD.SelectedItem as string).SingleOrDefault();
                txtGhiChu.Text = cd.GhiChu;
            }
            else
            {
                return;
            }
        }       
        private void LayDuLieu()
        {
            dtgChuDe.ItemsSource = database.tblChuDes.Select(item => item);
            dtgChuDe.SelectedIndex = 0;
            cmbTenCD.ItemsSource = database.tblChuDes.Select(item => item.TenChuDe);
        }
        private bool KiemTraTrong()
        {
            if (cmbTenCD.Text == "" || txtGhiChu.Text == "")
            {
                return true;
            }
            return false;
        }
        private void ThemCD()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn thêm chủ đề hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblChuDe cd = new tblChuDe();
                cd.TenChuDe = cmbTenCD.Text;
                cd.GhiChu = txtGhiChu.Text;
                database.tblChuDes.InsertOnSubmit(cd);
                database.SubmitChanges();
                MessageBox.Show("Thêm chủ đề thành công.", "Thông Tin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void SuaCD()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn sửa thông tin chủ đề hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblChuDe tg = database.tblChuDes.Where(item => item.TenChuDe == cmbTenCD.SelectedItem as string).SingleOrDefault();
                tg.GhiChu = txtGhiChu.Text;
                database.SubmitChanges();
                MessageBox.Show("Sửa thông tin chủ đề thành công.", "Thông Tin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void XoaCD()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa thông tin chủ đề hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblChuDe cd = database.tblChuDes.Where(item => item.TenChuDe == cmbTenCD.SelectedItem as string).SingleOrDefault();
                database.tblChuDes.DeleteOnSubmit(cd);
                database.SubmitChanges();
                MessageBox.Show("Xóa thông tin chủ đề thành công.", "Thông Tin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
