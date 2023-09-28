using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Quan_Ly
{
    public class panelNhanVien
    {
        List<nhanVien> dsNhanVien = new List<nhanVien>();
        ControlPanel ControlPanel = new ControlPanel();
        public void Main(Panel panelNhanVien, ImageList imgList, string permission)
        {
            //Lấy thông tin từ data
            LoadDataFromExcel(permission);
            //Đưa thông tin lên panelpanelNhanVien
            renderControlsToPanel(panelNhanVien, imgList, permission);

        }

        private void LoadDataFromExcel(string permission)
        {
            //Làm mới danh sách
            dsNhanVien.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Nhân Viên.xlsx")))
                {
                    if (permission == "member")
                    {
                        //lấy sheet đầu tiên
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                        //cho duyệt từ dòng 3 đến hết
                        for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                        {
                            //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                            string hoVaTen = worksheet.Cells[i, 1].Value.ToString();
                            string soDienThoai = worksheet.Cells[i, 2].Value.ToString();
                            DateTime ngaySinh = Convert.ToDateTime(worksheet.Cells[i, 3].Value);
                            int luong = Convert.ToInt32(worksheet.Cells[i, 4].Value);
                            //tạo biến nguyenLieu để thêm vào dsNguyenLieu
                            nhanVien nVien = new nhanVien(hoVaTen, soDienThoai, ngaySinh, luong);
                            //thêm biến vừa tạo vào dsNguyenLieu
                            dsNhanVien.Add(nVien);
                        }
                    }
                    else if (permission == "admin")
                    {
                        //lấy sheet 2
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[2];
                        //cho duyệt từ dòng 3 đến hết
                        for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                        {
                            //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                            string hoVaTen = worksheet.Cells[i, 1].Value.ToString();
                            string soDienThoai = worksheet.Cells[i, 2].Value.ToString();
                            DateTime ngaySinh = Convert.ToDateTime(worksheet.Cells[i, 3].Value);
                            int luong = Convert.ToInt32(worksheet.Cells[i, 4].Value);
                            //tạo biến nguyenLieu để thêm vào dsNguyenLieu
                            nhanVien nVien = new nhanVien(hoVaTen, soDienThoai, ngaySinh, luong);
                            //thêm biến vừa tạo vào dsNguyenLieu
                            dsNhanVien.Add(nVien);
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
        //đưa dữ liệu lên PanelpanelNhanVien
        private void renderControlsToPanel(Panel panelNhanVien, ImageList imgList, string permission)
        {
            //vị trí control đầu tiên
            int x = 5, y = 60, index = 0;
            //duyệt dsNguyenLieu
            foreach (nhanVien nhanVien in dsNhanVien)
            {
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, biến nguyenLieu, số thứ tự trên panel và panelpanelNhanVien)
                AddControlToPanel(x, y, nhanVien, index, panelNhanVien, imgList, permission);
                //chỉnh vị trí và stt cho control tiếp theo
                y += 40;
                index++;
            }
        }

        private void AddControlToPanel(int x, int y, nhanVien nhanVien, int index, Panel panelNhanVien, ImageList imgList, string permission)
        {
            TextBox textBoxTen = ControlPanel.CreateTextBox("txtName", nhanVien.ten, HorizontalAlignment.Left, x, y, 245, 35);
            TextBox textBoxSoDienThoai = ControlPanel.CreateTextBox("txtSoDienThoai", nhanVien.soDienThoai, HorizontalAlignment.Right, x + 250, y, 160, 35);
            DateTimePicker dateTimeNgaySinh = ControlPanel.CreateDateTimePicker("dateTimeNgaySinh", nhanVien.ngaySinh, "dd/MM/yyyy", x + 415, y, 160, 35);
            TextBox textBoxLuong = ControlPanel.CreateTextBox("txtLuong", nhanVien.luong.ToString(), HorizontalAlignment.Right, x + 580, y, 160, 35);
            Button buttonDelete = ControlPanel.CreateButton(x + 755, y, 35, 35, imgList);

            panelNhanVien.Controls.Add(textBoxTen);
            panelNhanVien.Controls.Add(textBoxSoDienThoai);
            panelNhanVien.Controls.Add(dateTimeNgaySinh);
            panelNhanVien.Controls.Add(textBoxLuong);
            panelNhanVien.Controls.Add(buttonDelete);

            // Định nghĩa sự kiện Click cho nút buttonDelete
            buttonDelete.Click += (sender, e) => bttDelete(buttonDelete, panelNhanVien, imgList, permission);

        }
        public void bttDelete(Button buttonDelete, Panel KhoHang, ImageList imgList, string permission)
        {
            // Khai báo biến lưu trữ tên cần xóa
            string nameNeedToDel = "";

            // Lấy tọa độ Y của nút xóa
            int y = buttonDelete.Location.Y;

            // Duyệt qua tất cả các controls trong Panel KhoHang
            foreach (Control control in KhoHang.Controls)
            {
                // Kiểm tra nếu control có cùng tọa độ Y và tên là "textBoxTen"
                if (control.Location.Y == y && control.Name == "textBoxTen")
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
                Refresh(KhoHang, imgList, permission);
            }
        }

        public void Refresh(Panel panelNhanVien, ImageList imgList, string permission)
        {
            ClearPanelControls(panelNhanVien);
            LoadDataFromExcel(permission);
            renderControlsToPanel(panelNhanVien, imgList, permission);
        }

        private void ClearPanelControls(Panel panelNhanVien)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là textbox, button và NumericUpDown
            List<Control> controlsToRemove = panelNhanVien.Controls.OfType<Control>().Where(control =>
                control is TextBox || control is DateTimePicker || control is Button).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelNhanVien.Controls.Remove(control);
                control.Dispose();
            }

        }

        public void Save(Panel panelNhanVien, ImageList imgList, string permission)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo("data/Nhân Viên.xlsx")))
                {
                    if (permission.ToLower() == "member")
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                        // Lặp qua các controls trên panelNhanVien và lấy dữ liệu để ghi vào Excel
                        for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                        {
                            foreach (Control control in panelNhanVien.Controls)
                            {
                                if (control is TextBox textBox)
                                {
                                    string controlName = textBox.Name;
                                    string cellValue = textBox.Text;

                                    // Ghi dữ liệu vào cột tương ứng
                                    if (controlName == "txtName")
                                        worksheet.Cells[i, 1].Value = cellValue;
                                    else if (controlName == "txtSoDienThoai")
                                        worksheet.Cells[i, 2].Value = cellValue;
                                    else if (controlName == "txtLuong")
                                        worksheet.Cells[i, 4].Value = cellValue;
                                }
                                else if (control is DateTimePicker dateTimePicker)
                                {
                                    string controlName = dateTimePicker.Name;
                                    DateTime cellValue = dateTimePicker.Value;

                                    // Ghi dữ liệu vào cột tương ứng
                                    if (controlName == "dateTimeNgaySinh")
                                        worksheet.Cells[i, 3].Value = cellValue;
                                }
                            }
                            i++;
                        }
                        package.Save();
                    }
                    else if (permission.ToLower() == "admin")
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[2];
                        // Lặp qua các controls trên panelNhanVien và lấy dữ liệu để ghi vào Excel
                        for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                        {
                            foreach (Control control in panelNhanVien.Controls)
                            {
                                if (control is TextBox textBox)
                                {
                                    string controlName = textBox.Name;
                                    string cellValue = textBox.Text;

                                    // Ghi dữ liệu vào cột tương ứng
                                    if (controlName == "txtName")
                                        worksheet.Cells[i, 1].Value = cellValue;
                                    else if (controlName == "txtSoDienThoai")
                                        worksheet.Cells[i, 2].Value = cellValue;
                                    else if (controlName == "txtLuong")
                                        worksheet.Cells[i, 4].Value = cellValue;
                                }
                                else if (control is DateTimePicker dateTimePicker)
                                {
                                    string controlName = dateTimePicker.Name;
                                    DateTime cellValue = dateTimePicker.Value;

                                    // Ghi dữ liệu vào cột tương ứng
                                    if (controlName == "dateTimeNgaySinh")
                                        worksheet.Cells[i, 3].Value = cellValue;
                                }
                            }
                            i++;
                        }
                        package.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh(panelNhanVien, imgList, permission);
            }
        }

    }
}
