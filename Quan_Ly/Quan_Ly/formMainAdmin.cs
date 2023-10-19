using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using TextBox = System.Windows.Forms.TextBox;

namespace Quan_Ly
{
    public partial class formMainAdmin : MetroFramework.Forms.MetroForm
    {
        ControlPanel control = new ControlPanel();
        panelKhoHang khoHang = new panelKhoHang();
        panelNhanVien nhanVien = new panelNhanVien();
        panelThongKe thongKe = new panelThongKe();
        panelDoanhThu doanhThu = new panelDoanhThu();
        panelBanHang banHang = new panelBanHang();
        panelMenu menu = new panelMenu();
        public formMainAdmin(string tenNhanVien)
        {
            InitializeComponent();
            labelTenNV.Text += tenNhanVien;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formDoiMatKhau formDoiMatKhau = new formDoiMatKhau();
            formDoiMatKhau.ShowDialog();
        }
        private void formMainAdmin_Load(object sender, EventArgs e)
        {
            bttBanHang.Visible = false;
            dateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
            khoHang.Main(panelKhoHang, imageIconList);
            nhanVien.Main(panelMember, imageIconList, "member");
            nhanVien.Main(panelAdmin, imageIconList, "admin");
            cbbMonth.SelectedIndex = Convert.ToInt32(DateTime.Today.Month - 1);
            dateTime_PanelDoanhThu_ValueChanged(sender, e);
            banHang.Main(Convert.ToDateTime(dateTime.Text), panelBanHang_Menu, panelBanHang_Total, txtTotalPrice, imageIconList);
            menu.Main(panelMenu, imageIconList);

        }
        #region PanelKhoHang
        private void bttRefreshPanelKhoHang_Click(object sender, EventArgs e)
        {
            khoHang.Refresh(panelKhoHang, imageIconList);
        }

        private void bttSaveValuePanelKhoHang_Click(object sender, EventArgs e)
        {
            khoHang.Save(panelKhoHang, imageIconList);
        }

