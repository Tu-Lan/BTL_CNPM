using System.ComponentModel;

namespace CNPM
{
    partial class frmDoiMatKhau
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.txtConfirmPassMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassMoi = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassCu = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtConfirmPassMoi
            // 
            this.txtConfirmPassMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassMoi.Location = new System.Drawing.Point(290, 287);
            this.txtConfirmPassMoi.Multiline = true;
            this.txtConfirmPassMoi.Name = "txtConfirmPassMoi";
            this.txtConfirmPassMoi.PasswordChar = '*';
            this.txtConfirmPassMoi.Size = new System.Drawing.Size(303, 30);
            this.txtConfirmPassMoi.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassMoi.Location = new System.Drawing.Point(290, 235);
            this.txtPassMoi.Multiline = true;
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.PasswordChar = '*';
            this.txtPassMoi.Size = new System.Drawing.Size(303, 30);
            this.txtPassMoi.TabIndex = 17;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(252, 45);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 40);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Đổi Mật Khẩu";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(74, 131);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(108, 27);
            this.lbUser.TabIndex = 16;
            this.lbUser.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(290, 128);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(303, 30);
            this.txtUser.TabIndex = 18;
            // 
            // txtPassCu
            // 
            this.txtPassCu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCu.Location = new System.Drawing.Point(290, 180);
            this.txtPassCu.Multiline = true;
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.PasswordChar = '*';
            this.txtPassCu.Size = new System.Drawing.Size(303, 30);
            this.txtPassCu.TabIndex = 25;
            // 
            // btnDoi
            // 
            this.btnDoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoi.Location = new System.Drawing.Point(271, 355);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(139, 45);
            this.btnDoi.TabIndex = 21;
            this.btnDoi.Text = "Đổi";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Xác Nhận MK Mới";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(74, 238);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(155, 27);
            this.lbPass.TabIndex = 15;
            this.lbPass.Text = "Mật Khẩu Mới";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 467);
            this.Controls.Add(this.txtPassCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmPassMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.txtPassMoi);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPassCu;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.TextBox txtPassMoi;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox txtConfirmPassMoi;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}