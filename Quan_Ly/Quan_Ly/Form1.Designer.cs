namespace Quan_Ly
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabKhoHang = new System.Windows.Forms.TabPage();
            this.panelThemMoiKhoHang = new System.Windows.Forms.Panel();
            this.bttRefreshPanelTMKH = new System.Windows.Forms.Button();
            this.bttThemPanelTMKH = new System.Windows.Forms.Button();
            this.txtDonGiaPanelTMKH = new System.Windows.Forms.TextBox();
            this.txtSoLuongPanelTMKH = new System.Windows.Forms.TextBox();
            this.txtDonViPanelTMKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNamePanelTMKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelChucNangKhoHang = new System.Windows.Forms.Panel();
            this.bttSaveValuePanelKhoHang = new System.Windows.Forms.Button();
            this.bttRefeshPanelKhoHang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelKhoHang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabKhoHang.SuspendLayout();
            this.panelThemMoiKhoHang.SuspendLayout();
            this.panelChucNangKhoHang.SuspendLayout();
            this.panelKhoHang.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.tabBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageIconList
            // 
            this.imageIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIconList.ImageStream")));
            this.imageIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIconList.Images.SetKeyName(0, "cafe.png");
            this.imageIconList.Images.SetKeyName(1, "home.png");
            this.imageIconList.Images.SetKeyName(2, "people.png");
            this.imageIconList.Images.SetKeyName(3, "stats-chart.png");
            this.imageIconList.Images.SetKeyName(4, "storefront.png");
            this.imageIconList.Images.SetKeyName(5, "pie-chart.png");
            this.imageIconList.Images.SetKeyName(6, "refresh-circle.png");
            this.imageIconList.Images.SetKeyName(7, "save.png");
            this.imageIconList.Images.SetKeyName(8, "add-circle.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhoHang);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabThongKe);
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabBanHang);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.imageIconList;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(4, 136);
            this.tabControl.MainPage = "";
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1046, 606);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Style = Sunny.UI.UIStyle.Custom;
            this.tabControl.TabBackColor = System.Drawing.Color.White;
            this.tabControl.TabIndex = 2;
            this.tabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabControl.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.tabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // tabKhoHang
            // 
            this.tabKhoHang.AutoScroll = true;
            this.tabKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabKhoHang.Controls.Add(this.panelThemMoiKhoHang);
            this.tabKhoHang.Controls.Add(this.panelChucNangKhoHang);
            this.tabKhoHang.Controls.Add(this.panelKhoHang);
            this.tabKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKhoHang.ImageIndex = 4;
            this.tabKhoHang.Location = new System.Drawing.Point(0, 40);
            this.tabKhoHang.Name = "tabKhoHang";
            this.tabKhoHang.Size = new System.Drawing.Size(1046, 566);
            this.tabKhoHang.TabIndex = 1;
            this.tabKhoHang.Text = "Kho Hàng";
            // 
            // panelThemMoiKhoHang
            // 
            this.panelThemMoiKhoHang.BackColor = System.Drawing.Color.White;
            this.panelThemMoiKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThemMoiKhoHang.Controls.Add(this.bttRefreshPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.bttThemPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.txtDonGiaPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.txtSoLuongPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.txtDonViPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.label11);
            this.panelThemMoiKhoHang.Controls.Add(this.label10);
            this.panelThemMoiKhoHang.Controls.Add(this.txtNamePanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.label9);
            this.panelThemMoiKhoHang.Controls.Add(this.label7);
            this.panelThemMoiKhoHang.Controls.Add(this.label8);
            this.panelThemMoiKhoHang.Location = new System.Drawing.Point(671, 169);
            this.panelThemMoiKhoHang.Name = "panelThemMoiKhoHang";
            this.panelThemMoiKhoHang.Size = new System.Drawing.Size(359, 382);
            this.panelThemMoiKhoHang.TabIndex = 5;
            // 
            // bttRefreshPanelTMKH
            // 
            this.bttRefreshPanelTMKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttRefreshPanelTMKH.ImageIndex = 6;
            this.bttRefreshPanelTMKH.ImageList = this.imageIconList;
            this.bttRefreshPanelTMKH.Location = new System.Drawing.Point(295, 282);
            this.bttRefreshPanelTMKH.Name = "bttRefreshPanelTMKH";
            this.bttRefreshPanelTMKH.Size = new System.Drawing.Size(53, 38);
            this.bttRefreshPanelTMKH.TabIndex = 5;
            this.bttRefreshPanelTMKH.UseVisualStyleBackColor = true;
            this.bttRefreshPanelTMKH.Click += new System.EventHandler(this.bttRefreshPanelTMKH_Click);
            // 
            // bttThemPanelTMKH
            // 
            this.bttThemPanelTMKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttThemPanelTMKH.ImageIndex = 8;
            this.bttThemPanelTMKH.ImageList = this.imageIconList;
            this.bttThemPanelTMKH.Location = new System.Drawing.Point(195, 282);
            this.bttThemPanelTMKH.Name = "bttThemPanelTMKH";
            this.bttThemPanelTMKH.Size = new System.Drawing.Size(94, 38);
            this.bttThemPanelTMKH.TabIndex = 17;
            this.bttThemPanelTMKH.Text = "Thêm";
            this.bttThemPanelTMKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttThemPanelTMKH.UseVisualStyleBackColor = true;
            this.bttThemPanelTMKH.Click += new System.EventHandler(this.bttThemMoiKhoHang_Click);
            // 
            // txtDonGiaPanelTMKH
            // 
            this.txtDonGiaPanelTMKH.Location = new System.Drawing.Point(121, 220);
            this.txtDonGiaPanelTMKH.Name = "txtDonGiaPanelTMKH";
            this.txtDonGiaPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtDonGiaPanelTMKH.TabIndex = 16;
            // 
            // txtSoLuongPanelTMKH
            // 
            this.txtSoLuongPanelTMKH.Location = new System.Drawing.Point(122, 170);
            this.txtSoLuongPanelTMKH.Name = "txtSoLuongPanelTMKH";
            this.txtSoLuongPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtSoLuongPanelTMKH.TabIndex = 15;
            // 
            // txtDonViPanelTMKH
            // 
            this.txtDonViPanelTMKH.Location = new System.Drawing.Point(122, 120);
            this.txtDonViPanelTMKH.Name = "txtDonViPanelTMKH";
            this.txtDonViPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtDonViPanelTMKH.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "Đơn giá  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng :";
            // 
            // txtNamePanelTMKH
            // 
            this.txtNamePanelTMKH.Location = new System.Drawing.Point(122, 70);
            this.txtNamePanelTMKH.Name = "txtNamePanelTMKH";
            this.txtNamePanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtNamePanelTMKH.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thêm mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn vị :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên      :";
            // 
            // panelChucNangKhoHang
            // 
            this.panelChucNangKhoHang.BackColor = System.Drawing.Color.White;
            this.panelChucNangKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChucNangKhoHang.Controls.Add(this.bttSaveValuePanelKhoHang);
            this.panelChucNangKhoHang.Controls.Add(this.bttRefeshPanelKhoHang);
            this.panelChucNangKhoHang.Controls.Add(this.label6);
            this.panelChucNangKhoHang.Controls.Add(this.label5);
            this.panelChucNangKhoHang.Location = new System.Drawing.Point(671, 12);
            this.panelChucNangKhoHang.Name = "panelChucNangKhoHang";
            this.panelChucNangKhoHang.Size = new System.Drawing.Size(359, 151);
            this.panelChucNangKhoHang.TabIndex = 2;
            // 
            // bttSaveValuePanelKhoHang
            // 
            this.bttSaveValuePanelKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSaveValuePanelKhoHang.ImageIndex = 7;
            this.bttSaveValuePanelKhoHang.ImageList = this.imageIconList;
            this.bttSaveValuePanelKhoHang.Location = new System.Drawing.Point(141, 87);
            this.bttSaveValuePanelKhoHang.Name = "bttSaveValuePanelKhoHang";
            this.bttSaveValuePanelKhoHang.Size = new System.Drawing.Size(53, 30);
            this.bttSaveValuePanelKhoHang.TabIndex = 4;
            this.bttSaveValuePanelKhoHang.UseVisualStyleBackColor = true;
            this.bttSaveValuePanelKhoHang.Click += new System.EventHandler(this.bttSaveValuePanelKhoHang_Click);
            // 
            // bttRefeshPanelKhoHang
            // 
            this.bttRefeshPanelKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttRefeshPanelKhoHang.ImageIndex = 6;
            this.bttRefeshPanelKhoHang.ImageList = this.imageIconList;
            this.bttRefeshPanelKhoHang.Location = new System.Drawing.Point(141, 34);
            this.bttRefeshPanelKhoHang.Name = "bttRefeshPanelKhoHang";
            this.bttRefeshPanelKhoHang.Size = new System.Drawing.Size(53, 30);
            this.bttRefeshPanelKhoHang.TabIndex = 3;
            this.bttRefeshPanelKhoHang.UseVisualStyleBackColor = true;
            this.bttRefeshPanelKhoHang.Click += new System.EventHandler(this.bttRefreshPanelKhoHang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lưu         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Refresh    :";
            // 
            // panelKhoHang
            // 
            this.panelKhoHang.AutoScroll = true;
            this.panelKhoHang.BackColor = System.Drawing.Color.White;
            this.panelKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelKhoHang.Controls.Add(this.label4);
            this.panelKhoHang.Controls.Add(this.label3);
            this.panelKhoHang.Controls.Add(this.label2);
            this.panelKhoHang.Controls.Add(this.label1);
            this.panelKhoHang.Location = new System.Drawing.Point(11, 12);
            this.panelKhoHang.Name = "panelKhoHang";
            this.panelKhoHang.Size = new System.Drawing.Size(654, 539);
            this.panelKhoHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "S/Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng nguyên liệu còn lại";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.AutoScroll = true;
            this.tabNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabNhanVien.Controls.Add(this.panel3);
            this.tabNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanVien.ImageIndex = 2;
            this.tabNhanVien.Location = new System.Drawing.Point(0, 40);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(1046, 566);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân Viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 539);
            this.panel3.TabIndex = 1;
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabThongKe.Controls.Add(this.panel4);
            this.tabThongKe.ImageIndex = 5;
            this.tabThongKe.Location = new System.Drawing.Point(0, 40);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Size = new System.Drawing.Size(1046, 566);
            this.tabThongKe.TabIndex = 5;
            this.tabThongKe.Text = "Thống Kê";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(13, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 539);
            this.panel4.TabIndex = 1;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.AutoScroll = true;
            this.tabDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDoanhThu.Controls.Add(this.panel5);
            this.tabDoanhThu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoanhThu.ImageIndex = 3;
            this.tabDoanhThu.Location = new System.Drawing.Point(0, 40);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Size = new System.Drawing.Size(1046, 566);
            this.tabDoanhThu.TabIndex = 3;
            this.tabDoanhThu.Text = "Doanh Thu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(11, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 539);
            this.panel5.TabIndex = 1;
            // 
            // tabBanHang
            // 
            this.tabBanHang.AutoScroll = true;
            this.tabBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabBanHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabBanHang.Controls.Add(this.panel1);
            this.tabBanHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBanHang.ImageIndex = 0;
            this.tabBanHang.Location = new System.Drawing.Point(0, 40);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Size = new System.Drawing.Size(1046, 566);
            this.tabBanHang.TabIndex = 4;
            this.tabBanHang.Text = "Bán Hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 539);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(801, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(26, 111, 26, 24);
            this.Text = "Tròn Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhoHang.ResumeLayout(false);
            this.panelThemMoiKhoHang.ResumeLayout(false);
            this.panelThemMoiKhoHang.PerformLayout();
            this.panelChucNangKhoHang.ResumeLayout(false);
            this.panelChucNangKhoHang.PerformLayout();
            this.panelKhoHang.ResumeLayout(false);
            this.panelKhoHang.PerformLayout();
            this.tabNhanVien.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabBanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageIconList;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabKhoHang;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel panelKhoHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChucNangKhoHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttSaveValuePanelKhoHang;
        private System.Windows.Forms.Button bttRefeshPanelKhoHang;
        private System.Windows.Forms.Panel panelThemMoiKhoHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttThemPanelTMKH;
        private System.Windows.Forms.TextBox txtDonGiaPanelTMKH;
        private System.Windows.Forms.TextBox txtSoLuongPanelTMKH;
        private System.Windows.Forms.TextBox txtDonViPanelTMKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNamePanelTMKH;
        private System.Windows.Forms.Button bttRefreshPanelTMKH;
    }
}

