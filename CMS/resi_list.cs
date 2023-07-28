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
using System.Text.RegularExpressions;


namespace CMS
{
    public partial class resi_list : Form
    {
        public resi_list()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;
        public int sel_row;
        public static int n;

        private void loaddatagrid()
        {
            string ss = "select resident_tbl.res_id as 'RESIDENT ID', resident_tbl.flat_no as 'FLAT NUMBER', resident_tbl.res_name as 'NAME', resident_tbl.res_type as 'RESIDENT TYPE', resident_tbl.res_mobile as 'MOBILE NUMBER', resident_tbl.res_email as 'E-MAIL', resident_tbl.move_in as 'MOVE IN DATE',flat_details.car_park as 'TOTAL CAR PARK', group_concat(car_tbl.car_regino separator '/') as 'CAR NUMBER' from resident_tbl left outer JOIN car_tbl ON resident_tbl.res_id=car_tbl.res_id inner join flat_details ON flat_details.flat_no=resident_tbl.flat_no where resident_tbl.move_out IS null  group by resident_tbl.res_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.RowTemplate.Height = 35;
            //DataGridViewColumn column = dataGridView1.Columns[1];
            //column.Width = 75;
            //dataGridView1.Columns[1].Width = 75;
            //dataGridView1.Columns[3].Width = 75;
            //dataGridView1.Columns[4].Width = 75;
            dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            tb_email.Text = "";
            tb_flatno.Text = "";
            tb_mobile.Text = "";
            tb_movein.Text = "";
            tb_name.Text = "";
            tb_resid.Text = "";
            tb_totcarpark.Text = "";
            dg_carno.Columns.Clear();
            dg_carno.RowCount = 1;
            dg_carno.Columns[0].Name = "Registration Number";
            dg_carno.ClearSelection();
            cb_restype.SelectedIndex = -1;
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}


        private void resi_list_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            n = dataGridView1.RowCount;
            dg_carno.RowCount = 2;
            dg_carno.Columns[0].Name = "Registration Number";
            dg_carno.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft sans serif", 12);
            dg_carno.RowsDefaultCellStyle.Font = new Font("Microsoft sans serif", 11);
            
            clear();
            tb_search.Text = "";
            rb_flatno.Select();
            tb_search.Focus();
        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                //MessageBox.Show("DO NOT CLICK ON CELL HEADER");
                return;
            }
            dg_carno.Columns.Clear();
            rb_flatno.Select();
             sel_row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows.Count > 0)
            {
                tb_resid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_flatno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cb_restype.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_totcarpark.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                tb_movein.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

                if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString().Contains('/'))
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    char[] seperator = { '/' };
                    string[] strlist = str.Split(seperator);
                    foreach (string st in strlist)

                    {
                        dg_carno.ColumnCount = 1;
                        dg_carno.Columns[0].Name = "Registration Number";
                        dg_carno.Rows.Add(st);
                        dg_carno.ClearSelection();

                    }

                }
                else
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    dg_carno.ColumnCount = 1;
                    dg_carno.Columns[0].Name = "Registration Number";
                    dg_carno.Rows.Add(str);
                    // dg_carno.RowCount = 2;
                    dg_carno.RowCount = int.Parse(tb_totcarpark.Text);
                    dg_carno.ClearSelection();
                }
            }
        }

        private void rb_vehicleno_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adloginform frm = new adloginform();
            frm.Show();
        }
       
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            clear();
            tb_search.Text = "";
            tb_search.Focus();
            rb_flatno.Select();
            loaddatagrid();
        }
        

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_flatno.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([FLAT NUMBER],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (rb_resiname.Checked)
            {
                tb_search.Focus();
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([NAME],'System.String') Like '%{0}%'", tb_search.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            if (rb_vehicleno.Checked)
            {
                if (tb_search.Text != "")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = string.Format("Convert([CAR NUMBER],'System.String') Like '%{0}%'", tb_search.Text);
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

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_resid.Text == "")
            {
                MessageBox.Show("SELECT THE RESIDENT PROFILE TO BE UPDATED");
                return;
            }
            else
            {
                DateTime dat = DateTime.ParseExact(tb_movein.Text, "dd-MM-yyyy",new CultureInfo("ja-JP"));
                string d3= dat.ToString("yyyy-MM-dd");
                //MessageBox.Show(d3.ToString());
                string s = "update resident_tbl set res_name ='" + tb_name.Text + "', res_email='" + tb_email.Text + "', res_mobile='"+tb_mobile.Text+"',res_type='"+cb_restype.Text+"',move_in='"+d3+"' where resident_tbl.res_id = '" + tb_resid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();

                loaddatagrid();

                string delc = "delete from car_tbl where res_id='" + tb_resid.Text + "';";
                MySqlCommand cmd1 = new MySqlCommand(delc, ob.cmscon);
                cmd1.ExecuteNonQuery();

                if (dg_carno.RowCount == 2)
                {
                        for (int i = 0; i < dg_carno.Rows.Count; i++)
                        {
                            if (string.IsNullOrEmpty(dg_carno.Rows[i].Cells[0].Value as string))
                            {
                                loaddatagrid();
                           
                            }
                            else           
                            {
                                string sss = "Insert into car_tbl (car_regino,res_id) values ( '" + dg_carno.Rows[i].Cells[0].Value + "','" + tb_resid.Text + "')";
                                MySqlCommand cmd2 = new MySqlCommand(sss, ob.cmscon);
                                cmd2.ExecuteNonQuery();
                                loaddatagrid();
                            }
                        }
                    }

           
                else
                {
                    if (string.IsNullOrEmpty(dg_carno.Rows[0].Cells[0].Value as string))

                    {
                        loaddatagrid();
                    }
                    else
                    {
                        string sss = "Insert into car_tbl (car_regino,res_id) values ( '" + dg_carno.Rows[0].Cells[0].Value + "','" + tb_resid.Text + "')";
                        MySqlCommand cmd2 = new MySqlCommand(sss, ob.cmscon);
                        cmd2.ExecuteNonQuery();
                        loaddatagrid();
                    }
                }
            }
            MessageBox.Show("RESIDENT DETAILS SUCCESSFULLY UPDATED");

            dataGridView1.Rows[sel_row].Selected = true;
        }

        private void rb_flatno_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void rb_resiname_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Enabled=true;
            clear();
        }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void bt_deactivate_Click(object sender, EventArgs e)
        {
            if (tb_resid.Text == "")
            {
                MessageBox.Show("SELECT THE FLAT TO BE DEACTIVATED");
            }
            else
            {
                DateTime dat = DateTime.Now;

                string d1 = dat.ToString("yyyy-MM-dd");

               // MessageBox.Show(d1.ToString());
                string s = "update resident_tbl set move_out = '" + d1 + "' where resident_tbl.res_id = '" + tb_resid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();
                string ss = "update flat_details set status = 'Vacant' where flat_no=" + int.Parse(tb_flatno.Text);
                MySqlCommand cmd3 = new MySqlCommand(ss, ob.cmscon);
                cmd3.ExecuteNonQuery();
                loaddatagrid();
                MessageBox.Show("RESIDENT PROFILE DEACTIVATED SUCCESSFULLY");
                string sss = "delete from logintbl_resi where logintbl_resi.username = '" + tb_resid.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                cmd1.ExecuteNonQuery();

            }

        }

        private void dg_carno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }
    }
}
