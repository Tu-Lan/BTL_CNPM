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
    public partial class frmLichHoc: Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString;
        // Đặt font cho DataGridView

     /*   private int GetSelectedRecordID()
        {
            if (dgvLH.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvLH.SelectedRows[0].Index;
                return Convert.ToInt32(dgvLH.Rows[selectedRowIndex].Cells["ID"].Value);
            }
            return -1; // Trả về -1 nếu không có hàng nào được chọn
        }
*/
        private int GetSelectedRecordID()
        {
            if (dgvLH.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvLH.SelectedRows[0].Index;
                return Convert.ToInt32(dgvLH.Rows[selectedRowIndex].Cells["ID"].Value);
            }
            return -1; // Trả về -1 nếu không có hàng nào được chọn
        }

        public frmLichHoc()
        {
            InitializeComponent();
            // Thiết lập Font hỗ trợ Unicode cho toàn bộ form
          
            
        }
        private void LoadDataIntoComboBoxes()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
           

            // Truy vấn SQL để lấy dữ liệu từ các bảng
            string queryMaLop = "SELECT MaLop FROM LOP";
            string queryMaMonHoc = "SELECT MaMonHoc FROM MONHOC";
            string queryMaGiaoVien = "SELECT MaGiaoVien FROM GIAOVIEN";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Lấy dữ liệu cho ComboBox MaLop
                    SqlCommand commandMaLop = new SqlCommand(queryMaLop, connection);
                    SqlDataReader readerMaLop = commandMaLop.ExecuteReader();
                    while (readerMaLop.Read())
                    {
                        cb_ML.Items.Add(readerMaLop["MaLop"].ToString());
                    }
                    readerMaLop.Close();

                    // Lấy dữ liệu cho ComboBox MaMonHoc
                    SqlCommand commandMaMonHoc = new SqlCommand(queryMaMonHoc, connection);
                    SqlDataReader readerMaMonHoc = commandMaMonHoc.ExecuteReader();
                    while (readerMaMonHoc.Read())
                    {
                        cb_MM.Items.Add(readerMaMonHoc["MaMonHoc"].ToString());
                    }
                    readerMaMonHoc.Close();

                    // Lấy dữ liệu cho ComboBox MaGiaoVien
                    SqlCommand commandMaGiaoVien = new SqlCommand(queryMaGiaoVien, connection);
                    SqlDataReader readerMaGiaoVien = commandMaGiaoVien.ExecuteReader();
                    while (readerMaGiaoVien.Read())
                    {
                        cb_MGV.Items.Add(readerMaGiaoVien["MaGiaoVien"].ToString());
                    }
                    readerMaGiaoVien.Close();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM LichHoc"; // Câu truy vấn SQL để lấy dữ liệu từ bảng LichHoc

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLH.DataSource = dataTable; // Đổ dữ liệu từ DataTable vào DataGridView
                    dgvLH.DefaultCellStyle.Font = new Font("Segoe UI", 12);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void frmLichHoc_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (cb_ML.SelectedItem == null || cb_MM.SelectedItem == null || cb_MGV.SelectedItem == null || txtCH.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string maLop = cb_ML.SelectedItem.ToString();
            string maMonHoc = cb_MM.SelectedItem.ToString();
            string maGiaoVien = cb_MGV.SelectedItem.ToString();
            DateTime ngayHoc = dtpNgayHoc.Value; // Lấy giá trị ngày từ DateTimePicker
            string caHoc = txtCH.Text; // Lấy giá trị từ TextBox


            // Gọi stored procedure để thêm dữ liệu vào bảng LichHoc
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("ThemLichHoc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaLop", maLop);
                    command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    command.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                    command.Parameters.AddWithValue("@NgayHoc", ngayHoc);
                    command.Parameters.AddWithValue("@CaHoc", caHoc);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm dữ liệu thành công!");

                    connection.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            // Lấy ID của bản ghi cần sửa
            int ID_Cua_Ban = GetSelectedRecordID();

            // Kiểm tra xem có bản ghi nào được chọn không
            if (ID_Cua_Ban == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để sửa.");
                return;
            }

            // Kiểm tra dữ liệu đầu vào
            if (cb_ML.SelectedItem == null || cb_MM.SelectedItem == null || cb_MGV.SelectedItem == null || txtCH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string maLop = cb_ML.SelectedItem.ToString();
            string maMonHoc = cb_MM.SelectedItem.ToString();
            string maGiaoVien = cb_MGV.SelectedItem.ToString();
            DateTime ngayHoc = dtpNgayHoc.Value; // Lấy giá trị ngày từ DateTimePicker
            string caHoc = txtCH.Text; // Lấy giá trị từ TextBox

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SuaLichHoc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID_Cua_Ban); // Truyền ID của bản ghi cần sửa vào tham số @ID
                    command.Parameters.AddWithValue("@MaLop", maLop);
                    command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    command.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                    command.Parameters.AddWithValue("@NgayHoc", ngayHoc);
                    command.Parameters.AddWithValue("@CaHoc", caHoc);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Sửa dữ liệu thành công!");

                    connection.Close();

                    // Sau khi sửa dữ liệu thành công, cần reload lại dữ liệu
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy ID của bản ghi cần xóa
            int ID_Cua_Ban = GetSelectedRecordID();
           
            // Gọi stored procedure để xóa dữ liệu từ bảng LichHoc
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("XoaLichHoc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID_Cua_Ban); // Truyền ID của bản ghi cần xóa vào tham số @ID

                    command.ExecuteNonQuery();

                    MessageBox.Show("Xóa dữ liệu thành công!");

                    connection.Close();

                    // Sau khi xóa dữ liệu thành công, cần reload lại dữ liệu
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void TimKiemTheoCaHoc(string keyword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM LichHoc WHERE CaHoc LIKE @Keyword"; // Câu truy vấn SQL để tìm kiếm theo ca học
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%"); // Thêm '%' để tìm kiếm các ca học chứa keyword

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvLH.DataSource = dataTable; // Đổ dữ liệu từ DataTable vào DataGridView
                    dgvLH.DefaultCellStyle.Font = new Font("Segoe UI", 12);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            TimKiemTheoCaHoc(keyword);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của các control
            cb_ML.SelectedIndex = -1;
            cb_MM.SelectedIndex = -1;
            cb_MGV.SelectedIndex = -1;
            dtpNgayHoc.Value = DateTime.Now;
            txtCH.Text = "";
            txtTimKiem.Text = "";

            // Reload dữ liệu ban đầu
            LoadData();
        }

        private void dgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                int ID_Cua_Ban = Convert.ToInt32(dgvLH.Rows[e.RowIndex].Cells["ID"].Value);

                ShowDataInControls(ID_Cua_Ban);
            }
        }
        private void ShowDataInControls(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM LichHoc WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cb_ML.SelectedItem = reader["MaLop"].ToString();
                        cb_MM.SelectedItem = reader["MaMonHoc"].ToString();
                        cb_MGV.SelectedItem = reader["MaGiaoVien"].ToString();
                        dtpNgayHoc.Value = Convert.ToDateTime(reader["NgayHoc"]);
                        txtCH.Text = reader["CaHoc"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
