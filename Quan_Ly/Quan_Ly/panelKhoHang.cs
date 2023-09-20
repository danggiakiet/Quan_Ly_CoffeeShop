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


namespace Quan_Ly
{
    public class panelKhoHang
    {
        //Tạo dsNguyenLieu chứa thông tin từ kho hàng
        private List<nguyenLieu> dsNguyenLieu = new List<nguyenLieu>();

        public void Main(Panel KhoHang)
        {
            //Lấy thông tin từ data
            LoadDataFromExcel();
            //Đưa thông tin lên panelKhoHang
            renderControlsToPanel(KhoHang);
        }

        private void LoadDataFromExcel()
        {
            //Làm mới danh sách
            dsNguyenLieu.Clear();
            try
            {
                //Mở file excel
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    //lấy sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    //cho duyệt từ dòng 3 đến hết
                    for (int i = 3; i <= worksheet.Dimension.End.Row; i++)
                    {
                        //khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string tenNguyenLieu = worksheet.Cells[i, 1].Value.ToString();
                        string donVi = worksheet.Cells[i, 2].Value.ToString();
                        int soLuong = Convert.ToInt32(worksheet.Cells[i, 3].Value);
                        int donGia = Convert.ToInt32(worksheet.Cells[i, 4].Value);
                        //tạo biến nguyenLieu để thêm vào dsNguyenLieu
                        nguyenLieu nLieu = new nguyenLieu(tenNguyenLieu, donVi, soLuong, donGia);
                        //thêm biến vừa tạo vào dsNguyenLieu
                        dsNguyenLieu.Add(nLieu);
                    }
                }
            }
            catch (Exception ex)
            {
                //Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //đưa dữ liệu lên PanelKhoHang
        private void renderControlsToPanel(Panel KhoHang)
        {
            //vị trí control đầu tiên
            int x = 5, y = 120, index = 0;
            //duyệt dsNguyenLieu
            foreach (nguyenLieu nguyenLieu in dsNguyenLieu)
            {
                //Gọi hàm thêm control vào panel với các giá trị: vị trí x, vị trí y, biến nguyenLieu, số thứ tự trên panel và panelKhoHang)
                AddControlToPanel(x, y, nguyenLieu, index, KhoHang);
                //chỉnh vị trí và stt cho control tiếp theo
                y += 40;
                index++;
            }
        }

        private void AddControlToPanel(int x, int y, nguyenLieu nguyenLieu, int index, Panel KhoHang)
        {
            TextBox textBoxTen = CreateTextBox(nguyenLieu.ten, HorizontalAlignment.Left, x, y, 410, 35);
            TextBox textBoxDonVi = CreateTextBox(nguyenLieu.donVi, HorizontalAlignment.Center, x + 415, y, 100, 35);
            NumericUpDown numericUpDownSoLuong = CreateNumericUpDown(nguyenLieu.soLuong, HorizontalAlignment.Right, x + 520, y, 95);

            KhoHang.Controls.Add(textBoxTen);
            KhoHang.Controls.Add(textBoxDonVi);
            KhoHang.Controls.Add(numericUpDownSoLuong);
        }

        private TextBox CreateTextBox(string text, HorizontalAlignment align, int x, int y, int width, int height)
        {
            TextBox textBox = new TextBox();
            textBox.Text = text;
            textBox.TextAlign = align;
            textBox.ReadOnly = true;
            textBox.Width = width;
            textBox.Height = height;
            textBox.Location = new Point(x, y);
            return textBox;
        }

        private NumericUpDown CreateNumericUpDown(int value, HorizontalAlignment align, int x, int y, int width)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Value = value;
            numericUpDown.TextAlign = align;
            numericUpDown.Width = width;
            numericUpDown.Location = new Point(x, y);
            return numericUpDown;
        }

        public void Refresh(Panel KhoHang)
        {
            ClearPanelControls(KhoHang);
            LoadDataFromExcel();
            renderControlsToPanel(KhoHang);
        }

        private void ClearPanelControls(Panel KhoHang)
        {
            //tạo danh sách chứa controls cần xóa, các controls cần xóa là textbox và NumericUpDown
            List<Control> controlsToRemove = KhoHang.Controls.OfType<Control>().Where(control =>
                control is TextBox || control is NumericUpDown).ToList();

            foreach (Control control in controlsToRemove)
            {
                KhoHang.Controls.Remove(control);
                control.Dispose();
            }

        }

        public void Save(Panel KhoHang)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int i = 3;

                    foreach (Control control in KhoHang.Controls.OfType<NumericUpDown>())
                    {
                        worksheet.Cells[i, 3].Value = ((NumericUpDown)control).Value;
                        i++;
                    }

                    package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh(KhoHang);
            }
        }

        public void addNew(string ten, string donVi, int soLuong, int donGia, Panel KhoHang)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo("data/Kho Hàng.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int i = worksheet.Dimension.End.Row;
                    worksheet.Cells[i + 1, 1].Value = ten;
                    worksheet.Cells[i + 1, 2].Value = donVi;
                    worksheet.Cells[i + 1, 3].Value = soLuong.ToString();
                    worksheet.Cells[i + 1, 4].Value = donGia.ToString();
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh(KhoHang);
            }
        }
    }
}
