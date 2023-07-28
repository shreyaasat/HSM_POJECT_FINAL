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
    public partial class mainstaff_frm : Form
    {
        public mainstaff_frm()
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
                string ss = "Select staff_id from maintenance_staff order by staff_id desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);

               // dg_staffmobile.RowCount = 2;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    tb_generateid.Text = ds.Tables[0].Rows[0]["staff_id"].ToString();
                }

                else
                {
                    tb_generateid.Text = "E1000";

                }
                if (!string.IsNullOrEmpty(tb_generateid.Text))
                {
                    tb_generateid.SelectionStart = 1;
                    tb_generateid.SelectionLength = 4;
                    label1.Text = tb_generateid.SelectedText;
                }
                if (!string.IsNullOrEmpty(label1.Text))
                {
                    int id = int.Parse(label1.Text.ToString()) + 1;
                    tb_staffid.Text = "E" + id.ToString("0000");
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }

        private void loaddatagrid()
        {
            string sss = "select maintenance_staff.staff_id AS 'STAFF ID', maintenance_staff.staff_name AS 'NAME',  maintenance_staff.category AS 'CATEGORY', group_concat(main_staff_con.staff_contact separator ',') as 'MOBILE NUMBER'from main_staff_con inner join maintenance_staff ON maintenance_staff.staff_id=main_staff_con.staff_id group by main_staff_con.staff_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mainstaff_frm_Load(object sender, EventArgs e)
        {
            rb_searchname.Select();
            dg_staffmobile.ClearSelection();
            loaddatagrid();
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_staffname.Text = "";
            //tb_staffmobile.Text = "";
            cb_category.SelectedIndex = -1;
            dg_staffmobile.Columns.Clear();
            tb_staffname.Select();
            dg_staffmobile.ColumnCount = 1;
            dg_staffmobile.Columns[0].Name = "Mobile Number";
            
            dg_staffmobile.RowCount = 2;
            dg_staffmobile.ClearSelection();
            // dg_staffmobile.Rows[0].Cells[0].
            ((DataGridViewTextBoxColumn)dg_staffmobile.Columns[0]).MaxInputLength = 11;

            generateid();
        }

        private void rb_searchname_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Select();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_generateid_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (tb_staffid.Text == "")
            {
                MessageBox.Show("CLICK 'ADD NEW' BUTTON TO GENERATE STAFF ID");
                tb_staffid.Focus();
                return;
            }

            if (tb_staffname.Text == "")
            {
                MessageBox.Show("ENTER STAFF NAME");
                tb_staffname.Focus();
                return;
            }

            if (cb_category.Text == "")
            {
                MessageBox.Show("SELECT STAFF CATEGORY");
                cb_category.Focus();
                return;
            }

            try
            {
                string s = "Insert into maintenance_staff (staff_name,staff_id,category) values ('" + tb_staffname.Text + "','" + tb_staffid.Text + "','" + cb_category.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dg_staffmobile.Rows.Count - 1; i++)
                {
                    string sss = "Insert into main_staff_con (staff_contact,staff_id) values ( '" + dg_staffmobile.Rows[i].Cells[0].Value + "','" + tb_staffid.Text + "')";
                    MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                    cmd1.ExecuteNonQuery();

                }

                MessageBox.Show(" STAFF DETAILS SUCCESSFULLY ADDED");
                loaddatagrid();
                //tb_staffid.Text = "";
                //tb_staffname.Text = "";
                //cb_category.SelectedIndex = -1;
                //dg_staffmobile.Rows.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            if (tb_staffid.Text == "")
            {
                MessageBox.Show("SELECT THE STAFF TO UPDATE");
            }
            else
            {

                string s = "update maintenance_staff set staff_name ='" +tb_staffname.Text + "', category='" + cb_category.Text + "' where maintenance_staff.staff_id = '" + tb_staffid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();
                loaddatagrid();

                string delc = "delete from main_staff_con where staff_id='" + tb_staffid.Text + "';";
                MySqlCommand cmd1 = new MySqlCommand(delc, ob.cmscon);
                cmd1.ExecuteNonQuery();
                if (dg_staffmobile.RowCount >1)
                {
                    for (int i = 0; i < dg_staffmobile.Rows.Count; i++)
                    {
                        if (string.IsNullOrEmpty(dg_staffmobile.Rows[i].Cells[0].Value as string))
                        {
                            loaddatagrid();
                        }
                        else
                        {
                            string sss = "Insert into main_staff_con (staff_contact,staff_id) values ( '" + dg_staffmobile.Rows[i].Cells[0].Value + "','" + tb_staffid.Text + "')";
                            MySqlCommand cmd2 = new MySqlCommand(sss, ob.cmscon);
                            cmd2.ExecuteNonQuery();
                            loaddatagrid();
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(dg_staffmobile.Rows[0].Cells[0].Value as string))

                    {
                        loaddatagrid();
                    }
                    else
                    {
                        string sss = "Insert into main_staff_con (staff_contact,staff_id) values ( '" + dg_staffmobile.Rows[0].Cells[0].Value + "','" + tb_staffid.Text + "')";
                        MySqlCommand cmd2 = new MySqlCommand(sss, ob.cmscon);
                        cmd2.ExecuteNonQuery();
                        loaddatagrid();
                    }
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_staffid.Text == "" || tb_staffname.Text=="")
            {
                MessageBox.Show("SELECT THE STAFF PROFILE TO DELETE");
            }
            else
            {

                try
                {
                    string s = "delete from maintenance_staff where maintenance_staff.staff_id = '" + tb_staffid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" STAFF DETAILS SUCCESSFULLY DELETED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_staffmobile.Columns.Clear();
            rb_searchname.Select();
            sel_row = dataGridView1.CurrentCell.RowIndex;
           // int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                tb_staffid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_staffname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_category.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Contains(','))
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    char[] seperator = { ',' };
                    string[] strlist = str.Split(seperator);
                    foreach (string st in strlist)

                    {
                        dg_staffmobile.ColumnCount = 1;
                        dg_staffmobile.Columns[0].Name = "Mobile Number";
                        dg_staffmobile.Rows.Add(st);
                        dg_staffmobile.ClearSelection();

                    }

                }
                else
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dg_staffmobile.ColumnCount = 1;
                    dg_staffmobile.Columns[0].Name = "Mobile Number";
                    dg_staffmobile.Rows.Add(str);
                    // dg_carno.RowCount = 2;
                    //dg_staffmobile.RowCount = 1;
                    dg_staffmobile.ClearSelection();
                }
                tb_staffid.ReadOnly = true;
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_staffname.Text = "";
            tb_staffid.Text = "";
            cb_category.SelectedIndex = -1;
            cb_category.Text = "--SELECT--";
            tb_search.Select();
            // dg_staffmobile.ClearSelection();
            dg_staffmobile.Columns.Clear();
            rb_searchname.Checked = true;
            loaddatagrid();
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
                tb_staffname.Text = "";
                tb_staffid.Text = "";
                cb_category.SelectedIndex = -1;
                cb_category.Text = "--SELECT--";
                tb_search.Select();
                dg_staffmobile.Columns.Clear();
                //dg_staffmobile.ClearSelection();
                rb_searchname.Checked = true;

                loaddatagrid();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dg_staffmobile_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            {
                e.Control.KeyPress -= new KeyPressEventHandler(mobiledg_keypress);
                if (dg_staffmobile.CurrentCell.ColumnIndex == 0) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(mobiledg_keypress);
                    }
                }
            }
        }

        private void mobiledg_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}
