using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CMS
{
    public partial class flatlist_form : Form
    {
        public flatlist_form()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;
        public static int n;

        private void loaddatagrid()
        {
            string ss = " select flat_details.flat_no AS 'FLAT NUMBER', flat_details.area AS 'AREA (SFT)',  flat_details.flat_type AS 'FLAT TYPE', flat_details.car_park AS 'TOTAL CAR PARK', flat_details.status AS 'STATUS', flat_details.owner_name AS 'OWNER NAME', flat_details.owner_email AS 'E-MAIL',group_concat(owner_mobile.mobile_no separator ',') as 'MOBILE NUMBER'from owner_mobile inner join flat_details ON flat_details.flat_no=owner_mobile.flat_no group by owner_mobile.flat_no";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.DataSource = dt;
        }

        private void flatlist_form_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            radioButton1.Select();
            tb_search.Focus();
            n = dataGridView1.RowCount;


            // MySqlConnection connection = new MySqlConnection(MyConnectionString);
            // connection.Open();
            //try
            //{
            //    MySqlCommand cmd = ob.cmscon.CreateCommand();
            //    cmd.CommandText = " select flat_details.flat_no AS 'FLAT NUMBER', flat_details.area AS 'AREA (SFT)',  flat_details.flat_type AS 'FLAT TYPE', flat_details.car_park AS 'TOTAL CAR PARK',flat_details.owner_name AS 'OWNER NAME', flat_details.owner_email AS 'E-MAIL',group_concat(owner_mobile.mobile_no separator ', ') as 'MOBILE NUMBER'from owner_mobile inner join flat_details ON flat_details.flat_no=owner_mobile.flat_no group by owner_mobile.flat_no";
            //    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    adap.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //}
            //catch (Exception ex)
            //{
            //     MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (ob.cmscon.State == ConnectionState.Open)
            //    {
            //        ob.cmscon.Close();
            //    }
            //}
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_flatnum.Text = "";
            tb_status.Text = "";
            tb_type.Text = "";
            tb_carpark.Text = "";
            tb_ownername.Text = "";
            tb_owneremail.Text = "";
            tb_mobile.Text = "";
            tb_search.Text = "";
            tb_area.Text = "";
            dataGridView1.DataSource = dt;
            tb_search.Focus();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            sel_row = dataGridView1.CurrentCell.RowIndex;
            // int numRows = dataGridView1.Rows.Count;
            if (e.RowIndex == -1)
            {
                //MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }

            if (dataGridView1.Rows.Count > 0)
            {
                tb_flatnum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_area.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_type.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_carpark.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_status.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_ownername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_owneremail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adloginform frm = new adloginform();

            frm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tb_flatnum.Text = "";
            tb_status.Text = "";
            tb_type.Text = "";
            tb_carpark.Text = "";
            tb_ownername.Text = "";
            tb_owneremail.Text = "";
            tb_mobile.Text = "";
            tb_search.Text = "";
            tb_area.Text = "";
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (tb_flatnum.Text == "")
            {
                MessageBox.Show("SELECT THE FLAT TO BE UPDATED");
            }
            else
            {

                string s = "update flat_details set owner_name ='" + tb_ownername.Text + "', owner_email='" + tb_owneremail.Text + "' where flat_details.flat_no = '" + tb_flatnum.Text + "'";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();

                //string ss = "select flat_details.flat_no AS 'FLAT NUMBER', flat_details.area AS 'AREA (SFT)',  flat_details.flat_type AS 'FLAT TYPE', flat_details.car_park AS 'TOTAL CAR PARK',flat_details.status AS 'STATUS',flat_details.owner_name AS 'OWNER NAME', flat_details.owner_email AS 'E-MAIL',group_concat(owner_mobile.mobile_no separator ',') as 'MOBILE NUMBER'from owner_mobile inner join flat_details ON flat_details.flat_no=owner_mobile.flat_no group by owner_mobile.flat_no";
                //MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                //dt = new DataTable();
                //adap.Fill(dt);
                //dataGridView1.DataSource = dt;

                loaddatagrid();
                string str = tb_mobile.Text;
                char[] seperator = { ',' };
                string[] strlist = str.Split(seperator);
                string delq = "delete from owner_mobile where flat_no=" + tb_flatnum.Text;
                MySqlCommand cmd1 = new MySqlCommand(delq, ob.cmscon);
                cmd1.ExecuteNonQuery();

                if (tb_mobile.Text.Contains(','))
                {

                    foreach (string st in strlist)

                    {
                        // MessageBox.Show("count", st);
                        // string sss = "Update owner_mobile set mobile_no = '" + st + "' where flat_no = '" + tb_flatnum.Text + "' ";
                        string sss = "insert into owner_mobile set mobile_no = '" + st + "', flat_no= '" + tb_flatnum.Text + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sss, ob.cmscon);
                        cmd2.ExecuteNonQuery();
                    }

                }
                else
                {
                    string sss = "insert into owner_mobile set mobile_no = '" + tb_mobile.Text + "', flat_no= '" + tb_flatnum.Text + "'";
                    MySqlCommand cmd3 = new MySqlCommand(sss, ob.cmscon);
                    cmd3.ExecuteNonQuery();
                }
                loaddatagrid();
                MessageBox.Show(" FLAT DETAILS SUCCESSFULLY UPDATED");
            }
            // ob.cmscon.Close();

            dataGridView1.Rows[sel_row].Selected = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_carpark_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_flatnum.Text = "";
            tb_status.Text = "";
            tb_type.Text = "";
            tb_carpark.Text = "";
            tb_ownername.Text = "";
            tb_owneremail.Text = "";
            tb_mobile.Text = "";
            tb_search.Text = "";
            tb_area.Text = "";
            dataGridView1.DataSource = dt;
            tb_search.Focus();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([FLAT NUMBER],'System.String') Like '%{0}%'", tb_search.Text);
                    //"`FLAT NUMBER` like '%"+tb_search.Text+"%'";
                    dataGridView1.DataSource = dv;
                }
            }
            if (radioButton2.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {

                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([MOBILE NUMBER],'System.String') Like '%{0}%'", tb_search.Text);
                    //"`FLAT NUMBER` like '%"+tb_search.Text+"%'";
                    dataGridView1.DataSource = dv;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void tb_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sts = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                //string amt = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                if (sts == "Vacant")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    //dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                    //dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    // dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.DarkGreen;

                    //dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    // dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.PeachPuff;
                    dataGridView1.Rows[i].Cells[4].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }
    }
}
