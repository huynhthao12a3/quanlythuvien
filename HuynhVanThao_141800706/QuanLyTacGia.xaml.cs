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
    /// Interaction logic for QuanLyTacGia.xaml
    /// </summary>
    public partial class QuanLyTacGia : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public QuanLyTacGia()
        {
            InitializeComponent();
            dtgTacGia.ItemsSource = database.tblTacGias.Select(item => item);
            cmbTenTG.ItemsSource = database.tblTacGias.Select(item => item.TenTacGia);
        }
        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }     
        private void dtgTacGia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tblTacGia tg = (tblTacGia)dtgTacGia.SelectedItem;
            txbTenTG.Text = tg.GhiChu;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if(KiemTraTrong() == false)
            {
                ThemTG();
                LayDuLieu();
                cmbTenTG.Text = "";
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
                SuaTG();
                LayDuLieu();
                cmbTenTG.Text = "";
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
                XoaTG();
                LayDuLieu();
                cmbTenTG.Text = "";
                txtGhiChu.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }      
        private void cmbTenTG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbTenTG.SelectedIndex >= 0)
            {
                tblTacGia tg = database.tblTacGias.Where(item => item.TenTacGia == cmbTenTG.SelectedItem as string).SingleOrDefault();
                txtGhiChu.Text = tg.GhiChu;
            }
            else
            {
                return;
            }            
        }
        private void LayDuLieu()
        {
            dtgTacGia.ItemsSource = database.tblTacGias.Select(item => item);
            dtgTacGia.SelectedIndex = 0;
            cmbTenTG.ItemsSource = database.tblTacGias.Select(item => item.TenTacGia);
        }
        private bool KiemTraTrong()
        {
            if(cmbTenTG.Text == "" || txtGhiChu.Text == "")
            {
                return true;
            }
            return false;
        }
        private void ThemTG()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn thêm tác giả hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                tblTacGia tg = new tblTacGia();
                tg.TenTacGia = cmbTenTG.Text;
                tg.GhiChu = txtGhiChu.Text;
                database.tblTacGias.InsertOnSubmit(tg);
                database.SubmitChanges();
                MessageBox.Show("Thêm tác giả thành công.", "Thông Tin", MessageBoxButton.OK,MessageBoxImage.Information);
            }            
        }
        private void SuaTG()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn sửa thông tin tác giả hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblTacGia tg = database.tblTacGias.Where(item => item.TenTacGia == cmbTenTG.SelectedItem as string).SingleOrDefault();
                tg.GhiChu = txtGhiChu.Text;
                database.SubmitChanges();
                MessageBox.Show("Sửa thông tin tác giả thành công.", "Thông Tin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void XoaTG()
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa thông tin tác giả hiện tại không ?", "Xác Nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tblTacGia tg = database.tblTacGias.Where(item => item.TenTacGia == cmbTenTG.SelectedItem as string).SingleOrDefault();
                database.tblTacGias.DeleteOnSubmit(tg);
                database.SubmitChanges();
                MessageBox.Show("Xóa thông tin tác giả thành công.", "Thông Tin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
