using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        int i = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
             String.Format("Hello.net Page # {0}", i), new Font("Arial", 35),
             Brushes.Black, e.MarginBounds.Left,
                 e.MarginBounds.Top);

            if (i++ < 10)
                  e.HasMorePages = true;
            else
            {
                  e.HasMorePages = false;
                  i = 1;
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Print Start");
            MessageBox.Show("Print Start2");
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Print End");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Preview_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void PrinterChoice_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void PaperChoice_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void PrintStart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
