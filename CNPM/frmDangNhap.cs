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
                string query = "SELECT COUNT(*) FROM tblSignUp WHERE sUserName='" + username + "' and " + "sPassword='" + password + "'";
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
                        MessageBox.Show("Chào mừng!!", "Thông báo");
                        frmTrangChu trangChu = new frmTrangChu();
                        this.Hide();
                        trangChu.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Điền hết các ô đi!!");
            }
        }

        private void returnDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy= new frmDangKy();
            this.Hide();
            dangKy.Show();
        }


    }
}
