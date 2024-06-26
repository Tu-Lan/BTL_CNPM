using System;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmTrangChuAD : Form
    {
        public frmTrangChuAD()
        {
            InitializeComponent();
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
            frmHocSinh hs = new frmHocSinh();
            this.Hide();
            hs.Show();
        }
    }
}