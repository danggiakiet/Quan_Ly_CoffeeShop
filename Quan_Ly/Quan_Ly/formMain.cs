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

namespace Quan_Ly
{
    public partial class formMain : MetroFramework.Forms.MetroForm
    {
        ControlPanel control = new ControlPanel();
        panelKhoHang khoHang = new panelKhoHang();
        panelThongKe thongKe = new panelThongKe();
        public formMain()
        {
            InitializeComponent();

        }
        private void formMain_Load(object sender, EventArgs e)
        {
            khoHang.Main(panelKhoHang, imageIconList);
            cbbMonth.SelectedIndex = Convert.ToInt32(DateTime.Today.Month - 1);
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
                    khoHang.addNew(txtMaNguyenLieuPanelTMKH.Text,txtNamePanelTMKH.Text, txtDonViPanelTMKH.Text, soLuong, donGia, panelKhoHang, imageIconList);
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
        private void cbbMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            thongKe.Main(panelDsThongKe, Convert.ToInt32(cbbMonth.Text));
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
