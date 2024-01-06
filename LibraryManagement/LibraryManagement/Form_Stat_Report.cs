using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QLTV.BUS;
using QLTV.DTO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Diagnostics;


namespace LibraryManagement
{
    public partial class Form_Stat_Report : Form
    {
        private StatAndReportBUS stat;
        private Utils u;
        public Form_Stat_Report()
        {
            InitializeComponent();
            stat = new StatAndReportBUS();
            u = new Utils();
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            Stat();
        }

        private void Stat()
        {
            // Tag Page Thông kê Mượn Sách
            PieChart_SoSachMuon();
            PieChart_DocGia();
            ColumnRevenueOfBook();
            SplineTotalRentInYear();
            ColumnTop5();
            // Tag Page Thông kê Sách
            DataStatBook();
            PieChart_Top10TheLoai();
            Bar_Top10TacGia();
            Bar_Top10NCC();
            // Tag page Thống kê Độc giả
            DataStatReader();
            Pie_Top10DocGiaMax();
            Pie_Top10DocGiaMin();
        }

        // Số sách mượn trong 1 tháng
        private void PieChart_SoSachMuon()
        {
            PieSoSachMuon.Series.Clear();
            PieSoSachMuon.Titles.Clear();
            PieSoSachMuon.Titles.Add($"Báo cáo số sách mượn trong tháng 4 năm {dateStat.Value.Year}");
            PieSoSachMuon.Series.Add("SoSachMuon");
            PieSoSachMuon.Series["SoSachMuon"].ChartType = SeriesChartType.Doughnut;
            PieSoSachMuon.Series["SoSachMuon"].IsValueShownAsLabel = true;
            DataTable data = stat.NumberBookInMonth(dateStat.Value.Month, dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                PieSoSachMuon.Visible = false;
            else
                PieSoSachMuon.Visible = true;
            foreach (DataRow row in data.Rows) 
            {
                PieSoSachMuon.Series["SoSachMuon"].Points.AddXY(row["TenSach"], row["SoLuongMuon"]);
            }
        }

        private void PieChart_DocGia()
        {
            PieReader.Series.Clear();
            PieReader.Titles.Clear();
            PieReader.Titles.Add($"Báo cáo số lần độc giả mượn sách trong tháng {dateStat.Value.Month} năm {dateStat.Value.Year}");
            PieReader.Series.Add("DocGia");
            PieReader.Series["DocGia"].ChartType = SeriesChartType.Doughnut;
            PieReader.Series["DocGia"].IsValueShownAsLabel = true;
            DataTable data = stat.NumberReaderInMonth(dateStat.Value.Month, dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                PieReader.Visible = false;
            else
                PieReader.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                PieReader.Series["DocGia"].Points.AddXY(row["TenDocGia"], row["SoLanMuonSach"]);
            }
        }

        private void SplineTotalRentInYear()
        {
            SplineYear.Series.Clear();
            SplineYear.Titles.Clear();
            SplineYear.Titles.Add($"Báo cáo số lần mượn của từng quyển sách qua năm {dateStat.Value.Year}");
            Series series = SplineYear.Series.Add("Tháng");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 2;
            series.MarkerSize = 100;
            DataTable data = stat.SoSachMuonInYear(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                SplineYear.Visible = false;
            else
                SplineYear.Visible = true;
            // Thêm dữ liệu vào loại biểu đồ
            for (int i = 1; i <= 12; i++)
            {
                int rows = 0;
                double yValue;
                DataRow[] foundRows = stat.SoSachMuonInYear(dateStat.Value.Year).Select($"Thang = {i}");
                yValue = foundRows.Length > 0 ? Convert.ToDouble(stat.SoSachMuonInYear(dateStat.Value.Year).Rows[rows]["SoLanMuon"]) : 0;
                string xValue = $"{i}";
                series.Points.AddXY(xValue, yValue);
                rows++;
            }

        }

        private void ColumnRevenueOfBook()
        {
            ColumnRevenue.Series.Clear();
            ColumnRevenue.Titles.Clear();
            ColumnRevenue.ChartAreas[0].AxisX.Interval = 1;
            ColumnRevenue.ChartAreas[0].AxisX.IntervalOffset = 0;
            ColumnRevenue.Titles.Add($"Báo cáo Doanh Thu Mượn Sách trong năm {dateStat.Value.Year}");
            ColumnRevenue.Series.Add("Revenue");
            ColumnRevenue.Series["Revenue"].ChartType = SeriesChartType.Bar;
            DataTable data = stat.RevenueOfBook(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                ColumnRevenue.Visible = false;
            else
                ColumnRevenue.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                ColumnRevenue.Series["Revenue"].Points.AddXY(row["TenSach"], row["SubTotal"]);
            }

        }

        private void ColumnTop5()
        {
            BarMax.Series.Clear();
            BarMax.Titles.Clear();
            BarMax.Titles.Add($"Top 5 Sách mượn nhiều nhất trong năm {dateStat.Value.Year}");
            BarMax.Series.Add("Max");
            BarMax.Series["Max"].ChartType = SeriesChartType.Bar;
            DataTable data_Max = stat.Top5MuonNhieuNhat(dateStat.Value.Year);
            if (data_Max.Rows.Count <= 0)
                BarMax.Visible = false;
            else
                BarMax.Visible = true;
            foreach (DataRow row in data_Max.Rows)
            {
                BarMax.Series["Max"].Points.AddXY(row["TenSach"], row["SoLuongDangMuon"]);
            }


            BarMin.Series.Clear();
            BarMin.Titles.Clear();
            BarMin.Titles.Add($"Top 5 Sách mượn ít nhất trong năm {dateStat.Value.Year}");
            BarMin.Series.Add("Min");
            BarMin.Series["Min"].ChartType = SeriesChartType.Bar;
            DataTable data_Min = stat.Top5MuonItNhat(dateStat.Value.Year);
            if (data_Min.Rows.Count <= 0)
                BarMin.Visible = false;
            else
                BarMin.Visible = true;
            foreach (DataRow row in data_Min.Rows)
            {
                BarMin.Series["Min"].Points.AddXY(row["TenSach"], row["SoLuongDangMuon"]);
            }
        }

        private void DataStatBook()
        {
            dataStatBook.DataSource = stat.ListBooksIsNotRentInYear(dateStat.Value.Year);
        }

        private void PieChart_Top10TheLoai()
        {
            PieTheLoai.Series.Clear();
            PieTheLoai.Titles.Clear();
            PieTheLoai.Titles.Add($"Báo cáo 10 thể loại được mượn nhiều nhất năm {dateStat.Value.Year}");          
            PieTheLoai.Series.Add("TheLoai");
            PieTheLoai.Series["TheLoai"].ChartType = SeriesChartType.Doughnut;
            PieTheLoai.Series["TheLoai"].IsValueShownAsLabel = true;
            DataTable data = stat.Top10TheLoai(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                PieTheLoai.Visible = false;
            else
                PieTheLoai.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                PieTheLoai.Series["TheLoai"].Points.AddXY(row["TheLoai"], row["SoLuongMuon"]);
            }
        }

        private void Bar_Top10TacGia()
        {
            BarTacGia.Series.Clear();
            BarTacGia.Titles.Clear();
            BarTacGia.Titles.Add($"Thống kê 10 tác giả có số lần mượn cao nhất trong năm {dateStat.Value.Year}");
            BarTacGia.ChartAreas[0].AxisX.Interval = 1;
            BarTacGia.ChartAreas[0].AxisX.IntervalOffset = 0;
            BarTacGia.Series.Add("TacGia");
            BarTacGia.Series["TacGia"].ChartType = SeriesChartType.Bar;
            DataTable data = stat.Top10TacGia(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                BarTacGia.Visible = false;
            else
                BarTacGia.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                BarTacGia.Series["TacGia"].Points.AddXY(row["TenTacGia"], row["SoLuongMuon"]);
            }
        }

        private void Bar_Top10NCC()
        {
            BarNCC.Series.Clear();
            BarNCC.Titles.Clear();
            BarNCC.ChartAreas[0].AxisX.Interval = 1;
            BarNCC.ChartAreas[0].AxisX.IntervalOffset = 0;
            BarNCC.Titles.Add($"Thống kê 10 nhà cung cấp có số lần mượn cao nhất trong năm {dateStat.Value.Year}");
            BarNCC.Series.Add("NCC");
            BarNCC.Series["NCC"].ChartType = SeriesChartType.Bar;
            DataTable data = stat.Top10NCC(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                BarTacGia.Visible = false;
            else
                BarTacGia.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                BarNCC.Series["NCC"].Points.AddXY(row["TenNCC"], row["SoLuongMuon"]);
            }
        }

        private void DataStatReader()
        {
            dataStatReader.DataSource = stat.ListReadersIsNotRentInYear(dateStat.Value.Year);
        }

        private void Pie_Top10DocGiaMax()
        {
            BarDocGiaMax.Series.Clear();
            BarDocGiaMax.Titles.Clear();
            BarDocGiaMax.Titles.Add($"Thống kê 10 độc giả có số lần mượn cao nhất trong năm {dateStat.Value.Year}");
            BarDocGiaMax.Series.Add("Reader");
            BarDocGiaMax.Series["Reader"].ChartType = SeriesChartType.Bar;
            DataTable data = stat.Top10DocGiaMuonNhieuNhat(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                BarDocGiaMax.Visible = false;
            else
                BarDocGiaMax.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                BarDocGiaMax.Series["Reader"].Points.AddXY(row["TenDocGia"], row["SoLanMuon"]);
            }
        }

        private void Pie_Top10DocGiaMin()
        {
            BarDocGiaMin.Series.Clear();
            BarDocGiaMin.Titles.Clear();
            BarDocGiaMin.Titles.Add($"Thống kê 10 độc giả có số lần mượn thấp trong năm {dateStat.Value.Year}");
            BarDocGiaMin.Series.Add("Reader");
            BarDocGiaMin.Series["Reader"].ChartType = SeriesChartType.Bar;
            DataTable data = stat.Top10DocGiaMuonItNhat(dateStat.Value.Year);
            if (data.Rows.Count <= 0)
                BarDocGiaMin.Visible = false;
            else
                BarDocGiaMin.Visible = true;
            foreach (DataRow row in data.Rows)
            {
                BarDocGiaMin.Series["Reader"].Points.AddXY(row["TenDocGia"], row["SoLanMuon"]);
            }
        }

        // excel
        private void TitleExcel(String s, ref ExcelWorksheet sheet)
        {
            sheet.Cells[1, 1, 1, 10].Merge = true;
            sheet.Cells[1, 1].Value = s;
            sheet.Cells[1, 1].Style.Font.Bold = true;
            sheet.Cells[1, 1].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
            sheet.Cells[1, 1].Style.Font.Size = 20;
            sheet.Row(1).Height = 36;
        }

        private void SetTableExcel(String title, ref int lastrow, ref ExcelWorksheet sheet, DataTable table)
        {
            lastrow += 5;
            sheet.Cells[lastrow, 1].Value = $"{title.ToUpper()}";
            sheet.Cells[lastrow, 1].Style.Font.Bold = true;
            sheet.Cells[lastrow, 1].Style.Font.Color.SetColor(Color.Green);
            lastrow++;
            sheet.Cells[lastrow, 1].LoadFromDataTable(table, true);

            // Lấy danh sách các ô cần được format border
            var range = sheet.Cells[lastrow, 1,
               table.Rows.Count + lastrow, table.Columns.Count];

            // Đặt border cho các ô
            var border = range.Style.Border;
            border.Top.Style = ExcelBorderStyle.Thin;
            border.Bottom.Style = ExcelBorderStyle.Thin;
            border.Left.Style = ExcelBorderStyle.Thin;
            border.Right.Style = ExcelBorderStyle.Thin;
            // Tự động cỡ độ rộng cột
            sheet.Cells.AutoFitColumns();
            lastrow = sheet.Dimension.End.Row;
        }

        private void Excel(String file)
        {
            if (File.Exists(@"D:\excel.xlsx"))
            {
                File.Delete(@"D:\excel.xlsx");
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo excel = new FileInfo(file);
            ExcelPackage pck = new ExcelPackage(excel);
            // Trang excel thống kê mượn sách
            ExcelWorksheet muonsach = pck.Workbook.Worksheets.Add("Thống kê mượn sách");
            // 1. Tạo tiêu đề
            TitleExcel($"BÁO CÁO MƯỢN SÁCH TRONG NĂM {dateStat.Value.Year}", ref muonsach);
            // 2. Tạo các table trên datatable
            int lastrow = muonsach.Dimension.End.Row;
            SetTableExcel($"BÁO CÁO SỐ SÁCH MƯỢN TRONG NĂM {dateStat.Value.Year}", ref lastrow, ref muonsach,
                stat.SoSachMuonInYear(dateStat.Value.Year));

            SetTableExcel($"Báo cáo số lần độc giả mượn sách trong tháng {dateStat.Value.Month} năm {dateStat.Value.Year}", 
                ref lastrow, ref muonsach,
                stat.NumberReaderInMonth(dateStat.Value.Month, dateStat.Value.Year));

            SetTableExcel($"Báo cáo số lần mượn của từng quyển sách qua năm {dateStat.Value.Year}", 
                ref lastrow, ref muonsach,
                stat.SoSachMuonInYear(dateStat.Value.Year));

            SetTableExcel($"Báo cáo Doanh Thu Mượn Sách trong năm {dateStat.Value.Year}", 
                ref lastrow, ref muonsach,
                stat.RevenueOfBook(dateStat.Value.Year));

            SetTableExcel($"Top 5 Sách mượn nhiều nhất trong năm {dateStat.Value.Year}", 
                ref lastrow, ref muonsach,
                stat.Top5MuonNhieuNhat(dateStat.Value.Year));

            SetTableExcel($"Top 5 Sách mượn ít nhất trong năm {dateStat.Value.Year}", 
                ref lastrow, ref muonsach,
                stat.Top5MuonItNhat(dateStat.Value.Year));
            // Trang thống kê sách
            ExcelWorksheet sach = pck.Workbook.Worksheets.Add("Thống kê sách");
            // 1. Tạo tiêu đề
            TitleExcel($"BÁO CÁO MƯỢN SÁCH TRONG NĂM {dateStat.Value.Year}", ref sach);
            // 2. Tạo các table trên datatable
            lastrow = sach.Dimension.End.Row;
            SetTableExcel($"BÁO CÁO DANH SÁCH NHỮNG QUYỂN SÁCH KHÔNG ĐƯỢC MƯỢN NĂM {dateStat.Value.Year}", 
                ref lastrow, ref sach,
               stat.ListBooksIsNotRentInYear(dateStat.Value.Year));

            SetTableExcel($"Báo cáo 10 thể loại được mượn nhiều nhất năm {dateStat.Value.Year}",
                ref lastrow, ref sach,
                stat.Top10TheLoai(dateStat.Value.Year));

            SetTableExcel($"Thống kê 10 tác giả có số lần mượn cao nhất trong năm {dateStat.Value.Year}",
                ref lastrow, ref sach,
                stat.Top10TacGia(dateStat.Value.Year));

            SetTableExcel($"Thống kê 10 nhà cung cấp có số lần mượn cao nhất trong năm {dateStat.Value.Year}",
                ref lastrow, ref sach,
                stat.Top10NCC(dateStat.Value.Year));

            // Trang thống kê độc giả
            ExcelWorksheet reader = pck.Workbook.Worksheets.Add("Thống kê Độc giả");
            // 1. Tạo tiêu đề
            TitleExcel($"BÁO CÁO MƯỢN SÁCH TRONG NĂM {dateStat.Value.Year}", ref reader);
            // 2. Tạo các table trên datatable
            lastrow = reader.Dimension.End.Row;
            SetTableExcel($"BÁO CÁO DANH SÁCH NHỮNG ĐỘC GIẢ KHÔNG MƯỢN SÁCH NĂM {dateStat.Value.Year}",
                ref lastrow, ref reader,
               stat.ListReadersIsNotRentInYear(dateStat.Value.Year));

            SetTableExcel($"Thống kê 10 độc giả có số lần mượn cao nhất trong năm {dateStat.Value.Year}",
                ref lastrow, ref reader,
               stat.Top10DocGiaMuonNhieuNhat(dateStat.Value.Year));

            SetTableExcel($"Thống kê 10 độc giả có số lần mượn thấp nhất trong năm {dateStat.Value.Year}",
                ref lastrow, ref reader,
                stat.Top10DocGiaMuonItNhat(dateStat.Value.Year));
            // Lưu tệp tin Excel
            pck.Save();
        }

        private void Form_Stat_Report_Load(object sender, EventArgs e)
        {
            u.SetPropertiesDataGridView(dataStatBook);
            u.SetPropertiesDataGridView(dataStatReader);
            dateStat.MaxDate = DateTime.Now;
            Stat();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog excel = new SaveFileDialog();
            excel.Filter = "Excel (*.xlsx)|*.xlsx" + "|All files (*.*)|*.*";
            String file = "";
            if (excel.ShowDialog() == DialogResult.OK)
            {
                file = excel.FileName.Split('.')[0] + ".xlsx";
            }
            else
                return;
            Excel(file);
            DialogResult result = u.Message("Export Excel", "Lưu file thành công.\n Bạn có muốn mở nó không", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                Process.Start(file);
            }
        }
    }
}
