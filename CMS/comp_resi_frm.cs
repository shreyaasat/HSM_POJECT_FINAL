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
    public partial class comp_resi_frm : Form
    {
        public comp_resi_frm()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;

        private void loaddatagrid()
        {
            string sss = "select complaints.com_id AS 'COMPLAINT ID',complaints.c_date as 'DATE',complaints.category as 'CATEGORY',complaints.status as 'STATUS',complaints.com_desc as 'DESCRIPTION' from complaints where complaints.flat_no='"+resiloginform.flatnumb+"'";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comp_resi_frm_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_category.Text = "";
            tb_compid.Text = "";
            tb_date.Text = "";
            rtb_mycomp.Text = "";
            tb_status.Text = "";
            loaddatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
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
                tb_category.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_status.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                rtb_mycomp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                //tb_securityid.ReadOnly = true;
            }
        }

        private void rb_pending_Click(object sender, EventArgs e)
        {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", "PENDING");
                dataGridView1.DataSource = dv;
        }

        private void rb_active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_active_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", "ACTIVE");
            dataGridView1.DataSource = dv;
        }

        private void rb_closed_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", "CLOSED");
            dataGridView1.DataSource = dv;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
          
            cb_category.SelectedIndex = -1;
            rtb_newcomp.Text = "";
            cb_category.Focus();
            loaddatagrid();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cb_category.SelectedIndex == -1)
                {
                    MessageBox.Show("SELECT COMPLAINT CATEGORY");
                    cb_category.Focus();
                    return;
                }
                if (rtb_newcomp.Text == "")
                {
                    MessageBox.Show("ENTER COMPLAINT DESCRIPTION");
                    cb_category.Focus();
                    return;
                }


                else
                {
                    DateTime d1 = DateTime.Now;
                    DateTime dat = DateTime.ParseExact(d1.ToShortDateString(), "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d3 = dat.ToString("yyyy-MM-dd");
                    string s = "Insert into complaints (c_date,category,flat_no,com_desc,status) values ('" + d3 + "','"+cb_category.Text+"','" + resiloginform.flatnumb + "','" + rtb_newcomp.Text + "','ACTIVE')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();
                    // loaddatagrid();
                    MessageBox.Show(" COMPLAINT SUCCESSFULLY REGISTERED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
