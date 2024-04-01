using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmDiemHS : Form
    {
        private double diemTrungBinhKy;
        private string username;
        private string role;
        public frmDiemHS(string maHS, string username, string role)
        {
            this.username = username;
            this.role = role;
            InitializeComponent();
            txtMaHS.Text = maHS;
        }

        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void reset()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            cmbLop.Text = "";
            cmbNamHoc.Text = "";
            cmbMonHoc.Text = "";
            cmbHocKy.Text = "";
            txtDiemMieng.Text = "";
            txtDiem15p.Text = "";
            txtDiem45p.Text = "";
            txtDiemThi.Text = "";
        }
        private void frmDiemHS_Load_1(object sender, EventArgs e)
{
    try
    {
        using (SqlConnection conn = new SqlConnection(constr))
        {
            string query =
                @"SELECT KQ.MaHocSinh, HS.HoTen AS [Họ và Tên], L.TenLop AS [Tên Lớp], NH.TenNamHoc AS [Tên Năm Học], 
                MH.TenMonHoc AS [Tên Môn Học], HK.TenHocKy AS [Tên Học Kỳ], KQ.DiemMiengTB AS [Điểm miệng], 
                KQ.Diem15PhutTB AS [Điểm 15 phút], KQ.Diem45PhutTB AS [Điểm 45 phút], KQ.DiemThi AS [Điểm thi]
                FROM dbo.KQ_HOCSINH_MONHOC AS KQ 
                INNER JOIN HOCSINH HS ON KQ.MaHocSinh = HS.MaHocSinh 
                INNER JOIN LOP L ON KQ.MaLop = L.MaLop 
                INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc 
                INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy 
                INNER JOIN dbo.MONHOC MH ON MH.MaMonHoc = KQ.MaMonHoc 
                WHERE KQ.MaHocSinh = @MaHocSinh AND HK.MaHocKy = 'HK1' ";


            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);

                conn.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    // Thêm cột điểm trung bình môn (TBMon)
                    dt.Columns.Add("TBMon", typeof(decimal));

                    // Tính toán điểm trung bình môn và gán vào cột mới
                    foreach (DataRow row in dt.Rows)
                    {
                        decimal diemMieng = Convert.ToDecimal(row["Điểm miệng"]);
                        decimal diem15p = Convert.ToDecimal(row["Điểm 15 phút"]);
                        decimal diem45p = Convert.ToDecimal(row["Điểm 45 phút"]);
                        decimal diemThi = Convert.ToDecimal(row["Điểm thi"]);

                        // Tính điểm trung bình môn
                        decimal tbMon = (diemMieng + diem15p + diem45p * 2 + diemThi * 3) / 7;
                        row["TBMon"] = Math.Round(tbMon, 2); // Làm tròn đến 2 chữ số sau dấu thập phân
                    }

                    // Thêm hàng tính trung bình học kỳ
                    DataRow avgRow = dt.NewRow();

                    // Tính toán trung bình học kỳ
                    decimal sumTBMon = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        sumTBMon += Convert.ToDecimal(row["TBMon"]);
                    }
                    decimal avgTBMon = sumTBMon / dt.Rows.Count;
                    avgRow["MaHocSinh"] = "Trung bình học kỳ";
                    avgRow["Họ và Tên"] = "";
                    avgRow["Tên Lớp"] = "";
                    avgRow["Tên Năm Học"] = "";
                    avgRow["Tên Môn Học"] = "";
                    avgRow["Tên Học Kỳ"] = "";
                    avgRow["Điểm miệng"] = DBNull.Value;
                    avgRow["Điểm 15 phút"] = DBNull.Value;
                    avgRow["Điểm 45 phút"] = DBNull.Value;
                    avgRow["Điểm thi"] = DBNull.Value;
                    avgRow["TBMon"] = Math.Round(avgTBMon, 2); // Làm tròn đến 2 chữ số sau dấu thập phân

                    // Thêm hàng vào DataTable
                    dt.Rows.Add(avgRow);

                    // Hiển thị DataGridView
                    dgvDiemHK1.DataSource = dt;
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}

        private string GetIDLop(string tenLop)
        {
            string MaLop = "";
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string query = "Select Lop.MaLop from Lop where Lop.TenLop  = @TenLop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaLop = reader["MaLop"].ToString();
                }

                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return MaLop;
        }
        private string GetIDNamHoc(string TenNamHoc)
        {
            string MaNamHoc = "";
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string query = "SELECT MaNamHoc FROM NAMHOC WHERE TenNamHoc = @TenNamHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNamHoc", TenNamHoc);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaNamHoc = reader["MaNamHoc"].ToString();
                }

                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }

            return MaNamHoc;
        }
        private string GetIDMonHoc(string tenMon)
        {
            string MaMonHoc = "";
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string query = "Select MaMonHoc from MONHOC where TenMonHoc  = @TenLop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLop", tenMon);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaMonHoc = reader["MaMonHoc"].ToString();
                }

                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return MaMonHoc;
        }
        private string GetIDHocKy(string tenHK)
        {
            string MaHocKy = "";
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                string query = "Select MaHocKy from HOCKY where TenHocKy  = @TenHocKy";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLop", tenHK);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaHocKy = reader["MaHocKy"].ToString();
                }

                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return MaHocKy;
        }
        private void dgvDSDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDiemHK1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            int i;
            i = dgvDiemHK1.CurrentRow.Index;
            txtMaHS.Text = dgvDiemHK1.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDiemHK1.Rows[i].Cells[1].Value.ToString();
            txtTenLop.Text = dgvDiemHK1.Rows[i].Cells[2].Value.ToString();
            txtTenNamHoc.Text = dgvDiemHK1.Rows[i].Cells[3].Value.ToString();
            txtTenMon.Text = dgvDiemHK1.Rows[i].Cells[4].Value.ToString();
            txtTenHocKy.Text = dgvDiemHK1.Rows[i].Cells[5].Value.ToString();
            txtDiemMieng.Text = dgvDiemHK1.Rows[i].Cells[6].Value.ToString();
            txtDiem15p.Text = dgvDiemHK1.Rows[i].Cells[7].Value.ToString();
            txtDiem45p.Text = dgvDiemHK1.Rows[i].Cells[8].Value.ToString();
            txtDiemThi.Text = dgvDiemHK1.Rows[i].Cells[9].Value.ToString();

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


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHocSinh hocSinh = new frmHocSinh(username, role);
            hocSinh.Show();
            this.Hide();
        }
        
    }
}