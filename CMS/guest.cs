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
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select guest.g_name AS 'NAME',guest.flat_no as 'FLAT NO.',guest.g_veh_no as 'VEHICLE NO.',guest.g_contact as 'MOBILE' from guest";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guest_Load(object sender, EventArgs e)
        {
            rb_searchflat.Select();
            loaddatagrid();
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            tb_name1.Text = "";
            tb_flatno1.Text = "";
            tb_contact1.Text = "";
            tb_veh1.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            {
                if (tb_name1.Text == "")
                {
                    MessageBox.Show("ENTER GUEST NAME");
                    tb_name1.Focus();
                    return;
                }
                if (tb_contact1.Text == "")
                {
                    MessageBox.Show("ENTER MOBILE NUMBER");
                    tb_contact1.Focus();
                    return;
                }
                if (tb_veh1.Text == "")
                {
                    tb_veh1.Text = "Walk in";
                    tb_flatno1.Focus();
                    return;
                }
                if (tb_flatno1.Text == "")
                {
                    MessageBox.Show("ENTER FLAT NUMBER");
                    tb_flatno1.Focus();
                    return;
                }
                else
                {
                    string s = "Insert into guest (g_name,g_contact,g_veh_no,flat_no) values ('" + tb_name1.Text + "','" + tb_contact1.Text + "','" + tb_veh1.Text + "','" + tb_flatno1.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show("GUEST DETAILS SUCCESSFULLY ADDED");
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Focus();
            tb_name1.Text = "";
            tb_contact1.Text = "";
            tb_veh1.Text = "";
            tb_flatno1.Text = "";
            loaddatagrid();
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
                tb_name1.Text = "";
                tb_contact1.Text = "";
                tb_veh1.Text = "";
                tb_flatno1.Text = "";
                loaddatagrid();
            }
        }

        private void tb_flatno1_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no,status from flat_details where flat_no= '" + int.Parse(tb_flatno1.Text) + "'";
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_flatno1.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {

                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == ("Vacant"))
                    {
                        MessageBox.Show("THIS FLAT IS VACANT. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_flatno1.Text = "";
                        ob.cmscon.Close();
                        tb_flatno1.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_flatno1.Text = "";
                    ob.cmscon.Close();
                    tb_flatno1.Select();

                }

            }
            catch
            {
                tb_flatno1.CausesValidation = true;
            }
        }

        private void rb_searchflat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_contact1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}
       
       

