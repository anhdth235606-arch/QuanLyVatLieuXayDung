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
    public partial class FormCTX : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=katoridesu ;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormCTX()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadPhieu()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuXuat", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormXuat fx = new FormXuat();
            fx.ShowDialog();
        }

        private void FormCTX_Load(object sender, EventArgs e)
        {
            dgvPhieuX.DataSource = LoadPhieu();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayXuat = dateTimePicker1.Value.Date; // Nếu dùng DateTimePicker
                int maKho = int.Parse(txtKho.Text);
                int maNguoiDung = int.Parse(txtND.Text);

                string insertQuery = @"INSERT INTO PhieuXuat (NgayXuat, MaKho, MaNguoiDung)
                              VALUES (@NgayXuat, @MaKho, @MaNguoiDung);
                              SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                    int maPhieuXuatMoi = Convert.ToInt32(cmd.ExecuteScalar());
                    txtMaPhieu.Text = maPhieuXuatMoi.ToString();

                    MessageBox.Show("Thêm phiếu xuất thành công! Mã phiếu xuất: " + maPhieuXuatMoi);
                    dgvPhieuX.DataSource = LoadPhieu(); // Load lại grid nếu cần
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu xuất: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuXuat = int.Parse(txtMaPhieu.Text);
                DateTime ngayXuat = dateTimePicker1.Value.Date;
                int maKho = int.Parse(txtKho.Text);
                int maNguoiDung = int.Parse(txtND.Text);

                string updateQuery = @"UPDATE PhieuXuat
                                       SET NgayXuat = @NgayXuat,
                                           MaKho = @MaKho,
                                           MaNguoiDung = @MaNguoiDung
                                       WHERE MaPhieuXuat = @MaPhieuXuat";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                    cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật phiếu xuất thành công!");
                        dgvPhieuX.DataSource = LoadPhieu();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu xuất cần cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu xuất: " + ex.Message);
            }
        }
            
           
            
         
            

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuXuat = int.Parse(txtMaPhieu.Text);

                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu xuất này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;

                string deleteQuery = "DELETE FROM PhieuXuat WHERE MaPhieuXuat = @MaPhieuXuat";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa phiếu xuất thành công!");
                        dgvPhieuX.DataSource = LoadPhieu();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu xuất để xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu xuất: " + ex.Message);
            }
        }
    }
}