        private void bttThemMoiKhoHang_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieuPanelTMKH.Text == "" || txtNamePanelTMKH.Text == "" || txtDonViPanelTMKH.Text == "" || txtSoLuongPanelTMKH.Text == "" || txtDonGiaPanelTMKH.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(txtSoLuongPanelTMKH.Text, out int soLuong) || !int.TryParse(txtDonGiaPanelTMKH.Text, out int donGia))
                {
                    MessageBox.Show("Yêu cầu số lượng hoặc đơn giá là dữ liệu kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    khoHang.addNew(txtMaNguyenLieuPanelTMKH.Text, txtNamePanelTMKH.Text, txtDonViPanelTMKH.Text, soLuong, donGia, panelKhoHang, imageIconList);
                    txtMaNguyenLieuPanelTMKH.Clear();
                    txtNamePanelTMKH.Clear();
                    txtDonViPanelTMKH.Clear();
                    txtSoLuongPanelTMKH.Clear();
                    txtDonGiaPanelTMKH.Clear();
                }
            }
        }

        private void bttRefreshPanelTMKH_Click(object sender, EventArgs e)
        {
            control.Clear_TextBox(panelThemMoiKhoHang);
        }
        #endregion

        #region PanelNhanVien
        //Kiểm tra số điện thoại
        private bool kiemTraSoDienThoai(string input)
        {
            return input.All(char.IsDigit);
        }

        //Member
        private void btt_PanelMember_Refresh_Click(object sender, EventArgs e)
        {
            nhanVien.Refresh(panelMember, imageIconList, "member");
        }

        private void btt_PanelMember_Save_Click(object sender, EventArgs e)
        {
            nhanVien.Save(panelMember, imageIconList, "member");
        }

        private void btt_PanelMember_Add_Click(object sender, EventArgs e)
        {
            double luong;
            if (txt_TMNV_MaNV.Text == "" || txt_TMNV_Password.Text == "" || txt_TMNV_Ten.Text == "" || txt_TMNV_DienThoai.Text == "" || txt_TMNV_Luong.Text == "" || txt_TMNV_CauHoi.Text == "" || txt_TMNV_TraLoi.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (kiemTraSoDienThoai(txt_TMNV_DienThoai.Text))
                {
                    if (double.TryParse(txt_TMNV_Luong.Text, out luong))
                    {
                        nhanVien.addNew(panelMember, imageIconList, "member", txt_TMNV_MaNV.Text, txt_TMNV_Password.Text, txt_TMNV_CauHoi.Text, txt_TMNV_TraLoi.Text, txt_TMNV_Ten.Text, txt_TMNV_DienThoai.Text, dateTime_TMNV_NgaySinh, luong);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị lương phải là kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_TMNV_Luong.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại phải là kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TMNV_DienThoai.Clear();
                }
            }
        }

        private void btt_PanelMember_RefreshValue_Click(object sender, EventArgs e)
        {
            control.Clear_TextBox(panelMember_Add);
        }

        //Admin
        private void btt_PanelAdmin_Refresh_Click(object sender, EventArgs e)
        {
            nhanVien.Refresh(panelAdmin, imageIconList, "admin");
        }

        private void btt_PanelAdmin_Save_Click(object sender, EventArgs e)
        {
            nhanVien.Save(panelAdmin, imageIconList, "admin");
        }

        private void btt_PanelAdmin_Add_Click(object sender, EventArgs e)
        {
            double luong;
            if (txt_TMQL_MaNV.Text == "" || txt_TMQL_Password.Text == "" || txt_TMQL_Ten.Text == "" || txt_TMQL_Sdt.Text == "" || txt_TMQL_Luong.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (kiemTraSoDienThoai(txt_TMQL_Sdt.Text))
                {
                    if (double.TryParse(txt_TMQL_Luong.Text, out luong))
                    {
                        nhanVien.addNew(panelAdmin, imageIconList, "admin", txt_TMQL_MaNV.Text, txt_TMQL_Password.Text, txt_TMQL_CauHoi.Text, txt_TMQL_TraLoi.Text, txt_TMQL_Ten.Text, txt_TMQL_Sdt.Text, dateTime_TMQL_NgaySinh, luong);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị lương phải là kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_TMQL_Luong.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại phải là kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TMQL_Sdt.Clear();
                }
            }
        }

        private void btt_PanelAdmin_ResetValue_Click(object sender, EventArgs e)
        {
            control.Clear_TextBox(panelAdmin_Add);
        }

        #endregion

        #region PanelThongKe
        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongKe.Main(panelDsThongKe, Convert.ToInt32(cbbMonth.Text));
        }
        #endregion

        #region Panel DoanhThu
        private void dateTime_PanelDoanhThu_ValueChanged(object sender, EventArgs e)
        {
            doanhThu.Main(panelDoanhThu_SanPham, txtPanelDoanhThu_TienLoi, txtPanelDoanhThu_TienVon, dateTime_PanelDoanhThu.Value);
            doanhThu.LoadDataFromExcel_TienLoi_TienVon(dateTime_PanelDoanhThu.Value.Month, txt_PanelDoanhThu_TongLoiThang, txt_PanelDoanhThu_TongVonThang);
        }
        #endregion

        #region Panel BanHang
        private void checkPanelBanHang_Total(Panel panelTotal)
        {
            bool hasTextBox = false;

            foreach (Control control in panelTotal.Controls)
            {
                if (control is TextBox)
                {
                    hasTextBox = true;
                    break;
                }
            }

            bttBanHang.Visible = hasTextBox;
        }
        private void panelBanHang_Total_Paint(object sender, PaintEventArgs e)
        {
            checkPanelBanHang_Total(panelBanHang_Total);
        }
        private void bttBanHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thực hiện hành động này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                banHang.saveOrder(panelBanHang_Total, DateTime.Today.Month, DateTime.Today.Day);
                txtTotalPrice.Clear();
                dateTime_PanelDoanhThu_ValueChanged(sender, e);
                thongKe.Main(panelDsThongKe, Convert.ToInt32(cbbMonth.Text));
            }
        }
        #endregion

        #region Menu
        private string OpenFileWithDefaultPath()
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập đường dẫn mặc định là ổ C
            openFileDialog.InitialDirectory = "C:\\";

            // Thiết lập các thuộc tính khác cho hộp thoại mở tệp tin
            openFileDialog.Title = "Chọn tệp tin";
            openFileDialog.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tất cả các tệp tin|*.*";


            // Hiển thị hộp thoại mở tệp tin và kiểm tra kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn tới tệp tin mà người dùng đã chọn
                string selectedFilePath = openFileDialog.FileName;

                // Kiểm tra định dạng của tệp
                string fileExtension = System.IO.Path.GetExtension(selectedFilePath).ToLower();
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                {
                    // Nếu tệp là hình ảnh, trả về đường dẫn
                    return selectedFilePath;
                }
                else
                {
                    MessageBox.Show("File được chọn phải có định dạng hình ảnh: .jpg, .jpeg, .png", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            return null; // Trả về null nếu người dùng không chọn tệp tin
        }
        private void linkLabelOpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string file_path = OpenFileWithDefaultPath();
            txtMenu_imagePath.Text = file_path;
        }

        #endregion
        formLogin formLogin = new formLogin();
        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formLogin == null || formLogin.IsDisposed)
            {
                // Nếu formLogin chưa được tạo hoặc đã bị giải phóng, tạo một mới
                formLogin = new formLogin();
            }

            this.Hide();
            formLogin.Show();
        }
    }
}
