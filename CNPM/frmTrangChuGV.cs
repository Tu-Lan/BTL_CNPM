using System;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmTrangChuGV : Form
    {
        private string username;
        private string role;
        public frmTrangChuGV(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            txtInfo.Text = "Tên người dùng: " + username + "\r\nVai trò: " + role;
        }

        private void điểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh(username:username,role:role);
            this.Hide();
            hs.Show();
        }
    }
}