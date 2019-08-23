namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Print_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrinterChoice_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaperChoice_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintStart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preview_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Print_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Print_ToolStripMenuItem
            // 
            this.Print_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrinterChoice_ToolStripMenuItem,
            this.PaperChoice_ToolStripMenuItem,
            this.PrintStart_ToolStripMenuItem,
            this.Preview_ToolStripMenuItem});
            this.Print_ToolStripMenuItem.Name = "Print_ToolStripMenuItem";
            this.Print_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.Print_ToolStripMenuItem.Text = "인쇄";
            // 
            // PrinterChoice_ToolStripMenuItem
            // 
            this.PrinterChoice_ToolStripMenuItem.Name = "PrinterChoice_ToolStripMenuItem";
            this.PrinterChoice_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.PrinterChoice_ToolStripMenuItem.Text = "프린터선택";
            this.PrinterChoice_ToolStripMenuItem.Click += new System.EventHandler(this.PrinterChoice_ToolStripMenuItem_Click);
            // 
            // PaperChoice_ToolStripMenuItem
            // 
            this.PaperChoice_ToolStripMenuItem.Name = "PaperChoice_ToolStripMenuItem";
            this.PaperChoice_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.PaperChoice_ToolStripMenuItem.Text = "용지설정";
            this.PaperChoice_ToolStripMenuItem.Click += new System.EventHandler(this.PaperChoice_ToolStripMenuItem_Click);
            // 
            // PrintStart_ToolStripMenuItem
            // 
            this.PrintStart_ToolStripMenuItem.Name = "PrintStart_ToolStripMenuItem";
            this.PrintStart_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.PrintStart_ToolStripMenuItem.Text = "프린트";
            this.PrintStart_ToolStripMenuItem.Click += new System.EventHandler(this.PrintStart_ToolStripMenuItem_Click);
            // 
            // Preview_ToolStripMenuItem
            // 
            this.Preview_ToolStripMenuItem.Name = "Preview_ToolStripMenuItem";
            this.Preview_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Preview_ToolStripMenuItem.Text = "미리보기";
            this.Preview_ToolStripMenuItem.Click += new System.EventHandler(this.Preview_ToolStripMenuItem_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 31);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(776, 407);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Print_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrinterChoice_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaperChoice_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintStart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Preview_ToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

