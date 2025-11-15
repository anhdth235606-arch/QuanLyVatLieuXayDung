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
    public partial class FormNCC : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KATORIDESU;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormNCC()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadNCC()
        {
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = LoadNCC();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maNvvMoi = txtMaCC.Text;

                string tenNCC = txtTenCC.Text.Trim();
                string diaChi = txtDC.Text.Trim();
                string dienThoai = txtSDT.Text.Trim();
                string email = txtemail.Text.Trim();
                string checkQuery = " SELECT COUNT(*)  FROM NhaCungCap  WHERE MaNhaCungCap  = @MaNhaCungCap ";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaNhaCungCap ", maNvvMoi);

                    // Thực thi và lấy về số lượng bản ghi (0 hoặc 1)
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Nếu đã tồn tại
                        MessageBox.Show("Mã Nhà Cung Cấp  này đã tồn tại trong hệ thống. Vui lòng nhập mã khác!", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaCC.Clear();
                        txtMaCC.Focus();
                        return; // Ngừng thực thi nếu mã bị trùng

                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, Phone , Email)
    VALUES (@TenNhaCungCap, @DiaChi, @Phone , @Email)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNhaCungCap", maNvvMoi);
                            cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNCC);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmd.Parameters.AddWithValue("@Phone", dienThoai);
                            cmd.Parameters.AddWithValue("@Email", email);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm Nhà Cung Cấp thành công!");

                                // 5. Tải lại DataGridView sau khi thêm
                                dgvNCC.DataSource = LoadNCC();

                                // (Tùy chọn) Gọi hàm để xóa trắng các control input
                                // ClearInputs(); 
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm Nhà Cung Cấp . Vui lòng kiểm tra lại dữ liệu nhập.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);

            }
            txtDC.Clear();
            txtemail.Clear();
            txtMaCC.Clear();
            txtSDT.Clear();
            txtTenCC.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try {
            int maNCC = int.Parse(txtMaCC.Text); // Lấy từ dòng chọn trên DataGridView
            string tenNCC = txtTenCC.Text.Trim();
            string diaChi = txtDC.Text.Trim();
            string dienThoai = txtSDT.Text.Trim();
            string email = txtemail.Text.Trim();
            string updateQuery = @"UPDATE NhaCungCap
                               SET TenNhaCungCap = @TenNhaCungCap,
                                   DiaChi = @DiaChi,
                                   Phone  = @Phone ,
                                   Email = @Email
                               WHERE MaNhaCungCap = @MaNhaCungCap";
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@MaNhaCungCap", maNCC);
                cmd.Parameters.AddWithValue("@TenNhaCungCap", tenNCC);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Phone", dienThoai);
                cmd.Parameters.AddWithValue("@Email", email);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                    dgvNCC.DataSource = LoadNCC();
                }
                else
                {
                    MessageBox.Show("Không cập nhật được nhà cung cấp. Kiểm tra lại Mã NCC.");
                }
            }
        }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi cập nhật NCC: " + ex.Message);
    }
    txtMaCC.Clear();
    txtTenCC.Clear();
    txtDC.Clear();
    txtSDT.Clear();
    txtemail.Clear();
        }
    }
}
     

    

