using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmDiemHS : Form
    {
        public frmDiemHS()
        {
            InitializeComponent();
        }

        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;

        private void frmDiemHS_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "SELECT KQ.MaHocSinh, HS.HoTen, KQ.DiemMiengTB, KQ.Diem15PhutTB, KQ.Diem45PhutTB, KQ.DiemThi \nFROM KQ_HOCSINH_MONHOC KQ\nINNER JOIN HOCSINH HS ON KQ.MaHocSinh = HS.MaHocSinh;\n";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataAdapter adt = new SqlDataAdapter())
                    {
                        adt.SelectCommand = cmd; // Gán SqlCommand cho SelectCommand

                        DataTable dt = new DataTable();
                        adt.Fill(dt);

                        
                            dgvDSDiem.DataSource = dt;

                            dgvDSDiem.Columns[0].HeaderText = "Mã Học Sinh";
                            dgvDSDiem.Columns[1].HeaderText = "Họ và Tên";
                            dgvDSDiem.Columns[2].HeaderText = "Điểm miệng";
                            dgvDSDiem.Columns[3].HeaderText = "Điểm 15 phút";
                            dgvDSDiem.Columns[4].HeaderText = "Điểm 45 phút";
                            dgvDSDiem.Columns[5].HeaderText = "Điểm thi";
                        
                    }
                }
            }
        }

    }
}