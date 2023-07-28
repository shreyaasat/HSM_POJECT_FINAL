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
    public partial class resident_lst_view : Form
    {
        public resident_lst_view()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string ss = "select flat_details.flat_no AS 'FLAT NO.', flat_details.owner_name AS 'OWNER NAME', flat_details.status as 'STATUS',group_concat(owner_mobile.mobile_no separator ', ') as 'OWNER MOBILE',resident_tbl.res_name AS 'RESIDENT NAME',resident_tbl.res_mobile as 'RESIDENT MOBILE', resident_tbl.res_type as 'RESIDENT TYPE' FROM flat_details LEFT JOIN resident_tbl ON flat_details.flat_no = resident_tbl.flat_no and  resident_tbl.move_out is null JOIN owner_mobile ON owner_mobile.flat_no = flat_details.flat_no group by owner_mobile.flat_no";
            //string ss = "select flat_details.flat_no as 'FLAT NO.', resident_tbl.res_name as 'NAME', resident_tbl.res_type as 'RESIDENT TYPE', resident_tbl.res_mobile as 'MOBILE NUMBER' from resident_tbl left join flat_details ON flat_details.flat_no=resident_tbl.flat_no where resident_tbl.move_out IS null  group by resident_tbl.res_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = dt;
            tb_search.Focus();

        }  
        private void resident_lst_view_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            rb_search.Checked = true;
            tb_search.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sts = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                //string amt = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                if (sts == "Vacant")
                {
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                    //dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    // dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.DarkGreen;

                    //dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.PeachPuff;
                    dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_search.Checked)
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
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void rb_search_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
            tb_search.Text = "";
        }

        private void rb_resiowner_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_resiowner_Click(object sender, EventArgs e)
        {
            tb_search.Text = "OWNER";
            if (tb_search.Text == tb_search.Text)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([RESIDENT TYPE],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void rb_nonresiowner_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Text = "OWNER";
            if (tb_search.Text == tb_search.Text)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([RESIDENT TYPE],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void rb_tenant_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Text = "TENANT";
            if (tb_search.Text == tb_search.Text)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([RESIDENT TYPE],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void rb_vacant_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Text = "Vacant";
            if (tb_search.Text == tb_search.Text)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            tb_search.Text ="";
            tb_search.Focus();
            rb_search.Select();
            loaddatagrid();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
