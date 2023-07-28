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
    public partial class sec_form : Form
    {
        public sec_form()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void generateid()
        {
            try
            {
                string ss = "Select guard_id from guard_tbl order by guard_id desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    tb_generateid.Text = ds.Tables[0].Rows[0]["guard_id"].ToString();
                }

                else
                {
                    tb_generateid.Text = "SG1000";

                }
                if (!string.IsNullOrEmpty(tb_generateid.Text))
                {
                    tb_generateid.SelectionStart = 2;
                    tb_generateid.SelectionLength = 4;
                    label4.Text = tb_generateid.SelectedText;
                }
                if (!string.IsNullOrEmpty(label4.Text))
                {
                    int id = int.Parse(label4.Text.ToString()) + 1;
                    tb_securityid.Text = "SG" + id.ToString("000");
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }

        private void loaddatagrid()
        {
            string sss = "select guard_tbl.guard_id AS 'GUARD ID',guard_tbl.guard_name as 'NAME',guard_tbl.guard_contact as 'MOBILE' from guard_tbl";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void sec_form_Load(object sender, EventArgs e)
        {
            rb_search.Select();
            loaddatagrid();
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            //tb_securityid.Text = "";
            tb_mobile.Text = "";
            tb_search.Text = "";
            tb_name.Select();
            generateid();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_securityid.Text == "")
                {
                    MessageBox.Show("GUARD ID CANNOT BE EMPTY. CLICK ADD NEW AND ENTER GUARD DETAILS");
                    tb_securityid.Focus();
                    return;
                }
                if (tb_name.Text == "")
                {
                    MessageBox.Show("ENTER SECURITY GUARD NAME");
                    tb_name.Focus();
                    return;
                }
                if (tb_mobile.Text == "")
                {
                    MessageBox.Show("ENTER MOBILE NUMBER");
                    tb_mobile.Focus();
                    return;
                }
                
                else
                {
                    string s = "Insert into guard_tbl (guard_id,guard_name,guard_contact) values ('" + tb_securityid.Text + "','" + tb_name.Text + "','" + tb_mobile.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    String lg = "INSERT INTO  logintbl_guard (username) values ('" + tb_securityid.Text + "')";
                    MySqlCommand comnd = new MySqlCommand(lg, ob.cmscon);
                    comnd.ExecuteNonQuery();
                    MessageBox.Show(" GUARD DETAILS SUCCESSFULLY ADDED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
            rb_search.Select();
            //int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                tb_securityid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_securityid.ReadOnly = true;
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_name.Text = "";
            tb_securityid.Text = "";
            tb_mobile.Text = "";
            tb_name.Select();
            tb_search.Focus();
            rb_search.Select();
            loaddatagrid();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

            if (rb_search.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([NAME],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
           
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_name.Text = "";
                tb_securityid.Text = "";
                tb_mobile.Text = "";
                loaddatagrid();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_securityid.Text == "")
            {
                MessageBox.Show("SELECT THE GUARD PROFILE TO UPDATE");
            }
            
            else
            {
                try
                {
                    string s = "update guard_tbl set guard_name = '" + tb_name.Text + "', guard_contact= '" + tb_mobile.Text + "' where guard_tbl.guard_id = '" + tb_securityid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" GUARD DETAILS SUCCESSFULLY UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;
        }

        private void rb_search_CheckedChanged(object sender, EventArgs e)
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

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_securityid.Text == "")
            {
                MessageBox.Show("SELECT THE VENDOR PROFILE TO DELETE");
            }
            else
            {
                try
                {
                    string s = "delete from guard_tbl where guard_tbl.guard_id = '" + tb_securityid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    tb_search.Text = "";
                    tb_name.Text = "";
                    tb_mobile.Text = "";
                    tb_securityid.Text = "";
                    tb_search.Select();
                    rb_search.Checked = true;
                    MessageBox.Show(" SECURITY GUARD DETAILS SUCCESSFULLY DELETED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
