using System.ComponentModel;

namespace CNPM
{
    partial class frmDiemHS
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
            this.dgvDSDiem = new System.Windows.Forms.DataGridView();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblMaNamHoc = new System.Windows.Forms.Label();
            this.txtTenNamHoc = new System.Windows.Forms.TextBox();
            this.lblDiem45p = new System.Windows.Forms.Label();
            this.txtDiem45p = new System.Windows.Forms.TextBox();
            this.lblDiem15p = new System.Windows.Forms.Label();
            this.txtDiem15p = new System.Windows.Forms.TextBox();
            this.lblDiemMieng = new System.Windows.Forms.Label();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSDiem
            // 
            this.dgvDSDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDiem.Location = new System.Drawing.Point(12, 345);
            this.dgvDSDiem.Name = "dgvDSDiem";
            this.dgvDSDiem.Size = new System.Drawing.Size(1058, 312);
            this.dgvDSDiem.TabIndex = 26;
            this.dgvDSDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDiem_CellClick);
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(12, 34);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(208, 29);
            this.txtMaHS.TabIndex = 28;
            // 
            // lblMaHS
            // 
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(12, 9);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(117, 22);
            this.lblMaHS.TabIndex = 29;
            this.lblMaHS.Text = "Mã Học Sinh:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(92, 298);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 26);
            this.txtTimKiem.TabIndex = 48;
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(13, 305);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbTimkiem.TabIndex = 47;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(453, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(355, 299);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(255, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(12, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(117, 22);
            this.lblHoTen.TabIndex = 50;
            this.lblHoTen.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(12, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(208, 29);
            this.txtHoTen.TabIndex = 49;
            // 
            // lblTenLop
            // 
            this.lblTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLop.Location = new System.Drawing.Point(13, 144);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(117, 22);
            this.lblTenLop.TabIndex = 52;
            this.lblTenLop.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(13, 169);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(208, 29);
            this.txtTenLop.TabIndex = 51;
            // 
            // lblHocKy
            // 
            this.lblHocKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(289, 144);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(117, 22);
            this.lblHocKy.TabIndex = 58;
            this.lblHocKy.Text = "Học Kỳ:";
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(289, 169);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(208, 29);
            this.txtTenHocKy.TabIndex = 57;
            // 
            // lblTenMon
            // 
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(288, 75);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(117, 22);
            this.lblTenMon.TabIndex = 56;
            this.lblTenMon.Text = "Tên Môn Học:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(288, 100);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(208, 29);
            this.txtTenMon.TabIndex = 55;
            // 
            // lblMaNamHoc
            // 
            this.lblMaNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNamHoc.Location = new System.Drawing.Point(288, 9);
            this.lblMaNamHoc.Name = "lblMaNamHoc";
            this.lblMaNamHoc.Size = new System.Drawing.Size(117, 22);
            this.lblMaNamHoc.TabIndex = 54;
            this.lblMaNamHoc.Text = "Tên Năm Học:";
            // 
            // txtTenNamHoc
            // 
            this.txtTenNamHoc.Location = new System.Drawing.Point(288, 34);
            this.txtTenNamHoc.Name = "txtTenNamHoc";
            this.txtTenNamHoc.Size = new System.Drawing.Size(208, 29);
            this.txtTenNamHoc.TabIndex = 53;
            // 
            // lblDiem45p
            // 
            this.lblDiem45p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem45p.Location = new System.Drawing.Point(564, 144);
            this.lblDiem45p.Name = "lblDiem45p";
            this.lblDiem45p.Size = new System.Drawing.Size(117, 22);
            this.lblDiem45p.TabIndex = 64;
            this.lblDiem45p.Text = "Điểm 45 phút:";
            // 
            // txtDiem45p
            // 
            this.txtDiem45p.Location = new System.Drawing.Point(564, 169);
            this.txtDiem45p.Name = "txtDiem45p";
            this.txtDiem45p.Size = new System.Drawing.Size(208, 29);
            this.txtDiem45p.TabIndex = 63;
            // 
            // lblDiem15p
            // 
            this.lblDiem15p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem15p.Location = new System.Drawing.Point(563, 75);
            this.lblDiem15p.Name = "lblDiem15p";
            this.lblDiem15p.Size = new System.Drawing.Size(117, 22);
            this.lblDiem15p.TabIndex = 62;
            this.lblDiem15p.Text = "Điểm 15 phút:";
            // 
            // txtDiem15p
            // 
            this.txtDiem15p.Location = new System.Drawing.Point(563, 100);
            this.txtDiem15p.Name = "txtDiem15p";
            this.txtDiem15p.Size = new System.Drawing.Size(208, 29);
            this.txtDiem15p.TabIndex = 61;
            // 
            // lblDiemMieng
            // 
            this.lblDiemMieng.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemMieng.Location = new System.Drawing.Point(563, 9);
            this.lblDiemMieng.Name = "lblDiemMieng";
            this.lblDiemMieng.Size = new System.Drawing.Size(117, 22);
            this.lblDiemMieng.TabIndex = 60;
            this.lblDiemMieng.Text = "Điểm Miệng:";
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Location = new System.Drawing.Point(563, 34);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(208, 29);
            this.txtDiemMieng.TabIndex = 59;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemThi.Location = new System.Drawing.Point(806, 75);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(117, 22);
            this.lblDiemThi.TabIndex = 66;
            this.lblDiemThi.Text = "Điểm Thi:";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(806, 100);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(208, 29);
            this.txtDiemThi.TabIndex = 65;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(12, 216);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(117, 22);
            this.lblMaLop.TabIndex = 68;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(12, 241);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(208, 29);
            this.txtMaLop.TabIndex = 67;
            // 
            // frmDiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 669);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblDiemThi);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.lblDiem45p);
            this.Controls.Add(this.txtDiem45p);
            this.Controls.Add(this.lblDiem15p);
            this.Controls.Add(this.txtDiem15p);
            this.Controls.Add(this.lblDiemMieng);
            this.Controls.Add(this.txtDiemMieng);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.txtTenHocKy);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblMaNamHoc);
            this.Controls.Add(this.txtTenNamHoc);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.dgvDSDiem);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDiemHS";
            this.Text = "Nhập điểm học sinh";
            this.Load += new System.EventHandler(this.frmDiemHS_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;

        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblMaNamHoc;
        private System.Windows.Forms.TextBox txtTenNamHoc;
        private System.Windows.Forms.Label lblDiem45p;
        private System.Windows.Forms.TextBox txtDiem45p;
        private System.Windows.Forms.Label lblDiem15p;
        private System.Windows.Forms.TextBox txtDiem15p;
        private System.Windows.Forms.Label lblDiemMieng;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox txtDiemThi;

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.Label lblMaHS;

        private System.Windows.Forms.TextBox txtMaHS;

        private System.Windows.Forms.DataGridView dgvDSDiem;

        #endregion
    }
}