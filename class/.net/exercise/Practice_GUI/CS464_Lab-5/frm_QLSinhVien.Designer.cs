
namespace CS464_Lab_5
{
    partial class frm_QLSinhVien
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
            this.data_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_soDienThoai = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cls_ngoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_hoiGiao = new System.Windows.Forms.CheckBox();
            this.chk_tinLanh = new System.Windows.Forms.CheckBox();
            this.chk_thienChua = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chk_phatGiao = new System.Windows.Forms.CheckBox();
            this.cb_danToc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdo_khac = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txt_nganh = new System.Windows.Forms.TextBox();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_truong = new System.Windows.Forms.TextBox();
            this.txt_tenDayDu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_ngaySinh
            // 
            this.data_ngaySinh.CustomFormat = "dd/MM/yyyy";
            this.data_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_ngaySinh.Location = new System.Drawing.Point(107, 203);
            this.data_ngaySinh.Name = "data_ngaySinh";
            this.data_ngaySinh.ShowCheckBox = true;
            this.data_ngaySinh.Size = new System.Drawing.Size(200, 22);
            this.data_ngaySinh.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_soDienThoai);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cls_ngoaiNgu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chk_hoiGiao);
            this.groupBox1.Controls.Add(this.chk_tinLanh);
            this.groupBox1.Controls.Add(this.chk_thienChua);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chk_phatGiao);
            this.groupBox1.Controls.Add(this.cb_danToc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.data_ngaySinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdo_khac);
            this.groupBox1.Controls.Add(this.rdo_nu);
            this.groupBox1.Controls.Add(this.rdo_nam);
            this.groupBox1.Controls.Add(this.txt_nganh);
            this.groupBox1.Controls.Add(this.txt_khoa);
            this.groupBox1.Controls.Add(this.txt_lop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_truong);
            this.groupBox1.Controls.Add(this.txt_tenDayDu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 516);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(288, 476);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 20);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://kcntt.duytan.edu.vn/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(635, 434);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(79, 32);
            this.btn_luu.TabIndex = 33;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // txt_soDienThoai
            // 
            this.txt_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDienThoai.Location = new System.Drawing.Point(487, 354);
            this.txt_soDienThoai.Name = "txt_soDienThoai";
            this.txt_soDienThoai.Size = new System.Drawing.Size(200, 26);
            this.txt_soDienThoai.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(367, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Số Điện Thoại:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(487, 310);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 26);
            this.txt_email.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(418, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Email:";
            // 
            // cls_ngoaiNgu
            // 
            this.cls_ngoaiNgu.FormattingEnabled = true;
            this.cls_ngoaiNgu.Location = new System.Drawing.Point(487, 203);
            this.cls_ngoaiNgu.Name = "cls_ngoaiNgu";
            this.cls_ngoaiNgu.Size = new System.Drawing.Size(200, 89);
            this.cls_ngoaiNgu.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(393, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ngoại Ngữ:";
            // 
            // chk_hoiGiao
            // 
            this.chk_hoiGiao.AutoSize = true;
            this.chk_hoiGiao.Location = new System.Drawing.Point(214, 405);
            this.chk_hoiGiao.Name = "chk_hoiGiao";
            this.chk_hoiGiao.Size = new System.Drawing.Size(85, 21);
            this.chk_hoiGiao.TabIndex = 26;
            this.chk_hoiGiao.Text = "Hồi Giáo";
            this.chk_hoiGiao.UseVisualStyleBackColor = true;
            // 
            // chk_tinLanh
            // 
            this.chk_tinLanh.AutoSize = true;
            this.chk_tinLanh.Location = new System.Drawing.Point(107, 406);
            this.chk_tinLanh.Name = "chk_tinLanh";
            this.chk_tinLanh.Size = new System.Drawing.Size(86, 21);
            this.chk_tinLanh.TabIndex = 25;
            this.chk_tinLanh.Text = "Tin Lành";
            this.chk_tinLanh.UseVisualStyleBackColor = true;
            // 
            // chk_thienChua
            // 
            this.chk_thienChua.AutoSize = true;
            this.chk_thienChua.Location = new System.Drawing.Point(214, 379);
            this.chk_thienChua.Name = "chk_thienChua";
            this.chk_thienChua.Size = new System.Drawing.Size(103, 21);
            this.chk_thienChua.TabIndex = 24;
            this.chk_thienChua.Text = "Thiên Chúa";
            this.chk_thienChua.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Tôn Giáo:";
            // 
            // chk_phatGiao
            // 
            this.chk_phatGiao.AutoSize = true;
            this.chk_phatGiao.Location = new System.Drawing.Point(107, 380);
            this.chk_phatGiao.Name = "chk_phatGiao";
            this.chk_phatGiao.Size = new System.Drawing.Size(93, 21);
            this.chk_phatGiao.TabIndex = 22;
            this.chk_phatGiao.Text = "Phật Giáo";
            this.chk_phatGiao.UseVisualStyleBackColor = true;
            // 
            // cb_danToc
            // 
            this.cb_danToc.FormattingEnabled = true;
            this.cb_danToc.Location = new System.Drawing.Point(107, 337);
            this.cb_danToc.Name = "cb_danToc";
            this.cb_danToc.Size = new System.Drawing.Size(200, 24);
            this.cb_danToc.TabIndex = 21;
            this.cb_danToc.Text = "Không Dân Tộc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dân Tộc:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 80);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Địa Chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày Sinh:";
            // 
            // rdo_khac
            // 
            this.rdo_khac.AutoSize = true;
            this.rdo_khac.Location = new System.Drawing.Point(107, 175);
            this.rdo_khac.Name = "rdo_khac";
            this.rdo_khac.Size = new System.Drawing.Size(61, 21);
            this.rdo_khac.TabIndex = 15;
            this.rdo_khac.Text = "Khác";
            this.rdo_khac.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(107, 149);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(47, 21);
            this.rdo_nu.TabIndex = 14;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Checked = true;
            this.rdo_nam.Location = new System.Drawing.Point(107, 123);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(58, 21);
            this.rdo_nam.TabIndex = 13;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // txt_nganh
            // 
            this.txt_nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nganh.Location = new System.Drawing.Point(487, 164);
            this.txt_nganh.Name = "txt_nganh";
            this.txt_nganh.Size = new System.Drawing.Size(200, 26);
            this.txt_nganh.TabIndex = 12;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(487, 125);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.Size = new System.Drawing.Size(200, 26);
            this.txt_khoa.TabIndex = 11;
            // 
            // txt_lop
            // 
            this.txt_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop.Location = new System.Drawing.Point(487, 86);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(200, 26);
            this.txt_lop.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trường:";
            // 
            // txt_truong
            // 
            this.txt_truong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_truong.Location = new System.Drawing.Point(487, 47);
            this.txt_truong.Name = "txt_truong";
            this.txt_truong.Size = new System.Drawing.Size(200, 26);
            this.txt_truong.TabIndex = 5;
            // 
            // txt_tenDayDu
            // 
            this.txt_tenDayDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDayDu.Location = new System.Drawing.Point(107, 82);
            this.txt_tenDayDu.Name = "txt_tenDayDu";
            this.txt_tenDayDu.Size = new System.Drawing.Size(200, 26);
            this.txt_tenDayDu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đầy Đủ:";
            // 
            // txt_maSV
            // 
            this.txt_maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSV.Location = new System.Drawing.Point(107, 47);
            this.txt_maSV.Name = "txt_maSV";
            this.txt_maSV.Size = new System.Drawing.Size(200, 26);
            this.txt_maSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // frm_QLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLSinhVien";
            this.Text = "QLSinhVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_truong;
        private System.Windows.Forms.TextBox txt_tenDayDu;
        private System.Windows.Forms.TextBox txt_nganh;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdo_khac;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cb_danToc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk_hoiGiao;
        private System.Windows.Forms.CheckBox chk_tinLanh;
        private System.Windows.Forms.CheckBox chk_thienChua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chk_phatGiao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox cls_ngoaiNgu;
        private System.Windows.Forms.TextBox txt_soDienThoai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker data_ngaySinh;
    }
}