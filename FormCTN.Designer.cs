namespace QuanLyVatLieuXayDung
{
    partial class FormCTN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaNhap = new System.Windows.Forms.TextBox();
            this.txtmaKho = new System.Windows.Forms.TextBox();
            this.txtNgDung = new System.Windows.Forms.TextBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnTaoP = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập ";
            // 
            // txtmaNhap
            // 
            this.txtmaNhap.Location = new System.Drawing.Point(183, 129);
            this.txtmaNhap.Name = "txtmaNhap";
            this.txtmaNhap.Size = new System.Drawing.Size(100, 22);
            this.txtmaNhap.TabIndex = 5;
            // 
            // txtmaKho
            // 
            this.txtmaKho.Location = new System.Drawing.Point(183, 201);
            this.txtmaKho.Name = "txtmaKho";
            this.txtmaKho.Size = new System.Drawing.Size(100, 22);
            this.txtmaKho.TabIndex = 6;
            // 
            // txtNgDung
            // 
            this.txtNgDung.Location = new System.Drawing.Point(183, 279);
            this.txtNgDung.Name = "txtNgDung";
            this.txtNgDung.Size = new System.Drawing.Size(100, 22);
            this.txtNgDung.TabIndex = 7;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(410, 12);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(378, 257);
            this.dgvPhieuNhap.TabIndex = 8;
            // 
            // btnTaoP
            // 
            this.btnTaoP.Location = new System.Drawing.Point(520, 309);
            this.btnTaoP.Name = "btnTaoP";
            this.btnTaoP.Size = new System.Drawing.Size(168, 23);
            this.btnTaoP.TabIndex = 9;
            this.btnTaoP.Text = "Tạo ";
            this.btnTaoP.UseVisualStyleBackColor = true;
            this.btnTaoP.Click += new System.EventHandler(this.btnTaoP_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(45, 337);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(155, 351);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(77, 391);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // FormCTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnTaoP);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.txtNgDung);
            this.Controls.Add(this.txtmaKho);
            this.Controls.Add(this.txtmaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCTN";
            this.Text = "FormCTN";
            this.Load += new System.EventHandler(this.FormCTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaNhap;
        private System.Windows.Forms.TextBox txtmaKho;
        private System.Windows.Forms.TextBox txtNgDung;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnTaoP;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}