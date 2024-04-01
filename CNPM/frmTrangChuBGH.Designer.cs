using System.ComponentModel;

namespace CNPM
{
    partial class frmTrangChuBGH
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
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.meNu.SuspendLayout();
            this.SuspendLayout();
            // 
            // meNu
            // 
            this.meNu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meNu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.giáoViênToolStripMenuItem, this.lớpHọcToolStripMenuItem, this.mônHọcToolStripMenuItem, this.báoCáoToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.meNu.Location = new System.Drawing.Point(0, 0);
            this.meNu.Name = "meNu";
            this.meNu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.meNu.Size = new System.Drawing.Size(762, 35);
            this.meNu.TabIndex = 1;
            this.meNu.Text = "menu";
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.giáoViênToolStripMenuItem.Text = "Giáo Viên";
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
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(588, 4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(174, 31);
            this.txtInfo.TabIndex = 3;
            // 
            // frmTrangChuBGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 610);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.meNu);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTrangChuBGH";
            this.Text = "frmTrangChuBGH";
            this.meNu.ResumeLayout(false);
            this.meNu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInfo;

        private System.Windows.Forms.MenuStrip meNu;
        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        #endregion
    }
}