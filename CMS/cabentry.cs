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
    public partial class cabentry : Form
    {
        public cabentry()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select cab.driver_name AS 'NAME',cab.flat_no as 'FLAT NO.',cab.cab_veh_no as 'VEHICLE NO.' from cab";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_searchflat.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([FLAT NO.],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (rb_searchvehicle.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([VEHICLE NO.],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }

            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_name.Text = "";
                tb_veh.Text = "";
                tb_flat.Text = "";
                loaddatagrid();
            }

        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_veh.Text = "";
            tb_flat.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            {
                
                
                    if (tb_name.Text == "")
                    {
                        MessageBox.Show("ENTER DRIVER NAME");
                        tb_name.Focus();
                        return;
                    }
                    if (tb_veh.Text == "")
                    {
                        MessageBox.Show("ENTER VEHICLE NO");
                        tb_veh.Focus();
                        return;
                    }
                    if (tb_flat.Text == "")
                    {
                        MessageBox.Show("ENTER FLAT NO");
                        tb_flat.Focus();
                        return;
                    }
                    else
                    {
                        string s = "Insert into cab (driver_name,cab_veh_no,flat_no) values ('" + tb_name.Text + "','" + tb_veh.Text + "','" + tb_flat.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                        cmd.ExecuteNonQuery();
                        loaddatagrid();
                        MessageBox.Show("CAB DETAILS SUCCESSFULLY ADDED");
                    }

                }
            }

        private void cabdeli_Load(object sender, EventArgs e)
        {
            rb_searchflat.Select();
            loaddatagrid();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void tb_flat_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no,status from flat_details where flat_no= '" + int.Parse(tb_flat.Text) + "'";
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_flat.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {

                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == ("Vacant"))
                    {
                        MessageBox.Show("THIS FLAT IS VACANT. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_flat.Text = "";
                        ob.cmscon.Close();
                        tb_flat.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_flat.Text = "";
                    ob.cmscon.Close();
                    tb_flat.Select();

                }

            }
            catch
            {
               tb_flat.CausesValidation = true;
            }
        }
    }
    }
    
