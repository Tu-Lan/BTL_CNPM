using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        private void checkTrong()
        {
            if (dgvGV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (txtMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDT.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (txtMaMonHoc.Text=="")
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMonHoc.Focus();
                return;
            }
        }

        private void frmGiaoVien_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query =
                    "SELECT * FROM GIAOVIEN;";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvGV.DataSource = dt;
                    }

                    dgvGV.Columns[0].HeaderText = "Mã Giáo Viên";
                    dgvGV.Columns[1].HeaderText = "Tên Giáo Viên";
                    dgvGV.Columns[2].HeaderText = "Địa Chỉ";
                    dgvGV.Columns[3].HeaderText = "Số Điện Thoại";
                    dgvGV.Columns[4].HeaderText = "Mã Môn Học";
                }
            }
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGV.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            int i;
            i = dgvGV.CurrentRow.Index;
            txtMaGV.Text = dgvGV.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvGV.Rows[i].Cells[1].Value.ToString();
            txtMaMonHoc.Text = dgvGV.Rows[i].Cells[4].Value.ToString();
            txtMaDT.Text = dgvGV.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dgvGV.Rows[i].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(constr))
            {
            try
            {
                SqlCommand cmd = new SqlCommand("themGV", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaGiaoVien", txtMaGV.Text);
                cmd.Parameters.AddWithValue("@TenGiaoVien", txtName.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtMaDT.Text);
                cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMonHoc.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                frmGiaoVien_Load_1(sender, e);
                reset();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        }

        private void reset()
        {
            txtMaGV.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMaDT.Text = "";
            txtMaMonHoc.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand("usp_SuaGiaoVien", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGiaoVien", txtMaGV.Text);
                    cmd.Parameters.AddWithValue("@TenGiaoVien", txtName.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtMaDT.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMaMonHoc.Text);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin giáo viên thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên có mã " + txtMaGV.Text + ".");
                    }
                    frmGiaoVien_Load_1(sender, e);
                    reset();
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
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa giáo viên có mã " + txtMaGV.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        SqlCommand cmd = new SqlCommand("usp_XoaGiaoVien", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaGiaoVien", txtMaGV.Text);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa giáo viên thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy giáo viên có mã " + txtMaGV.Text + ".");
                        }
                        frmGiaoVien_Load_1(sender, e);
                        reset();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frmGiaoVien_Load_1(sender,e);
            }
            else
            {
                string connection = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                string query = "Select * from GIAOVIEN where TenGiaoVien like N'%" + txtTimKiem.Text + "%'";
                SqlDataAdapter adt = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgvGV.DataSource = dt;

            }
        }
    }
}