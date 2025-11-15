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
    public partial class FormThanhVien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KATORIDESU;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormThanhVien()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("select * from NguoiDung", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void FormThanhVien_Load(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource=LoadNguoiDung();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maNGmoi = txtMa.Text;
                string tenDNmoi = txtDangNhap.Text;
                string tenNGmoi = txtTen.Text;
                string vaiTromoi = cbVaitro.Text.Trim();
                string matKhaumoi = txtMk.Text;
                int hoatDong = 1; // mặc định đang hoạt động

             string checkQuery = " SELECT COUNT(*)  FROM NguoiDung   WHERE MaNguoiDung = @MaNguoiDung";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaNguoiDung", maNGmoi);

                    // Thực thi và lấy về số lượng bản ghi (0 hoặc 1)
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Nếu đã tồn tại
                        MessageBox.Show("Mã Vật Liệu này đã tồn tại trong hệ thống. Vui lòng nhập mã khác!", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMa.Clear();
                        txtMa.Focus();
                        return; // Ngừng thực thi nếu mã bị trùng

                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO NguoiDung (
        TenDangNhap, MatKhau, HoTen, VaiTro, HoatDong
    )
    VALUES (
        @TenDangNhap, @MatKhau, @HoTen, @VaiTro, @HoatDong
    )";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@HoatDong", hoatDong);
                            cmd.Parameters.AddWithValue("@MatKhau", matKhaumoi);
                            cmd.Parameters.AddWithValue("@TenDangNhap", tenDNmoi);
                            cmd.Parameters.AddWithValue("@HoTen", tenNGmoi);
                            cmd.Parameters.AddWithValue("@VaiTro ", vaiTromoi);
                            cmd.Parameters.AddWithValue("@MaNguoiDung", maNGmoi);
                          
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm Người Dùng thành công!");

                                // 5. Tải lại DataGridView sau khi thêm
                                dgvNguoiDung.DataSource = LoadNguoiDung();

                                // (Tùy chọn) Gọi hàm để xóa trắng các control input
                                // ClearInputs(); 
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm Người Dùng . Vui lòng kiểm tra lại dữ liệu nhập.");
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);

            }
            txtTen.Clear();
            txtMk.Clear();
            txtMa.Clear();
            txtDangNhap.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNGmoi = txtMa.Text;
                string tenDNmoi = txtDangNhap.Text;
                string tenNGmoi = txtTen.Text;
                string vaiTromoi = cbVaitro.Text.Trim();
                string matKhaumoi = txtMk.Text;
                int hoatDong = 1; // mặc định đang hoạt động
                string updatequery = ("UPDATE NguoiDung SET TenDangNhap = @TenDangNhap,  MatKhau = @MatKhau,  HoTen = @HoTen,  VaiTro = @VaiTro,HoatDong = @HoatDong WHERE MaNguoiDung = @MaNguoiDung");
                using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                {
                    cmd.Parameters.AddWithValue("@HoatDong", hoatDong);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhaumoi);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDNmoi);
                    cmd.Parameters.AddWithValue("@HoTen", tenNGmoi);
                    cmd.Parameters.AddWithValue("@VaiTro ", vaiTromoi);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNGmoi);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Cập nhật Người Dùng  thành công!");
                        // 4. Tải lại DataGridView
                        dgvNguoiDung.DataSource = LoadNguoiDung();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Người Dùng để sửa hoặc dữ liệu không thay đổi!");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);

            }

            txtTen.Clear();
            txtMk.Clear();
            txtMa.Clear();
            txtDangNhap.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
        }
    }
}
