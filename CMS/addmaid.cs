using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Collections;

namespace CMS
{
    public partial class addmaid : Form
    {
        public addmaid()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;

        private void loaddatagrid()
        {
            string sss = "select maid_tbl.maid_id AS 'MAID ID',maid_tbl.maid_name as 'NAME',maid_tbl.maid_mobile as 'MOBILE', group_concat(resident_tbl.flat_no) as 'WORKS IN' from(maid_tbl left join maidflat_tbl on maid_tbl.maid_id = maidflat_tbl.maid_id) left join(resident_tbl) on(maidflat_tbl.res_id = resident_tbl.res_id) group by maid_tbl.maid_id";
            MySqlDataAdapter adap = new MySqlDataAdapter(sss, ob.cmscon);
            dt = new DataTable();
            dataGridView1.RowTemplate.Height = 40;
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            ob.cmscon.Close();
          
        }
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    

        private void addmaid_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            rb_searchname.Checked = true;
            tb_search.Focus();
            DataGridViewButtonColumn dcol = new DataGridViewButtonColumn();
            dcol.HeaderText = "ADD TO MY FLAT";
               
            dcol.Text = "Add";
            dcol.Name = "btn1";
            dcol.Width = 40;
            // dcol.CellTemplate.Style.BackColor = Color.AliceBlue;
            dcol.FlatStyle = FlatStyle.Popup;
            dcol.CellTemplate.Style.BackColor = Color.LightCyan;
            dcol.CellTemplate.Style.ForeColor = Color.Black;
            dcol.DefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            //dcol.DefaultCellStyle.BackColor = Color.;

            dcol.ReadOnly = true;
            
            dcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dcol);

            DataGridViewButtonColumn dcol2 = new DataGridViewButtonColumn();
            dcol2.HeaderText = "REMOVE FROM MY FLAT";

            dcol2.Text = "Remove";
            dcol2.Name = "btn2";
            dcol2.Width = 40;
            dcol2.ReadOnly = true;
            //dcol.DefaultCellStyle.BackColor = Color.Gainsboro;
            dcol2.FlatStyle = FlatStyle.Popup;
             dcol2.CellTemplate.Style.BackColor = Color.LightCyan;
            dcol2.CellTemplate.Style.ForeColor = Color.Black;
            dcol2.DefaultCellStyle.Font  = new Font("Tahoma", 11, FontStyle.Bold);
            dcol2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(dcol2);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string uname = loginpage.usn;
            // dataGridView1.Rows[e.RowIndex].Selected = true;
            dataGridView1.AutoGenerateColumns = false;
           // MessageBox.Show(e.ColumnIndex.ToString(), "Current Column index");
            int count1=0;
            int count = 0;
            ob.cmscon.Open();
            try
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string col1 = row.Cells[0].Value.ToString();
                    // MessageBox.Show(uname);
                    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Contains(','))
                    {
                        string str = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        char[] seperator = { ',' };
                        string[] strlist = str.Split(seperator);
                        foreach (string st in strlist)

                        {
                            resiloginform frm = new resiloginform();
                            if (st == resiloginform.flatnumb)
                            {
                                MessageBox.Show(" MAID ALREADY ADDED TO YOUR FLAT");
                                count1 = count1 + 1;
                                break;
                            }
                        }
                        
                    }


                    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == resiloginform.flatnumb)
                    {
                        MessageBox.Show(" MAID ALREADY ADDED TO YOUR FLAT");
                    }
                    else
                    {
                        if (count1 == 0)
                        {

                            string s1 = " insert into maidflat_tbl values('" + col1 + "','" + uname + "')";
                            MySqlCommand cmd1 = new MySqlCommand(s1, ob.cmscon);
                            cmd1.ExecuteNonQuery();
                            loaddatagrid();
                            MessageBox.Show(" MAID SUCCESSFULLY ADDED TO YOUR FLAT");
                        }
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string col2 = row.Cells[0].Value.ToString();
                    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Contains(','))
                    {
                        string str = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        char[] seperator = { ',' };
                        string[] strlist = str.Split(seperator);

                        foreach (string st in strlist)

                        {
                            resiloginform frm = new resiloginform();
                            if (st == resiloginform.flatnumb)
                            {
                                string s2 = "delete from maidflat_tbl where maid_id = '" + col2 + "' and res_id = '" + uname + "' ";
                                MySqlCommand cmd2 = new MySqlCommand(s2, ob.cmscon);
                                cmd2.ExecuteNonQuery();
                                loaddatagrid();
                                MessageBox.Show(" MAID SUCCESSFULLY REMOVED FROM YOUR FLAT");
                                count = count + 1;
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            MessageBox.Show(" MAID NOT WORKING IN YOUR FLAT ");
                        }
                    }
                    else
                    {

                        if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == resiloginform.flatnumb)
                        {
                            string s2 = "delete from maidflat_tbl where maid_id = '" + col2 + "' and res_id = '" + uname + "' ";
                            MySqlCommand cmd2 = new MySqlCommand(s2, ob.cmscon);
                            cmd2.ExecuteNonQuery();
                            loaddatagrid();
                            MessageBox.Show(" MAID SUCCESSFULLY REMOVED FROM YOUR FLAT");
                        }
                        else
                        {
                            if (count == 0)
                                MessageBox.Show(" MAID NOT WORKING IN YOUR FLAT ");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ob.cmscon.Dispose();

            }

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (rb_searchname.Checked)
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

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            tb_search.Focus();
            rb_searchname.Select();
            dataGridView1.DataSource = dt;
        }

        private void rb_searchname_CheckedChanged(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void rb_inside_Click(object sender, EventArgs e)
        {
            tb_search.Text = resiloginform.flatnumb;
            if (tb_search.Text == resiloginform.flatnumb)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Convert([WORKS IN],'System.String') Like '%{0}%'", tb_search.Text);
               dataGridView1.DataSource = dv;
            }


            if (tb_search.Text == "")
            {
                tb_search.Focus();
                loaddatagrid();
            }
        }
    }
}
