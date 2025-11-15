namespace QuanLyVatLieuXayDung
{
    partial class FormThanhVien
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVaitro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(585, 51);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Thêm";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(585, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Thoát";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(585, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Cập Nhật";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Location = new System.Drawing.Point(90, 240);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.RowHeadersWidth = 51;
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(621, 159);
            this.dgvNguoiDung.TabIndex = 18;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(407, 55);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(100, 22);
            this.txtMk.TabIndex = 17;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(179, 147);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 16;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 55);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ Tên";
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Location = new System.Drawing.Point(179, 212);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(100, 22);
            this.txtDangNhap.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên Đăng Nhập ";
            // 
            // cbVaitro
            // 
            this.cbVaitro.FormattingEnabled = true;
            this.cbVaitro.Items.AddRange(new object[] {
            "Admin ",
            "NhanVien"});
            this.cbVaitro.Location = new System.Drawing.Point(357, 147);
            this.cbVaitro.Name = "cbVaitro";
            this.cbVaitro.Size = new System.Drawing.Size(121, 24);
            this.cbVaitro.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Vai Trò";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xóa ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVaitro);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThanhVien";
            this.Text = "FormThanhVien";
            this.Load += new System.EventHandler(this.FormThanhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVaitro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}