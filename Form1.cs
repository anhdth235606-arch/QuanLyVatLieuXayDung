using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVatLieu_Click(object sender, EventArgs e)
        {
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVatLieu_Click_1(object sender, EventArgs e)
        {

            FormVL f2 = new FormVL();
            f2.ShowDialog();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            FormKhoHang f3 = new FormKhoHang();
            f3.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            FormNCC f4 = new FormNCC();
            f4.ShowDialog();
        }

        private void btnNgDung_Click(object sender, EventArgs e)
        {
            FormThanhVien f5 = new FormThanhVien();
            f5.ShowDialog();
        }
    }
    }

