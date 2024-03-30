namespace CNPM
{
    partial class frmLichHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cb_MGV = new System.Windows.Forms.ComboBox();
            this.cb_MM = new System.Windows.Forms.ComboBox();
            this.cb_ML = new System.Windows.Forms.ComboBox();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.dtpNgayHoc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDanToc
            // 
            this.lblMaDanToc.AutoSize = true;
            this.lblMaDanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDanToc.Location = new System.Drawing.Point(405, 118);
            this.lblMaDanToc.Name = "lblMaDanToc";
            this.lblMaDanToc.Size = new System.Drawing.Size(53, 19);
            this.lblMaDanToc.TabIndex = 87;
            this.lblMaDanToc.Text = "Ca học";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(689, 285);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(0, 0);
            this.btnChiTiet.TabIndex = 86;
            this.btnChiTiet.Text = "Chi tiết học sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(61, 71);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(53, 19);
            this.lblMaHS.TabIndex = 85;
            this.lblMaHS.Text = "Mã lớp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(143, 286);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 26);
            this.txtTimKiem.TabIndex = 84;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(49, 291);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbTimkiem.TabIndex = 83;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(766, 287);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 82;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(637, 287);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 81;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(510, 287);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(373, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(56, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 19);
            this.lblAddress.TabIndex = 77;
            this.lblAddress.Text = "Mã giáo viên";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(405, 71);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 19);
            this.lblGender.TabIndex = 76;
            this.lblGender.Text = "Ngày học";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(61, 118);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(60, 19);
            this.lblTenHS.TabIndex = 74;
            this.lblTenHS.Text = "Mã môn";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(403, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 29);
            this.lbTitle.TabIndex = 72;
            this.lbTitle.Text = "LỊCH HỌC";
            // 
            // dgvLH
            // 
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Location = new System.Drawing.Point(53, 342);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.Size = new System.Drawing.Size(880, 300);
            this.dgvLH.TabIndex = 71;
            this.dgvLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLH_CellClick);
            // 
            // cb_MGV
            // 
            this.cb_MGV.FormattingEnabled = true;
            this.cb_MGV.Location = new System.Drawing.Point(164, 159);
            this.cb_MGV.Name = "cb_MGV";
            this.cb_MGV.Size = new System.Drawing.Size(164, 21);
            this.cb_MGV.TabIndex = 90;
            // 
            // cb_MM
            // 
            this.cb_MM.FormattingEnabled = true;
            this.cb_MM.Location = new System.Drawing.Point(164, 115);
            this.cb_MM.Name = "cb_MM";
            this.cb_MM.Size = new System.Drawing.Size(164, 21);
            this.cb_MM.TabIndex = 91;
            // 
            // cb_ML
            // 
            this.cb_ML.FormattingEnabled = true;
            this.cb_ML.Location = new System.Drawing.Point(164, 69);
            this.cb_ML.Name = "cb_ML";
            this.cb_ML.Size = new System.Drawing.Size(164, 21);
            this.cb_ML.TabIndex = 92;
            // 
            // txtCH
            // 
            this.txtCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCH.Location = new System.Drawing.Point(510, 118);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(200, 26);
            this.txtCH.TabIndex = 93;
            // 
            // dtpNgayHoc
            // 
            this.dtpNgayHoc.Location = new System.Drawing.Point(510, 71);
            this.dtpNgayHoc.Name = "dtpNgayHoc";
            this.dtpNgayHoc.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayHoc.TabIndex = 94;
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 654);
            this.Controls.Add(this.dtpNgayHoc);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.cb_ML);
            this.Controls.Add(this.cb_MM);
            this.Controls.Add(this.cb_MGV);
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
            this.Name = "frmLichHoc";
            this.Text = "frmLichHoc";
            this.Load += new System.EventHandler(this.frmLichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ComboBox cb_MGV;
        private System.Windows.Forms.ComboBox cb_MM;
        private System.Windows.Forms.ComboBox cb_ML;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.DateTimePicker dtpNgayHoc;
    }
}