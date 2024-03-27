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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHienDiem = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDiem
            // 
            this.dgvDSDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDiem.Location = new System.Drawing.Point(12, 117);
            this.dgvDSDiem.Name = "dgvDSDiem";
            this.dgvDSDiem.Size = new System.Drawing.Size(677, 300);
            this.dgvDSDiem.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienDiem);
            this.panel1.Controls.Add(this.cmbMonHoc);
            this.panel1.Controls.Add(this.lblMonHoc);
            this.panel1.Controls.Add(this.cmbHocKy);
            this.panel1.Controls.Add(this.lblHocKy);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cmbLop);
            this.panel1.Controls.Add(this.lblLop);
            this.panel1.Controls.Add(this.cmbNamHoc);
            this.panel1.Controls.Add(this.lblNamHoc);
            this.panel1.Location = new System.Drawing.Point(715, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 414);
            this.panel1.TabIndex = 27;
            // 
            // btnHienDiem
            // 
            this.btnHienDiem.Location = new System.Drawing.Point(5, 281);
            this.btnHienDiem.Name = "btnHienDiem";
            this.btnHienDiem.Size = new System.Drawing.Size(259, 31);
            this.btnHienDiem.TabIndex = 9;
            this.btnHienDiem.Text = "Hiện thị danh sách";
            this.btnHienDiem.UseVisualStyleBackColor = true;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Items.AddRange(new object[] { "Toán", "Vật Lý", "Hóa Học", "Sinh Học", "Lịch Sử", "Địa Lý", "Ngữ Văn", "GDCD", "Thể Dục" });
            this.cmbMonHoc.Location = new System.Drawing.Point(3, 245);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(204, 29);
            this.cmbMonHoc.TabIndex = 8;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Location = new System.Drawing.Point(3, 220);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(99, 22);
            this.lblMonHoc.TabIndex = 7;
            this.lblMonHoc.Text = "Môn Học:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] { "Học Kỳ 1", "Học Kỳ 2" });
            this.cmbHocKy.Location = new System.Drawing.Point(3, 188);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(204, 29);
            this.cmbHocKy.TabIndex = 6;
            // 
            // lblHocKy
            // 
            this.lblHocKy.Location = new System.Drawing.Point(3, 163);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(99, 22);
            this.lblHocKy.TabIndex = 5;
            this.lblHocKy.Text = "Học Kỳ";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(54, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 22);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Nhập điểm học sinh";
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Items.AddRange(new object[] { "6A", "6B", "7A", "7B", "8A", "8B", "9A", "9B" });
            this.cmbLop.Location = new System.Drawing.Point(3, 131);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(204, 29);
            this.cmbLop.TabIndex = 3;
            // 
            // lblLop
            // 
            this.lblLop.Location = new System.Drawing.Point(3, 106);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(65, 22);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Items.AddRange(new object[] { "2022-2023", "2023-2024" });
            this.cmbNamHoc.Location = new System.Drawing.Point(3, 74);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(204, 29);
            this.cmbNamHoc.TabIndex = 1;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Location = new System.Drawing.Point(3, 49);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(99, 22);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm Học:";
            // 
            // frmDiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSDiem);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDiemHS";
            this.Text = "Nhập điểm học sinh";
            this.Load += new System.EventHandler(this.frmDiemHS_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHienDiem;

        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label lblMonHoc;

        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label lblHocKy;

        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.ComboBox cmbNamHoc;

        private System.Windows.Forms.DataGridView dgvDSDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNamHoc;

        #endregion
    }
}