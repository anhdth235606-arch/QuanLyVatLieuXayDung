namespace QuanLyVatLieuXayDung
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
            this.btnVatLieu = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVatLieu
            // 
            this.btnVatLieu.Location = new System.Drawing.Point(114, 72);
            this.btnVatLieu.Name = "btnVatLieu";
            this.btnVatLieu.Size = new System.Drawing.Size(75, 23);
            this.btnVatLieu.TabIndex = 0;
            this.btnVatLieu.Text = "Vật Liệu";
            this.btnVatLieu.UseVisualStyleBackColor = true;
            this.btnVatLieu.Click += new System.EventHandler(this.btnVatLieu_Click_1);
            // 
            // btnNCC
            // 
            this.btnNCC.Location = new System.Drawing.Point(146, 168);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(75, 23);
            this.btnNCC.TabIndex = 1;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.UseVisualStyleBackColor = true;
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(386, 128);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(75, 23);
            this.btnKho.TabIndex = 2;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnNCC);
            this.Controls.Add(this.btnVatLieu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVatLieu;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnKho;
    }
}

