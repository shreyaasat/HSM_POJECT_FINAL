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
    public partial class ser_vendor : Form
    {
        public ser_vendor()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select service_vendor.sp_id AS 'VENDOR ID',service_vendor.sp_name as 'NAME',service_vendor.sp_mobile as 'MOBILE',service_vendor.sp_type as 'CATEGORY' from service_vendor";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void generateid()
        {
            
            {
                int a;
                string ss = "Select sp_id from service_vendor order by sp_id desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    a = int.Parse(ds.Tables[0].Rows[0]["sp_id"].ToString());
                    a = a + 1;
                    tb_spid.Text = a.ToString();
                }

                else
                {
                    tb_spid.Text = "300001";

                }
            }
        }
    
        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_spname.Text == "")
                {
                    MessageBox.Show("ENTER SERVICE PROVIDER NAME");
                    tb_spname.Focus();
                    return;
                }
                if (tb_spmobile.Text == "")
                {
                    MessageBox.Show("ENTER MOBILE NUMBER");
                    tb_spmobile.Focus();
                    return;
                }
                if (cb_servicetype.Text == "")
                {
                    MessageBox.Show("SELECT SERVICE CATEGORY");
                    cb_servicetype.Focus();
                    return;
                }

                if (cb_servicetype.Text == "--SELECT--")
                {
                    MessageBox.Show("SELECT SERVICE CATEGORY");
                    cb_servicetype.Focus();
                    return;
                }
                else
                {
                    string s = "Insert into service_vendor (sp_id,sp_name,sp_mobile,sp_type) values ('" + tb_spid.Text + "','" + tb_spname.Text + "','" + tb_spmobile.Text + "','" + cb_servicetype.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                   
                    MessageBox.Show(" VENDOR DETAILS SUCCESSFULLY ADDED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ser_vendor_Load(object sender, EventArgs e)
        {
            rb_name.Select();
            loaddatagrid();
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_spname.Text = "";
            tb_spmobile.Text = "";
            cb_servicetype.SelectedIndex = -1;
            tb_spname.Select();
            generateid();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

            if (tb_spid.Text == "")
            {
                MessageBox.Show("SELECT THE VENDOR PROFILE TO DELETE");
            }
            else
            {
                try
                {
                    string s = "delete from service_vendor where service_vendor.sp_id = '" + tb_spid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    tb_search.Text = "";
                    tb_spname.Text = "";
                    tb_spmobile.Text = "";
                    tb_spid.Text = "";
                    cb_servicetype.SelectedIndex = -1;
                    tb_search.Select();
                    rb_name.Checked = true;
                    cb_servicetype.Text = "--SELECT--";
                    MessageBox.Show(" VENDOR DETAILS SUCCESSFULLY DELETED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
            rb_name.Select();
           // int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                tb_spid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_spname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_spmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cb_servicetype.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_spid.ReadOnly = true;
            }

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_spname.Text = "";
            tb_spmobile.Text = "";
            tb_spid.Text = "";
            cb_servicetype.SelectedIndex = -1;
            cb_servicetype.Text = "--SELECT--";
            tb_search.Select();
            rb_name.Checked=true;
            // dataGridView1.DataSource = dt;
            loaddatagrid();
        }



        private void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Select();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
                using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
                }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_name.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([NAME],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (rb_category.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([CATEGORY],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_spid.Text = "";
                tb_spmobile.Text = "";
                tb_spname.Text = "";
                cb_servicetype.SelectedIndex=-1;
                loaddatagrid();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_spid.Text == "")
            {
                MessageBox.Show("SELECT THE VENDOR PROFILE TO UPDATE");

            }
            if (cb_servicetype.Text == "--SELECT--")
            {
                MessageBox.Show("SELECT SERVICE CATEGORY");
                cb_servicetype.Focus();
                return;
            }
            else
            {
                try
                {
                    string s = "update service_vendor set sp_name = '" + tb_spname.Text + "', sp_mobile= '" + tb_spmobile.Text + "',sp_type='"+cb_servicetype.Text+"' where service_vendor.sp_id = '" + tb_spid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" VENDOR DETAILS SUCCESSFULLY UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;

        }

        private void tb_spmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "XXXXX XXXXX" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}
