using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Point = System.Drawing.Point;
using TextBox = System.Windows.Forms.TextBox;

namespace Quan_Ly
{
    public class panelBanHang
    {
        List<doUongMenu> dsMenu = new List<doUongMenu>();
        ControlPanel ControlPanel = new ControlPanel();
        public void Main(DateTime ngay, Panel panelBanHang, Panel panelTotal, TextBox txtTotalPrice, ImageList imageList)
        {
            //Lấy dữ liệu
            Refresh(panelBanHang, panelTotal, ngay.Month, ngay.Day, txtTotalPrice, imageList);
            LoadDataFromExcel(ngay.Month, ngay.Day);
            renderControlsToPanel(panelBanHang, panelTotal, txtTotalPrice, imageList);
        }
        private void LoadDataFromExcel(int month, int day)
        {
            //Làm mới danh sách
            dsMenu.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Menu.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //bắt đầu từ dòng 3 cho đến dòng cuối cùng
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng cột
                        // Lấy tên đồ uống
                        string tenDoUong = worksheet.Cells[i, 1].Value?.ToString();

                        // Lấy giá
                        var priceCell = worksheet.Cells[i, 2].Value;

                        int? price = null;

                        if (priceCell != null && int.TryParse(priceCell.ToString(), out int parsedValue))
                        {
                            price = parsedValue;
                        }

                        // Kiểm tra giá trị soLuongDaBan trước khi sử dụng nó
                        if (tenDoUong != null && price.HasValue)
                        {
                            // Tạo biến doUongThongKe để thêm vào dsDoUongThongKe
                            doUongMenu doUongMenu = new doUongMenu(tenDoUong, price.Value);

                            // Thêm biến vừa tạo vào dsDoUongThongKe
                            dsMenu.Add(doUongMenu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();
            }
        }
        private void renderControlsToPanel(Panel panelBanHang, Panel panelTotal, TextBox txtTotalPrice, ImageList imageList)
        {
            //vị trí control đầu tiên
            int x = 25, y = 90, index = 1;
            //duyệt dsDoUongThongKe
            foreach (doUongMenu doUong in dsMenu)
            {
                if(index > 4)
                {
                    x = 25;
                    y += 240;
                    index = 1;
                }    
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, panelDoUongThongKe
                AddControlToPanel(x, y, doUong, panelBanHang, panelTotal, imageList, txtTotalPrice, index);
                x += 160;
                index++;
                //chỉnh vị trí và stt cho control tiếp theo
            }
        } 
        int xPanelTotal = 10,  yPanelTotal = 80;
        private void addControlToPanelTotal(doUongMenu doUong, Panel panelTotal, ImageList imageList, TextBox txtTotalPrice)
        {
            TextBox txtTenDoUong = ControlPanel.CreateTextBox("txtTenDoUong", doUong.Ten, HorizontalAlignment.Left, xPanelTotal, yPanelTotal, 220, 35);
            txtTenDoUong.ReadOnly = true;

            NumericUpDown numericSoLuong = ControlPanel.CreateNumericUpDown(1, HorizontalAlignment.Left, xPanelTotal + 225, yPanelTotal, 60);

            TextBox txtPrice = ControlPanel.CreateTextBox("txtPrice", doUong.Price.ToString("N0"), HorizontalAlignment.Right, xPanelTotal + 290, yPanelTotal, 150, 35);
            txtPrice.ReadOnly = true;

            Button bttDelete = ControlPanel.CreateButton(xPanelTotal + 445, yPanelTotal, 35, 35, imageList);


            panelTotal.Controls.Add(txtTenDoUong);
            panelTotal.Controls.Add(numericSoLuong);
            panelTotal.Controls.Add(txtPrice);
            panelTotal.Controls.Add(bttDelete);

            yPanelTotal += 40;

            numericSoLuong.ValueChanged += (sender, e) =>
            {
                // Lấy giá trị hiện tại của numericSoLuong
                int soLuong = (int)numericSoLuong.Value;

                // Chuyển đổi giá trị doUong.Price từ chuỗi sang số nguyên (nếu không thể, sử dụng 0)
                int donGia = 0;
                if (int.TryParse(doUong.Price.ToString(), out donGia))
                {
                    int tongGia = donGia * soLuong;
                    txtPrice.Text = tongGia.ToString("N0");
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị đơn giá
                    txtPrice.Text = "0"; // Hoặc một giá trị mặc định khác
                }
                TotalPrice(panelTotal, txtTotalPrice);
            };

            bttDelete.Click += (sender, e) => 
            { 
                ClearPanelTotalControls(panelTotal, bttDelete.Location.Y); yPanelTotal -= 40;
                TotalPrice(panelTotal, txtTotalPrice);
            };
        }
        private void AddControlToPanel(int x, int y, doUongMenu doUong, Panel panelBanHang, Panel panelTotal, ImageList imageList, TextBox txtTotalPrice, int index)
        {
            Button bttImageDoUong = ControlPanel.CreateButton(x, y, 135, 160, null);
            string path = $"img/Menu/{doUong.Ten}.png";
            try
            {
                bttImageDoUong.BackgroundImage = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                bttImageDoUong.Text = "(none)";
            }
            bttImageDoUong.Name = "bttImageDoUong";


            TextBox txtTenDoUong = ControlPanel.CreateTextBox("txtTenDoUong", doUong.Ten, HorizontalAlignment.Center, x, y + 160, 135, 50);
            txtTenDoUong.ReadOnly = true;
            txtTenDoUong.Multiline = true; // Cho phép hiển thị nhiều dòng
            txtTenDoUong.WordWrap = true; // Tự động xuống dòng khi cần

            panelBanHang.Controls.Add(bttImageDoUong);
            panelBanHang.Controls.Add(txtTenDoUong);

            // Định nghĩa sự kiện Click cho nút buttonDelete
            bttImageDoUong.Click += (sender, e) =>
            {
                addControlToPanelTotal(doUong, panelTotal, imageList, txtTotalPrice);
                TotalPrice(panelTotal, txtTotalPrice);
            };
        }

        public void Refresh(Panel panelBanHang, Panel panelTotal, int month, int day, TextBox txtTotalPrice, ImageList imageList)
        {
            ClearPanelControls(panelBanHang);
            LoadDataFromExcel(month, day);
            renderControlsToPanel(panelBanHang, panelTotal, txtTotalPrice, imageList);
        }
        private void ClearPanelControls(Panel panelBanHang)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là Richtextbox, Label
            List<Control> controlsToRemove = panelBanHang.Controls.OfType<Control>().Where(control =>
                control is TextBox || control is Button || control is NumericUpDown).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelBanHang.Controls.Remove(control);
                control.Dispose();
            }
        }
        private void ClearPanelTotalControls(Panel panelTotal, int y)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là Richtextbox, Label
            List<Control> controlsToRemove = panelTotal.Controls.OfType<Control>().Where(control =>
            (control is TextBox || control is Button || control is NumericUpDown) && control.Location.Y == y).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelTotal.Controls.Remove(control);
                control.Dispose();
            }

            // Di chuyển các controls sau control vừa xóa lên trên 40px
            foreach (Control control in panelTotal.Controls)
            {
                if (control.Location.Y > y)
                {
                    // Cập nhật vị trí Y của control lên trên 40px
                    control.Location = new Point(control.Location.X, control.Location.Y - 40);
                }
            }
        }
        private void TotalPrice(Panel panelTotal, TextBox txtTotalPrice)
        {
            int totalPrice = 0;

            // Lặp qua các controls trong panelTotal
            foreach (Control control in panelTotal.Controls)
            {
                if (control is TextBox txtPrice && txtPrice.Name == "txtPrice")
                {
                    int price;
                    if (int.TryParse(txtPrice.Text.Replace(",", "").Replace(".", ""), out price)) // Loại bỏ dấu ',' nếu có
                    {
                        totalPrice += price;
                    }
                }
            }

            // Cập nhật giá trị txtTotalPrice
            txtTotalPrice.Text = totalPrice.ToString("N0");
        }

    }
}
