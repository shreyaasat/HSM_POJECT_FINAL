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
    public partial class noticeboard : Form
    {
        public noticeboard()
        {
            InitializeComponent();
        }

        Cms ob = new Cms();
        //DataTable dt;
       // string date;

        private void noticeboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtb_notice.Text == "")
                {
                    MessageBox.Show("NOTIFICATION TEXT IS EMPTY. ENTER DETAILS AND CLICK SAVE");
                    rtb_notice.Focus();
                    return;
                }
                DateTime dat = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", new CultureInfo("ja-JP"));
                string d3 = dat.ToString("yyyy-MM-dd");
                string s = "Insert into notice_tbl (date,announcement) values ('" + d3 + "','" + rtb_notice.Text + "')";
                MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" NOTIFICATION DETAILS SUCCESSFULLY POSTED");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
