using System;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmTrangChuBGH : Form
    {
        private string username;
        private string role;
        public frmTrangChuBGH(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            txtInfo.Text = "Tên người dùng: " + username + "\r\nVai trò: " + role;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất!!","Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmDangNhap dangNhap = new frmDangNhap();
                this.Hide();
                dangNhap.Show();
            }
            else
            {
                return;
            }
        }
        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc monHoc = new frmMonHoc(username, role);
            monHoc.Show();
            this.Hide();
        }
    }
}