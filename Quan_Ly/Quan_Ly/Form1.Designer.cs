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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabTrangChu = new System.Windows.Forms.TabPage();
            this.tabKhoHang = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cafe.png");
            this.imageList.Images.SetKeyName(1, "home.png");
            this.imageList.Images.SetKeyName(2, "people.png");
            this.imageList.Images.SetKeyName(3, "stats-chart.png");
            this.imageList.Images.SetKeyName(4, "storefront.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTrangChu);
            this.tabControl.Controls.Add(this.tabKhoHang);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabBanHang);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tabControl.ImageList = this.imageList;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(2, 96);
            this.tabControl.MainPage = "";
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1046, 606);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Style = Sunny.UI.UIStyle.Orange;
            this.tabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabIndex = 2;
            this.tabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.tabControl.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.tabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.AutoScroll = true;
            this.tabTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabTrangChu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTrangChu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTrangChu.ImageIndex = 1;
            this.tabTrangChu.Location = new System.Drawing.Point(0, 40);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Size = new System.Drawing.Size(1046, 566);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            // 
            // tabKhoHang
            // 
            this.tabKhoHang.AutoScroll = true;
            this.tabKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabKhoHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabKhoHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKhoHang.ImageIndex = 4;
            this.tabKhoHang.Location = new System.Drawing.Point(0, 40);
            this.tabKhoHang.Name = "tabKhoHang";
            this.tabKhoHang.Size = new System.Drawing.Size(1046, 566);
            this.tabKhoHang.TabIndex = 1;
            this.tabKhoHang.Text = "Kho Hàng";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.AutoScroll = true;
            this.tabNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNhanVien.ImageIndex = 2;
            this.tabNhanVien.Location = new System.Drawing.Point(0, 40);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(1046, 566);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân Viên";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.AutoScroll = true;
            this.tabDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDoanhThu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoanhThu.ImageIndex = 3;
            this.tabDoanhThu.Location = new System.Drawing.Point(0, 40);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Size = new System.Drawing.Size(1046, 566);
            this.tabDoanhThu.TabIndex = 3;
            this.tabDoanhThu.Text = "Doanh Thu";
            // 
            // tabBanHang
            // 
            this.tabBanHang.AutoScroll = true;
            this.tabBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabBanHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabBanHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBanHang.ImageIndex = 0;
            this.tabBanHang.Location = new System.Drawing.Point(0, 40);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Size = new System.Drawing.Size(1046, 566);
            this.tabBanHang.TabIndex = 4;
            this.tabBanHang.Text = "Bán Hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(843, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 714);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabTrangChu;
        private System.Windows.Forms.TabPage tabKhoHang;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

