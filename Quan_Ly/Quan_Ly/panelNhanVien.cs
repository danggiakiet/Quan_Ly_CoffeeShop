using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Quan_Ly
{
    public class panelNhanVien
    {
        List<nhanVien> dsNhanVien = new List<nhanVien>();
        ControlPanel ControlPanel = new ControlPanel();
        public void Main(Panel panelNhanVien, ImageList imgList)
        {
            //Lấy thông tin từ data
            LoadDataFromExcel();
            //Đưa thông tin lên panelpanelNhanVien
            renderControlsToPanel(panelNhanVien, imgList);

        }

        private void LoadDataFromExcel()
        {
            //Làm mới danh sách
            dsNhanVien.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Nhân Viên.xlsx")))
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
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //đưa dữ liệu lên PanelpanelNhanVien
        private void renderControlsToPanel(Panel panelNhanVien, ImageList imgList)
        {
            //vị trí control đầu tiên
            int x = 5, y = 120, index = 0;
            //duyệt dsNguyenLieu
            foreach (nhanVien nhanVien in dsNhanVien)
            {
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, biến nguyenLieu, số thứ tự trên panel và panelpanelNhanVien)
                AddControlToPanel(x, y, nhanVien, index, panelNhanVien, imgList);
                //chỉnh vị trí và stt cho control tiếp theo
                y += 40;
                index++;
            }
        }

        private void AddControlToPanel(int x, int y, nhanVien nhanVien, int index, Panel panelNhanVien, ImageList imgList)
        {
            TextBox textBoxTen = ControlPanel.CreateTextBoxTen(nhanVien.ten, HorizontalAlignment.Left, x, y, 245, 35);
            TextBox textBoxSoDienThoai = ControlPanel.CreateTextBox(nhanVien.soDienThoai, HorizontalAlignment.Right, x + 250, y, 160, 35);
            string ngaySinhFormatted = nhanVien.ngaySinh.ToString("dd/MM/yyyy");
            TextBox textBoxNgaySinh = ControlPanel.CreateTextBox(ngaySinhFormatted, HorizontalAlignment.Right, x + 415, y, 160, 35);
            string luongFormatted = nhanVien.luong.ToString("N0");
            TextBox textBoxLuong = ControlPanel.CreateTextBox(luongFormatted, HorizontalAlignment.Right, x + 580, y, 160, 35);
            Button buttonDelete = ControlPanel.CreateButton(x + 755, y, 35, 35, imgList);

            panelNhanVien.Controls.Add(textBoxTen);
            panelNhanVien.Controls.Add(textBoxSoDienThoai);
            panelNhanVien.Controls.Add(textBoxNgaySinh);
            panelNhanVien.Controls.Add(textBoxLuong);
            panelNhanVien.Controls.Add(buttonDelete);

            //// Định nghĩa sự kiện Click cho nút buttonDelete
            //buttonDelete.Click += (sender, e) => bttDelete(buttonDelete, panelNhanVien, imgList);

        }

        public void Refresh(Panel panelNhanVien, ImageList imgList)
        {
            ClearPanelControls(panelNhanVien);
            LoadDataFromExcel();
            renderControlsToPanel(panelNhanVien, imgList);
        }

        private void ClearPanelControls(Panel panelNhanVien)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là textbox, button và NumericUpDown
            List<Control> controlsToRemove = panelNhanVien.Controls.OfType<Control>().Where(control =>
                control is TextBox || control is NumericUpDown || control is Button).ToList();

            foreach (Control control in controlsToRemove)
            {
                panelNhanVien.Controls.Remove(control);
                control.Dispose();
            }

        }

        //public void Save(Panel panelNhanVien, ImageList imgList)
        //{
        //    try
        //    {
        //        using (var package = new ExcelPackage(new FileInfo("data/Nhân Viên.xlsx")))
        //        {
        //            ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
        //            int i = 3;

        //            foreach (Control control in panelNhanVien.Controls.OfType<NumericUpDown>())
        //            {
        //                worksheet.Cells[i, 3].Value = ((NumericUpDown)control).Value;
        //                i++;
        //            }

        //            package.Save();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Refresh(panelNhanVien, imgList);
        //    }
        //}
    }
}
