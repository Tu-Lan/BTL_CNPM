using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmBangDiemHK2 : Form
    {
        private string username;
        private string role;
        public frmBangDiemHK2(string maHS, string username, string role)
        {
            this.username = username;
            this.role = role;
            InitializeComponent();
            txtMaHS.Text = maHS;
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void reset()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
        private void frmBangDiemHK2_Load(object sender, EventArgs e)
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
                WHERE KQ.MaHocSinh = @MaHocSinh AND HK.MaHocKy = 'HK2' ";

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
                    dgvDSDiemHK2.DataSource = dt;
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}




        private void dgvDSDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSDiemHK2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            int i;
            i = dgvDSDiemHK2.CurrentRow.Index;
            txtMaHS.Text = dgvDSDiemHK2.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSDiemHK2.Rows[i].Cells[1].Value.ToString();
            txtTenLop.Text = dgvDSDiemHK2.Rows[i].Cells[2].Value.ToString();
            txtTenNamHoc.Text = dgvDSDiemHK2.Rows[i].Cells[3].Value.ToString();
            txtTenMon.Text = dgvDSDiemHK2.Rows[i].Cells[4].Value.ToString();
            txtTenHocKy.Text = dgvDSDiemHK2.Rows[i].Cells[5].Value.ToString();
            txtDiemMieng.Text = dgvDSDiemHK2.Rows[i].Cells[6].Value.ToString();
            txtDiem15p.Text = dgvDSDiemHK2.Rows[i].Cells[7].Value.ToString();
            txtDiem45p.Text = dgvDSDiemHK2.Rows[i].Cells[8].Value.ToString();
            txtDiemThi.Text = dgvDSDiemHK2.Rows[i].Cells[9].Value.ToString();

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

                    frmBangDiemHK2_Load(sender, e);
                    reset();
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHocSinh hocSinh = new frmHocSinh(username, role);
            hocSinh.Show();
            this.Hide();
        }
    }
}