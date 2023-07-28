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
    public partial class maid_list_view : Form
    {
        public maid_list_view()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            //string sss = "select maid_tbl.maid_id AS 'MAID ID',maid_tbl.maid_name as 'NAME',maid_tbl.maid_mobile as 'MOBILE', group_concat(resident_tbl.flat_no) as 'WORKS IN' from(maid_tbl left join maidflat_tbl on maid_tbl.maid_id = maidflat_tbl.maid_id) left join(resident_tbl) on(maidflat_tbl.res_id = resident_tbl.res_id) group by maid_tbl.maid_id";
           // string sss = " select maid_tbl.maid_id as 'MAID ID',maid_tbl.maid_name as 'NAME',maid_tbl.maid_mobile as'MOBILE' ,maidentry_tbl.intime as 'IN TIME',maidentry_tbl.date,maidentry_tbl.outtime AS 'OUT TIME' FROM maid_tbl left join maidentry_tbl on maid_tbl.maid_id = maidentry_tbl.maid_id and maidentry_tbl.date = curdate()";
            string sss = " select maid_tbl.maid_id as 'MAID ID',maid_tbl.maid_name as 'NAME',maid_tbl.maid_mobile as 'MOBILE' ,maidentry_tbl.date as 'DATE',DATE_FORMAT(maidentry_tbl.intime, '%h : %i %p') as 'IN TIME', date_format(maidentry_tbl.outtime, '%I : %i %p') AS 'OUT TIME' FROM maid_tbl left join maidentry_tbl on maid_tbl.maid_id = maidentry_tbl.maid_id and maidentry_tbl.date = curdate()";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = dt;
        }
        private void maid_list_view_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            rb_searchname.Select();
            tb_search.Focus();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            //tb_search.Select();
            if (rb_searchname.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([NAME],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
                if (tb_search.Text == "")
                {
                    tb_search.Focus();
                    loaddatagrid();
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            loaddatagrid();
        }
    }
}
