﻿using MetroFramework.Controls;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        ControlPanel control = new ControlPanel();
        panelKhoHang khoHang = new panelKhoHang();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            khoHang.Main(panelKhoHang, imageIconList);
        }
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
            if (txtNamePanelTMKH.Text == "" || txtDonViPanelTMKH.Text == "" || txtSoLuongPanelTMKH.Text == "" || txtDonGiaPanelTMKH.Text == "")
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(txtSoLuongPanelTMKH.Text, out int soLuong) || !int.TryParse(txtDonGiaPanelTMKH.Text, out int donGia))
                {
                    MessageBox.Show("Yêu cầu số lượng hoặc đơn giá là dữ liệu kiểu số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    khoHang.addNew(txtNamePanelTMKH.Text, txtDonViPanelTMKH.Text, soLuong, donGia, panelKhoHang,imageIconList);
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
    }
}
