using System.ComponentModel;

namespace CNPM
{
    partial class frmTrangChuAD
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
            this.meNu = new System.Windows.Forms.MenuStrip();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meNu.SuspendLayout();
            this.SuspendLayout();
            // 
            // meNu
            // 
            this.meNu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meNu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.giáoViênToolStripMenuItem, this.họcSinhToolStripMenuItem, this.lớpHọcToolStripMenuItem, this.bảngĐiểmToolStripMenuItem, this.mônHọcToolStripMenuItem, this.điểmMônHọcToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.meNu.Location = new System.Drawing.Point(0, 0);
            this.meNu.Name = "meNu";
            this.meNu.Size = new System.Drawing.Size(933, 31);
            this.meNu.TabIndex = 0;
            this.meNu.Text = "menu";
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.giáoViênToolStripMenuItem.Text = "Giáo Viên";
            // 
            // họcSinhToolStripMenuItem
            // 
            this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.họcSinhToolStripMenuItem.Text = "Học Sinh";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            this.bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            this.bảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.bảngĐiểmToolStripMenuItem.Text = "Bảng Điểm";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.mônHọcToolStripMenuItem.Text = "Môn Học";
            // 
            // điểmMônHọcToolStripMenuItem
            // 
            this.điểmMônHọcToolStripMenuItem.Name = "điểmMônHọcToolStripMenuItem";
            this.điểmMônHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.điểmMônHọcToolStripMenuItem.Text = "Điểm Môn Học";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmTrangChuAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.meNu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.meNu;
            this.Name = "frmTrangChuAD";
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChuAD_FormClosing);
            this.meNu.ResumeLayout(false);
            this.meNu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem điểmMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngĐiểmToolStripMenuItem;

        private System.Windows.Forms.MenuStrip meNu;

        #endregion
    }
}