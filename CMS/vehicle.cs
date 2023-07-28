using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CMS
{
    public partial class vehicle : Form
    {
        public vehicle()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        DataTable dt;
        public int sele_row;
        // gen_carpass frm = new gen_carpass();
        

        private void loaddatagrid()
        {
            string ss = "select resident_tbl.res_id as 'RESIDENT ID', resident_tbl.flat_no as 'FLAT NUMBER', resident_tbl.res_name as 'NAME', resident_tbl.res_type as 'RESIDENT TYPE',flat_details.car_park as 'TOTAL CAR PARK', group_concat(car_tbl.car_regino separator ',') as 'CAR NUMBER' from resident_tbl left outer JOIN car_tbl ON resident_tbl.res_id=car_tbl.res_id inner join flat_details ON flat_details.flat_no=resident_tbl.flat_no where resident_tbl.move_out IS null  group by resident_tbl.res_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void vehicle_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            dg_carno.RowCount = 2;
            dg_carno.Columns[0].Name = "Registration Number";
            dg_carno.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft sans serif", 12);
            dg_carno.RowsDefaultCellStyle.Font = new Font("Microsoft sans serif", 11);
            dg_carno.ClearSelection();
            rb_flatno.Checked=true;
            tb_search.Select();
            ob.cmscon.Close();
            panel2.Hide();
            button1.Hide();
            button3.Hide();
            button2.Hide();

        }

 

        private void rb_flatno_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dg_carno.Columns.Clear();
           // rb_flatno.Select();
            sele_row = dataGridView1.CurrentCell.RowIndex;
            if (e.RowIndex == -1)
            {
                MessageBox.Show(" ClICK ON THE DATAGRID CELL TO SELECT A RECORD ");
                return;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                tb_flatno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_totalcarpark.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Contains(','))
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    char[] seperator = { ',' };
                    string[] strlist = str.Split(seperator);
                    foreach (string st in strlist)

                    {
                        dg_carno.ColumnCount = 1;
                        dg_carno.Columns[0].Name = "Registration Number";
                        //dg_carno.RowCount = int.Parse(tb_totalcarpark.Text);
                        dg_carno.Rows.Add(st);
                        //dg_carno.ClearSelection();

                    }

                }
                else
                {
                    string str = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dg_carno.Columns.Clear();
                    dg_carno.ColumnCount = 1;
                    dg_carno.Columns[0].Name = "Registration Number";
                    dg_carno.Rows.Add(str);
                    dg_carno.ClearSelection();
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_flatno.Text = "";
            dg_carno.Rows.Clear();
            dg_carno.ClearSelection();
            tb_search.Select();
            rb_flatno.Checked=true;
            loaddatagrid();
            ob.cmscon.Close();
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
           
            if (rb_carno.Checked)
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
                tb_flatno.Text = "";
                dg_carno.Rows.Clear();
                dg_carno.ClearSelection();
                tb_search.Select();
                rb_flatno.Checked = true;
                loaddatagrid();
                ob.cmscon.Close();
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Enabled = true;
            tb_search.Focus();
            tb_flatno.Text = "";
            dg_carno.Rows.Clear();
            dg_carno.ClearSelection();
            tb_search.Select();
            rb_flatno.Checked = true;
            loaddatagrid();
            ob.cmscon.Close();
        }

        private void bt_genpass_Click(object sender, EventArgs e)
        {
            //dg_carno_CellClick(sender,  e);
            if (tb_flatno.Text == "")
            {
                MessageBox.Show("FLAT NUMBER CANNOT BE EMPTY");
                return;
            }

            if (dg_carno.CurrentCell.Value == null)
            {
                MessageBox.Show("CAR DETAILS NOT REGISTERED");
                return;
            }
            
            
            else
            {
                vehicle frm5 = new vehicle();
                //frm5.Show();
                panel1.Hide();
                panel2.Visible = true;
                panel2.Show();
                button3.Show();
                button2.Show();
                button1.Show();
                frm5.BackColor = Color.Linen;
                lb_vehno.Text = dg_carno.CurrentCell.Value.ToString();
                lb_validity.Text = DateTime.Today.AddDays(365).ToString("dd-MM-yyyy");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle frm5 = new vehicle();
            panel1.Show();
            panel2.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            frm5.BackColor = Color.DarkSalmon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vehicle frm5 = new vehicle();
            panel1.Show();
            panel2.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            frm5.BackColor = Color.DarkSalmon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }

        //vehicle frm = new vehicle();
        PrintPreviewDialog ppvd = new PrintPreviewDialog();
        PrintDocument pd = new PrintDocument();
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel2 = pnl;
            getprintarea(pnl);
            ppvd.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            ppvd.ShowDialog();
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(mem, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.Y);
        }

        Bitmap mem;
        public void getprintarea(Panel pnl)
        {
            mem = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(mem, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void dg_carno_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    lb_vehno.Text = dg_carno.SelectedCells.ToString();
        //}

        //private void bt_genpass_Click(object sender, EventArgs e)
        //{
        //    frm.Show();
        //    this.Hide();
        //}
    }
}
