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
    public partial class sp_list_view : Form
    {
        public sp_list_view()
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
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = dt;
        }

        private void sp_list_view_Load(object sender, EventArgs e)
        {
            rb_name.Select();
            loaddatagrid();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_search.Select();
            rb_name.Checked = true;
            loaddatagrid();
        }

        private void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Select();
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
            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
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
