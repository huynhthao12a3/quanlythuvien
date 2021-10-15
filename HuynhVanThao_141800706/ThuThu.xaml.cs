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
        public ThuThu()
        {
            InitializeComponent();
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

        
    }
}
