using MetroFramework.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly
{
    public partial class formMain : MetroFramework.Forms.MetroForm
    {
        ControlPanel control = new ControlPanel();
        panelKhoHang khoHang = new panelKhoHang();
        panelNhanVien nhanVien = new panelNhanVien();
        panelThongKe thongKe = new panelThongKe();
        panelDoanhThu doanhThu = new panelDoanhThu();
        panelBanHang banHang = new panelBanHang();
        public formMain()
        {
            InitializeComponent();

        }
        private void formMain_Load(object sender, EventArgs e)
        {
            bttBanHang.Visible = false;
            dateTime.Text = DateTime.Today.ToString("dd/MM/yyyy");
            khoHang.Main(panelKhoHang, imageIconList);
            cbbMonth.SelectedIndex = Convert.ToInt32(DateTime.Today.Month - 1);
            dateTime_PanelDoanhThu_ValueChanged(sender, e);
            banHang.Main(Convert.ToDateTime(dateTime.Text), panelBanHang_Menu, panelBanHang_Total, txtTotalPrice, imageIconList);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formDoiMatKhau formDoiMatKhau = new formDoiMatKhau();
            formDoiMatKhau.ShowDialog();
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

        private void bttRefreshPanelThongKe_Click(object sender, EventArgs e)
        {
            thongKe.Refresh(panelDsThongKe, DateTime.Today.Month);
        }
    }
}
