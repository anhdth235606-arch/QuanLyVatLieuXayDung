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

    public partial class FormCTN : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=katoridesu ;Initial Catalog=QuanLyVatLieuXayDung;Integrated Security=True");

        public FormCTN()
        {
            InitializeComponent();
            conn.Open();
        }
        DataTable LoadPhieuNhap()
        {
            SqlCommand cmd = new SqlCommand("select * from PhieuNhap", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void FormCTN_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = LoadPhieuNhap();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các textbox
                string maPhieumoi =txtmaNhap.Text;
                DateTime ngayNhap  = dateTimePicker1.Value.Date;
                int maKho = int.Parse(txtmaKho.Text);
                int maNguoiDung = int.Parse(txtNgDung.Text);

                // Thêm mới phiếu nhập
                string insertQuery = @"INSERT INTO PhieuNhap(NgayNhap, MaKho, MaNguoiDung)
                               VALUES (@NgayNhap, @MaKho, @MaNguoiDung)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieumoi);

                    cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm phiếu nhập thành công!");
                        dgvPhieuNhap.DataSource = LoadPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm phiếu nhập. Kiểm tra lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap = int.Parse(txtmaNhap.Text);   // Dữ liệu này phải là mã có sẵn trong CSDL
                DateTime ngayNhap = dateTimePicker1.Value;
                int maKho = int.Parse(txtmaKho.Text);
                int maNguoiDung = int.Parse(txtNgDung.Text);

                string updateQuery = @"UPDATE PhieuNhap SET 
                                NgayNhap = @NgayNhap, 
                                MaKho = @MaKho, 
                                MaNguoiDung = @MaNguoiDung
                               WHERE MaPhieuNhap = @MaPhieuNhap";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);
                    cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật phiếu nhập thành công!");
                        dgvPhieuNhap.DataSource = LoadPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu nhập để cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuNhap = int.Parse(txtmaNhap.Text);
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;

                string deleteQuery = "DELETE FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                        dgvPhieuNhap.DataSource = LoadPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu nhập để xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTaoP_Click(object sender, EventArgs e)
        {
            FormNhap fn = new FormNhap();
            fn.ShowDialog();
        }
    }
    }

