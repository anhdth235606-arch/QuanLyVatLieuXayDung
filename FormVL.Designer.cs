namespace QuanLyVatLieuXayDung
{
    partial class FormVL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenVL = new System.Windows.Forms.TextBox();
            this.txtmaVL = new System.Windows.Forms.TextBox();
            this.dgvVL = new System.Windows.Forms.DataGridView();
            this.quanLyVatLieuXayDungDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyVatLieuXayDungDataSet = new QuanLyVatLieuXayDung.QuanLyVatLieuXayDungDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.btnGan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuXayDungDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuXayDungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Vật Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Vật Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Nhập";
            // 
            // txttenVL
            // 
            this.txttenVL.Location = new System.Drawing.Point(120, 48);
            this.txttenVL.Name = "txttenVL";
            this.txttenVL.Size = new System.Drawing.Size(100, 22);
            this.txttenVL.TabIndex = 4;
            // 
            // txtmaVL
            // 
            this.txtmaVL.Location = new System.Drawing.Point(120, 129);
            this.txtmaVL.Name = "txtmaVL";
            this.txtmaVL.Size = new System.Drawing.Size(100, 22);
            this.txtmaVL.TabIndex = 5;
            // 
            // dgvVL
            // 
            this.dgvVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVL.Location = new System.Drawing.Point(23, 255);
            this.dgvVL.Name = "dgvVL";
            this.dgvVL.RowHeadersWidth = 51;
            this.dgvVL.RowTemplate.Height = 24;
            this.dgvVL.Size = new System.Drawing.Size(730, 183);
            this.dgvVL.TabIndex = 6;
            this.dgvVL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // quanLyVatLieuXayDungDataSetBindingSource
            // 
            this.quanLyVatLieuXayDungDataSetBindingSource.DataSource = this.quanLyVatLieuXayDungDataSet;
            this.quanLyVatLieuXayDungDataSetBindingSource.Position = 0;
            // 
            // quanLyVatLieuXayDungDataSet
            // 
            this.quanLyVatLieuXayDungDataSet.DataSetName = "QuanLyVatLieuXayDungDataSet";
            this.quanLyVatLieuXayDungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá Bán";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(310, 48);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 22);
            this.txtNhap.TabIndex = 8;
            // 
            // txtBan
            // 
            this.txtBan.Location = new System.Drawing.Point(310, 135);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(100, 22);
            this.txtBan.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(695, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(695, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn Vị Tính";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDonVT
            // 
            this.txtDonVT.Location = new System.Drawing.Point(547, 135);
            this.txtDonVT.Name = "txtDonVT";
            this.txtDonVT.Size = new System.Drawing.Size(100, 22);
            this.txtDonVT.TabIndex = 13;
            this.txtDonVT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhà cung cấp";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(547, 48);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(100, 22);
            this.txtNCC.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số Lượng Tồn";
            // 
            // txtSLT
            // 
            this.txtSLT.Location = new System.Drawing.Point(120, 184);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(100, 22);
            this.txtSLT.TabIndex = 18;
            // 
            // btnGan
            // 
            this.btnGan.Location = new System.Drawing.Point(695, 100);
            this.btnGan.Name = "btnGan";
            this.btnGan.Size = new System.Drawing.Size(75, 31);
            this.btnGan.TabIndex = 19;
            this.btnGan.Text = "Cập Nhật";
            this.btnGan.UseVisualStyleBackColor = true;
            this.btnGan.Click += new System.EventHandler(this.btnGan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(695, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGan);
            this.Controls.Add(this.txtSLT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDonVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvVL);
            this.Controls.Add(this.txtmaVL);
            this.Controls.Add(this.txttenVL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVL";
            this.Text = "FormVL";
            this.Load += new System.EventHandler(this.FormVL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuXayDungDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuXayDungDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenVL;
        private System.Windows.Forms.TextBox txtmaVL;
        private System.Windows.Forms.DataGridView dgvVL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.Button btnGan;
        private System.Windows.Forms.BindingSource quanLyVatLieuXayDungDataSetBindingSource;
        private QuanLyVatLieuXayDungDataSet quanLyVatLieuXayDungDataSet;
        private System.Windows.Forms.Button btnThoat;
    }
}