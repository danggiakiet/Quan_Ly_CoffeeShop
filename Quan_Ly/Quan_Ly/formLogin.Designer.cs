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
            this.bttDangNhap = new Sunny.UI.UIButton();
            this.txtUser = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.bttDangNhap.Location = new System.Drawing.Point(274, 428);
            this.bttDangNhap.MinimumSize = new System.Drawing.Size(1, 1);
            this.bttDangNhap.Name = "bttDangNhap";
            this.bttDangNhap.Radius = 10;
            this.bttDangNhap.RectColor = System.Drawing.Color.Transparent;
            this.bttDangNhap.Size = new System.Drawing.Size(134, 38);
            this.bttDangNhap.Style = Sunny.UI.UIStyle.Custom;
            this.bttDangNhap.TabIndex = 0;
            this.bttDangNhap.Text = "Đăng nhập";
            this.bttDangNhap.Click += new System.EventHandler(this.bttDangNhap_Click);
            // 
            // txtUser
            // 
            this.txtUser.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(274, 267);
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
            this.txtPassword.Location = new System.Drawing.Point(274, 328);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.RectColor = System.Drawing.Color.Black;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(208, 40);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu  :";
            // 
            // checkNotHidePassword
            // 
            this.checkNotHidePassword.AutoSize = true;
            this.checkNotHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNotHidePassword.Location = new System.Drawing.Point(274, 376);
            this.checkNotHidePassword.Name = "checkNotHidePassword";
            this.checkNotHidePassword.Size = new System.Drawing.Size(150, 28);
            this.checkNotHidePassword.TabIndex = 6;
            this.checkNotHidePassword.Text = "Hiện mật khẩu";
            this.checkNotHidePassword.UseVisualStyleBackColor = true;
            this.checkNotHidePassword.CheckedChanged += new System.EventHandler(this.checkNotHidePassword_CheckedChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quan_Ly.Properties.Resources.Logo_Tròn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 612);
            this.Controls.Add(this.checkNotHidePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.bttDangNhap);
            this.DoubleBuffered = true;
            this.Name = "formLogin";
            this.Text = "formLogin";
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
        private System.Windows.Forms.CheckBox checkNotHidePassword;
    }
}