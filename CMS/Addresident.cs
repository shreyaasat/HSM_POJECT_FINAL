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
using System.Globalization;

namespace CMS
{
    public partial class Addresident : Form
    {
        public Addresident()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        //DataTable dt;
             
        private void  generateid()
        {
            try
            {
                string ss = "Select res_id from resident_tbl order by res_id desc";
                MySqlDataAdapter adap = new MySqlDataAdapter(ss, ob.cmscon);
                DataSet ds = new DataSet();
                adap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    tb_generateid.Text = ds.Tables[0].Rows[0]["res_id"].ToString();

                }

                else
                {
                    tb_generateid.Text = "R1000";

                }        
                if (!string.IsNullOrEmpty(tb_generateid.Text))
                {
                    tb_generateid.SelectionStart = 1;
                    tb_generateid.SelectionLength = 4;
                    label1.Text = tb_generateid.SelectedText;
                }
                if (!string.IsNullOrEmpty(label1.Text))
                {
                   int id = int.Parse(label1.Text.ToString()) + 1;
                   // MessageBox.Show(id.ToString());
                   tb_resid.Text = "R" + id.ToString("0000");
                   

                }
            }
            catch(Exception ab)
            {
                MessageBox.Show(ab.Message);
            }
        }
        private void Addresident_Load(object sender, EventArgs e)
        {
            
            generateid();
            dateTimePicker1.Value = DateTime.Now;
           
            tb_flatno.Select();



               
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_flatno.Text == "")
                {
                    MessageBox.Show("ENTER THE FLAT NUMBER");
                }
                else
                {

                    DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    string d3 = dat.ToString("yyyy-MM-dd");
                    string s = "Insert into resident_tbl (res_id,flat_no,res_name,res_email,res_mobile,res_type,move_in) values ('" + tb_resid.Text + "','" + tb_flatno.Text + "','" + tb_resname.Text + "','" + tb_resemail.Text + "','" + tb_resmobile.Text + "','" + cb_restype.Text + "','" + d3 + "')";
                    MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                    cmd.ExecuteNonQuery();

                    String lg = "INSERT INTO  logintbl_resi (username) values ('" + tb_resid.Text + "')";
                    MySqlCommand comnd = new MySqlCommand(lg, ob.cmscon);
                    comnd.ExecuteNonQuery();


                    //dg_carnumber.RowCount = int.Parse(tb_carpark.Text);

                    for (int i = 0; i < dg_carnumber.Rows.Count; i++)
                       

                    {
                        // if (string.IsNullOrEmpty(dg_carnumber.Rows[i].Cells[0].Value as string))
                        MessageBox.Show(dg_carnumber.Rows.Count.ToString());
                        if (dg_carnumber.Rows[i].Cells[0].Value != null && dg_carnumber.Rows[i].Cells[0].Value != string.Empty)
                        {
                            string sss = "Insert into car_tbl (car_regino,res_id) values ( '" + dg_carnumber.Rows[i].Cells[0].Value + "','" + tb_resid.Text + "')";
                            MySqlCommand cmd1 = new MySqlCommand(sss, ob.cmscon);
                            MessageBox.Show("inside if statement");
                            cmd1.ExecuteNonQuery();
                        }

                    }

                    string ss = "update flat_details set status = 'Occupied' where flat_no=" + int.Parse(tb_flatno.Text);
                    MySqlCommand cmd3 = new MySqlCommand(ss, ob.cmscon);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show(" RESIDENT DETAILS SUCCESSFULLY ADDED");
                    tb_flatno.Text = "";
                    tb_resemail.Text = "";
                    tb_resid.Text = "";
                    tb_resname.Text = "";
                    tb_resmobile.Text = "";
                    cb_restype.SelectedIndex = -1;
                    cb_restype.Text = "--SELECT--";
                    tb_carpark.Text = "";
                    dg_carnumber.Rows.Clear();


                    generateid();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //System.Windows.Forms.Application.Exit();
            this.Close();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tb_flatno_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void tb_flatno_Validated(object sender, EventArgs e)
        {
            try
            {

                Cms ob = new Cms();
                string ss = "select car_park,status from flat_details where flat_no=" + int.Parse(tb_flatno.Text);
                MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                MySqlDataReader mdr;
                string input = tb_flatno.Text;
                mdr = cmd2.ExecuteReader();
                if (mdr.Read())

                {
                    tb_carpark.Text = mdr.GetInt32("car_park").ToString();
                    dg_carnumber.RowCount = int.Parse(tb_carpark.Text);
                    string str;
                    str = mdr.GetString("status");
                    //MessageBox.Show(str);
                    if (str == ("Occupied"))
                    {
                        MessageBox.Show("THIS FLAT IS ALREADY OCCUPIED. PLEASE ENTER CORRECT FLAT NUMBER.");
                        tb_flatno.Text = "";
                        tb_carpark.Text = "";
                        ob.cmscon.Close();
                        tb_flatno.Select();
                    }

                }
                else
                {
                    MessageBox.Show("FLAT NUMBER DOES NOT EXIST. PLEASE ENTER VALID FLAT NUMBER");
                    tb_flatno.Text = "";
                    tb_carpark.Text = "";
                    ob.cmscon.Close();
                    tb_flatno.Select();
                    
                }
               


            }
            catch
            {
                tb_flatno.CausesValidation = true;
            }
        }
            
        private void cb_restype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_restype.Text == "OWNER" || cb_restype.SelectedText == "OWNER")
                {

                    Cms ob = new Cms();
                    string ss = "select owner_name,owner_email from flat_details where flat_no=" + int.Parse(tb_flatno.Text);
                    MySqlCommand cmd2 = new MySqlCommand(ss, ob.cmscon);
                    MySqlDataReader mdr;
                    string input = tb_flatno.Text;
                    mdr = cmd2.ExecuteReader();
                    if (mdr.Read())

                    {
                        tb_resname.Text = mdr.GetString("owner_name").ToString();
                        tb_resemail.Text = mdr.GetString("owner_email").ToString();
                        //dg_carnumber.RowCount = int.Parse(tb_carpark.Text);

                        ob.cmscon.Close();
                        // tb_resmobile.Select();
                    }


                    else
                    {
                        ob.cmscon.Close();
                        tb_resname.Select();

                    }
                    //Cms ob1 = new Cms();
                    ob.cmscon.Open();
                    string ss1 = "select mobile_no from owner_mobile where flat_no=" + int.Parse(tb_flatno.Text);
                    MySqlCommand cmd3 = new MySqlCommand(ss1, ob.cmscon);
                    MySqlDataReader mdr1;
                    //  string input1 = tb_flatno.Text;
                    mdr1 = cmd3.ExecuteReader();
                    // MessageBox.Show("hdb");
                    while (mdr1.Read())

                    {
                        for (int i = 0; i < 1; i++)
                        {
                            // MessageBox.Show("hdb");
                            tb_resmobile.Text = mdr1.GetString("mobile_no").ToString();

                            dg_carnumber.Select();
                        }

                    }
                    ob.cmscon.Close();
                }
                else
                {
                    tb_resname.Text = "";
                    tb_resmobile.Text = "";
                    tb_resemail.Text = "";
                    cb_restype.CausesValidation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cb_restype.CausesValidation = true;
            }
        }

        private void tb_resmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ENTER NUMERIC DATA ONLY.\n\nENTER MOBILE IN " + "\"" + "##### #####" + "\"" + " FORMAT.", "ERROR");
            }
        }

        private void tb_resemail_Leave(object sender, EventArgs e)
        {
            var mail = tb_resemail.Text;
            bool isValidEmail = mail.Contains("@") && mail.Contains(".");
            if (!isValidEmail)
            {
                MessageBox.Show("PLEASE ENTER A VALID EMAIL");
                return;
            }
        }
    }
    
}
