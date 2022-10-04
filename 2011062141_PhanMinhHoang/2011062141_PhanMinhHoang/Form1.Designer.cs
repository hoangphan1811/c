namespace _2011062141_PhanMinhHoang
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
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.lbLophoc = new System.Windows.Forms.Label();
            this.lbMasv = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKluu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvSinhvien = new System.Windows.Forms.ListView();
            this.clMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThongtin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.cbbLop);
            this.grbThongtin.Controls.Add(this.dtpNgaysinh);
            this.grbThongtin.Controls.Add(this.txbHoten);
            this.grbThongtin.Controls.Add(this.txbMaSV);
            this.grbThongtin.Controls.Add(this.lbHoten);
            this.grbThongtin.Controls.Add(this.lbLophoc);
            this.grbThongtin.Controls.Add(this.lbMasv);
            this.grbThongtin.Controls.Add(this.lbNgaysinh);
            this.grbThongtin.Location = new System.Drawing.Point(56, 43);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(663, 168);
            this.grbThongtin.TabIndex = 0;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
            this.grbThongtin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(370, 73);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(121, 24);
            this.cbbLop.TabIndex = 5;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(90, 76);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaysinh.TabIndex = 4;
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(370, 40);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(100, 22);
            this.txbHoten.TabIndex = 3;
            this.txbHoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(104, 37);
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(136, 22);
            this.txbMaSV.TabIndex = 3;
            this.txbMaSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(308, 40);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(46, 16);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ tên";
            // 
            // lbLophoc
            // 
            this.lbLophoc.AutoSize = true;
            this.lbLophoc.Location = new System.Drawing.Point(308, 76);
            this.lbLophoc.Name = "lbLophoc";
            this.lbLophoc.Size = new System.Drawing.Size(55, 16);
            this.lbLophoc.TabIndex = 0;
            this.lbLophoc.Text = "Lớp học";
            // 
            // lbMasv
            // 
            this.lbMasv.AutoSize = true;
            this.lbMasv.Location = new System.Drawing.Point(17, 40);
            this.lbMasv.Name = "lbMasv";
            this.lbMasv.Size = new System.Drawing.Size(81, 16);
            this.lbMasv.TabIndex = 1;
            this.lbMasv.Text = "Mã sinh viên";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(17, 76);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(67, 16);
            this.lbNgaysinh.TabIndex = 0;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnKluu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(216, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 89);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 42);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(256, 42);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(90, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKluu
            // 
            this.btnKluu.Location = new System.Drawing.Point(337, 42);
            this.btnKluu.Name = "btnKluu";
            this.btnKluu.Size = new System.Drawing.Size(75, 23);
            this.btnKluu.TabIndex = 0;
            this.btnKluu.Text = "K.Lưu";
            this.btnKluu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(171, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvSinhvien);
            this.groupBox2.Location = new System.Drawing.Point(56, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lsvSinhvien
            // 
            this.lsvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMa,
            this.clHoten,
            this.clNgaysinh,
            this.clLop});
            this.lsvSinhvien.FullRowSelect = true;
            this.lsvSinhvien.GridLines = true;
            this.lsvSinhvien.HideSelection = false;
            this.lsvSinhvien.Location = new System.Drawing.Point(6, 21);
            this.lsvSinhvien.Name = "lsvSinhvien";
            this.lsvSinhvien.Size = new System.Drawing.Size(631, 211);
            this.lsvSinhvien.TabIndex = 0;
            this.lsvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhvien.View = System.Windows.Forms.View.Details;
            this.lsvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lsvSinhvien_SelectedIndexChanged);
            // 
            // clMa
            // 
            this.clMa.Text = "Mã SV";
            this.clMa.Width = 155;
            // 
            // clHoten
            // 
            this.clHoten.Text = "Họ và tên";
            this.clHoten.Width = 183;
            // 
            // clNgaysinh
            // 
            this.clNgaysinh.Text = "Ngày sinh";
            this.clNgaysinh.Width = 175;
            // 
            // clLop
            // 
            this.clLop.Text = "Lớp";
            this.clLop.Width = 161;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbThongtin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbLophoc;
        private System.Windows.Forms.Label lbMasv;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKluu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvSinhvien;
        private System.Windows.Forms.ColumnHeader clMa;
        private System.Windows.Forms.ColumnHeader clHoten;
        private System.Windows.Forms.ColumnHeader clNgaysinh;
        private System.Windows.Forms.ColumnHeader clLop;
    }
}

