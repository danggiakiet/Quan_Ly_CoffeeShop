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
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.TabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabPage1);
            this.Tab.Controls.Add(this.metroTabPage2);
            this.Tab.Location = new System.Drawing.Point(2, 80);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(543, 235);
            this.Tab.Style = MetroFramework.MetroColorStyle.Orange;
            this.Tab.TabIndex = 1;
            this.Tab.UseSelectable = true;
            // 
            // TabPage1
            // 
            this.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabPage1.HorizontalScrollbarBarColor = true;
            this.TabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage1.HorizontalScrollbarSize = 10;
            this.TabPage1.Location = new System.Drawing.Point(4, 38);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(535, 193);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Home";
            this.TabPage1.VerticalScrollbarBarColor = true;
            this.TabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage1.VerticalScrollbarSize = 10;
            this.TabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(524, 193);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Nhân Viên";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 341);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(13, 39, 13, 13);
            this.Text = "Tròn Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage TabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}

