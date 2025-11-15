namespace QuanLyVatLieuXayDung
{
    partial class FormXuat
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
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXuat
            // 
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Location = new System.Drawing.Point(111, 35);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.RowHeadersWidth = 51;
            this.dgvXuat.RowTemplate.Height = 24;
            this.dgvXuat.Size = new System.Drawing.Size(406, 365);
            this.dgvXuat.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cập Nhật ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvXuat);
            this.Name = "FormXuat";
            this.Text = "FormXuat";
            this.Load += new System.EventHandler(this.FormXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}