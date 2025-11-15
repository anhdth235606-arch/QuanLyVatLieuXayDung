namespace QuanLyVatLieuXayDung
{
    partial class FormCTX
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.dgvPhieuX = new System.Windows.Forms.DataGridView();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtmaVL = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(111, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(167, 337);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(51, 337);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 23;
            this.btnNhap.Text = "Nhập ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(504, 321);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(168, 23);
            this.btnTao.TabIndex = 22;
            this.btnTao.Text = "Tạo Phiếu";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPhieuX
            // 
            this.dgvPhieuX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuX.Location = new System.Drawing.Point(394, 24);
            this.dgvPhieuX.Name = "dgvPhieuX";
            this.dgvPhieuX.RowHeadersWidth = 51;
            this.dgvPhieuX.RowTemplate.Height = 24;
            this.dgvPhieuX.Size = new System.Drawing.Size(378, 257);
            this.dgvPhieuX.TabIndex = 21;
            // 
            // txtKho
            // 
            this.txtKho.Location = new System.Drawing.Point(167, 148);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(100, 22);
            this.txtKho.TabIndex = 20;
            // 
            // txtmaVL
            // 
            this.txtmaVL.Location = new System.Drawing.Point(167, 80);
            this.txtmaVL.Name = "txtmaVL";
            this.txtmaVL.Size = new System.Drawing.Size(100, 22);
            this.txtmaVL.TabIndex = 19;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(167, 24);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 22);
            this.txtMaPhieu.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Vật Liệu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Phiếu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã Kho  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã Người Dùng ";
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(167, 221);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(100, 22);
            this.txtND.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 390);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày Xuất ";
            // 
            // FormCTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dgvPhieuX);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.txtmaVL);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCTX";
            this.Text = "FormCTX";
            this.Load += new System.EventHandler(this.FormCTX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.DataGridView dgvPhieuX;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtmaVL;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}