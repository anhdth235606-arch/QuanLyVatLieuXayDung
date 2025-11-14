using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyVatLieuXayDung
{
    public partial class FormKhoHang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KATORIDESU;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormKhoHang()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadData()
        {
            SqlCommand cmd = new SqlCommand("select * from KhoHang ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TenKho = txtTenKho.Text;
                string DiaChi = txtDiaChi.Text;
            }
        }
    }
}
