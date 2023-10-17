using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.Style;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;
using Point = System.Drawing.Point;
using Button = System.Windows.Forms.Button;
using Microsoft.Office.Core;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace Quan_Ly
{
    public class panelKhoHang
    {
        //Tạo dsNguyenLieu chứa thông tin từ kho hàng
        private List<nguyenLieu> dsNguyenLieu = new List<nguyenLieu>();
        private ControlPanel ControlPanel = new ControlPanel();
        private Dictionary<int, string> dsMaNL = new Dictionary<int, string>();

        public void Main(Panel KhoHang, ImageList imgList)
        {
            //Lấy thông tin từ data
            LoadDataFromExcel();
            //Đưa thông tin lên panelKhoHang
            renderControlsToPanel(KhoHang, imgList);

        }

        private void LoadDataFromExcel()
        {
            // Làm mới danh sách
            dsNguyenLieu.Clear();
            try
            {
                // Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    // Lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    // Cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string maNguyenLieu = Convert.ToString(worksheet.Cells[i, 1].Value ?? "null");
                        string tenNguyenLieu = Convert.ToString(worksheet.Cells[i, 2].Value ?? "null");
                        string donVi = Convert.ToString(worksheet.Cells[i, 3].Value ?? "null");
                        int soLuong = Convert.ToInt32(worksheet.Cells[i, 4].Value ?? 0);
                        int donGia = Convert.ToInt32(worksheet.Cells[i, 5].Value ?? 0);
                        // Tạo biến nguyenLieu để thêm vào dsNguyenLieu
                        nguyenLieu nLieu = new nguyenLieu(maNguyenLieu, tenNguyenLieu, donVi, soLuong, donGia);
                        // Thêm biến vừa tạo vào dsNguyenLieu
                        dsNguyenLieu.Add(nLieu);
                    }
                    // Đóng file Excel
                    package.Dispose();
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //đưa dữ liệu lên PanelKhoHang
        private void renderControlsToPanel(Panel KhoHang, ImageList imgList)
        {
            //vị trí control đầu tiên
            int x = 5, y = 120, index = 0;
            //duyệt dsNguyenLieu
            foreach (nguyenLieu nguyenLieu in dsNguyenLieu)
            {
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, biến nguyenLieu, số thứ tự trên panel và panelKhoHang)
                AddControlToPanel(x, y, nguyenLieu, index, KhoHang, imgList);
                //chỉnh vị trí và stt cho control tiếp theo
                y += 40;
                index++;
            }
        }

        private void AddControlToPanel(int x, int y, nguyenLieu nguyenLieu, int index, Panel KhoHang, ImageList imgList)
        {
            TextBox textBoxMaNguyenLieu = ControlPanel.CreateTextBox("txtMaNL", nguyenLieu.maNguyenLieu, HorizontalAlignment.Left, x, y, 100, 35);
            TextBox textBoxTen = ControlPanel.CreateTextBox("txtName", nguyenLieu.ten, HorizontalAlignment.Left, x + 105, y, 305, 35);
            TextBox textBoxDonVi = ControlPanel.CreateTextBox("txtDonVi", nguyenLieu.donVi, HorizontalAlignment.Center, x + 415, y, 100, 35);
            NumericUpDown numericUpDownSoLuong = ControlPanel.CreateNumericUpDown(nguyenLieu.soLuong, HorizontalAlignment.Right, x + 520, y, 95);
            TextBox textBoxDonGia = ControlPanel.CreateTextBox("txtDonGia", nguyenLieu.donGia.ToString(), HorizontalAlignment.Right, x + 620, y, 130, 35);
            Button buttonDelete = ControlPanel.CreateButton(x + 755, y, 35, 35, imgList);

            KhoHang.Controls.Add(textBoxMaNguyenLieu);
            KhoHang.Controls.Add(textBoxTen);
            KhoHang.Controls.Add(textBoxDonVi);
            KhoHang.Controls.Add(numericUpDownSoLuong);
            KhoHang.Controls.Add(textBoxDonGia);
            KhoHang.Controls.Add(buttonDelete);

            // Định nghĩa sự kiện Click cho nút buttonDelete
            buttonDelete.Click += (sender, e) => bttDelete(buttonDelete, KhoHang, imgList);

        }

        public void Refresh(Panel KhoHang, ImageList imgList)
        {
            ClearPanelControls(KhoHang);
            LoadDataFromExcel();
            renderControlsToPanel(KhoHang, imgList);
        }

        private void ClearPanelControls(Panel KhoHang)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là textbox, button và NumericUpDown
            List<Control> controlsToRemove = KhoHang.Controls.OfType<Control>().Where(control =>
                control is TextBox || control is NumericUpDown || control is Button).ToList();

            foreach (Control control in controlsToRemove)
            {
                KhoHang.Controls.Remove(control);
                control.Dispose();
            }

        }

        public void Save(Panel KhoHang, ImageList imgList)
        {
            dsMaNL.Clear();
            List<int> dsLocationY = new List<int>();
            try
            {
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //Duyệt các control trong panelNhanVien
                    foreach (Control control in KhoHang.Controls)
                    {
                        //nếu control là textbox
                        if (control is TextBox textBox)
                        {
                            //nếu control có name là "txtMaNV"
                            if (textBox.Name == "txtName")
                            {
                                //Thêm vị trí Y của textbox vào danh sách LocationY
                                dsLocationY.Add(textBox.Location.Y);
                            }
                        }
                    }
                    //Khởi tạo biến i bắt đầu từ dòng 3 trong file excel
                    int i = 3;
                    //Cho duyệt từng giá trị Y trong danh sách
                    foreach (int y in dsLocationY)
                    {
                        //Duyệt qua các control trong panel
                        foreach (Control control in KhoHang.Controls)
                        {
                            //Nếu control là textbox
                            if (control is TextBox textBox)
                            {
                                //Và có giá trị Y tương ứng với y và có tên là "txtName"
                                if (textBox.Location.Y == y && textBox.Name == "txtMaNL")
                                {
                                    if (dsMaNL.ContainsValue(textBox.Text))
                                    {
                                        MessageBox.Show("Mã nguyên liệu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        // //thoát khỏi phần còn lại của phương thức và không thực hiện lưu dữ liệu hoặc bất kỳ mã lệnh nào khác sau đó
                                        return;
                                    }
                                    else
                                    {
                                        //thì thêm vào dòng i cột 1
                                        worksheet.Cells[i, 1].Value = textBox.Text;
                                        dsMaNL.Add(i, textBox.Text);
                                    }
                                }
                                else if (textBox.Location.Y == y && textBox.Name == "txtName")
                                {
                                    worksheet.Cells[i, 2].Value = textBox.Text;
                                }
                                else if (textBox.Location.Y == y && textBox.Name == "txtDonVi")
                                {
                                    worksheet.Cells[i, 3].Value = textBox.Text;
                                }
                                else if (textBox.Location.Y == y && textBox.Name == "txtDonGia")
                                {
                                    //Thêm đơn giá
                                    worksheet.Cells[i, 5].Value = textBox.Text.ToString();
                                    // Đặt căn chỉnh sang phải (right-align) cho ô cột đơn giá
                                    worksheet.Cells[i, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                                    //Thêm tổng giá
                                    worksheet.Cells[i, 6].Formula = "C" + i + "*D" + i; // Sử dụng công thức Excel để tính tổng giá
                                }
                            }
                            else if (control is NumericUpDown numericUpDown)
                            {
                                if (numericUpDown.Location.Y == y)
                                {
                                    worksheet.Cells[i, 4].Value = ((NumericUpDown)control).Value;
                                }
                            }
                        }
                        i++;
                    }
                    package.Save();
                    // Đóng file Excel
                    package.Dispose();
                    MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Refresh(KhoHang, imgList);
            }
        }

        public void addNew(string maNL, string ten, string donVi, int soLuong, int donGia, Panel KhoHang, ImageList imgList)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    //Mở sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //Khai báo giá trị bắt đầu là = 3
                    int start = worksheet.Dimension.Start.Row + 2;
                    int check = 0;
                    //Cho duyệt dữ liệu từ dòng 3 đến dòng cuối cùng
                    for (int i = start; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //Nếu tên đã tồn tại thì báo lỗi
                        if (worksheet.Cells[i, 1].Value.ToString().ToLower() == maNL.ToLower())
                        {
                            check++;
                            MessageBox.Show("Mã nguyên liệu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    //Nếu tên chưa tồn tại trong data thì thêm dòng mới
                    if (check == 0)
                    {
                        //Tạo vị trí dòng mới
                        int newRow = worksheet.Dimension.End.Row + 1;
                        //Thêm mã nguyên liệu
                        worksheet.Cells[newRow, 1].Value = maNL;
                        //Thêm tên
                        worksheet.Cells[newRow, 2].Value = ten;
                        //Thêm đơn vị
                        worksheet.Cells[newRow, 3].Value = donVi;
                        //Thêm số lượng
                        worksheet.Cells[newRow, 4].Value = soLuong.ToString();
                        //Thêm đơn giá
                        worksheet.Cells[newRow, 5].Value = donGia.ToString();
                        // Đặt căn chỉnh sang phải (right-align) cho ô cột đơn giá
                        worksheet.Cells[newRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                        //Thêm tổng giá
                        worksheet.Cells[newRow, 6].Formula = "C" + newRow + "*D" + newRow; // Sử dụng công thức Excel để tính tổng giá
                        package.Save();
                        MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Đóng file Excel
                        package.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào file kho hàng: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Refresh(KhoHang, imgList);
            }

        }

        public void bttDelete(Button buttonDelete, Panel KhoHang, ImageList imgList)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Khai báo biến lưu trữ tên cần xóa
                string nameNeedToDel = "";

                // Lấy tọa độ Y của nút xóa
                int y = buttonDelete.Location.Y;

                // Duyệt qua tất cả các controls trong Panel KhoHang
                foreach (Control control in KhoHang.Controls)
                {
                    // Kiểm tra nếu control có cùng tọa độ Y và tên là "textBoxTen"
                    if (control.Location.Y == y && control.Name == "txtName")
                    {
                        // Lưu tên cần xóa
                        nameNeedToDel = control.Text;
                        break; // Dừng vòng lặp
                    }
                }

                try
                {
                    // Mở tệp Excel "Kho Hàng.xlsx" bằng thư viện EPPlus
                    using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                    {
                        // Mở sheet đầu tiên
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                        // Khai báo giá trị bắt đầu là dòng 3
                        int start = worksheet.Dimension.Start.Row + 2;
                        int check = 0; // Biến kiểm tra

                        // Duyệt qua các dòng dữ liệu từ dòng 3 đến dòng cuối cùng
                        for (int i = start; i <= worksheet.Dimension.End.Row; i++)
                        {
                            // Nếu tên trong tệp Excel trùng với tên cần xóa (không phân biệt hoa thường)
                            if (worksheet.Cells[i, 1].Value.ToString().ToLower() == nameNeedToDel.ToLower())
                            {
                                check = 1; // Đánh dấu rằng tìm thấy tên trùng

                                // Xóa các ô dữ liệu tương ứng
                                worksheet.Cells[i, 1].Clear();
                                worksheet.Cells[i, 2].Clear();
                                worksheet.Cells[i, 3].Clear();
                                worksheet.Cells[i, 4].Clear();
                                worksheet.Cells[i, 5].Clear();

                                // Kiểm tra xem có phải dòng cuối không
                                if (i == Convert.ToUInt32(worksheet.Dimension.End.Row) + 1)
                                {
                                    // Nếu đã xóa một dòng, chỉ cần xóa dòng tiếp theo
                                    if (check != 0)
                                    {
                                        worksheet.DeleteRow(i, 1);
                                    }
                                    break; // Dừng vòng lặp
                                }
                                else
                                {
                                    // Dịch chuyển dữ liệu từ các dòng phía sau lên trên để ghi đè lên dòng hiện tại
                                    for (int j = i; j < worksheet.Dimension.End.Row; j++)
                                    {
                                        worksheet.Cells[j, 1].Value = worksheet.Cells[j + 1, 1].Value;
                                        worksheet.Cells[j, 2].Value = worksheet.Cells[j + 1, 2].Value;
                                        worksheet.Cells[j, 3].Value = worksheet.Cells[j + 1, 3].Value;
                                        worksheet.Cells[j, 4].Value = worksheet.Cells[j + 1, 4].Value;
                                        worksheet.Cells[j, 5].Formula = worksheet.Cells[j + 1, 5].Formula;
                                    }

                                    // Xóa dữ liệu ở hàng cuối cùng
                                    worksheet.DeleteRow(worksheet.Dimension.End.Row, 1);
                                    break; // Dừng vòng lặp
                                }
                            }

                            if (check != 0)
                            {
                                break; // Dừng vòng lặp nếu đã xóa tên
                            }
                        }

                        // Lưu tệp sau khi hoàn thành tất cả thay đổi
                        package.Save();
                        // Đóng file Excel
                        package.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                    MessageBox.Show("Xóa không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Hiển thị thông báo thành công sau khi xóa
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi hàm Refresh để cập nhật Panel KhoHang
                    Refresh(KhoHang, imgList);
                }
            }
            else
            {
                return;
            }
        }


    }
}
