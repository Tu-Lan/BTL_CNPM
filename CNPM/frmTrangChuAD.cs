using System;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmTrangChuAD : Form
    {
        private string username;
        private string role;
        public frmTrangChuAD(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            txtInfo.Text = "Tên người dùng: " + username + "\r\nVai trò: " + role;
        }
        private bool isUserWantsToExit = false;
        private void frmTrangChuAD_FormClosing(object sender, FormClosingEventArgs e)
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
        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc monHoc = new frmMonHoc(username, role);
            monHoc.Show();
            this.Hide();;
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop lop = new frmLop(username, role);
            lop.Show();
            this.Show();
        }
        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien giaoVien = new frmGiaoVien(username, role);
            giaoVien.Show();
            this.Hide();
        }
        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHoc lichHoc = new frmLichHoc(username,role);
            lichHoc.Show();
            this.Hide();
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTK quanLyTk = new frmQuanLyTK(username,role);
            quanLyTk.Show();
            this.Hide();
        }
    }
}