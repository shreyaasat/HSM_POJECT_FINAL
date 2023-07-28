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
using System.Globalization;

namespace CMS
{
    public partial class covid_frm : Form
    {
        public covid_frm()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select covid_tbl.flat_no AS 'FLAT NO',covid_tbl.date_reported as 'DATE REPORTED',covid_tbl.no_of_cases as 'NO. OF CASES',covid_tbl.homequarantine as 'HOME QUARANTINE',covid_tbl.hospitalised as 'HOSPITALISED',covid_tbl.recovered as 'RECOVERED',covid_tbl.deceased as 'DECEASED' from covid_tbl";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void covid_frm_Load(object sender, EventArgs e)
        {
            
            rb_searchflatno.Select();
            loaddatagrid();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_flatno.Text == "")
                {
                    MessageBox.Show("FLAT NUMBER CANNOT BE EMPTY");
                    tb_flatno.Focus();
                    return;
                }
                if (tb_cases.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES REPORTED");
                    tb_cases.Focus();
                    return;
                }
                if (tb_hq.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES HOME QUARANTINED - ENTER '0' IF NONE");
                    tb_hq.Focus();
                    return;
                }
                if (tb_hospital.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES HOSPITALISED - ENTER '0' IF NONE");
                    tb_hospital.Focus();
                    return;
                }
                if (tb_recovered.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES RECOVERED - ENTER '0' IF NONE");
                    tb_recovered.Focus();
                    return;
                }

                if (tb_deceased.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES DECEASED- ENTER '0' IF NONE");
                    tb_deceased.Focus();
                    return;
                }
                int tc = Convert.ToInt32(tb_cases.Text);
                int d = Convert.ToInt32(tb_deceased.Text);
                int h = Convert.ToInt32(tb_hospital.Text);
                int r = Convert.ToInt32(tb_recovered.Text);
                int hq = Convert.ToInt32(tb_hq.Text);
                if (tc == d + h + r + hq)
                {
                    DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d3 = dat.ToString("yyyy-MM-dd");
                    string s = "Insert into covid_tbl (flat_no,date_reported,no_of_cases,homequarantine,hospitalised,recovered,deceased) values ('" + tb_flatno.Text + "','" + d3 + "','" + tb_cases.Text + "','" + tb_hq.Text + "','" + tb_hospital.Text + "','" + tb_recovered.Text + "','" + tb_deceased.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();

                    MessageBox.Show(" COVID DETAILS SUCCESSFULLY SAVED");
                }
                else
                {
                    MessageBox.Show("PLEASE CHECK THE VALUES ENTERED");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("PLEASE CLICK UPDATE BUTTON TO ADD CASES TO THE FLAT");
            }


        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            //tb_search.Select();
            if (rb_searchflatno.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([FLAT NO],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_search.Text = "";
                tb_cases.Text = "";
                tb_deceased.Text = "";
                tb_flatno.Text = "";
                tb_hospital.Text = "";
                tb_hq.Text = "";
                tb_recovered.Text = "";
                rb_searchflatno.Select();
                loaddatagrid();
            }
        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            sel_row = dataGridView1.CurrentCell.RowIndex;
            int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
               // MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                this.dataGridView1.Columns["FLAT NO"].SortMode = DataGridViewColumnSortMode.Automatic;
                return;
            }
            rb_searchflatno.Select();
            if (dataGridView1.Rows.Count > 0)
            {
                tb_flatno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_cases.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_hq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_hospital.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_recovered.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_deceased.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_flatno.ReadOnly = true;
                 
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_cases.Text = "";
            tb_deceased.Text = "";
            tb_flatno.ReadOnly = false;
            tb_flatno.Text = "";
            tb_hospital.Text = "";
            tb_hq.Text = "";
            tb_recovered.Text = "";
            tb_search.Focus();
            dateTimePicker1.Value = DateTime.Today;
            rb_searchflatno.Select();
            // dataGridView1.DataSource = dt;
            loaddatagrid();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            if (tb_flatno.Text == "")
            {
                MessageBox.Show("SELECT THE FLAT TO UPDATE COVID DETAILS");
            }
            else
            {
                if (tb_cases.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES REPORTED");
                    tb_cases.Focus();
                    return;
                }
                if (tb_hq.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES HOME QUARANTINED - ENTER '0' IF NONE");
                    tb_hq.Focus();
                    return;
                }
                if (tb_hospital.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES HOSPITALISED - ENTER '0' IF NONE");
                    tb_hospital.Focus();
                    return;
                }
                if (tb_recovered.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES RECOVERED - ENTER '0' IF NONE");
                    tb_recovered.Focus();
                    return;
                }

                if (tb_deceased.Text == "")
                {
                    MessageBox.Show("ENTER THE NUMBER OF CASES DECEASED- ENTER '0' IF NONE");
                    tb_deceased.Focus();
                    return;
                }
                int tc = Convert.ToInt32(tb_cases.Text);
                int d = Convert.ToInt32(tb_deceased.Text);
                int h = Convert.ToInt32(tb_hospital.Text);
                int r = Convert.ToInt32(tb_recovered.Text);
                int hq = Convert.ToInt32(tb_hq.Text);
                if (tc == d + h + r + hq)

                {   
                
                    DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d4 = dat.ToString("yyyy-MM-dd");

                    string s = "update covid_tbl set no_of_cases = '" + tb_cases.Text + "', homequarantine = '" + tb_hq.Text + "', hospitalised='"+ tb_hospital.Text +"',recovered='"+tb_recovered.Text+"',deceased = '"+tb_deceased.Text+"' where flat_no = '" + tb_flatno.Text + "' && date_reported = '"+d4+"'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();

                    //string delc = "delete from maidflat_tbl where maid_id='" + tb_maidid.Text + "'";
                    //MySqlCommand cmd2 = new MySqlCommand(delc, ob.cmscon);
                    //cmd2.ExecuteNonQuery();

                    
                    MessageBox.Show(" COVID DETAILS SUCCESSFULLY UPDATED");
                }
                else
                {
                    MessageBox.Show("PLEASE CHECK THE VALUES");
                    return;
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_flatno.Text == "")
            {
                MessageBox.Show("PLEASE SELECT THE FLAT NO. TO DELETE");
                return;
            }
            else
            {
                string message = "ARE YOU SURE YOU WANT TO DELETE";
                string title = "ALERT MESSAGE";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                // DialogResult result= MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    {
                    DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d4 = dat.ToString("yyyy-MM-dd");
                    string s = "delete from covid_tbl where flat_no = '" + tb_flatno.Text + "' && date_reported = '" + d4 + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show("DELETED SUCCESSFULLY");
                    }
                    else if (result == DialogResult.No)
                    {
                    return;
                    }
                
            }
        }

        private void rb_searchflatno_CheckedChanged(object sender, EventArgs e)
        {

        }
    }   
}
