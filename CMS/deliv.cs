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
    public partial class deliv : Form
    {
        public deliv()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select delivery.ag_name AS 'NAME',delivery.ag_contact as 'MOBILE',delivery.del_type as 'CATEGORY',delivery.flat_no as 'DELIVERING TO' from delivery";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_searchname.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([NAME],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (rb_searchflat.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([DELIVERING TO],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                cb_cat.SelectedIndex = -1;
                tb_name.Text = "";
                tb_mobile.Text = "";
                tb_delito.Text = "";
                loaddatagrid();
            }
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            cb_cat.SelectedIndex = -1;
            tb_name.Text = "";
            tb_mobile.Text = "";
            tb_delito.Text = "";

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            {
                if(cb_cat.SelectedIndex == -1)
                {
                    MessageBox.Show("SELECT DELIVERY CATEGORY");
                    cb_cat.Focus();
                    return;   
                }
                if(tb_name.Text == "")
                {
                    MessageBox.Show("ENTER AGENT NAME");
                    tb_name.Focus();
                    return;
                }
                if(tb_mobile.Text == "")
                {
                    MessageBox.Show("ENTER MOBILE NUMBER");
                    tb_mobile.Focus();
                    return;
                }
                if(tb_delito.Text == "")
                {
                    MessageBox.Show("ENTER FLAT NUMBER");
                    tb_delito.Focus();
                    return;
                }
                else
                {
                    string s = "Insert into delivery(del_type,ag_name,ag_contact,flat_no) values ('" + cb_cat.Text + "','" + tb_name.Text + "','" + tb_mobile.Text + "','" + tb_delito.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show("DELIVERY DETAILS SUCCESSFULLY ADDED");
                }
            }
        }

        private void deliv_Load(object sender, EventArgs e)
        {
            rb_searchflat.Select();
            loaddatagrid();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void tb_delito_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no,status from flat_details where flat_no= '" + int.Parse(tb_delito.Text) + "'";
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_delito.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {

                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == ("Vacant"))
                    {
                        MessageBox.Show("THIS FLAT IS VACANT. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_delito.Text = "";
                        ob.cmscon.Close();
                        tb_delito.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_delito.Text = "";
                    ob.cmscon.Close();
                    tb_delito.Select();

                }

            }
            catch
            {
                tb_delito.CausesValidation = true;
            }
        }

        private void tb_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}
