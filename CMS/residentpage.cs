using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace CMS
{
    public partial class resiloginform : Form
    {
        public resiloginform()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public static string flatnumb;


        //string unam = loginpage.usn;


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginpage frm = new loginpage();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void residentlogin_Load(object sender, EventArgs e)
        {
            //DateTime dat2 = DateTime.Now;
            //string d2 = dat2.ToString("yyyy-MM-dd");
            //string d3 = dat2.ToString("hh:mm:ss");
            ////MySqlDataAdapter da = new MySqlDataAdapter("select from maidentry_tbl where maid_id='" + tb_maidid.Text + "' AND outtime is null AND date = '" + d2 + "'", ob.cmscon);
            ////DataTable dt = new DataTable();
            ////da.Fill(dt);
            //MySqlDataAdapter da1 = new MySqlDataAdapter("select resident_tbl.flat_no from resident_tbl where flat_no==usn ",ob.cmscon);
            //// if (dt.Rows.Count > 0)
            //DataTable dt = new DataTable();
            //da1.Fill(dt);
            
            
            string uname = loginpage.usn;
            using (var cmdfd = new MySqlCommand("select resident_tbl.flat_no from resident_tbl where resident_tbl.res_id='"+uname+"' ", ob.cmscon))
            {
                string count = Convert.ToString(cmdfd.ExecuteScalar());
                tb_unitno.Text = count.ToString();
                flatnumb = tb_unitno.Text.ToString();
            }
            using (var cmdfd = new MySqlCommand("select resident_tbl.res_name from resident_tbl where resident_tbl.res_id='" + uname + "' ", ob.cmscon))
            {
                string count = Convert.ToString(cmdfd.ExecuteScalar());
                tbname.Text = count.ToString();
            }

            using (var cmdfd = new MySqlCommand("select maintenance_charge.total from maintenance_charge where maintenance_charge.flat_no='" + tb_unitno.Text + "'&& month(due_date) = month(curdate()) ", ob.cmscon))
            {
                string count = Convert.ToString(cmdfd.ExecuteScalar());
                tb_cam.Text ="Rs. "+count.ToString();
            }

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

            using (var cmdfd = new MySqlCommand("select maintenance_charge.due_date from maintenance_charge where maintenance_charge.flat_no='" + tb_unitno.Text + "'&& month(due_date) = month(curdate()) ", ob.cmscon))
            {
                DateTime count = Convert.ToDateTime(cmdfd.ExecuteScalar());
                // DateTime dat = DateTime.ParseExact(count, "dd-MM-yyyy", new CultureInfo("ja-JP"));
               // string date = DateTime.Now.ToString("dd/MM/yyyy");
                tb_duedate.Text = count.ToString("dd-MM-yyyy");
            }

            using (var cmdfd = new MySqlCommand("select maintenance_charge.status from maintenance_charge where maintenance_charge.flat_no='" + tb_unitno.Text + "' && month(due_date) = month(curdate()) ", ob.cmscon))
            {
                string count = Convert.ToString(cmdfd.ExecuteScalar());

                tb_status.Text = count.ToString();
            }

            if (tb_status.Text=="Due")
            {
                tb_status.BackColor = Color.OrangeRed;
            }
            else
            {
                tb_status.BackColor = Color.LightGreen;
            }

            // loaddatagrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_covid_Click(object sender, EventArgs e)
        {
            covidupdate frm = new covidupdate();
            frm.Show();
        }

        private void bt_residents_Click(object sender, EventArgs e)
        {
            resident_lst_view frm = new resident_lst_view();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            notice_view frm = new notice_view();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sp_list_view frm = new sp_list_view();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maid_list_view frm = new maid_list_view();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_unitno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addmaid frm = new addmaid();
            frm.Show();
        }

        private void bt_myprofile_Click(object sender, EventArgs e)
        {

        }

        private void bt_pwdchange_Click(object sender, EventArgs e)
        {
            pwdchange frm = new pwdchange();
            frm.Show();
        }

        private void bt_mycomplaint_Click(object sender, EventArgs e)
        {
            comp_resi_frm frm = new comp_resi_frm();
            frm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
