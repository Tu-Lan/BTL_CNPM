using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmDiemHS : Form
    {
        public frmDiemHS(string maHS)
        {
            InitializeComponent();
            txtMaHS.Text = maHS;
        }

        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void reset()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            txtTenLop.Text = "";
            txtTenNamHoc.Text = "";
            txtTenMon.Text = "";
            txtTenHocKy.Text = "";
            txtDiemMieng.Text = "";
            txtDiem15p.Text = "";
            txtDiem45p.Text = "";
            txtDiemThi.Text = "";
        }
        private void frmDiemHS_Load_1(object sender, EventArgs e)
        {using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT KQ.MaHocSinh, HS.HoTen, KQ.MaLop, L.TenLop, KQ.MaNamHoc, NH.TenNamHoc, KQ.MaMonHoc, MH.TenMonHoc, KQ.MaHocKy, HK.TenHocKy, KQ.DiemMiengTB, KQ.Diem15PhutTB, KQ.Diem45PhutTB, KQ.DiemThi " +
                               "FROM KQ_HOCSINH_MONHOC AS KQ " +
                               "INNER JOIN HOCSINH AS HS ON KQ.MaHocSinh = HS.MaHocSinh " +
                               "INNER JOIN LOP AS L ON KQ.MaLop = L.MaLop " +
                               "INNER JOIN NAMHOC AS NH ON KQ.MaNamHoc = NH.MaNamHoc " +
                               "INNER JOIN MONHOC AS MH ON KQ.MaMonHoc = MH.MaMonHoc " +
                               "INNER JOIN HOCKY AS HK ON KQ.MaHocKy = HK.MaHocKy " +
                               "WHERE HS.MaHocSinh = @MaHocSinh";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                    conn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvDSDiem.DataSource = dt;
                        dgvDSDiem.Columns[0].HeaderText = "Mã Học Sinh";
                        dgvDSDiem.Columns[1].HeaderText = "Họ và Tên";
                        dgvDSDiem.Columns[3].HeaderText = "Tên Lớp";
                        dgvDSDiem.Columns[5].HeaderText = "Tên Năm Học";
                        dgvDSDiem.Columns[7].HeaderText = "Tên Môn Học";
                        dgvDSDiem.Columns[9].HeaderText = "Tên Học Kỳ";
                        dgvDSDiem.Columns[10].HeaderText = "Điểm miệng";
                        dgvDSDiem.Columns[11].HeaderText = "Điểm 15 phút";
                        dgvDSDiem.Columns[12].HeaderText = "Điểm 45 phút";
                        dgvDSDiem.Columns[13].HeaderText = "Điểm thi";
                    }
                }
            }

        }
        private void dgvDSDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSDiem.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            int i;
            i = dgvDSDiem.CurrentRow.Index;
            txtMaHS.Text = dgvDSDiem.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSDiem.Rows[i].Cells[1].Value.ToString();
            txtTenLop.Text = dgvDSDiem.Rows[i].Cells[2].Value.ToString();
            txtTenNamHoc.Text = dgvDSDiem.Rows[i].Cells[3].Value.ToString();
            txtTenMon.Text = dgvDSDiem.Rows[i].Cells[4].Value.ToString();
            txtTenHocKy.Text = dgvDSDiem.Rows[i].Cells[5].Value.ToString();
            txtDiemMieng.Text = dgvDSDiem.Rows[i].Cells[6].Value.ToString();
            txtDiem15p.Text = dgvDSDiem.Rows[i].Cells[7].Value.ToString();
            txtDiem45p.Text = dgvDSDiem.Rows[i].Cells[8].Value.ToString();
            txtDiemThi.Text = dgvDSDiem.Rows[i].Cells[9].Value.ToString();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa điểm này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes){
                using (SqlConnection conn = new SqlConnection(constr))
                {

                    SqlCommand cmd = new SqlCommand("sua_KQ_HOCSINH_MONHOC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                    cmd.Parameters.AddWithValue("@MaLop", txtTenLop.Text);
                    cmd.Parameters.AddWithValue("@MaNamHoc", txtTenNamHoc.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtTenMon.Text);
                    cmd.Parameters.AddWithValue("@MaHocKy", txtTenHocKy.Text);
                    cmd.Parameters.AddWithValue("@DiemMiengTB", txtDiemMieng.Text);
                    cmd.Parameters.AddWithValue("@Diem15PhutTB", txtDiem15p.Text);
                    cmd.Parameters.AddWithValue("@Diem45PhutTB", txtDiem45p.Text);
                    cmd.Parameters.AddWithValue("@DiemThi", txtDiemThi.Text);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Dữ liệu đã được cập nhật thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy dữ liệu phù hợp để cập nhật.");
                    }

                    frmDiemHS_Load_1(sender, e);
                    reset();
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("them_KQ_HOCSINH_MONHOC", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDiemHS_Load_1(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}