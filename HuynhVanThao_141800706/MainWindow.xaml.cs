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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HuynhVanThao_141800706
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DangNhap form = new DangNhap();
            form.Show();
        }

        private void DangKy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DangKy form = new DangKy();
            form.Show();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            image.Visibility = Visibility.Hidden;
        }
    }
}
