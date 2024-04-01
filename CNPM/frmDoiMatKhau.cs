using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string newPassword = txtPassMoi.Text;
            string confirmPassMoi = txtConfirmPassMoi.Text;
            string oldPassword = txtPassCu.Text;
            if (newPassword != confirmPassMoi)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            updatePassWord(username, oldPassword, newPassword);
        }

        private void updatePassWord(string username, string oldPassword, string newPassword)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
            string query = "SELECT MatKhau FROM NGUOIDUNG WHERE TenDangNhap  = @UserName";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    string currentPass = (string)cmd.ExecuteScalar();
                    if (currentPass == null || currentPass != oldPassword)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string updatePasswordQuery = "UPDATE NGUOIDUNG SET MatKhau = @NewPassword WHERE TenDangNhap = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updatePasswordQuery, conn))
                    {
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCommand.Parameters.AddWithValue("@Username", username);
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}