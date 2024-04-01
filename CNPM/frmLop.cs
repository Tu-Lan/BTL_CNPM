using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmLop : Form
    {
        private string role;
        private string username;
        public frmLop(string username, string role)
        {
            this.username = username;
            this.role = role;
            InitializeComponent();
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        String query = "select LOP.MaLop, LOP.TenLop, KHOILOP.TenKhoiLop, NAMHOC.TenNamHoc,LOP.SiSo, GIAOVIEN.TenGiaoVien \r\nfrom LOP  INNER JOIN KHOILOP \r\nON LOP.MaKhoiLop = KHOILOP.MaKhoiLop INNER JOIN NAMHOC \r\nON LOP.MaNamHoc=NAMHOC.MaNamHoc INNER JOIN GIAOVIEN \r\nON GIAOVIEN.MaGiaoVien = LOP.MaGiaoVien";


        void resetData()
        {
            txtMaLop.Text = "";
            txtSiSo.Text = "";
            txtTenLop.Text = "";
            cboGiaoVien.Text = "";
            cboKhoi.Text = "";
            cboNamHoc.Text = "";

        }

void load_CbxNamHoc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select NAMHOC.TenNamHoc from NAMHOC", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        cboNamHoc.DataSource = dt;
                        cboNamHoc.DisplayMember = "TenNamHoc";
                    }
                }
            }
        }
        void load_CbxKhoi()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select KHOILOP.TenKhoiLop from KHOILOP", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        cboKhoi.DataSource = dt;
                        cboKhoi.DisplayMember = "TenKhoiLop";
                    }
                }
            }
        }
        void load_CbxGiaoVien()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select GIAOVIEN.TenGiaoVien from GIAOVIEN", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        cboGiaoVien.DataSource = dt;
                        cboGiaoVien.DisplayMember = "TenGiaoVien";
                    }
                }
            }
        }
        private void frmLop_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select LOP.MaLop, LOP.TenLop, KHOILOP.TenKhoiLop, NAMHOC.TenNamHoc,LOP.SiSo, GIAOVIEN.TenGiaoVien \r\nfrom LOP  INNER JOIN KHOILOP \r\nON LOP.MaKhoiLop = KHOILOP.MaKhoiLop INNER JOIN NAMHOC \r\nON LOP.MaNamHoc=NAMHOC.MaNamHoc INNER JOIN GIAOVIEN \r\nON GIAOVIEN.MaGiaoVien = LOP.MaGiaoVien;", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvLH.DataSource = dt;
                    }
                    dgvLH.Columns[0].HeaderText = "Mã học sinh";
                    dgvLH.Columns[1].HeaderText = "Tên lớp";
                    dgvLH.Columns[2].HeaderText = "Tên khối";
                    dgvLH.Columns[3].HeaderText = "Năm học";
                    dgvLH.Columns[4].HeaderText = "Sĩ số";
                    dgvLH.Columns[5].HeaderText = "Tên giáo viên";
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertClass";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = txtMaLop.Text;
                    cmd.Parameters.Add("@TenLop", SqlDbType.VarChar).Value = txtTenLop.Text;
                    cmd.Parameters.Add("@MaKhoiLop", SqlDbType.VarChar).Value = LayMaKhoi(cboKhoi.Text);
                    cmd.Parameters.Add("@MaNamHoc", SqlDbType.VarChar).Value = LayMaNamHoc(cboNamHoc.Text);
                    cmd.Parameters.Add("@SiSo", SqlDbType.Int).Value = txtSiSo.Text;
                    cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar).Value = GetTeacherID(cboGiaoVien.Text);
                    cnn.Open();
                    if (checkValidation())
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            frmLop_Load_1(sender, e);
                            resetData();
                        }
                        catch
                        {
                            MessageBox.Show("Can't insert duplicate key", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }

                }
            }
        }
        public bool checkValidation()
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Please enter class's ID", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return false;
            }
            if (txtSiSo.Text == "")
            {
                MessageBox.Show("Please enter class's quantity", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSiSo.Focus();
                return false;
            }
            if (cboGiaoVien.Text == "")
            {
                MessageBox.Show("Please enter teacher's name", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGiaoVien.Focus();
                return false;
            }
            if (cboKhoi.Text == "")
            {
                MessageBox.Show("Please enter grade's name", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboKhoi.Focus();
                return false;
            }
            if (cboNamHoc.Text == "")
            {
                MessageBox.Show("Please enter school year", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNamHoc.Focus();
                return false;
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Please enter class's name", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLop.Focus();
                return false;
            }

            return true;

        }
        private string GetTeacherID(string teacherName)
        {
            string MaGV = "";
            SqlConnection cnn = new SqlConnection(constr);

            try
            {
                cnn.Open();
                string query = "Select GIAOVIEN.MaGiaoVien from GIAOVIEN where GIAOVIEN.TenGiaoVien = @TenGiaoVien";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@TenGiaoVien", teacherName);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MaGV = reader["MaGiaoVien"].ToString();
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                cnn.Close();
            }

            return MaGV;
        }

        private string LayMaNamHoc(string tenNamHoc)
        {
            string MaNamHoc = "";
            SqlConnection cnn = new SqlConnection(constr);
            try
            {
                cnn.Open();
                string query = "Select NAMHOC.MaNamHoc from NAMHOC where NAMHOC.TenNamHoc = @TenNamHoc";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@TenNamHoc", tenNamHoc);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MaNamHoc = reader["MaNamHoc"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
            }
            finally
            {
                cnn.Close();
            }

            return MaNamHoc;
        }

        private string LayMaKhoi(string tenKhoi)
        {
            string MaKhoi = "";
            SqlConnection cnn = new SqlConnection(constr);
            try
            {
                cnn.Open();
                string query = "Select KHOILOP.MaKhoiLop from KHOILOP where KHOILOP.TenKhoiLop = @TeKhoi";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@TeKhoi", tenKhoi);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MaKhoi = reader["MaKhoiLop"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
            }
            finally
            {
                cnn.Close();
            }

            return MaKhoi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_Lop";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = txtMaLop.Text;
                    cmd.Parameters.Add("@TenLop", SqlDbType.VarChar).Value = txtTenLop.Text;
                    cmd.Parameters.Add("@MaKhoiLop", SqlDbType.VarChar).Value = LayMaKhoi(cboKhoi.Text);
                    cmd.Parameters.Add("@MaNamHoc", SqlDbType.VarChar).Value = LayMaNamHoc(cboNamHoc.Text);
                    cmd.Parameters.Add("@SiSo", SqlDbType.Int).Value = txtSiSo.Text;
                    cmd.Parameters.Add("@MaGiaoVien", SqlDbType.VarChar).Value = GetTeacherID(cboGiaoVien.Text);
                    cnn.Open();
                    if (checkValidation())
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            frmLop_Load_1(sender, e);
                            resetData();
                        }
                        catch
                        {
                            MessageBox.Show("Can't update duplicate key", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "del_LOP";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = txtMaLop.Text;
                    cnn.Open();

                    if (checkValidation())
                    {
                        try
                        {
                            if (MessageBox.Show("Are you sure to delete this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                                frmLop_Load_1(sender, e);
                                resetData();
                            }
                            else
                            {
                                this.Show();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Can't DELETE duplicate key", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void dgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLH.CurrentRow.Index;
            txtMaLop.Text = dgvLH.Rows[i].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLH.Rows[i].Cells[1].Value.ToString();
            cboKhoi.Text = dgvLH.Rows[i].Cells[2].Value.ToString();
            cboNamHoc.Text = dgvLH.Rows[i].Cells[3].Value.ToString();
            txtSiSo.Text = dgvLH.Rows[i].Cells[4].Value.ToString();
            cboGiaoVien.Text = dgvLH.Rows[i].Cells[5].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Please enter searched infor", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimKiem.Focus();
                frmLop_Load_1(sender, e);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(query + " where LOP.TenLop like N'%" + txtTimKiem.Text + "%'", cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            dgvLH.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (role == "LND001")
            {
                frmTrangChuAD trangChuAD = new frmTrangChuAD(username:username,role:role);
                this.Hide();
                trangChuAD.Show();
            }else if (role == "LND002")
            {
                frmTrangChuBGH bgh = new frmTrangChuBGH(username:username,role:role);
                this.Hide();
                bgh.Show();
            }
            else if (role == "LND003")
            {
                frmTrangChuGV trangChuGv = new frmTrangChuGV(username, role);
                trangChuGv.Show();
                this.Hide();
            }
        }
    }
}