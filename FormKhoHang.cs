using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
        DataTable LoadKho()
        {
            SqlCommand cmd = new SqlCommand("select * from KhoHang ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {
            FormCTN cTn=new FormCTN();
            cTn.ShowDialog();
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = LoadKho();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int  maKhomoi = int.Parse(txtMaKho.Text);
                string tenKhomoi = txtTenKho.Text;
                string diaChimoi = txtDiaChi.Text;
                string updateQuery = "UPDATE KhoHang  SET TenKho = @TenKho,DiaChi = @DiaChi WHERE MaKho = @MaKho";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // 2. Thêm các tham số
                    cmd.Parameters.AddWithValue("@MaKho", maKhomoi);
                    cmd.Parameters.AddWithValue("@TenKho", tenKhomoi);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChimoi);

                    // 3. Thực thi câu lệnh
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật Kho thành công!");
                        // 4. Tải lại DataGridView
                        dgvKhoHang.DataSource = LoadKho();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Kho để sửa hoặc dữ liệu không thay đổi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
            txtDiaChi.Clear();
            txtMaKho.Clear();
            txtTenKho.Clear();


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int  maKhomoi = int.Parse(txtMaKho.Text);
                string tenKhomoi = txtTenKho.Text;
                string diaChimoi = txtDiaChi.Text;

                        // 2. Chuẩn bị câu lệnh SQL INSERT (Cần liệt kê TẤT CẢ các cột)
                        string insertQuery = @"INSERT INTO KhoHang (TenKho, DiaChi)
                                          VALUES (@TenKho, @DiaChi)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            // 3. Thêm TẤT CẢ các tham số và gán giá trị
                            cmd.Parameters.AddWithValue("@MaKho", maKhomoi);
                            cmd.Parameters.AddWithValue("@TenKho", tenKhomoi);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChimoi); 
                            // 4. Thực thi câu lệnh
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập Nhật  kho thành công!");

                                // 5. Tải lại DataGridView sau khi thêm
                                dgvKhoHang.DataSource = LoadKho();

                                // (Tùy chọn) Gọi hàm để xóa trắng các control input
                                // ClearInputs(); 
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật Kho . Vui lòng kiểm tra lại dữ liệu nhập.");
                            }
                        }
                   
                
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ví dụ: Mã HS bị trùng, Sai kiểu dữ liệu)
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            txtDiaChi.Clear();
            txtTenKho.Clear();
            txtMaKho.Clear();
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoxoa  = txtMaKho.Text;

            // 2. Chuẩn bị câu lệnh SQL DELETE
            // DELETE FROM [Tên Bảng] WHERE [Điều kiện xác định bản ghi]
            string deleteQuery = "DELETE FROM KhoHang  WHERE MaKho  = @MaKho ";

            // Bạn cần đảm bảo đối tượng 'conn' (SqlConnection) đã được khai báo và kết nối
            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
            {
                // 3. Thêm tham số (Chỉ cần tham số MaHocSinh)
                cmd.Parameters.AddWithValue("@MaKho ", maKhoxoa );

                // 4. Thực thi câu lệnh
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa học sinh thành công!");

                    // 5. Tải lại DataGridView sau khi xóa
                    dgvKhoHang.DataSource = LoadKho();

                    // (Tùy chọn) Xóa nội dung các control sau khi xóa thành công
                    // ClearInputs(); 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh có Mã Học Sinh này để xóa!");
                }
                txtMaKho.Clear();
                txtDiaChi.Clear();
                txtTenKho.Clear();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            FormCTX cTx = new FormCTX();
            cTx.ShowDialog();
        }


    }
    }
    
         

