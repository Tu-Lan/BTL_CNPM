using System.ComponentModel;

namespace CNPM
{
    partial class frmHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.btnBangDiemKy1 = new System.Windows.Forms.Button();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.lblMaDanToc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBangDiemKy2 = new System.Windows.Forms.Button();
            this.btn_DiemCaNam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(128, 284);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 26);
            this.txtTimKiem.TabIndex = 42;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(49, 291);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbTimkiem.TabIndex = 41;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(599, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(496, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(391, 285);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(291, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cmbGender.Location = new System.Drawing.Point(167, 165);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(162, 27);
            this.cmbGender.TabIndex = 36;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(510, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 26);
            this.txtAddress.TabIndex = 35;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(394, 118);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 19);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirth.Location = new System.Drawing.Point(510, 61);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(164, 26);
            this.txtBirth.TabIndex = 31;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(394, 68);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(75, 19);
            this.lblBirth.TabIndex = 30;
            this.lblBirth.Text = "Ngày Sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(50, 166);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 19);
            this.lblGender.TabIndex = 29;
            this.lblGender.Text = "Giới Tính:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(166, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 26);
            this.txtName.TabIndex = 28;
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(50, 118);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(95, 19);
            this.lblTenHS.TabIndex = 27;
            this.lblTenHS.Text = "Tên Học Sinh:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.Location = new System.Drawing.Point(166, 61);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(164, 26);
            this.txtMaHS.TabIndex = 26;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(403, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 29);
            this.lbTitle.TabIndex = 25;
            this.lbTitle.Text = "HỌC SINH";
            // 
            // dgvHS
            // 
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Location = new System.Drawing.Point(40, 344);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.Size = new System.Drawing.Size(880, 300);
            this.dgvHS.TabIndex = 24;
            this.dgvHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHS_CellContentClick);
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(50, 61);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(93, 19);
            this.lblMaHS.TabIndex = 43;
            this.lblMaHS.Text = "Mã Học Sinh:";
            // 
            // btnBangDiemKy1
            // 
            this.btnBangDiemKy1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangDiemKy1.Location = new System.Drawing.Point(714, 61);
            this.btnBangDiemKy1.Name = "btnBangDiemKy1";
            this.btnBangDiemKy1.Size = new System.Drawing.Size(164, 26);
            this.btnBangDiemKy1.TabIndex = 44;
            this.btnBangDiemKy1.Text = "Bảng điển học sinh kỳ 1";
            this.btnBangDiemKy1.UseVisualStyleBackColor = true;
            this.btnBangDiemKy1.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // txtMaDT
            // 
            this.txtMaDT.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDT.Location = new System.Drawing.Point(510, 161);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(164, 26);
            this.txtMaDT.TabIndex = 46;
            // 
            // lblMaDanToc
            // 
            this.lblMaDanToc.AutoSize = true;
            this.lblMaDanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDanToc.Location = new System.Drawing.Point(394, 168);
            this.lblMaDanToc.Name = "lblMaDanToc";
            this.lblMaDanToc.Size = new System.Drawing.Size(90, 19);
            this.lblMaDanToc.TabIndex = 45;
            this.lblMaDanToc.Text = "Mã Dân Tộc:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(349, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 26);
            this.txtEmail.TabIndex = 48;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(233, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 19);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 26);
            this.btnHome.TabIndex = 49;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBangDiemKy2
            // 
            this.btnBangDiemKy2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangDiemKy2.Location = new System.Drawing.Point(714, 111);
            this.btnBangDiemKy2.Name = "btnBangDiemKy2";
            this.btnBangDiemKy2.Size = new System.Drawing.Size(164, 26);
            this.btnBangDiemKy2.TabIndex = 50;
            this.btnBangDiemKy2.Text = "Bảng điển học sinh kỳ 2";
            this.btnBangDiemKy2.UseVisualStyleBackColor = true;
            this.btnBangDiemKy2.Click += new System.EventHandler(this.btnBangDiemKy2_Click);
            // 
            // btn_DiemCaNam
            // 
            this.btn_DiemCaNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiemCaNam.Location = new System.Drawing.Point(714, 159);
            this.btn_DiemCaNam.Name = "btn_DiemCaNam";
            this.btn_DiemCaNam.Size = new System.Drawing.Size(164, 26);
            this.btn_DiemCaNam.TabIndex = 53;
            this.btn_DiemCaNam.Text = "Bảng điểm cả năm";
            this.btn_DiemCaNam.UseVisualStyleBackColor = true;
            this.btn_DiemCaNam.Click += new System.EventHandler(this.btn_DiemCaNam_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 654);
            this.Controls.Add(this.btn_DiemCaNam);
            this.Controls.Add(this.btnBangDiemKy2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.lblMaDanToc);
            this.Controls.Add(this.btnBangDiemKy1);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvHS);
            this.Name = "frmHocSinh";
            this.Text = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_DiemCaNam;

        private System.Windows.Forms.Button btnBangDiemKy2;

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label lblMaDanToc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Button btnBangDiemKy1;

        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvHS;

        #endregion
    }
}