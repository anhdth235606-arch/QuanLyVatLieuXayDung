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
    public partial class FormNhap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=katoridesu ;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormNhap()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadNhap()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            DialogResult traloi = MessageBox.Show(
               "Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", // Nội dung thông báo
               "Xác nhận thoát", // Tiêu đề của hộp thoại
               MessageBoxButtons.YesNo, // Hiển thị hai nút Yes và No
               MessageBoxIcon.Question // Icon là dấu hỏi
           );

            // 2. Kiểm tra kết quả trả lời của người dùng
            if (traloi == DialogResult.Yes)
            {
                // Nếu người dùng chọn 'Yes', đóng Form hiện tại
                FormCTN ctn = new FormCTN();
                ctn.Show();

                // Hoặc đóng toàn bộ ứng dụng (nếu đây là Form chính)
                // Application.Exit(); 
            }
            // Nếu người dùng chọn 'No', chương trình không làm gì cả và tiếp tục chạy.
        }

        private void FormNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadNhap();
        }
    }
}
