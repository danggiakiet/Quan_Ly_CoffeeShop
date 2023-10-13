using OfficeOpenXml;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly
{
    public class panelDoanhThu
    {
        List<doUongThongKe> dsDoUongThongKe = new List<doUongThongKe>();
        ControlPanel ControlPanel = new ControlPanel();
        public void Main(Panel panelDoanhThu, TextBox tienLoi, TextBox tienVon, DateTime ngay)
        {
            //Lấy dữ liệu
            Refresh(panelDoanhThu, ngay.Month, ngay.Day, tienLoi, tienVon);
            LoadDataFromExcel(ngay.Month, ngay.Day, tienLoi, tienVon);
            renderControlsToPanel(panelDoanhThu);
        }
        private void LoadDataFromExcel(int month, int day, TextBox tienLoi, TextBox tienVon)
        {
            //Làm mới danh sách
            dsDoUongThongKe.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Doanh Thu.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[month + 1];
                    // Lấy giá trị từ ô cột kế cuối trong sheet
                    var tongLoiCell = worksheet.Cells[day + 2, worksheet.Dimension.End.Column - 1].Value;
                    if (tongLoiCell != null && int.TryParse(tongLoiCell.ToString(), out int parsedTongLoi))
                    {
                        tienLoi.Text = parsedTongLoi.ToString();
                    }

                    // Lấy giá trị từ ô cuối cùng trong sheet
                    var tongVonCell = worksheet.Cells[day + 2, worksheet.Dimension.End.Column].Value;
                    if (tongVonCell != null && int.TryParse(tongVonCell.ToString(), out int parsedTongVon))
                    {
                        tienVon.Text = parsedTongVon.ToString();
                    }
                    for (int i = 2; i <= worksheet.Dimension.End.Column - 3; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng cột
                        // Cột tương ứng và ô thứ 2
                        string tenDoUong = worksheet.Cells[2, i].Value?.ToString();

                        // Lấy số hàng cuối cùng trong cột
                        int lastRow = worksheet.Dimension.End.Row;

                        // Lấy giá trị từ ô theo ngày cùng trong cột tương ứng
                        var soLuongDaBanCell = worksheet.Cells[day + 2, i].Value;

                        int? soLuongDaBan = null;

                        if (soLuongDaBanCell != null && int.TryParse(soLuongDaBanCell.ToString(), out int parsedValue))
                        {
                            soLuongDaBan = parsedValue;
                        }

                        // Kiểm tra giá trị soLuongDaBan trước khi sử dụng nó
                        if (tenDoUong != null && soLuongDaBan.HasValue)
                        {
                            // Tạo biến doUongThongKe để thêm vào dsDoUongThongKe
                            doUongThongKe doUongThongKe = new doUongThongKe(tenDoUong, soLuongDaBan.Value);

                            // Thêm biến vừa tạo vào dsDoUongThongKe
                            dsDoUongThongKe.Add(doUongThongKe);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void renderControlsToPanel(Panel panelDoanhThu)
        {
            //vị trí control đầu tiên
            int x = 10, y = 65, index = 0;
            //duyệt dsDoUongThongKe
            foreach (doUongThongKe doUong in dsDoUongThongKe)
            {
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, panelDoUongThongKe
                AddControlToPanel(x, y, doUong, panelDoanhThu, index);
                index++;
                //chỉnh vị trí và stt cho control tiếp theo
                y += 40;
            }
        }

        private void AddControlToPanel(int x, int y, doUongThongKe doUong, Panel panelDoanhThu, int index)
        {
            TextBox txtTenDoUong = ControlPanel.CreateTextBox("txtTenDoUong", doUong.tenDoUong, HorizontalAlignment.Left, x, y, 285, 35);
            txtTenDoUong.ReadOnly = true;

            TextBox txtSoLuong = ControlPanel.CreateTextBox("txtSoLuong", doUong.soLuongDaBan.ToString(), HorizontalAlignment.Center, x + 290, y, 80, 35);

            panelDoanhThu.Controls.Add(txtTenDoUong);
            panelDoanhThu.Controls.Add(txtSoLuong);
        }

        public void Refresh(Panel panelDoanhThu, int month, int day, TextBox tienLoi, TextBox tienVon)
        {
            ClearPanelControls(panelDoanhThu);
            LoadDataFromExcel(month, day, tienLoi, tienVon);
            renderControlsToPanel(panelDoanhThu);
        }
        private void ClearPanelControls(Panel panelDoanhThu)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là Richtextbox, Label
            List<Control> controlsToRemove = panelDoanhThu.Controls.OfType<Control>().Where(control =>
                control is TextBox).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelDoanhThu.Controls.Remove(control);
                control.Dispose();
            }

        }
    }
}
