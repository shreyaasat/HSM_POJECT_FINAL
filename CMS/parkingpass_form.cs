using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace CMS
{
    public partial class parkingpass_form : Form
        
    {
        PrintPreviewDialog ppvd = new PrintPreviewDialog();
        PrintDocument pd = new PrintDocument();

        public parkingpass_form()
        {
            InitializeComponent();
        }
       
        
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            ppvd.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            ppvd.ShowDialog();

        }
        public void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(mem, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        Bitmap mem;
        public void getprintarea(Panel pnl)
        {
            mem = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(mem, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void button1_Click(object sender, EventArgs e)

        {
            

        }

        private void parkingpass_form_Load(object sender, EventArgs e)
        {


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Print(Panel )
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adloginform frm = new adloginform();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
        
}
