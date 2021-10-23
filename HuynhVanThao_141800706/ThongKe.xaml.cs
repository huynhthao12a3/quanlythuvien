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
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : Window
    {
        QLTVDataContext database = new QLTVDataContext();
        public ThongKe()
        {
            InitializeComponent();
            TongSoLuongSach();
            
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void TongSoLuongSach()
        {
            string soLuong = database.sp_TongSoLuongSach().Select(item => item.SLSach).SingleOrDefault().ToString();
            if (soLuong.Length == 4)
            {
                string sl = soLuong.Insert(1, ".");
                lblTongSL.Content = sl;
            }
            if (soLuong.Length == 5)
            {
                string sl = soLuong.Insert(2, ".");
                lblTongSL.Content = sl;
            }

        }
    }
}
