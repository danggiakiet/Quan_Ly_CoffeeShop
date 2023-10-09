namespace Quan_Ly
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.imageIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabKhoHang = new System.Windows.Forms.TabPage();
            this.panelKhoHang = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThemMoiKhoHang = new System.Windows.Forms.Panel();
            this.txtMaNguyenLieuPanelTMKH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.panelDsThongKe = new System.Windows.Forms.Panel();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabKhoHang.SuspendLayout();
            this.panelKhoHang.SuspendLayout();
            this.panelThemMoiKhoHang.SuspendLayout();
            this.panelChucNangKhoHang.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.panelThongKe.SuspendLayout();
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
            this.imageIconList.Images.SetKeyName(9, "trash-outline.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhoHang);
            this.tabControl.Controls.Add(this.tabThongKe);
            this.tabControl.Controls.Add(this.tabBanHang);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.imageIconList;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(17, 136);
            this.tabControl.MainPage = "";
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1236, 525);
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
            this.tabKhoHang.Controls.Add(this.panelKhoHang);
            this.tabKhoHang.Controls.Add(this.panelThemMoiKhoHang);
            this.tabKhoHang.Controls.Add(this.panelChucNangKhoHang);
            this.tabKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKhoHang.ImageIndex = 4;
            this.tabKhoHang.Location = new System.Drawing.Point(0, 40);
            this.tabKhoHang.Name = "tabKhoHang";
            this.tabKhoHang.Size = new System.Drawing.Size(1236, 485);
            this.tabKhoHang.TabIndex = 1;
            this.tabKhoHang.Text = "Kho Hàng";
            // 
            // panelKhoHang
            // 
            this.panelKhoHang.AutoScroll = true;
            this.panelKhoHang.BackColor = System.Drawing.Color.White;
            this.panelKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelKhoHang.Controls.Add(this.label14);
            this.panelKhoHang.Controls.Add(this.label13);
            this.panelKhoHang.Controls.Add(this.label12);
            this.panelKhoHang.Controls.Add(this.label4);
            this.panelKhoHang.Controls.Add(this.label3);
            this.panelKhoHang.Controls.Add(this.label2);
            this.panelKhoHang.Controls.Add(this.label1);
            this.panelKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelKhoHang.Location = new System.Drawing.Point(11, 12);
            this.panelKhoHang.Name = "panelKhoHang";
            this.panelKhoHang.Size = new System.Drawing.Size(830, 460);
            this.panelKhoHang.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mã";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(758, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "Xóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(652, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 91);
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
            this.label2.Location = new System.Drawing.Point(244, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng nguyên liệu còn lại";
            // 
            // panelThemMoiKhoHang
            // 
            this.panelThemMoiKhoHang.BackColor = System.Drawing.Color.White;
            this.panelThemMoiKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThemMoiKhoHang.Controls.Add(this.txtMaNguyenLieuPanelTMKH);
            this.panelThemMoiKhoHang.Controls.Add(this.label15);
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
            this.panelThemMoiKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelThemMoiKhoHang.Location = new System.Drawing.Point(855, 105);
            this.panelThemMoiKhoHang.Name = "panelThemMoiKhoHang";
            this.panelThemMoiKhoHang.Size = new System.Drawing.Size(367, 365);
            this.panelThemMoiKhoHang.TabIndex = 5;
            // 
            // txtMaNguyenLieuPanelTMKH
            // 
            this.txtMaNguyenLieuPanelTMKH.Location = new System.Drawing.Point(121, 56);
            this.txtMaNguyenLieuPanelTMKH.Name = "txtMaNguyenLieuPanelTMKH";
            this.txtMaNguyenLieuPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtMaNguyenLieuPanelTMKH.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 27);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mã :";
            // 
            // bttRefreshPanelTMKH
            // 
            this.bttRefreshPanelTMKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttRefreshPanelTMKH.ImageIndex = 6;
            this.bttRefreshPanelTMKH.ImageList = this.imageIconList;
            this.bttRefreshPanelTMKH.Location = new System.Drawing.Point(295, 317);
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
            this.bttThemPanelTMKH.Location = new System.Drawing.Point(195, 317);
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
            this.txtDonGiaPanelTMKH.Location = new System.Drawing.Point(121, 255);
            this.txtDonGiaPanelTMKH.Name = "txtDonGiaPanelTMKH";
            this.txtDonGiaPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtDonGiaPanelTMKH.TabIndex = 16;
            // 
            // txtSoLuongPanelTMKH
            // 
            this.txtSoLuongPanelTMKH.Location = new System.Drawing.Point(122, 205);
            this.txtSoLuongPanelTMKH.Name = "txtSoLuongPanelTMKH";
            this.txtSoLuongPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtSoLuongPanelTMKH.TabIndex = 15;
            // 
            // txtDonViPanelTMKH
            // 
            this.txtDonViPanelTMKH.Location = new System.Drawing.Point(122, 155);
            this.txtDonViPanelTMKH.Name = "txtDonViPanelTMKH";
            this.txtDonViPanelTMKH.Size = new System.Drawing.Size(226, 35);
            this.txtDonViPanelTMKH.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "Đơn giá  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 27);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng :";
            // 
            // txtNamePanelTMKH
            // 
            this.txtNamePanelTMKH.Location = new System.Drawing.Point(122, 105);
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
            this.label7.Location = new System.Drawing.Point(3, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn vị :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 27);
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
            this.panelChucNangKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChucNangKhoHang.Location = new System.Drawing.Point(856, 12);
            this.panelChucNangKhoHang.Name = "panelChucNangKhoHang";
            this.panelChucNangKhoHang.Size = new System.Drawing.Size(366, 81);
            this.panelChucNangKhoHang.TabIndex = 2;
            // 
            // bttSaveValuePanelKhoHang
            // 
            this.bttSaveValuePanelKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSaveValuePanelKhoHang.ImageIndex = 7;
            this.bttSaveValuePanelKhoHang.ImageList = this.imageIconList;
            this.bttSaveValuePanelKhoHang.Location = new System.Drawing.Point(294, 20);
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
            this.bttRefeshPanelKhoHang.Location = new System.Drawing.Point(113, 19);
            this.bttRefeshPanelKhoHang.Name = "bttRefeshPanelKhoHang";
            this.bttRefeshPanelKhoHang.Size = new System.Drawing.Size(53, 30);
            this.bttRefeshPanelKhoHang.TabIndex = 3;
            this.bttRefeshPanelKhoHang.UseVisualStyleBackColor = true;
            this.bttRefeshPanelKhoHang.Click += new System.EventHandler(this.bttRefreshPanelKhoHang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lưu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Refresh :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabThongKe.Controls.Add(this.panelThongKe);
            this.tabThongKe.ImageIndex = 5;
            this.tabThongKe.Location = new System.Drawing.Point(0, 40);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Size = new System.Drawing.Size(1236, 485);
            this.tabThongKe.TabIndex = 5;
            this.tabThongKe.Text = "Thống Kê";
            // 
            // panelThongKe
            // 
            this.panelThongKe.BackColor = System.Drawing.Color.White;
            this.panelThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThongKe.Controls.Add(this.panelDsThongKe);
            this.panelThongKe.Controls.Add(this.cbbMonth);
            this.panelThongKe.Controls.Add(this.label44);
            this.panelThongKe.Controls.Add(this.label32);
            this.panelThongKe.Location = new System.Drawing.Point(13, 10);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(1206, 460);
            this.panelThongKe.TabIndex = 2;
            // 
            // panelDsThongKe
            // 
            this.panelDsThongKe.AutoScroll = true;
            this.panelDsThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDsThongKe.Location = new System.Drawing.Point(15, 10);
            this.panelDsThongKe.Name = "panelDsThongKe";
            this.panelDsThongKe.Size = new System.Drawing.Size(1036, 432);
            this.panelDsThongKe.TabIndex = 5;
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(1124, 48);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(75, 31);
            this.cbbMonth.TabIndex = 4;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged_1);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1057, 56);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(61, 23);
            this.label44.TabIndex = 3;
            this.label44.Text = "Tháng";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1057, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(134, 23);
            this.label32.TabIndex = 1;
            this.label32.Text = "Thống kê theo:";
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
            this.tabBanHang.Size = new System.Drawing.Size(1236, 485);
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
            this.pictureBox1.Image = global::Quan_Ly.Properties.Resources.icon_120x120;
            this.pictureBox1.Location = new System.Drawing.Point(801, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.Padding = new System.Windows.Forms.Padding(26, 111, 26, 24);
            this.Text = "Tròn Coffee Shop";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKhoHang.ResumeLayout(false);
            this.panelKhoHang.ResumeLayout(false);
            this.panelKhoHang.PerformLayout();
            this.panelThemMoiKhoHang.ResumeLayout(false);
            this.panelThemMoiKhoHang.PerformLayout();
            this.panelChucNangKhoHang.ResumeLayout(false);
            this.panelChucNangKhoHang.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.panelThongKe.ResumeLayout(false);
            this.panelThongKe.PerformLayout();
            this.tabBanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageIconList;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabKhoHang;
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel panelKhoHang;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelThongKe;
        private System.Windows.Forms.Panel panelDsThongKe;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaNguyenLieuPanelTMKH;
        private System.Windows.Forms.Label label15;
    }
}

