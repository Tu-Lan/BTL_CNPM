using System;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmTrangChuGV : Form
    {
        public frmTrangChuGV()
        {
            InitializeComponent();
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
            frmHocSinh hs = new frmHocSinh();
            this.Hide();
            hs.Show();
        }
    }
}