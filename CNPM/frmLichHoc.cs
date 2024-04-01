using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmLichHoc : Form
    {
        private string role;
        private string username;
        public frmLichHoc(string username,string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void frmLichHoc_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT * FROM LichHoc";
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvLH.DataSource = dt;
                    }
                    dgvLH.Columns[0].HeaderText = "ID";
                    dgvLH.Columns[1].HeaderText = "Mã Lớp";
                    dgvLH.Columns[2].HeaderText = "Mã Môn Học";
                    dgvLH.Columns[3].HeaderText = "Mã Giáo Viên";
                    dgvLH.Columns[4].HeaderText = "Ngày Học";
                    dgvLH.Columns[5].HeaderText = "Ca Học";
                }
            }
            
        }
        private void reset()
        {
            txtMaLop.Text = "";
            txtCH.Text = "";
            txtMonHoc.Text = "";
            txtNgayHoc.Text = "";
            txtMaGV.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ThemLichHoc", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMonHoc.Text);
                    cmd.Parameters.AddWithValue("@MaGiaoVien", txtMaGV.Text);
                    cmd.Parameters.AddWithValue("@NgayHoc", txtNgayHoc.Text);
                    cmd.Parameters.AddWithValue("@CaHoc", txtCH.Text);
                    cmd.Parameters.Add("@ResultMessage", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    frmLichHoc_Load(sender, e);
                    reset();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học có mã " + txtID.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        SqlCommand cmd = new SqlCommand("xoaLichHoc", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        frmLichHoc_Load(sender, e);
                        reset();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("suaLichHoc", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtMonHoc.Text);
                    cmd.Parameters.AddWithValue("@MaGiaoVien", txtMaGV.Text);
                    cmd.Parameters.AddWithValue("@NgayHoc", txtNgayHoc.Text);
                    cmd.Parameters.AddWithValue("@CaHoc", txtCH.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Thông tin lịch học đã được cập nhật thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy bản ghi lịch học để cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private void dgvLH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvLH.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            int i;
            i = dgvLH.CurrentRow.Index;
            txtID.Text = dgvLH.Rows[i].Cells[0].Value.ToString();
            txtMaLop.Text = dgvLH.Rows[i].Cells[1].Value.ToString();
            txtMonHoc.Text = dgvLH.Rows[i].Cells[2].Value.ToString();
            txtMaGV.Text = dgvLH.Rows[i].Cells[3].Value.ToString();
            txtNgayHoc.Text = dgvLH.Rows[i].Cells[4].Value.ToString();
            txtCH.Text = dgvLH.Rows[i].Cells[5].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frmLichHoc_Load(sender,e);
            }
            else
            {
                string connection = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                string query = "Select * from LichHoc where ID like N'%" + txtTimKiem.Text + "%'";
                SqlDataAdapter adt = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgvLH.DataSource = dt;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (role == "LND001")
            {
                frmTrangChuAD trangChuAD = new frmTrangChuAD(username:username,role:role);
                this.Hide();
                trangChuAD.Show();
            }else if (role == "LND003")
            {
                frmTrangChuGV gv = new frmTrangChuGV(username:username,role:role);
                this.Hide();
                gv.Show();
            }
        }
    }
}
