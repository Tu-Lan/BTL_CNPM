using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private bool isUserWantsToExit = false;

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isUserWantsToExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    isUserWantsToExit = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }
        string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            if(username !="" && password != "")
            {
                string query = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TenDangNhap='" + username + "' and " + "MatKhau='" + password + "'";
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int v = (int)command.ExecuteScalar();
                    if (v != 1)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string roleQuery = "SELECT MaLoai FROM NGUOIDUNG WHERE TenDangNhap='" + username + "'";
                        SqlCommand roleCommand = new SqlCommand(roleQuery, connection);
                        string role = roleCommand.ExecuteScalar()?.ToString();

                        if (role == "LND001")
                        {
                            frmTrangChuAD trangChuAD = new frmTrangChuAD(username:txtUser.Text,role:role);
                            this.Hide();
                            trangChuAD.Show();
                        }else if (role == "LND002")
                        {
                            frmTrangChuBGH bgh = new frmTrangChuBGH(username:txtUser.Text,role:role);
                            this.Hide();
                            bgh.Show();
                        }
                        else
                        {
                            frmTrangChuGV gv = new frmTrangChuGV(username:txtUser.Text,role:role);
                            this.Hide();
                            gv.Show();
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Điền hết các ô đi!!");
            }
        }

    }
}
