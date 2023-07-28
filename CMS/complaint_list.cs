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
    public partial class complaint_list : Form
    {
        public complaint_list()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select complaints.com_id AS 'COMPLAINT ID',complaints.c_date as 'DATE',complaints.flat_no as 'FLAT NO.',complaints.category as 'CATEGORY',complaints.status as 'STATUS',complaints.com_desc as 'DESCRIPTION' from complaints where complaints.c_date > current_date() - interval 60 day";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void complaint_list_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            rb_flatnosearch.Select();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_date.Text = "";
            tb_compid.Text = "";
            tb_flatno.Text = "";
            rtb_descrip.Text = "";
            tb_status.Text = "";
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
                tb_compid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                tb_flatno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_category.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_status.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtb_descrip.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    dv.RowFilter = string.Format("Convert([FLAT NO.],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }

            if (tb_search.Text == "")
            {

                tb_search.Text = "";
                tb_date.Text = "";
                tb_compid.Text = "";
                tb_flatno.Text = "";
                tb_category.Text = "";
                rtb_descrip.Text = "";
                tb_status.Text = "";
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
                tb_search.Text = "";
                tb_date.Text = "";
                tb_compid.Text = "";
                tb_flatno.Text = "";
                tb_category.Text = "";
                rtb_descrip.Text = "";
                tb_status.Text = "";
                rb_flatnosearch.Select();
                tb_search.Focus();
                loaddatagrid();

                }
        }

        private void rb_pending_CheckedChanged(object sender, EventArgs e)
        {

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
                tb_search.Text = "";
                tb_date.Text = "";
                tb_compid.Text = "";
                tb_flatno.Text = "";
                tb_category.Text = "";
                rtb_descrip.Text = "";
                tb_status.Text = "";
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
            tb_search.Text = "";
            tb_date.Text = "";
            tb_compid.Text = "";
            tb_category.Text = "";
            tb_flatno.Text = "";
            rtb_descrip.Text = "";
            tb_status.Text = "";
            rb_flatnosearch.Select();
            tb_search.Focus();
            loaddatagrid();
        }

        private void rb_closed_Click(object sender, EventArgs e)
        {
            tb_search.Text = "CLOSED";
            if (tb_search.Text == "CLOSED")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Text = "";
                tb_date.Text = "";
                tb_compid.Text = "";
                tb_category.Text = "";
                tb_flatno.Text = "";
                rtb_descrip.Text = "";
                tb_status.Text = "";
                rb_flatnosearch.Select();
                tb_search.Focus();
                loaddatagrid();

            }
        }
    }
}
