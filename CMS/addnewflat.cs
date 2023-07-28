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
using System.Net.Mail;


namespace CMS
{
    public partial class Frm_addflat : Form
    {
        public Frm_addflat()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        private bool nonNumberEntered = false;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            tb_flatnum.Focus();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
        
        
        
        
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (tb_flatnum.Text == "")
            {
                MessageBox.Show("Please Enter Flat number");
                tb_flatnum.Focus();
                return;
            }

            if (cb_area.Text == "")
            {
                MessageBox.Show("Please Select the area of the flat");
                cb_area.Focus();
                return;

            }
           

                if (cb_flattype.Text == "")
            {
                MessageBox.Show("Please select flat type.");
                cb_flattype.Focus();
                return;

            }
           
            if (cb_noofcarpark.Text == "")
            {
                MessageBox.Show("Please select the number of car parking slots alotted.");
                cb_noofcarpark.Focus();
                return;

            }

            if (tb_ownername.Text == "")
            {
                MessageBox.Show("Please enter owner name.");
                tb_ownername.Focus();
                return;
            }

            if (tb_owneremail.Text == "")
            {
                MessageBox.Show("Please enter owner E-mail.");
                tb_owneremail.Focus();
                return;
            }
            // if (dg_ownermobile.Text == "")
            //  {
            //      MessageBox.Show("Please enter owner mobile number.");
            //     dg_ownermobile.Focus();
            //      return;
            //  }


            try
            {
                string s = "Insert into flat_details (flat_no,flat_type,owner_name,car_park,area,owner_email) values ('" + tb_flatnum.Text + "','" + cb_flattype.Text + "','" + tb_ownername.Text + "','" + cb_noofcarpark.Text + "','" + cb_area.Text + "','" + tb_owneremail.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dg_ownermobile.Rows.Count-1; i++)

                {
                    //MessageBox.Show("no. of mobile numbers", dg_ownermobile.Rows.Count.ToString());
                    string sss = "Insert into owner_mobile (mobile_no,flat_no) values ( '"+dg_ownermobile.Rows[i].Cells[0].Value+"','" + tb_flatnum.Text + "')";
                    //MessageBox.Show("no. of mobile numbers", dg_ownermobile.ColumnCount.ToString());
                    MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                    cmd1.ExecuteNonQuery();
                    
                }

                MessageBox.Show(" FLAT DETAILS SUCCESSFULLY ADDED");
                tb_flatnum.Text = "";
                cb_area.SelectedIndex = -1;
                cb_flattype.SelectedIndex = -1;
                cb_noofcarpark.SelectedIndex = -1;
                tb_owneremail.Text = "";
                tb_ownername.Text = "";
                dg_ownermobile.Rows.Clear();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_flatnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_area_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void dg_ownermobile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_area_Validated(object sender, EventArgs e)
        {
            if (cb_flattype.Focus() && cb_area.Text == "625")
            {
                cb_flattype.Text = "1 BHK";
                cb_noofcarpark.Text = "1";
                tb_ownername.Focus();
            }
            
            if (cb_flattype.Focus() && cb_area.Text == "1250")
            {
                cb_flattype.Text = "2 BHK";
                cb_noofcarpark.Focus();
            }
            if (cb_flattype.Focus() && cb_area.Text == "1500")
            {
                cb_flattype.Text = "2.5 BHK";
                cb_noofcarpark.Focus();
            }
            if (cb_flattype.Focus() && cb_area.Text == "1750")
            {
                cb_flattype.Text = "3 BHK";
                cb_noofcarpark.Focus();
            }
            if (cb_area.Text == "1900")
            {
                cb_flattype.Text = "3 BHK + MAIDS ROOM";
                cb_noofcarpark.Focus();
            }
            if (cb_flattype.Focus() && cb_area.Text == "2500")
            {
                cb_flattype.Text = "4 BHK";
                cb_noofcarpark.Text = "2";
                tb_ownername.Focus();
            }
            if (cb_flattype.Focus() && cb_area.Text == "2850")
            {
                cb_flattype.Text = "4 BHK + MAIDS ROOM";
                cb_noofcarpark.Text = "2";
                tb_ownername.Focus();
            }

        }

        private void tb_flatnum_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select flat_no from flat_details where flat_no=" + int.Parse(tb_flatnum.Text);
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_flatnum.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {
                    MessageBox.Show("FLAT NUMBER ALREADY REGISTERED. PLEASE ENTER VALID FLAT NUMBER");
                    tb_flatnum.Text = "";
                    ob.cmscon.Close();
                    tb_flatnum.Select();
                    
                }

                
                else
                {
                    cb_area.Select();
                    ob.cmscon.Close();

                }

            }
            catch
            {
                tb_flatnum.CausesValidation = true;
            }
        }

        private void dg_ownermobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dg_ownermobile_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            {
                e.Control.KeyPress -= new KeyPressEventHandler(mobiledg_keypress);
                if (dg_ownermobile.CurrentCell.ColumnIndex == 0) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(mobiledg_keypress);
                    }
                }
            }
        }
        private void mobiledg_keypress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN "+"\"" + "##### #####" +"\""+ " FORMAT.","ERROR");
            }
        }

        private void tb_owneremail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tb_owneremail_Leave(object sender, EventArgs e)
        {
            
                var mail = tb_owneremail.Text;
                bool isValidEmail = mail.Contains("@") && mail.Contains(".");
                if (!isValidEmail)
                {
                   MessageBox.Show("PLEASE ENTER A VALID EMAIL");
                   return;
                }
            
        }
    }
 }


                                                              