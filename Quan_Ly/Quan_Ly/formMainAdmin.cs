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

namespace Quan_Ly
{
    public partial class formMainAdmin : MetroFramework.Forms.MetroForm
    {
        ControlPanel control = new ControlPanel();
        panelKhoHang khoHang = new panelKhoHang();
        panelNhanVien nhanVien = new panelNhanVien();
        panelThongKe thongKe = new panelThongKe();
        public formMainAdmin()
        {
            InitializeComponent();

        }
        private void formMainAdmin_Load(object sender, EventArgs e)
        {
            khoHang.Main(panelKhoHang, imageIconList);
            nhanVien.Main(panelMember, imageIconList, "member");
            nhanVien.Main(panelAdmin, imageIconList, "admin");
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
            if (txt_TMNV_MaNV.Text == "" || txt_TMNV_Password.Text == "" || txt_TMNV_Ten.Text == "" || txt_TMNV_DienThoai.Text == "" || txt_TMNV_Luong.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (kiemTraSoDienThoai(txt_TMNV_DienThoai.Text))
                {
                    if (double.TryParse(txt_TMNV_Luong.Text, out luong))
                    {
                        nhanVien.addNew(panelMember, imageIconList, "member", txt_TMNV_MaNV.Text, txt_TMNV_Password.Text, txt_TMNV_Ten.Text, txt_TMNV_DienThoai.Text, dateTime_TMNV_NgaySinh, luong);
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
                        nhanVien.addNew(panelAdmin, imageIconList, "admin", txt_TMQL_MaNV.Text, txt_TMQL_Password.Text, txt_TMQL_Ten.Text, txt_TMQL_Sdt.Text, dateTime_TMQL_NgaySinh, luong);
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
    }
}
