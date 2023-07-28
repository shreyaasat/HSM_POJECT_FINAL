using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMS
{
    public partial class maintbill_form : Form
    {
        public maintbill_form()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;

        private void loaddatagrid()
        {
            string ss = "select maintenance_charge.flat_no as 'FLAT NO.', flat_details.owner_name as 'OWNER NAME', maintenance_charge.billing_date as 'BILL DATE',maintenance_charge.rate_per_sqft as 'RATE/SQFT (Rs.)', maintenance_charge.gst as 'GST (%)', maintenance_charge.total as 'AMOUNT', maintenance_charge.due_date as 'DUE DATE',maintenance_charge.status as 'STATUS' from maintenance_charge JOIN flat_details where maintenance_charge.flat_no=flat_details.flat_no && maintenance_charge.status = 'DUE'";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void generateid()
        {
            try
            {
                string ss = "Select bill_no from maintenance_charge order by bill_no desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    tb_generateid.Text = ds.Tables[0].Rows[0]["bill_no"].ToString();
                }

                else
                {
                //    tb_generateid.Text = "SG1000";
                tb_generateid.Text = "INV-" + DateTime.Now.ToString("MM/yyyy/") + 1000;

                }
                if (!string.IsNullOrEmpty(tb_generateid.Text))
                {
                    tb_generateid.SelectionStart = 12;
                    tb_generateid.SelectionLength = 4;
                    label9.Text = tb_generateid.SelectedText;
                }
                if (!string.IsNullOrEmpty(label9.Text))
                {
                    int id = int.Parse(label9.Text.ToString()) + 1;
                    tb_generateid.Text = "INV-" + DateTime.Now.ToString("MM/yyyy/") + id;
                }
            }
            catch (Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
           // int inv = 1000;
            if (tb_ratepersft.Text == "")
            {
                MessageBox.Show("ENTER VALUE FOR RATE/SFT");
                tb_ratepersft.Focus();
                return;
            }
            if (tb_gst.Text == "")
            {
                MessageBox.Show("ENTER VALUE FOR GST");
                tb_gst.Focus();
                return;
            }
            decimal rate = Convert.ToDecimal(tb_ratepersft.Text);
            decimal gst = Convert.ToInt32(tb_gst.Text);
            string message = "CAM  INVOICE WILL BE GENERATED FOR ALL FLATS";
            string title = "CAM INVOICE";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    string ss = "SELECT * FROM flat_details ";
                    MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                    dt = new DataTable();
                    adap.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var area1 = row["area"].ToString();
                        var flat_no = row["flat_no"].ToString();
                        decimal TotalAmount = (int.Parse(area1) * rate * gst / 100) + (int.Parse(area1) * rate);
                        TotalAmount = Math.Round(TotalAmount);
                        Console.WriteLine(TotalAmount);
                        //tb_generateid.Text = "INV-" + DateTime.Now.ToString("MM/yyyy/") + inv;
                        // inv = inv + 1;
                        generateid();

                        DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                        string d3 = dat.ToString("yyyy-MM-dd");
                        DateTime dat1 = DateTime.ParseExact(dateTimePicker2.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                        string d4 = dat.ToString("yyyy-MM-dd");
                        string sss = "insert into maintenance_charge (bill_no,flat_no,billing_date,due_date,rate_per_sqft,gst,total) values ('" + tb_generateid.Text + "','" + flat_no + "', '" + d3 + "','" + d4+ "','" + tb_ratepersft.Text + "','" + tb_gst.Text + "','" + TotalAmount + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                        cmd1.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ob.cmscon.Close();

                }
            }
            else
            {
                return;
            }

        }

        private void maintbill_form_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            generateid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_invoice_Click(object sender, EventArgs e)
        {
            invoicelist frm = new invoicelist();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string unit = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                if (unit == "DUE")
                {
                    dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Red;
                    dataGridView1.Rows[i].Cells[7].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    } 
}
