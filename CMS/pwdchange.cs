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
    public partial class pwdchange : Form
    {
        public pwdchange()
        {
            InitializeComponent();
        }
        Cms ob = new Cms();
        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (tb_newpwd.Text == "")
            {
                MessageBox.Show("ENTER NEW PASSWORD");
                return;

            }
            if (tb_confirmpwd.Text == "")
            {
                MessageBox.Show("CONFIRM NEW PASSWORD");
                return;

            }

            else
            {
                try
                {
                    if (tb_confirmpwd.Text == tb_newpwd.Text)
                    {
                        string s = " update logintbl_resi set password = '" + tb_confirmpwd.Text + "' where logintbl_resi.username = '" + loginpage.usn + "'";
                        // string s = "update service_vendor set sp_name = '" + tb_spname.Text + "', sp_mobile= '" + tb_spmobile.Text + "',sp_type='" + cb_servicetype.Text + "' where service_vendor.sp_id = '" + tb_spid.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(s, ob.cmscon);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" PASSWORD SUCCESSFULLY CHANGED");
                    }
                    else
                    {
                        MessageBox.Show("NEW AND CONFIRMATION PASSWORD DOESNT MATCH");
                        tb_newpwd.Text = "";
                        tb_confirmpwd.Text = "";
                        tb_newpwd.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_newpwd_Leave(object sender, EventArgs e)
        {
            string pwd = tb_newpwd.Text;
            bool isIntString = pwd.Any(char.IsDigit) && pwd.Length>=8;
            if (!isIntString)
            {
                MessageBox.Show(" PASSWORD MUST CONTAIN ATLEAST ONE DIGIT (0-9)\n AND MINIMUM 8 CHARACTERS");
                return;
            }
        }
    }
}
