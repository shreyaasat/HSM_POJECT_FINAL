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
    public partial class invoicelist1 : Form
    {
        public invoicelist1()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;
        public int offCount = 0;
        public int offCount1 = 0;
        public static int n;

        private void loaddatagrid()
        {
            String ss = "select maintenance_charge.flat_no as 'FLAT NO.', flat_details.owner_name as 'OWNER NAME',maintenance_charge.bill_no as 'BILL NUMBER', maintenance_charge.billing_date as 'BILL DATE', flat_details.area as 'AREA',maintenance_charge.rate_per_sqft as 'RATE/SFT (Rs.)', maintenance_charge.gst as 'GST(%)', maintenance_charge.total as 'AMOUNT', maintenance_charge.due_date as 'DUE DATE', maintenance_charge.status as 'STATUS' from maintenance_charge LEFT JOIN flat_details ON maintenance_charge.flat_no = flat_details.flat_no union select maintenance_charge.flat_no as 'FLAT NO.', flat_details.owner_name as 'OWNER NAME',maintenance_charge.bill_no as 'BILL NUMBER', maintenance_charge.billing_date as 'BILL DATE', flat_details.area as 'AREA',maintenance_charge.rate_per_sqft as 'RATE/SQFT (Rs.)', maintenance_charge.gst as 'GST (%)', maintenance_charge.total as 'AMOUNT', maintenance_charge.due_date as 'DUE DATE', maintenance_charge.status as 'STATUS' from maintenance_charge RIGHT JOIN flat_details ON maintenance_charge.flat_no = flat_details.flat_no";
            //string ss = "select maintenance_charge.flat_no as 'FLAT NO.', flat_details.owner_name as 'OWNER NAME',maintenance_charge.bill_no as 'BILL NUMBER', maintenance_charge.billing_date as 'BILL DATE', flat_details.area as 'AREA',maintenance_charge.rate_per_sqft as 'RATE/SQFT (Rs.)', maintenance_charge.gst as 'GST (%)', maintenance_charge.total as 'AMOUNT', maintenance_charge.due_date as 'DUE DATE',maintenance_charge.status as 'STATUS' from maintenance_charge FULL JOIN flat_details where maintenance_charge.flat_no=flat_details.flat_no group by maintenance_charge.flat_no";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            tb_amount.Text = "";
            tb_flatno.Text = "";
            tb_billno.Text = "";
            tb_area.Text = "";
            tb_billdate.Text = "";
            tb_duedate.Text = "";
            tb_gst.Text = "";
            tb_ownername.Text = "";
            tb_ratesft.Text = "";
            cb_status.SelectedIndex = -1;
        }

        private void invoicelist1_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            clear();
            tb_search.Text = "";
            rb_flatnosearch.Select();
            tb_search.Focus();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.Cells[i].Value.ToString() == "DUE")
                    {
                        offCount++;
                    }
                }
                // int offCount1 = 0;
                //for (int i = 0; i < dataGridView1.Columns.Count; i++)
                //{
                //    if (row.Cells[i].Value.ToString() == "PENDING")
                //    {
                //        offCount1++;
                //    }
                //}
            }
            n = offCount;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Close();
            adloginform frm = new adloginform();
            frm.Show();
        }

        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sts = Convert.ToString(dataGridView1.Rows[i].Cells[9].Value);
                //string amt = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                if (sts == "DUE")
                {

                    dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Red;
                    dataGridView1.Rows[i].Cells[9].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }

                else
                {
                    dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Green;
                    dataGridView1.Rows[i].Cells[9].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }

                dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Navy;
                dataGridView1.Rows[i].Cells[7].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rb_flatnosearch.Select();
            sel_row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows.Count > 0)
            {
                tb_flatno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_ownername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_billno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_billdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                tb_area.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_ratesft.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_gst.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_amount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                tb_duedate.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                cb_status.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
        }

        private void bt_refresh_Click_1(object sender, EventArgs e)
        {
            clear();
            tb_search.Text = "";
            tb_search.Focus();
            rb_flatnosearch.Select();
            loaddatagrid();
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
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
                tb_search.Focus();
                clear();
                loaddatagrid();
            }
        }

        private void rb_flatnosearch_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_search.Focus();
            tb_search.Text = "";
        }

        private void tb_search_Click_1(object sender, EventArgs e)
        {
            tb_search.Enabled = true;
            clear();
        }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void bt_update_Click_1(object sender, EventArgs e)
        {
            if (tb_flatno.Text == "")
            {
                MessageBox.Show("SELECT THE FLAT TO UPDATE BILL STATUS");
                return;
            }
            else
            {
                // DateTime dat = DateTime.ParseExact(tb_duedate.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                //string d3 = dat.ToString("yyyy-MM-dd");
                //MessageBox.Show(d3.ToString());
                string s = "update maintenance_charge set status ='" + cb_status.Text + "' where maintenance_charge.bill_no='" + tb_billno.Text + "' && maintenance_charge.flat_no = '" + tb_flatno.Text + "'";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();

                loaddatagrid();

                //string delc = "delete from car_tbl where res_id='" + tb_resid.Text + "';";
                //MySqlCommand cmd1 = new MySqlCommand(delc, ob.cmscon);
                //cmd1.ExecuteNonQuery();

            }

            MessageBox.Show("PAYMENT DETAILS SUCCESSFULLY UPDATED");

            dataGridView1.Rows[sel_row].Selected = true;
        }

        private void lb_amount_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
           // tb_search.Focus();
            tb_search.Text = "PAID";
            if (tb_search.Text == "PAID")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }
        

            if (tb_search.Text == "")
            {
                tb_search.Focus();
                clear();
                loaddatagrid();
             }
        }

        private void rb_due_Click(object sender, EventArgs e)
        {
            tb_search.Text = "DUE";
            if (tb_search.Text == "DUE")
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([STATUS],'System.String') Like '%{0}%'", tb_search.Text);
                dataGridView1.DataSource = dv;
            }
        }

        private void tb_billno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ownername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_billdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_duedate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_flatno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_area_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ratesft_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_gst_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_flatnosearch_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void lb_billno_Click(object sender, EventArgs e)
        {

        }

        private void lb_billdate_Click(object sender, EventArgs e)
        {

        }

        private void lb_duedate_Click(object sender, EventArgs e)
        {

        }

        private void lb_status_Click(object sender, EventArgs e)
        {

        }

        private void lb_flatno_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


