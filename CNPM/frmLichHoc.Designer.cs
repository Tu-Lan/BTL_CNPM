using System.ComponentModel;

namespace CNPM
{
    partial class frmLichHoc
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
            this.txtCH = new System.Windows.Forms.TextBox();
            this.lblMaDanToc = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtNgayHoc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCH
            // 
            this.txtCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCH.Location = new System.Drawing.Point(619, 121);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(200, 26);
            this.txtCH.TabIndex = 112;
            // 
            // lblMaDanToc
            // 
            this.lblMaDanToc.AutoSize = true;
            this.lblMaDanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDanToc.Location = new System.Drawing.Point(514, 121);
            this.lblMaDanToc.Name = "lblMaDanToc";
            this.lblMaDanToc.Size = new System.Drawing.Size(53, 19);
            this.lblMaDanToc.TabIndex = 108;
            this.lblMaDanToc.Text = "Ca học";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(716, 289);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(0, 0);
            this.btnChiTiet.TabIndex = 107;
            this.btnChiTiet.Text = "Chi tiết học sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(170, 121);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(53, 19);
            this.lblMaHS.TabIndex = 106;
            this.lblMaHS.Text = "Mã lớp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(170, 290);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 26);
            this.txtTimKiem.TabIndex = 105;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(76, 295);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbTimkiem.TabIndex = 104;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(793, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 103;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(664, 291);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 102;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(537, 291);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 101;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(400, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 100;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(512, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 19);
            this.lblAddress.TabIndex = 99;
            this.lblAddress.Text = "Mã giáo viên";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(514, 74);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 19);
            this.lblGender.TabIndex = 98;
            this.lblGender.Text = "Ngày học";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(170, 168);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(60, 19);
            this.lblTenHS.TabIndex = 97;
            this.lblTenHS.Text = "Mã môn";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(431, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 29);
            this.lbTitle.TabIndex = 96;
            this.lbTitle.Text = "LỊCH HỌC";
            // 
            // dgvLH
            // 
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Location = new System.Drawing.Point(80, 346);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.Size = new System.Drawing.Size(880, 300);
            this.dgvLH.TabIndex = 95;
            this.dgvLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLH_CellClick_1);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(252, 114);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(200, 26);
            this.txtMaLop.TabIndex = 114;
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHoc.Location = new System.Drawing.Point(252, 161);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(200, 26);
            this.txtMonHoc.TabIndex = 115;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(619, 161);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(200, 26);
            this.txtMaGV.TabIndex = 116;
            // 
            // txtNgayHoc
            // 
            this.txtNgayHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoc.Location = new System.Drawing.Point(619, 67);
            this.txtNgayHoc.Name = "txtNgayHoc";
            this.txtNgayHoc.Size = new System.Drawing.Size(200, 26);
            this.txtNgayHoc.TabIndex = 117;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(252, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 26);
            this.txtID.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 118;
            this.label1.Text = "ID:";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 26);
            this.btnHome.TabIndex = 193;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 658);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayHoc);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.lblMaDanToc);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvLH);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLichHoc";
            this.Text = "Lịch Học";
            this.Load += new System.EventHandler(this.frmLichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.Label lblMaDanToc;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvLH;

        #endregion

        private System.Windows.Forms.TextBox txtNgayHoc;
    }
}