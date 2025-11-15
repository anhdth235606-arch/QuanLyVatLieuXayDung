using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyVatLieuXayDung
{
    public partial class FormVL : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-43U7GJ9\\SQLEXPRESS;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormVL()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadData()
        {
            SqlCommand cmd = new SqlCommand("select * from VatLieu", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
                    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenVLMoi = txttenVL.Text;
                decimal  giaN = decimal.Parse(txtNhap.Text);
                decimal  giaB = decimal.Parse(txtBan.Text);
                string DonVT = txtDonVT.Text;
                int  NhaCC = int.Parse(txtNCC.Text);
                int  soLT = int.Parse(txtSLT.Text);

                string insertQuery = @"Insert into VatLieu(
TenVatLieu,DonViTinh,GiaNhap,GiaBan,SoLuongTon,MaNhaCungCap)
Values(
@TenVatLieu,@DonViTinh,@GiaNhap,@GiaBan,@SoluongTon,@MaNhaCungCap)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TenVatLieu", tenVLMoi);                    cmd.Parameters.AddWithValue("@DonViTinh", DonVT);
                    cmd.Parameters.AddWithValue("@GiaNhap", giaN);
                    

                    cmd.Parameters.AddWithValue("@GiaBan", giaB);
                  

                    cmd.Parameters.AddWithValue("@SoLuongTon", soLT);
                    cmd.Parameters.AddWithValue("MaNhaCungCap", NhaCC);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm vật liệu thành công!");

                        // 5. Tải lại DataGridView sau khi thêm
                        dgvVL.DataSource = LoadData();

                        // (Tùy chọn) Gọi hàm để xóa trắng các control input
                        // ClearInputs(); 
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm Vật Liệu. Vui lòng kiểm tra lại dữ liệu nhập.");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);

            }
            txttenVL.Clear();
            txtNCC.Clear();
            txtSLT.Clear();
            txtBan.Clear();
            txtDonVT.Clear();
            txtNhap.Clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            try
            {
                string  maVLMoi = txtmaVL.Text;
                string tenVLMoi = txttenVL.Text;
                decimal giaN = decimal.Parse(txtNhap.Text);
                decimal giaB = decimal.Parse(txtBan.Text);
                string DonVT = txtDonVT.Text;
                int NhaCC = int.Parse(txtNCC.Text);
                int soLT = int.Parse(txtSLT.Text);
                string updatequery = ("update VatLieu set TenVatLieu=@TenVatLieu,DonViTinh=@DonViTinh,GiaBan=@GiaBan,GiaNhap=@GiaNhap,SoLuongTon=@SoLuongTon,MaNhaCungCap=@MaNhaCungCap where MaVatLieu=@MaVatLieu");
                using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@TenVatLieu", tenVLMoi);
                    cmd.Parameters.AddWithValue("@VatLieu", tenVLMoi);
                    cmd.Parameters.AddWithValue("@DonViTinh", DonVT);
                    cmd.Parameters.AddWithValue("@GiaNhap", tenVLMoi);
                    cmd.Parameters.AddWithValue("@GiaBan", giaB);
                    cmd.Parameters.AddWithValue("@SoLuongTon", soLT);
                    cmd.Parameters.AddWithValue("MaNhaCungCap", NhaCC);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Cập nhật học sinh thành công!");
                        // 4. Tải lại DataGridView
                        dgvVL.DataSource = LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh để sửa hoặc dữ liệu không thay đổi!");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);

            }
            txttenVL.Clear();
            txtNCC.Clear();
            txtSLT.Clear();
            txtBan.Clear();
            txtDonVT.Clear();
            txtNhap.Clear();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string  maVLxoa = txtmaVL.Text;
            string deletequery = "DELETE FROM VatLieu WHERE MaVatLieu=@MaVatLieu ";
            using (SqlCommand cmd = new SqlCommand(deletequery, conn))
            {
                cmd.Parameters.AddWithValue("@MaVatLieu", maVLxoa);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    dgvVL.DataSource= LoadData();
                }
                else
                {
                     MessageBox.Show("Không tìm thấy vật liệu để xóa!");

                }
                txttenVL.Clear();
                txtNCC.Clear();
                txtSLT.Clear();
                txtBan.Clear();
                txtDonVT.Clear();
                txtNhap.Clear();
            }

        }

        private void FormVL_Load(object sender, EventArgs e)
        {
            dgvVL.DataSource= LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
                Application.Exit();

                // Hoặc đóng toàn bộ ứng dụng (nếu đây là Form chính)
                // Application.Exit(); 
            }
            // Nếu người dùng chọn 'No', chương trình không làm gì cả và tiếp tục chạy.
        }
    }
    }
  
           
      
   

