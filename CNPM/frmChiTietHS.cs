using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CNPM
{
    public partial class frmChiTietHS : Form
    {
        public frmChiTietHS(string maHS)
        {
            InitializeComponent();
            txtMaHS.Text = maHS;
        }

        private void frmChiTietHS_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
            using (SqlConnection conn =new SqlConnection(constr))
            {
                string query =
                    "SELECT\n    s.PK_sStudentID AS StudentID,    s.sFullName AS FullName,   sc.PK_sScoreID AS ScoreID,    sb.sName AS SubjectName,\n    sc.fMidTerm AS MidTerm,   sc.fFinal AS Final,  sc.fOral AS Oral FROM    tblStudent s INNER JOIN   tblSubject_Student ss ON s.PK_sStudentID = ss.FK_sStudentID\nINNER JOIN\n    tblSubject sb ON ss.FK_sSubjectID = sb.PK_sSubjectID\nLEFT JOIN\n    tblScore sc ON sb.PK_sSubjectID = sc.FK_sSubjectID WHERE s.PK_sStudentID = '"+txtMaHS.Text+"';";
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    using (SqlDataAdapter adt= new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataChiTietHS.DataSource = dt;
                    }

                    dataChiTietHS.Columns[0].HeaderText = "Mã Học Sinh";
                    dataChiTietHS.Columns[1].HeaderText = "Tên Học Sinh";
                    dataChiTietHS.Columns[2].HeaderText = "Mã Điểm";
                    dataChiTietHS.Columns[3].HeaderText = "Tên Môn Học";
                    dataChiTietHS.Columns[4].HeaderText = "Điểm giữa Kỳ";
                    dataChiTietHS.Columns[5].HeaderText = "Điểm Cuối Kỳ";
                    dataChiTietHS.Columns[6].HeaderText = "Điểm Miệng";
                    
                }
            }
        }
    }
}