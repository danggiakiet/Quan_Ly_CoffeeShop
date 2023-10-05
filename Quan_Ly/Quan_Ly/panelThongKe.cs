using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Application = System.Windows.Forms.Application;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Label = System.Windows.Forms.Label;

namespace Quan_Ly
{
    public class panelThongKe
    {
        List<doUongThongKe> dsDoUongThongKe = new List<doUongThongKe>();
        ControlPanel ControlPanel = new ControlPanel();
        public void Main(Panel panelDsThongKe, int month)
        {
            Refresh(panelDsThongKe, month);
            //Lấy thông tin từ data
            LoadDataFromExcel(month);
            //Đưa thông tin lên panelpanelNhanVien
            renderControlsToPanel(panelDsThongKe);
        }
        private void LoadDataFromExcel(int month)
        {
            //Làm mới danh sách
            dsDoUongThongKe.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Thống Kê.xlsx")))
                {
                    ExcelWorksheet worksheet = null;
                    //Duyệt tháng để mở sheet theo tháng
                    switch (month)
                    {
                        case 1: { worksheet = package.Workbook.Worksheets[1]; break; }
                        case 2: { worksheet = package.Workbook.Worksheets[2]; break; }
                        case 3: { worksheet = package.Workbook.Worksheets[3]; break; }
                        case 4: { worksheet = package.Workbook.Worksheets[4]; break; }
                        case 5: { worksheet = package.Workbook.Worksheets[5]; break; }
                        case 6: { worksheet = package.Workbook.Worksheets[6]; break; }
                        case 7: { worksheet = package.Workbook.Worksheets[7]; break; }
                        case 8: { worksheet = package.Workbook.Worksheets[8]; break; }
                        case 9: { worksheet = package.Workbook.Worksheets[9]; break; }
                        case 10: { worksheet = package.Workbook.Worksheets[10]; break; }
                        case 11: { worksheet = package.Workbook.Worksheets[11]; break; }
                        case 12: { worksheet = package.Workbook.Worksheets[12]; break; }
                        default:
                            {
                                MessageBox.Show("Lỗi khi mở sheet thống kê theo tháng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                    }
                    for (int i = 2; i < worksheet.Dimension.End.Column - 1; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng cột
                        // Cột tương ứng và ô thứ 2
                        string tenDoUong = worksheet.Cells[2, i].Value?.ToString();

                        // Lấy số hàng cuối cùng trong cột
                        int lastRow = worksheet.Dimension.End.Row;

                        // Lấy giá trị từ ô cuối cùng trong cột tương ứng
                        var soLuongDaBanCell = worksheet.Cells[lastRow, i].Value;

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
        int yDuongKe = 20;
        private void renderControlsToPanel(Panel panelDoUongThongKe)
        {
            //vị trí control đầu tiên
            int x = 10, y = 20, index = 0;
            //duyệt dsDoUongThongKe
            foreach (doUongThongKe doUong in dsDoUongThongKe)
            {
                //Chỉnh màu
                if(index > 13)
                {
                    index = 1;
                }    
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, panelDoUongThongKe
                AddControlToPanel(x, y, doUong, panelDoUongThongKe, index);
                index++;
                //chỉnh vị trí và stt cho control tiếp theo
                y += 50;
                yDuongKe += 50;
            }
        }

        private void AddControlToPanel(int x, int y, doUongThongKe doUong, Panel panelDoUongThongKe, int index)
        {
            // Tạo màu ngẫu nhiên và áp dụng cho BackColor   
            Color backColor = TaoMauRichTextBox(index);
            Label labelTenDoUong = ControlPanel.CreateLabel("labelTenDoUong", doUong.tenDoUong, x, y);
            labelTenDoUong.AutoSize = true;
            double chieuDaiRichTextBox;
            if (doUong.soLuongDaBan == 0)
            {
                // Nếu số lượng là 0, đặt chiều dài là 0
                chieuDaiRichTextBox = 0;
            }
            else
            {
                // Nếu số lượng không phải là 0, tính chiều dài dựa trên công thức nào đó
                chieuDaiRichTextBox = Convert.ToDouble(doUong.soLuongDaBan * 0.5);
            }

            // Tạo RichTextBox dựa trên chiều dài đã tính toán
            RichTextBox richTextBoxSoLuongDaBan = ControlPanel.CreateRichTextBoxThongKe("richTextBoxSoLuongDaBan", x + 225, y, Convert.ToInt32(chieuDaiRichTextBox), 28, backColor);

            Label labelSoLuongDaBan = ControlPanel.CreateLabel("labelSoLuongDaBan", doUong.soLuongDaBan.ToString(), richTextBoxSoLuongDaBan.Location.X + Convert.ToInt32(chieuDaiRichTextBox) + 20, y);


            panelDoUongThongKe.Controls.Add(labelTenDoUong);
            panelDoUongThongKe.Controls.Add(richTextBoxSoLuongDaBan);
            panelDoUongThongKe.Controls.Add(labelSoLuongDaBan);
        }
        // Hàm tạo màu ngẫu nhiên
        private Color TaoMauRichTextBox(int index)
        {
            Color color;
            switch (index)
            {
                case 1: color = Color.FromArgb(255, 0, 0); break;      // Đỏ
                case 2: color = Color.FromArgb(255, 128, 0); break;   // Cam đậm
                case 3: color = Color.FromArgb(255, 255, 0); break;   // Vàng
                case 4: color = Color.FromArgb(128, 255, 0); break;   // Xanh lá cây đậm
                case 5: color = Color.FromArgb(0, 255, 0); break;     // Xanh lá cây
                case 6: color = Color.FromArgb(0, 255, 128); break;   // Xanh lá cây nhạt
                case 7: color = Color.FromArgb(0, 255, 255); break;   // Cyan
                case 8: color = Color.FromArgb(0, 128, 255); break;   // Xanh dương đậm
                case 9: color = Color.FromArgb(0, 0, 255); break;     // Xanh dương
                case 10: color = Color.FromArgb(128, 0, 255); break;  // Tím đậm
                case 11: color = Color.FromArgb(255, 0, 255); break;  // Tím
                case 12: color = Color.FromArgb(255, 0, 128); break;  // Hồng
                case 13: color = Color.FromArgb(128, 128, 128); break; // Xám
                default: color = Color.Black; break;  // Màu mặc định (ví dụ: đen)
            }
            return color;
        }

        public void Refresh(Panel panelDsThongKe, int Month)
        {
            ClearPanelControls(panelDsThongKe);
            LoadDataFromExcel(Month);
            renderControlsToPanel(panelDsThongKe);
        }
        private void ClearPanelControls(Panel panelDsThongKe)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là Richtextbox, Label
            List<Control> controlsToRemove = panelDsThongKe.Controls.OfType<Control>().Where(control =>
                control is RichTextBox || control is Label).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelDsThongKe.Controls.Remove(control);
                control.Dispose();
            }

        }
    }
}
