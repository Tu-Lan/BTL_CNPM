using System.ComponentModel;

namespace CNPM
{
    partial class frmTrangChuGV
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
            this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meNu.SuspendLayout();
            this.SuspendLayout();
            // 
            // meNu
            // 
            this.meNu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meNu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.họcSinhToolStripMenuItem, this.lớpHọcToolStripMenuItem, this.mônHọcToolStripMenuItem, this.lịchHọcToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.meNu.Location = new System.Drawing.Point(0, 0);
            this.meNu.Name = "meNu";
            this.meNu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.meNu.Size = new System.Drawing.Size(891, 33);
            this.meNu.TabIndex = 1;
            this.meNu.Text = "menu";
            // 
            // họcSinhToolStripMenuItem
            // 
            this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.họcSinhToolStripMenuItem.Text = "Học Sinh";
            this.họcSinhToolStripMenuItem.Click += new System.EventHandler(this.họcSinhToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.mônHọcToolStripMenuItem.Text = "Môn Học";
            // 
            // lịchHọcToolStripMenuItem
            // 
            this.lịchHọcToolStripMenuItem.Name = "lịchHọcToolStripMenuItem";
            this.lịchHọcToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.lịchHọcToolStripMenuItem.Text = "Lịch Học";
            this.lịchHọcToolStripMenuItem.Click += new System.EventHandler(this.điểmMônHọcToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmTrangChuGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 692);
            this.Controls.Add(this.meNu);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTrangChuGV";
            this.Text = "Trang Chủ";
            this.meNu.ResumeLayout(false);
            this.meNu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip meNu;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        #endregion
    }
}