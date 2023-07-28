using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMS
{
    public partial class maidform : Form
    {
        public maidform()
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
                string ss = "Select maid_id from maid_tbl order by maid_id desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    tb_generateid.Text = ds.Tables[0].Rows[0]["maid_id"].ToString();
                }

                else
                {
                    tb_generateid.Text = "M1000";

                }
                if (!string.IsNullOrEmpty(tb_generateid.Text))
                {
                    tb_generateid.SelectionStart = 1;
                    tb_generateid.SelectionLength = 4;
                    label4.Text = tb_generateid.SelectedText;
                }
                if (!string.IsNullOrEmpty(label4.Text))
                {
                    int id = int.Parse(label4.Text.ToString()) + 1;
                    tb_maidid.Text = "M" + id.ToString("0000");
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }

        private void loaddatagrid()
        {
            string sss = "select maid_tbl.maid_id AS 'MAID ID',maid_tbl.maid_name as 'NAME',maid_tbl.maid_mobile as 'MOBILE', group_concat(resident_tbl.flat_no) as 'WORKS IN' from(maid_tbl left join maidflat_tbl on maid_tbl.maid_id = maidflat_tbl.maid_id) left join(resident_tbl) on(maidflat_tbl.res_id = resident_tbl.res_id) group by maid_tbl.maid_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Select();
        }

        private void maidform_Load(object sender, EventArgs e)
        {
           
            rb_searchname.Select();
            loaddatagrid();
        }

        private void bt_addnew_Click(object sender, EventArgs e)
        {

            tb_worksin.Text = "";
            tb_maidid.Text = "";
            tb_maidname.Text = "";
            tb_maidmob.Text = "";
            tb_search.Text = "";
            tb_maidname.Select();
            generateid();
        }


        private void bt_save_Click(object sender, EventArgs e)
        {

            try
            {

                if (tb_maidname.Text == "")
                {
                    MessageBox.Show("ENTER MAID NAME");
                    tb_maidname.Focus();
                    return;
                }
                if (tb_maidmob.Text == "")
                {
                    MessageBox.Show("ENTER MOBILE NUMBER");
                    tb_maidmob.Focus();
                    return;
                }
                if (tb_worksin.Text == "")
                {
                    MessageBox.Show("FLAT NUMBER CANNOT BE EMPTY");
                    tb_worksin.Focus();
                    return;
                }
                else
                {
                    string s = "Insert into maid_tbl (maid_id,maid_name,maid_mobile) values ('" + tb_maidid.Text + "','" + tb_maidname.Text + "','" + tb_maidmob.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);

                    string ss = " insert into maidflat_tbl values('" + tb_maidid.Text + "',(select resident_tbl.res_id from resident_tbl where resident_tbl.flat_no = '" + tb_worksin.Text + "'and resident_tbl.move_out is null))";
                    MySqlCommand cmd1 = new MySqlCommand(ss, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" MAID DETAILS SUCCESSFULLY ADDED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_worksin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_worksin_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no,status from flat_details where flat_no=" + int.Parse(tb_worksin.Text);
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_worksin.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {
                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == "Vacant")
                    {
                        MessageBox.Show("THIS FLAT IS VACANT. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_worksin.Text = "";
                        ob.cmscon.Close();
                        tb_worksin.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_worksin.Text = "";
                    ob.cmscon.Close();
                    tb_worksin.Select();

                }

            }
            catch
            {
                tb_worksin.CausesValidation = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
            int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            rb_searchname.Select();
            if (dataGridView1.Rows.Count > 0)
            {
                tb_maidid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_maidname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_maidmob.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_worksin.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_maidid.ReadOnly = true;
            }
        }


        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_maidid.Text = "";
            tb_maidmob.Text = "";
            tb_maidname.Text = "";
            tb_worksin.Text = "";

            tb_search.Focus();
            rb_searchname.Select();
            dataGridView1.DataSource = dt;
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
                    dv.RowFilter = string.Format("Convert([WORKS IN],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_maidid.Text = "";
                tb_maidmob.Text = "";
                tb_maidname.Text = "";
                tb_worksin.Text = "";
                loaddatagrid();
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_update_Click_1(object sender, EventArgs e)
        {
            if (tb_maidid.Text == "")
            {
                MessageBox.Show("SELECT THE MAID PROFILE TO UPDATE");
            }
            else
            {

                try
                {
                    string s = "update maid_tbl set maid_name = '" + tb_maidname.Text + "', maid_mobile= '" + tb_maidmob.Text + "' where maid_tbl.maid_id = '" + tb_maidid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();

                    string str = tb_worksin.Text;
                    char[] seperator = { ',' };
                    string[] strlist = str.Split(seperator);

                    string delc = "delete from maidflat_tbl where maid_id='" + tb_maidid.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(delc, ob.cmscon);
                    cmd2.ExecuteNonQuery();

                    if (tb_worksin.Text.Contains(','))
                    {

                        foreach (string st in strlist)

                        {
                            // MessageBox.Show("count", st);
                            // string sss = "Update owner_mobile set mobile_no = '" + st + "' where flat_no = '" + tb_flatnum.Text + "' ";
                            string sss = " insert into maidflat_tbl values('" + tb_maidid.Text + "',(select resident_tbl.res_id from resident_tbl where resident_tbl.flat_no = '" + st + "'and resident_tbl.move_out is null))";
                            MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                            cmd1.ExecuteNonQuery();
                            loaddatagrid();
                        }

                    }
                    else
                    {
                        string sss = " insert into maidflat_tbl values ('" + tb_maidid.Text + "', (select resident_tbl.res_id from resident_tbl where resident_tbl.flat_no = '" + tb_worksin.Text + "'and resident_tbl.move_out is null))";
                        MySqlCommand cmd3 = new MySqlCommand(sss, ob.cmscon);
                        cmd3.ExecuteNonQuery();
                        loaddatagrid();
                    }
                    MessageBox.Show(" MAID DETAILS SUCCESSFULLY UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;

        }

        

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

            if (tb_maidid.Text == "")
            {
                MessageBox.Show("SELECT THE MAID PROFILE TO DELETE");
            }
            else
            {

                try
                {
                    string s = "delete from maid_tbl where maid_tbl.maid_id = '" + tb_maidid.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" MAID DETAILS SUCCESSFULLY DELETED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_worksin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_worksin_Validated_1(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no,status from flat_details where flat_no= '"+ int.Parse(tb_worksin.Text)+"'";
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_worksin.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {
                   
                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == ("Vacant"))
                    {
                        MessageBox.Show("THIS FLAT IS VACANT. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_worksin.Text = "";
                        ob.cmscon.Close();
                        tb_worksin.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_worksin.Text = "";
                    ob.cmscon.Close();
                    tb_worksin.Select();

                }

            }
            catch
            {
                tb_worksin.CausesValidation = true;
            }
        }

        private void tb_maidmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}