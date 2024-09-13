namespace QL_ThuVien
{
    partial class frm_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_QuanLyTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_QuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_QuanLyTheLoai,
            this.btn_QuanLySach,
            this.mượnTrảSáchToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_QuanLyTheLoai
            // 
            this.btn_QuanLyTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLyTheLoai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_QuanLyTheLoai.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_QuanLyTheLoai.Name = "btn_QuanLyTheLoai";
            this.btn_QuanLyTheLoai.Padding = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.btn_QuanLyTheLoai.Size = new System.Drawing.Size(233, 52);
            this.btn_QuanLyTheLoai.Text = "Quản Lý Thể Loại";
            this.btn_QuanLyTheLoai.Click += new System.EventHandler(this.btn_QuanLyTheLoai_Click);
            // 
            // btn_QuanLySach
            // 
            this.btn_QuanLySach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_QuanLySach.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_QuanLySach.Name = "btn_QuanLySach";
            this.btn_QuanLySach.Padding = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.btn_QuanLySach.Size = new System.Drawing.Size(202, 52);
            this.btn_QuanLySach.Text = "Quản Lý Sách";
            this.btn_QuanLySach.Click += new System.EventHandler(this.btn_QuanLySach_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mượnTrảSáchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(258, 52);
            this.mượnTrảSáchToolStripMenuItem.Text = "Quản Lý Chức Năng";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.báoCáoThốngKêToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Padding = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(246, 52);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo Thống Kê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-135, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TrangChu";
            this.Text = "frm_TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_QuanLyTheLoai;
        private System.Windows.Forms.ToolStripMenuItem btn_QuanLySach;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}