using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class guardpage : Form
    {
        public guardpage()
        {
            InitializeComponent();
        }

      

        private void bt_maid_Click(object sender, EventArgs e)
        {
            maidentry_frm frm = new maidentry_frm();
            frm.Show();
        }

        private void bt_signout_Click(object sender, EventArgs e)
        {
            loginpage frm = new loginpage();
            this.Hide();
            frm.Show();

        }

        private void bt_dailyhelp_Click(object sender, EventArgs e)
        {
            servicevendor_entry frm = new servicevendor_entry();
            frm.Show();
        }

        private void bt_guest_Click(object sender, EventArgs e)
        {
            guest frm1 = new guest();
            frm1.Show();
        }

        private void bt_delivery_Click(object sender, EventArgs e)
        {
            deliv frm2 = new deliv();
            frm2.Show();
                
        }

        private void bt_taxi_Click(object sender, EventArgs e)
        {
            cabentry frm3 = new cabentry();
            frm3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guardpage_Load(object sender, EventArgs e)
        {

        }
    }
}

