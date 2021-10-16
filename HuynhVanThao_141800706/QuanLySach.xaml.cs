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
        }

        private void TimKiemTenSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKChuDe.Clear();
            txtTKTacGia.Clear();
            dtgSach.ItemsSource = from a in database.tblSaches
                                  join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                  where a.TenSach.Contains(txtTKTenSach.Text)
                                  select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
        }

        private void TimKiemChuDe_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKTenSach.Clear();
            txtTKTacGia.Clear();
            dtgSach.ItemsSource = from a in database.tblSaches
                                  join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                  where a.ChuDe.Contains(txtTKChuDe.Text)
                                  select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
        }

        private void TimKiemTacGia_KeyUp(object sender, KeyEventArgs e)
        {
            txtTKTenSach.Clear();
            txtTKChuDe.Clear();
            dtgSach.ItemsSource = from a in database.tblSaches
                                  join b in database.tblViTriSaches on a.MaSach equals b.MaSach
                                  where a.TacGia.Contains(txtTKTacGia.Text)
                                  select new { a.MaSach, a.TenSach, a.ChuDe, a.TacGia, a.NhaXB, a.NamXB, a.SoLuong, a.DonGia, b.KhuVuc, b.KeSach, b.OSach };
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
            
        }
    }
}
