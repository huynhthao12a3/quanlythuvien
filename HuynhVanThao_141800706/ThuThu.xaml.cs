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
    /// Interaction logic for ThuThu.xaml
    /// </summary>
    public partial class ThuThu : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public string maTT = "";
        public ThuThu()
        {
            InitializeComponent();
        }

        public ThuThu(string text) : this()
        {
            maTT = text;
            chip.Content = database.tblThuThus.Where(item => item.MaTT == maTT).Select(item => item.HoTenTT).SingleOrDefault();

        }
        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow form = new MainWindow();
            form.Show();
        }

        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Collapsed;
            btnCloseMenu.Visibility = Visibility.Visible;
        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Visible;
            btnCloseMenu.Visibility = Visibility.Collapsed;
        }
        private void TTCN_Click(object sender, RoutedEventArgs e)
        {
            ThongTinCaNhan form = new ThongTinCaNhan(maTT);
            form.ShowDialog();
            
        }
        private void QLSV_Click(object sender, RoutedEventArgs e)
        {
            QuanLySinhVien form = new QuanLySinhVien();
            form.ShowDialog();
        }

        private void QLTT_Click(object sender, RoutedEventArgs e)
        {
            QuanLyThuThu form = new QuanLyThuThu();
            form.ShowDialog();
        }

        private void QLS_Click(object sender, RoutedEventArgs e)
        {
            QuanLySach form = new QuanLySach();
            form.ShowDialog();
        }

        private void QLTG_Click(object sender, RoutedEventArgs e)
        {
            QuanLyTacGia form = new QuanLyTacGia();
            form.ShowDialog();
        }

        private void QLCD_Click(object sender, RoutedEventArgs e)
        {
            QuanLyChuDe form = new QuanLyChuDe();
            form.ShowDialog();
        }
    }
}
