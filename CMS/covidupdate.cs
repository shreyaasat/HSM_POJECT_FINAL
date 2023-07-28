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
    public partial class covidupdate : Form
    {
        public covidupdate()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;
        private void loaddatagrid()
        {
            string sss = "select covid_tbl.flat_no AS 'FLAT NO.',covid_tbl.date_reported as 'DATE REPORTED',covid_tbl.no_of_cases as 'CASES', covid_tbl.homequarantine as 'H.Q.',covid_tbl.hospitalised as 'HOSPITALISED',covid_tbl.recovered as ' RECOVERED', covid_tbl.deceased as 'DECEASED' from covid_tbl";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void covidupdate_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            using (var cmdfd = new MySqlCommand(" SELECT SUM(no_of_cases) FROM covid_tbl", ob.cmscon))
            {
                int count = Convert.ToInt32(cmdfd.ExecuteScalar());
                lb_cases.Text = count.ToString();
            }
            using (var cmd = new MySqlCommand("SELECT SUM(homequarantine) FROM covid_tbl", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_hq.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("SELECT SUM(hospitalised) FROM covid_tbl", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_hospital.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("SELECT SUM(recovered) FROM covid_tbl", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_recovered.Text = count1.ToString();
            }
            using (var cmd = new MySqlCommand("SELECT SUM(deceased) FROM covid_tbl", ob.cmscon))
            {
                int count1 = Convert.ToInt32(cmd.ExecuteScalar());
                lb_deceased.Text = count1.ToString();
            }
            int x = Convert.ToInt32(lb_cases.Text);
            int y = Convert.ToInt32(lb_recovered.Text);
            int z = x - y;
            tb_activecases.Text = Convert.ToString(z);
        }

        private void lb_recovered_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
    
}
