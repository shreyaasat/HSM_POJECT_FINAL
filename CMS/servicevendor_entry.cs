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

namespace CMS
{
    public partial class servicevendor_entry : Form
    {
        public servicevendor_entry()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        DataTable dt;

        private void dailyhelp_entry_Load(object sender, EventArgs e)
        {

        }

        private void bt_entry_Click(object sender, EventArgs e)
        {
            {
                if (tb_sv.Text == "")
                {
                    MessageBox.Show("ENTER SERVICE VENDOR ID");
                    tb_sv.Focus();
                    return;
                }
                else
                {

                    //DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                    //string d3 = dat.ToString("yyyy-MM-dd");

                    DateTime dat2 = DateTime.Now;
                    string d2 = dat2.ToString("yyyy-MM-dd");
                    string d3 = dat2.ToString("hh:mm:ss");
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from sv_entry where sv_id='" + tb_sv.Text + "' AND outtime is null AND date = '" + d2 + "'", ob.cmscon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("SERVICE VENDOR ENTRY ALREADY DONE");
                    }
                    else
                    {
                        try
                        {
                            DateTime dat1 = DateTime.Now;
                            string d4 = dat1.ToString("yyyy-MM-dd");
                            string d5 = dat1.ToString("hh:mm:ss");
                            string s = "Insert into sv_entry(sv_id,intime,date) values ('" + tb_sv.Text + "','" + d5 + "','" + d4 + "')";
                            MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("ENTRY DETAILS SUCCESSFULLY ADDED");
                        }
                        catch
                        {
                            MessageBox.Show("INCORRECT REGISTRATION ID");
                        }

                    }
                }
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {

            DateTime dat2 = DateTime.Now;
            string d2 = dat2.ToString("yyyy-MM-dd");
            string d3 = dat2.ToString("hh:mm:ss");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from sv_entry where sv_id='" + tb_sv.Text + "' AND outtime is null AND date = '" + d2 + "'", ob.cmscon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                string s = "update sv_entry set outtime = '" + d3 + "' where sv_id='" + tb_sv.Text + "' AND outtime is null";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);

                cmd.ExecuteNonQuery();
                MessageBox.Show("EXIT DETAILS SUCCESSFULLY ADDED");
            }
            else
            {
                MessageBox.Show("UPDATE FAILED. SERVICE VENDOR ENTRY NOT REGISTERED");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
