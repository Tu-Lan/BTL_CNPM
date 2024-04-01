using System.ComponentModel;

namespace CNPM
{
    partial class frmMonHoc
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
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(510, 133);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(156, 26);
            this.txtSoTiet.TabIndex = 155;
            // 
            // txtHeSo
            // 
            this.txtHeSo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSo.Location = new System.Drawing.Point(190, 133);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(156, 26);
            this.txtHeSo.TabIndex = 154;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(679, 217);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(0, 0);
            this.btnChiTiet.TabIndex = 153;
            this.btnChiTiet.Text = "Chi tiết học sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(133, 218);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(167, 26);
            this.txtTimKiem.TabIndex = 152;
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(39, 223);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(65, 19);
            this.lbTimkiem.TabIndex = 151;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(604, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 150;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(510, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 149;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(408, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 26);
            this.btnSua.TabIndex = 148;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(315, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 147;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(56, 260);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(623, 208);
            this.dgvMonHoc.TabIndex = 146;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 145;
            this.label4.Text = "Số tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 144;
            this.label3.Text = "Hệ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 143;
            this.label2.Text = "Tên môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(510, 87);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(156, 26);
            this.txtTenMon.TabIndex = 142;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(74, 87);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(86, 19);
            this.lblMaHS.TabIndex = 141;
            this.lblMaHS.Text = "Mã môn học";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(190, 87);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(156, 26);
            this.txtMaMon.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 139;
            this.label1.Text = "MÔN HỌC";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 26);
            this.btnHome.TabIndex = 156;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 505);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtHeSo);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}