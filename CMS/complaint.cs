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
    public partial class complaint : Form
    {
        public complaint()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;
       public int offCount=0;
       public int offCount1=0;
       public static int n;



        private void loaddatagrid()
        {
            string sss = "select complaints.com_id AS 'COMPLAINT ID',complaints.c_date as 'DATE',complaints.flat_no as 'FLAT NO',complaints.category as 'CATEGORY',complaints.status as 'STATUS',complaints.com_desc as 'DESCRIPTION' from complaints";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //private void generateid()
        //{
        //    try
        //    {
        //        string ss = "Select com_id from complaints order by com_id desc";
        //        MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
        //        DataSet ds = new DataSet();
        //        adap.Fill(ds);


        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            tb_generateid.Text = ds.Tables[0].Rows[0]["com_id"].ToString();
        //        }

        //        else
        //        {
        //            tb_generateid.Text = "CO1000";

        //        }
        //        if (!string.IsNullOrEmpty(tb_generateid.Text))
        //        {
        //            tb_generateid.SelectionStart = 2;
        //            tb_generateid.SelectionLength = 4;
        //            label7.Text = tb_generateid.SelectedText;
        //        }
        //        if (!string.IsNullOrEmpty(label7.Text))
        //        {
        //            int id = int.Parse(label7.Text.ToString()) + 1;
        //            tb_compid.Text = "CO" + id.ToString("000");
        //        }
        //    }
        //    catch (Exception ab)
        //    {
        //        MessageBox.Show(ab.Message);
        //    }
        //}


        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        private void bt_register_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (tb_flatno.Text == "")
                {
                    MessageBox.Show("ENTER FLAT NUMBER");
                    tb_flatno.Focus();
                    return;
                }
                if (cb_category.SelectedIndex==-1)
                {
                    MessageBox.Show("SELECT COMPLAINT CATEGORY");
                    cb_category.Focus();
                    return;
                }

                else
                {
                    DateTime d1 = DateTime.Now;
                    DateTime dat = DateTime.ParseExact(d1.ToShortDateString(), "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d3 = dat.ToString("yyyy-MM-dd");
                    string s = "Insert into complaints (c_date,category,flat_no,com_desc,status) values ('" + d3 + "','" + cb_category.Text + "','" + tb_flatno.Text + "','" + rtb_desc.Text + "','ACTIVE')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" COMPLAINT SUCCESSFULLY REGISTERED");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_flatno.Text = "";
            cb_category.SelectedIndex = -1;
            tb_flatno.Select();
            tb_flatno.Focus();
            rtb_desc.Text = "";
            
           
        }
        private void complaint_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               // int offCount = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString() == "ACTIVE")
                    {
                        offCount++;
                    }
                }
               // int offCount1 = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString() == "PENDING")
                    {
                        offCount1++;
                    }
                }

            }
            n = offCount + offCount1;
          //  MessageBox.Show(n.ToString());
                
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            loaddatagrid();
            rb_flatnosearch.Select();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            if (tb_compid2.Text == "")
            {
                MessageBox.Show("SELECT THE COMPLAINT ID TO UPDATE");
            }

            else
            {
                try
                {
                    string s = "update complaints set status = '" + cb_status2.Text + "', com_desc='"+rtb_desc2.Text + "' where complaints.com_id = '" + tb_compid2.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    loaddatagrid();
                    MessageBox.Show(" COMPLAINT STATUS SUCCESSFULLY UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView1.Rows[sel_row].Selected = true;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_date.Text = "";
            tb_compid2.Text = "";
            tb_flatno2.Text = "";
            cb_status2.SelectedIndex = -1;
            rtb_desc2.Text="";
            tb_search.Focus();
            rb_flatnosearch.Select();
            loaddatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
            rb_flatnosearch.Select();
            //int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                //MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                tb_compid2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                tb_flatno2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cb_status2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtb_desc2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_flatnosearch.Checked)
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

                tb_compid2.Text = "";
                tb_flatno2.Text = "";
                cb_status2.SelectedIndex = -1;
                rtb_desc2.Text = "";
                rb_flatnosearch.Select();
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void rb_active_Click(object sender, EventArgs e)
        {
            tb_search.Text = "ACTIVE";
            if (tb_search.Text == "ACTIVE")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_compid2.Text = "";
                tb_flatno2.Text = "";
                cb_status2.SelectedIndex = -1;
                rtb_desc2.Text = "";
                rb_flatnosearch.Select();
                tb_search.Focus();
                loaddatagrid();

            }
        }

        private void rb_pending_Click(object sender, EventArgs e)
        {
            tb_search.Text = "PENDING";
            if (tb_search.Text == "PENDING")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                tb_compid2.Text = "";
                tb_flatno2.Text = "";
                cb_status2.SelectedIndex = -1;
                rtb_desc2.Text = "";
                rb_flatnosearch.Select();
                tb_search.Focus();
                loaddatagrid();

            }
        }

        private void rb_flatnosearch_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Enabled = true;
            tb_search.Focus();
            tb_compid2.Text = "";
            tb_flatno2.Text = "";
            cb_status2.SelectedIndex = -1;
            rtb_desc2.Text = "";
            rb_flatnosearch.Select();
            tb_search.Focus();
            loaddatagrid();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_flatno_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_pending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_compid2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_flatno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

