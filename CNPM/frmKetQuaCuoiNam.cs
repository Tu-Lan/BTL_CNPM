using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmKetQuaCuoiNam : Form
    {
        private string role;
        private string username;
        public frmKetQuaCuoiNam(string maHS, string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            txtMaHS.Text = maHS;
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        string query =
            "SELECT " +
            "    MaHocSinh, " +
            "    (SELECT HoTen FROM HOCSINH WHERE HOCSINH.MaHocSinh = BANG_DIEM_CA_NAM.MaHocSinh), " +
            "    (SELECT ROUND(AVG((DiemMiengTB + Diem15PhutTB + Diem45PhutTB * 2 + DiemThi * 3) / 7), 2) " +
            "        FROM KQ_HOCSINH_MONHOC " +
            "        WHERE MaHocKy = 'HK1' AND MaHocSinh = BANG_DIEM_CA_NAM.MaHocSinh " +
            "        GROUP BY MaHocKy, MaHocSinh), " +
            "    (SELECT ROUND(AVG((DiemMiengTB + Diem15PhutTB + Diem45PhutTB * 2 + DiemThi * 3) / 7), 2) " +
            "        FROM KQ_HOCSINH_MONHOC " +
            "        WHERE MaHocKy = 'HK2' AND MaHocSinh = BANG_DIEM_CA_NAM.MaHocSinh " +
            "        GROUP BY MaHocKy, MaHocSinh), " +
            "    BANG_DIEM_CA_NAM.DIEMTB_CANAM, " +
            "    CASE " +
            "        WHEN BANG_DIEM_CA_NAM.DIEMTB_CANAM >= 8.0 THEN N'Giỏi' " +
            "        WHEN BANG_DIEM_CA_NAM.DIEMTB_CANAM >= 6.5 THEN N'Khá' " +
            "        WHEN BANG_DIEM_CA_NAM.DIEMTB_CANAM >= 5.0 THEN N'Trung Bình' " +
            "        ELSE N'Yếu' " +
            "    END AS N'Học Lực' " +
            "FROM " +
            "    (SELECT BANG_DIEMTB_HOCKI.MaHocSinh, " +
            "            ROUND(SUM((CASE WHEN BANG_DIEMTB_HOCKI.MaHocKy = 'HK1' THEN BANG_DIEMTB_HOCKI.DiemTBHocKi ELSE 0 END) " +
            "                    + (CASE WHEN BANG_DIEMTB_HOCKI.MaHocKy = 'HK2' THEN BANG_DIEMTB_HOCKI.DiemTBHocKi ELSE 0 END) * 2) / 3, 2) " +
            "                AS DIEMTB_CANAM " +
            "    FROM " +
            "        (SELECT MaHocSinh, MaHocKy, AVG((DiemMiengTB + Diem15PhutTB + Diem45PhutTB * 2 + DiemThi * 3) / 7) AS DiemTBHocKi " +
            "        FROM KQ_HOCSINH_MONHOC " +
            "        GROUP BY MaHocKy, MaHocSinh) AS BANG_DIEMTB_HOCKI " +
            "    GROUP BY BANG_DIEMTB_HOCKI.MaHocSinh) AS BANG_DIEM_CA_NAM";
        private void frmKetQuaCuoiNam_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                if (!string.IsNullOrEmpty(txtMaHS.Text))
                {
                    query += " WHERE BANG_DIEM_CA_NAM.MaHocSinh = @MaHocSinh";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(txtMaHS.Text))
                    {
                        cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHS.Text);
                    }

                    conn.Open();

                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dgvDiemTongKet.DataSource = dt;
                    }
                }
            }

            dgvDiemTongKet.Columns[0].HeaderText = "Mã Học Sinh";
            dgvDiemTongKet.Columns[1].HeaderText = "Tên Học Sinh";
            dgvDiemTongKet.Columns[2].HeaderText = "TBHKy1";
            dgvDiemTongKet.Columns[3].HeaderText = "TBHKy2";
            dgvDiemTongKet.Columns[4].HeaderText = "TB Năm";
            dgvDiemTongKet.Columns[5].HeaderText = "Học Lực";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHocSinh hocSinh = new frmHocSinh(username, role);
            hocSinh.Show();
            this.Hide();
        }

        private void dgvDiemTongKet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDiemTongKet.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            int i;
            i = dgvDiemTongKet.CurrentRow.Index;
            txtTenHS.Text = dgvDiemTongKet.Rows[i].Cells[1].Value.ToString();
        }
    }
}