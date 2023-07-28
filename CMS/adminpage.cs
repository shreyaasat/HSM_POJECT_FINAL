using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CMS
{
    public partial class adloginform : Form
    {
        public adloginform() => InitializeComponent();
        // Cms ob = new Cms();
        //lb_compnums.Text = complaint.n.ToString();
        public int count,count1;
        Cms ob = new Cms();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            //this.MaximizedBounds = Screen.GetWorkingArea(this);
            //this.WindowState = FormWindowState.Maximized;

            using (var cmdfd = new MySqlCommand(" select count(*) from flat_details", ob.cmscon))
            {
                int count = Convert.ToInt32(cmdfd.ExecuteScalar());
                lb_totflat1.Text = count.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from flat_details where status='Occupied'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_totresi1.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from maintenance_charge where status='Due'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lbcam1.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from complaints where status='ACTIVE' || status='PENDING'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_compnum1.Text = count1.ToString();
            }

            cb_dailyhelp.SelectedIndex = 0;
            cb_unit.SelectedIndex = 0;
            cb_resident.SelectedIndex = 0;
            cb_staff.SelectedIndex = 0;
            cb_cam.SelectedIndex = 0;
            cb_vehicle.SelectedIndex = 0;
            cb_complaint.SelectedIndex = 0;
            cb_notice.SelectedIndex = 0;
            //cb_vehicle.BackColor = Color.White;            
        }


        private void cb_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            Frm_addflat frm = new Frm_addflat();
            flatlist_form frm1 = new flatlist_form();
            var = this.cb_unit.GetItemText(this.cb_unit.Text);

            if (var == "ADD UNIT")
            {
                frm.Size = new Size(785, 500);
                frm1.Hide();
                frm.Show();
                cb_unit.SelectedIndex = 0;
            }

            if (var == "UNIT LIST")
            { 
              frm1.Size = new Size(785, 500);
              frm.Hide();
              frm1.Show();
              cb_unit.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginpage frm = new loginpage();
            frm.Show();

        }

        private void cb_resident_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            resi_list frm = new resi_list();
            Addresident frm1 = new Addresident();
            parkingpass_form frm2 = new parkingpass_form();
            vehicle frm3 = new vehicle();
                 
            frm.StartPosition = FormStartPosition.Manual;

            var = this.cb_resident.GetItemText(this.cb_resident.Text);
            
            if (var == "ADD RESIDENT")
            {
                frm1.Show();
                cb_resident.SelectedIndex = 0;
            }
            
            if (var == "RESIDENT LIST")
            {
                frm.Show();
                cb_resident.SelectedIndex = 0;
            }

            if (var == "GENERATE CAR PASS")
            {
                frm3.Show();
                cb_resident.SelectedIndex = 0;
            }
        }

        private void cb_dailyhelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            maidform frm = new maidform();
            ser_vendor frm1 = new ser_vendor();
            sec_form frm2 = new sec_form();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_dailyhelp.GetItemText(this.cb_dailyhelp.Text);
            if (var == "MAID DETAILS")
            {
                frm.Show();
                cb_dailyhelp.SelectedIndex = 0;
            }   


            if (var =="SERVICE VENDOR")
            {
                frm1.Show();
                cb_dailyhelp.SelectedIndex = 0;
            }

            if (var == "SECURITY GUARD")
            {
                frm2.Show();
                cb_dailyhelp.SelectedIndex = 0;
            }
        }

        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
           // comboBox4.Text = "DAILY HELP MANAGER";
        }

        private void cb_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            mainstaff_frm frm = new mainstaff_frm();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_staff.GetItemText(this.cb_staff.Text);

            if (var == "ADD STAFF")
            {
                frm.Show();
                cb_staff.SelectedIndex = 0;
            }
            if (var == "STAFF LIST")
            {
                frm.Show();
                cb_staff.SelectedIndex = 0;
            }
        }

        private void cb_utility_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            maintbill_form frm = new maintbill_form();
            invoicelist1 frm1 = new invoicelist1();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_cam.GetItemText(this.cb_cam.Text);

            if (var == "MAINTENANCE FEE")
            {
                frm.Show();
                cb_cam.SelectedIndex = 0;
            }

            if (var == "INVOICE LIST")
            {
                frm1.Show();
                cb_cam.SelectedIndex = 0;
            }
        }

        private void cb_complaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            complaint frm = new complaint();
            complaint_list frm1 = new complaint_list();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_complaint.GetItemText(this.cb_complaint.Text);

            if (var == "ADD COMPLAINT")
            {
                frm.Show();
                cb_complaint.SelectedIndex = 0;
            }
            if (var == "COMPLAINT LIST")
            {
               frm1.Show();
                cb_complaint.SelectedIndex = 0;
            }
        }

        private void cb_mc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            complaint frm = new complaint();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_complaint.GetItemText(this.cb_complaint.Text);

            if (var == "ADD COMPLAINT")
            {
                frm.Show();
                cb_complaint.SelectedIndex = 0;
            }
            
        }

        private void cb_notice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            noticeboard frm = new noticeboard();
            prev_posts frm1 = new prev_posts();
            frm.StartPosition = FormStartPosition.Manual;
            var = this.cb_notice.GetItemText(this.cb_notice.Text);

            if (var == "ADD NOTICE")
            {
                frm.Show();
                cb_notice.SelectedIndex = 0;
            }
            if (var == "PREVIOUS POSTS")
            {
                frm1.Show();
                cb_notice.SelectedIndex = 0;
            }
        }

        private void bt_covid_Click(object sender, EventArgs e)
        {
            covid_frm frmco = new covid_frm();
            frmco.Show();
        }

        private void adloginform_Activated(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var cmdfd = new MySqlCommand(" select count(*) from flat_details", ob.cmscon))
            {
                int count = Convert.ToInt32(cmdfd.ExecuteScalar());
                lb_totflat1.Text = count.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from flat_details where status='Occupied'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_totresi1.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from maintenance_charge where status='Due'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lbcam1.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("select count(*) from complaints where status='ACTIVE' || status='PENDING'", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_compnum1.Text = count1.ToString();
            }
        }
    }
}
