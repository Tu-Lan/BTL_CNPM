using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmHocSinh : Form
    {
        private string role;
        private string username;
        public frmHocSinh(string username,string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        private void checkTrong()
        {
            if (dgvHS.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (txtBirth.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBirth.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (this.cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return;
            }
        }
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query =
                    "SELECT  MaHocSinh, HoTen, CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS GioiTinh, NgaySinh, DiaChi,MaDanToc, Email FROM HOCSINH;";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvHS.DataSource = dt;
                    }

                    dgvHS.Columns[0].HeaderText = "Mã Học Sinh";
                    dgvHS.Columns[1].HeaderText = "Tên Học Sinh";
                    dgvHS.Columns[2].HeaderText = "Giới Tính";
                    dgvHS.Columns[3].HeaderText = "Ngày sinh";
                    dgvHS.Columns[4].HeaderText = "Địa chỉ";
                    dgvHS.Columns[5].HeaderText = "Mã Dân Tộc";
                    dgvHS.Columns[6].HeaderText = "Email";
                }
            }
        }
        private void dataHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHS.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            int i;
            i = dgvHS.CurrentRow.Index;
            txtMaHS.Text = dgvHS.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvHS.Rows[i].Cells[1].Value.ToString();
            cmbGender.Text = dgvHS.Rows[i].Cells[2].Value.ToString();
            txtBirth.Text = dgvHS.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dgvHS.Rows[i].Cells[4].Value.ToString();
            txtMaDT.Text = dgvHS.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvHS.Rows[i].Cells[6].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frmHocSinh_Load(sender,e);
            }
            else
            {
                string connection = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                string query = "Select * from HOCSINH where HoTen like N'%" + txtTimKiem.Text + "%'";
                SqlDataAdapter adt = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dgvHS.DataSource = dt;

            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmDiemHS diemHs = new frmDiemHS(txtMaHS.Text);
            diemHs.Show();
            this.Hide();
        }
        private void reset()
        {
            txtMaHS.Text = "";
            txtName.Text = "";
            cmbGender.Text = "";
            txtBirth.Text = "";
            txtAddress.Text = "";
            txtMaDT.Text = "";
            txtEmail.Text = "";
        }
        string gioiTinh = "";
        private void convertGendertoBit()
        {
            if (cmbGender.Text == "Nam")
            {
                gioiTinh = "1";
            }
            else if (cmbGender.Text == "Nữ")
            {
                gioiTinh = "0";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            convertGendertoBit();
            
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemHS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", txtBirth.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MaDanToc", txtMaDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    frmHocSinh_Load(sender, e);
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
            checkTrong();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    convertGendertoBit();
                    SqlCommand cmd = new SqlCommand("SuaHS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh); 
                    cmd.Parameters.AddWithValue("@NgaySinh", txtBirth.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MaDanToc", txtMaDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    frmHocSinh_Load(sender, e);
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("XoaHS", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa học sinh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHocSinh_Load(sender, e);
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
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
        }
    }
}