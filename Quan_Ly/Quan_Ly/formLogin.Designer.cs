namespace Quan_Ly
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.bttDangNhap = new Sunny.UI.UIButton();
            this.txtUser = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabelQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.checkNotHidePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttDangNhap
            // 
            this.bttDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDangNhap.FillColor = System.Drawing.Color.Silver;
            this.bttDangNhap.FillHoverColor = System.Drawing.Color.Gray;
            this.bttDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDangNhap.ForeColor = System.Drawing.Color.Black;
            this.bttDangNhap.Location = new System.Drawing.Point(296, 427);
            this.bttDangNhap.MinimumSize = new System.Drawing.Size(1, 1);
            this.bttDangNhap.Name = "bttDangNhap";
            this.bttDangNhap.Radius = 10;
            this.bttDangNhap.RectColor = System.Drawing.Color.Transparent;
            this.bttDangNhap.Size = new System.Drawing.Size(134, 38);
            this.bttDangNhap.Style = Sunny.UI.UIStyle.Custom;
            this.bttDangNhap.TabIndex = 4;
            this.bttDangNhap.Text = "Đăng nhập";
            this.bttDangNhap.Click += new System.EventHandler(this.bttDangNhap_Click);
            // 
            // txtUser
            // 
            this.txtUser.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(296, 282);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.RectColor = System.Drawing.Color.Black;
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(208, 40);
            this.txtUser.Style = Sunny.UI.UIStyle.Custom;
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "";
            // 
            // txtPassword
            // 
            this.txtPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(296, 343);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.RectColor = System.Drawing.Color.Black;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(208, 40);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu  :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye.png");
            this.imageList1.Images.SetKeyName(1, "eye-off.png");
            // 
            // linkLabelQuenMatKhau
            // 
            this.linkLabelQuenMatKhau.AutoSize = true;
            this.linkLabelQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelQuenMatKhau.Location = new System.Drawing.Point(373, 388);
            this.linkLabelQuenMatKhau.Name = "linkLabelQuenMatKhau";
            this.linkLabelQuenMatKhau.Size = new System.Drawing.Size(131, 20);
            this.linkLabelQuenMatKhau.TabIndex = 6;
            this.linkLabelQuenMatKhau.TabStop = true;
            this.linkLabelQuenMatKhau.Text = "Quên mật khẩu ?";
            this.linkLabelQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuenMatKhau_LinkClicked);
            // 
            // checkNotHidePassword
            // 
            this.checkNotHidePassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkNotHidePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkNotHidePassword.BackgroundImage = global::Quan_Ly.Properties.Resources.eye_off;
            this.checkNotHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkNotHidePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkNotHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkNotHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNotHidePassword.Location = new System.Drawing.Point(511, 343);
            this.checkNotHidePassword.Name = "checkNotHidePassword";
            this.checkNotHidePassword.Size = new System.Drawing.Size(42, 41);
            this.checkNotHidePassword.TabIndex = 3;
            this.checkNotHidePassword.UseVisualStyleBackColor = false;
            this.checkNotHidePassword.CheckedChanged += new System.EventHandler(this.checkNotHidePassword_CheckedChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Quan_Ly.Properties.Resources.Logo_Tròn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 698);
            this.Controls.Add(this.linkLabelQuenMatKhau);
            this.Controls.Add(this.checkNotHidePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.bttDangNhap);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton bttDangNhap;
        private Sunny.UI.UITextBox txtUser;
        private Sunny.UI.UITextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelQuenMatKhau;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkNotHidePassword;
    }
}