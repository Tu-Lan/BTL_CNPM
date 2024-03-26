using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CNPM
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
       
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query =
                    "SELECT PK_sTeacherID, sName, CASE WHEN bGender = 1 THEN 'Nam' ELSE N'Nữ' END AS Gender, fSalary, sPhone, sAddress FROM tblTeacher";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataGV.DataSource = dt;
                    }

                    dataGV.Columns[0].HeaderText = "Mã Giáo Viên";
                    dataGV.Columns[1].HeaderText = "Tên Giáo Viên";
                    dataGV.Columns[2].HeaderText = "Giới Tính";
                    dataGV.Columns[3].HeaderText = "Lương";
                    dataGV.Columns[4].HeaderText = "Số Điện Thoại";
                    dataGV.Columns[5].HeaderText = "Địa chỉ";
                }
            }
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGV.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            int i;
            i = dataGV.CurrentRow.Index;
            txtMaGV.Text = dataGV.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGV.Rows[i].Cells[1].Value.ToString();
            cbGender.Text = dataGV.Rows[i].Cells[2].Value.ToString();
            txtSalary.Text = dataGV.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dataGV.Rows[i].Cells[4].Value.ToString();
            txtAddress.Text = dataGV.Rows[i].Cells[5].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                frmGiaoVien_Load(sender,e);
            }
            else
            {
                string connection = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
                string query = "Select * from tblTeacher where sName like '%" + txtTimKiem.Text + "%'";
                SqlDataAdapter adt = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGV.DataSource = dt;

            }
        }
    }
}