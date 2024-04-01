using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmMonHoc : Form
    {
        private string role;
        private string username;
        public frmMonHoc(string username, string role)
        {
            this.username = username;
            this.role = role;
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using(SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
        
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvMonHoc.DataSource = dt;
                    }
                    dgvMonHoc.Columns[0].HeaderText = "Mã môn";
                    dgvMonHoc.Columns[1].HeaderText = "Tên môn";
                    dgvMonHoc.Columns[2].HeaderText = "Số tiết";
                    dgvMonHoc.Columns[3].HeaderText = "Hệ số";
        
                }
            }
        }
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMonHoc.CurrentRow.Index;
            txtMaMon.Text = dgvMonHoc.Rows[i].Cells[0].Value.ToString();
            txtTenMon.Text = dgvMonHoc.Rows[i].Cells[1].Value.ToString();
            txtSoTiet.Text = dgvMonHoc.Rows[i].Cells[2].Value.ToString();
            txtHeSo.Text = dgvMonHoc.Rows[i].Cells[3].Value.ToString();
        }
        public bool checkValidation()
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Please enter subject's ID", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMon.Focus();
                return false;
            }
            if (txtSoTiet.Text == "")
            {
                MessageBox.Show("Please enter subject's lesson", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTiet.Focus();
                return false;
            }
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("Please enter subject's name", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMon.Focus();
                return false;
            }
            if (txtHeSo.Text == "")
            {
                MessageBox.Show("Please enter subject's factor", "Noticationn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHeSo.Focus();
                return false;
            }


            return true;

        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        string query = "select *from MONHOC";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "INSERT_SUBJECT";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = txtMaMon.Text;
                    cmd.Parameters.Add("@TenMonHoc", SqlDbType.VarChar).Value = txtTenMon.Text;
                    cmd.Parameters.Add("@SoTiet", SqlDbType.Int).Value = txtSoTiet.Text;
                    cmd.Parameters.Add("@HeSo", SqlDbType.Int).Value = txtHeSo.Text;
                    cnn.Open();
                    if (checkValidation())
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            frmMonHoc_Load(sender, e);
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
        void resetData()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtSoTiet.Text = "";
            txtHeSo.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Update_Subject";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = txtMaMon.Text;
                    cmd.Parameters.Add("@TenMonHoc", SqlDbType.VarChar).Value = txtTenMon.Text;
                    cmd.Parameters.Add("@SoTiet", SqlDbType.Int).Value = txtSoTiet.Text;
                    cmd.Parameters.Add("@HeSo", SqlDbType.Int).Value = txtHeSo.Text;
                    cnn.Open();
                    if (checkValidation())
                    {
                        try
                        {
                            if (MessageBox.Show("Are you sure to update this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                                frmMonHoc_Load(sender, e);
                                resetData();
                            }
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
                    cmd.CommandText = "Update_Subject";
                    cmd.Connection = cnn;
                    cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar).Value = txtMaMon.Text;
                    cmd.Parameters.Add("@TenMonHoc", SqlDbType.VarChar).Value = txtTenMon.Text;
                    cmd.Parameters.Add("@SoTiet", SqlDbType.Int).Value = txtSoTiet.Text;
                    cmd.Parameters.Add("@HeSo", SqlDbType.Int).Value = txtHeSo.Text;
                    cnn.Open();
                    if (txtMaMon.Text != "")
                    {
                        try
                        {
                            if (MessageBox.Show("Are you sure to delete this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                                frmMonHoc_Load(sender, e);
                                resetData();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Can't update duplicate key", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter ID which you wanna delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaMon.Focus();
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
            }else if (role == "LND003")
            {
                frmTrangChuGV trangChuGv = new frmTrangChuGV(username:username,role:role);
                this.Hide();
                trangChuGv.Show();
            }
            else if(role == "LND002")
            {
                frmTrangChuBGH trangChuBgh = new frmTrangChuBGH(username, role);
                this.Hide();
                trangChuBgh.Show();
            }
        }
    }
}