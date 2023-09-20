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

            khoHang.Main(panelKhoHang);
        }
        private void bttRefreshPanelKhoHang_Click(object sender, EventArgs e)
        {
            khoHang.Refresh(panelKhoHang);
        }

        private void bttSaveValuePanelKhoHang_Click(object sender, EventArgs e)
        {
            khoHang.Save(panelKhoHang);
        }

        private void bttThemMoiKhoHang_Click(object sender, EventArgs e)
        {
            khoHang.addNew(txtNamePanelTMKH.Text, txtDonViPanelTMKH.Text, Convert.ToInt32(txtSoLuongPanelTMKH.Text), Convert.ToInt32(txtDonGiaPanelTMKH.Text), panelKhoHang);
        }

        private void bttRefreshPanelTMKH_Click(object sender, EventArgs e)
        {
            control.Clear_TextBox(panelThemMoiKhoHang);
        }
    }
}
