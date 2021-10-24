using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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
using LiveCharts;
using LiveCharts.Wpf;
using InteractiveDataDisplay.WPF;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Microsoft.Win32;

namespace HuynhVanThao_141800706
{
    /// <summary>
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : System.Windows.Window
    {


        QLTVDataContext database = new QLTVDataContext();
        public ThongKe()
        {
            InitializeComponent();
            TongSoLuongSach();
            TongGiaTriSach();
            SoLuongSachDangMuon();
            SoLuongSachDaMuon();
            SoLuongDGDangMuon();
            SoLuongDGQuaHan();
            dtgDSDGQH.ItemsSource = database.tblPhieuMuons.Where(item => item.GhiChu != "Đã trả sách" && item.NgayTra < DateTime.Now);
        }
       
        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            image.Visibility = Visibility.Hidden;
        }
        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            XuatDuLieuRaExcel();
        }
        private void TongSoLuongSach()
        {
            string soLuong = database.sp_TongSoLuongSach().Select(item => item.SLSach).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblTongSL.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblTongSL.Content = sl1;
                }
                else
                {
                    lblTongSL.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgay.Content = "Tính đến ngày " + ngay;
        }
        private void TongGiaTriSach()
        {
            string soLuong = database.sp_TongGiaTriSach().Select(item => item.GiaTri).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblTongGiaTri.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblTongGiaTri.Content = sl1;
                }
                else
                {
                    lblTongGiaTri.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgay0.Content = "Tính đến ngày " + ngay;
        }
        private void SoLuongSachDangMuon()
        {
            string soLuong = database.sp_SoLuongSachDangMuon().Select(item => item.SLMuon).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblSachDangMuon.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblSachDangMuon.Content = sl1;
                }
                else
                {
                    lblSachDangMuon.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgay1.Content = "Tính đến ngày " + ngay;
        }
        private void SoLuongSachDaMuon()
        {
            string soLuong = database.sp_SoLuongSachDaMuon().Select(item => item.SLMuon).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblSachDaMuon.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblSachDaMuon.Content = sl1;
                }
                else
                {
                    lblSachDaMuon.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgay2.Content = "Tính đến ngày " + ngay;
        }
        private void SoLuongDGDangMuon()
        {

            string soLuong = database.sp_SoLuongDGDangMuon().Select(item => item.Column1).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblSLDocGiaMuon.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblSLDocGiaMuon.Content = sl1;
                }
                else
                {
                    lblSLDocGiaMuon.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgayDG.Content = "Tính đến ngày " + ngay;
        }
        private void SoLuongDGQuaHan()
        {

            string soLuong = database.sp_SoLuongDGQuaHan().Select(item => item.SQLDGQuaHan).SingleOrDefault().ToString();
            if (soLuong.Length > 3 && soLuong.Length <= 6)
            {
                string sl = soLuong.Insert(soLuong.Length - 3, ".");
                lblSLDocGiaQuaHan.Content = sl;
            }
            else
            {
                if (soLuong.Length > 6)
                {
                    string sl = soLuong.Insert(soLuong.Length - 3, ".");
                    string sl1 = sl.Insert(soLuong.Length - 6, ".");
                    lblSLDocGiaQuaHan.Content = sl1;
                }
                else
                {
                    lblSLDocGiaQuaHan.Content = soLuong;
                }
            }
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            lblNgayDGQH.Content = "Tính đến ngày " + ngay;
        }
        private void XuatDuLieuRaExcel()
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == true)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Huỳnh Văn Thảo - 141800706";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Báo cáo thống kê";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Thống kê");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = "Danh sách quá hạn";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";
                    ws.Columns.Width = 20;
                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {"Mã phiếu mượn","Mã sinh viên","Mã sách","Người lập","Số lượng mượn","Ngày mượn","Ngày trả","Ghi chú"};

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Thống kê danh sách độc giả quá hạn";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;
                    
                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    IEnumerable<tblPhieuMuon> danhsach = database.tblPhieuMuons.Where(item => item.GhiChu != "Đã trả sách" && item.NgayTra < DateTime.Now);

                // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                foreach (var item in danhsach)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.MaPhieuMuon.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = item.MaSV.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = item.MaSach.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = item.NguoiLap.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = item.SoLuong.ToString();

                        // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        ws.Cells[rowIndex, colIndex++].Value = item.NgayMuon.ToShortDateString();
                        ws.Cells[rowIndex, colIndex++].Value = item.NgayTra.ToShortDateString();

                        ws.Cells[rowIndex, colIndex++].Value = item.GhiChu;


                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!","Thông Báo",MessageBoxButton.OK,MessageBoxImage.Information);
        }     
    }
}
