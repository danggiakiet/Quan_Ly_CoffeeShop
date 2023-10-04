using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;

namespace Quan_Ly
{
    public class panelThongKe
    {
        public void Main(Chart bangThongKe, int month)
        {
            loadDataToChart(bangThongKe, month);
        }
        private void loadDataToChart(Chart bangThongKe, int month)
        {
            bangThongKe.Series["s1"].Points.Clear();
            try
            {
                // Mở tệp Excel "Accounts.xlsx" bằng thư viện EPPlus
                using (var package = new ExcelPackage(new FileInfo("data/Doanh thu.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[month + 1];

                    // Thêm các điểm dữ liệu và hiển thị số lượng trên cột
                    bangThongKe.Series["s1"].Points.AddXY("Cà phê đen", worksheet.Cells[worksheet.Dimension.End.Row, 2].Value);
                    bangThongKe.Series["s1"].Points[0].Label = worksheet.Cells[worksheet.Dimension.End.Row, 2].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Cà phê sữa", worksheet.Cells[worksheet.Dimension.End.Row, 3].Value);
                    bangThongKe.Series["s1"].Points[1].Label = worksheet.Cells[worksheet.Dimension.End.Row, 3].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Bạc sỉu", worksheet.Cells[worksheet.Dimension.End.Row, 4].Value);
                    bangThongKe.Series["s1"].Points[2].Label = worksheet.Cells[worksheet.Dimension.End.Row, 4].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Cà phê muối", worksheet.Cells[worksheet.Dimension.End.Row, 5].Value);
                    bangThongKe.Series["s1"].Points[3].Label = worksheet.Cells[worksheet.Dimension.End.Row, 5].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Ca cao", worksheet.Cells[worksheet.Dimension.End.Row, 6].Value);
                    bangThongKe.Series["s1"].Points[4].Label = worksheet.Cells[worksheet.Dimension.End.Row, 6].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Ca cao muối", worksheet.Cells[worksheet.Dimension.End.Row, 7].Value);
                    bangThongKe.Series["s1"].Points[5].Label = worksheet.Cells[worksheet.Dimension.End.Row, 7].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Bạc sỉu muối", worksheet.Cells[worksheet.Dimension.End.Row, 8].Value);
                    bangThongKe.Series["s1"].Points[6].Label = worksheet.Cells[worksheet.Dimension.End.Row, 8].Value.ToString();

                    bangThongKe.Series["s1"].Points.AddXY("Ca cao đá xay", worksheet.Cells[worksheet.Dimension.End.Row, 9].Value);
                    bangThongKe.Series["s1"].Points[7].Label = worksheet.Cells[worksheet.Dimension.End.Row, 9].Value.ToString();

                    int suaChua = 0;
                    for (int i = 1; i <= 5; i++)
                    {
                        suaChua += Convert.ToInt32(worksheet.Cells[worksheet.Dimension.End.Row, 9 + i].Value);
                    }
                    bangThongKe.Series["s1"].Points.AddXY("Sữa chua", suaChua);
                    bangThongKe.Series["s1"].Points[8].Label = suaChua.ToString();

                    bangThongKe.Series["s1"].IsVisibleInLegend = false;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Lỗi đọc file không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
