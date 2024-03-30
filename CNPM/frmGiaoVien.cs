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
    public partial class frmGiaoVien : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        public frmGiaoVien()
        {
            InitializeComponent();
        }


        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
           // InitializeComponent();
            LoadData();
            LoadMonHocToComboBox();
        }
        private void LoadData()
        {
            string query = "SELECT MaGiaoVien, TenGiaoVien, DiaChi, DienThoai, MaMonHoc FROM GIAOVIEN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvGV.DataSource = table;
                }
            }
        }
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public ComboBoxItem(string value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadMonHocToComboBox()
        {
          
                string query = "SELECT MaMonHoc FROM MONHOC";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_mmh.Items.Add(reader["MaMonHoc"].ToString());
                    }
                    reader.Close();
                }
            

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMaGV.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtMaDT.Text) ||
                cb_mmh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra xem mã giáo viên đã tồn tại trong cơ sở dữ liệu chưa
            string maGV = txtMaGV.Text;
            string query = "SELECT COUNT(*) FROM GIAOVIEN WHERE MaGiaoVien = @MaGV";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaGV", maGV);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã giáo viên đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; // Nếu dữ liệu không hợp lệ, không thực hiện thêm và thoát khỏi hàm
            }

            // Lấy dữ liệu từ các TextBox và ComboBox
            string maGV = txtMaGV.Text;
            string tenGV = txtName.Text;
            string diaChi = txtAddress.Text;
            string dienThoai = txtMaDT.Text;
            string maMonHoc = string.Empty;
            object selectedItem = cb_mmh.SelectedItem;
            if (selectedItem != null)
            {
                if (selectedItem is KeyValuePair<string, string>)
                {
                    KeyValuePair<string, string> selectedMonHoc = (KeyValuePair<string, string>)selectedItem;
                    maMonHoc = selectedMonHoc.Key;
                }
                else if (selectedItem is string)
                {
                    maMonHoc = selectedItem.ToString();
                }
            }

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu
            string query = "INSERT INTO GIAOVIEN (MaGiaoVien, TenGiaoVien, DiaChi, DienThoai, MaMonHoc) VALUES (@MaGV, @TenGV, @DiaChi, @DienThoai, @MaMonHoc)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaGV", maGV);
                command.Parameters.AddWithValue("@TenGV", tenGV);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@DienThoai", dienThoai);
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_mmh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ ô được chọn
                DataGridViewRow row = dgvGV.Rows[e.RowIndex];
                string maGV = row.Cells["MaGiaoVien"].Value.ToString();
                string tenGV = row.Cells["TenGiaoVien"].Value.ToString();
                string diaChi = row.Cells["DiaChi"].Value.ToString();
                string dienThoai = row.Cells["DienThoai"].Value.ToString();
                string maMonHoc = row.Cells["MaMonHoc"].Value.ToString();

                // Hiển thị thông tin lên các TextBox và ComboBox
                txtMaGV.Text = maGV;
                txtName.Text = tenGV;
                txtAddress.Text = diaChi;
                txtMaDT.Text = dienThoai;

                // Tìm và chọn môn học tương ứng trong ComboBox
                foreach (var item in cb_mmh.Items)
                {
                    if (item is ComboBoxItem comboBoxItem)
                    {
                        if (comboBoxItem.Value == maMonHoc)
                        {
                            cb_mmh.SelectedItem = comboBoxItem;
                            break;
                        }
                    }
                }

            }
        }

        private void UpdateTeacher(string maGV, string tenGV, string diaChi, string dienThoai, string maMonHoc)
        {
            string query = "UPDATE GIAOVIEN SET TenGiaoVien = @TenGV, DiaChi = @DiaChi, DienThoai = @DienThoai, MaMonHoc = @MaMonHoc WHERE MaGiaoVien = @MaGV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenGV", tenGV);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@DienThoai", dienThoai);
                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                command.Parameters.AddWithValue("@MaGV", maGV);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteTeacher(string maGV)
        {
            string query = "DELETE FROM GIAOVIEN WHERE MaGiaoVien = @MaGV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaGV", maGV);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
           

            // Lấy thông tin từ các TextBox và ComboBox
            string maGV = txtMaGV.Text;
            string tenGV = txtName.Text;
            string diaChi = txtAddress.Text;
            string dienThoai = txtMaDT.Text;
            string maMonHoc = cb_mmh.SelectedItem.ToString();

            // Gọi hàm cập nhật giáo viên
            UpdateTeacher(maGV, tenGV, diaChi, dienThoai, maMonHoc);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã giáo viên từ TextBox
            string maGV = txtMaGV.Text;

            // Gọi hàm xóa giáo viên
            DeleteTeacher(maGV);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMaDT.Text = "";
            txtTimKiem.Text = "";
            cb_mmh.Text = "";

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ ô tìm kiếm
            string keyword = txtTimKiem.Text.Trim();

            // Thực hiện truy vấn tìm kiếm
            string query = "SELECT MaGiaoVien, TenGiaoVien, DiaChi, DienThoai, MaMonHoc FROM GIAOVIEN WHERE TenGiaoVien LIKE @Keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvGV.DataSource = table;
                }
            }
        }
    }
}
