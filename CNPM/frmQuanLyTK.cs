using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmQuanLyTK : Form
    {
        private string role;
        private string username;
        public frmQuanLyTK(string username,string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void frmQuanLyTK_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "SELECT *FROM NGUOIDUNG;";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvTK.DataSource = dt;
                    }
                    dgvTK.Columns[0].HeaderText = "Mã Người Dùng";
                    dgvTK.Columns[1].HeaderText = "Mã Loại TK";
                    dgvTK.Columns[2].HeaderText = "Tên Người Dùng";
                    dgvTK.Columns[3].HeaderText = "Tên Đăng Nhập";
                    dgvTK.Columns[4].HeaderText = "Mật Khẩu";
                }
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTK.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            int i;
            i = dgvTK.CurrentRow.Index;
            txtMaNguoiDung.Text = dgvTK.Rows[i].Cells[0].Value.ToString();
            txtMaLoai.Text = dgvTK.Rows[i].Cells[1].Value.ToString();
            txtTenNguoi.Text = dgvTK.Rows[i].Cells[2].Value.ToString();
            txtUserName.Text = dgvTK.Rows[i].Cells[3].Value.ToString();
            txtPass.Text = dgvTK.Rows[i].Cells[4].Value.ToString();
        }

        private void reset()
        {
            txtMaNguoiDung.Text = "";
            txtMaLoai.Text = "";
            txtTenNguoi.Text = "";
            txtUserName.Text = "";
            txtPass.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("themNguoiDung", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNguoiDung", txtMaNguoiDung.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text);
                    cmd.Parameters.AddWithValue("@TenNguoiDung", txtTenNguoi.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPass.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    frmQuanLyTK_Load(sender, e);
                    reset();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("suaNguoiDung", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNguoiDung", txtMaNguoiDung.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text);
                    cmd.Parameters.AddWithValue("@TenNguoiDung", txtTenNguoi.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPass.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    frmQuanLyTK_Load(sender, e);
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("xoaNguoiDung", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNguoiDung", txtMaNguoiDung.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQuanLyTK_Load(sender, e);
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frmQuanLyTK_Load(sender,e);
            }
            else
            {
                string connection = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                string query = "Select * from NGUOIDUNG where MaNguoiDung like N'%" + txtTimKiem.Text + "%'";
                SqlDataAdapter adt = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgvTK.DataSource = dt;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (role == "LND001")
            {
                frmTrangChuAD trangChuAD = new frmTrangChuAD(username: username, role: role);
                this.Hide();
                trangChuAD.Show();
            }
        }
    }
}