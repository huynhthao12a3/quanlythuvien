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
        public QuanLyPhieuMuon()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
