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
using System.Security.Cryptography;


namespace CMS // CMS IS PROJECT NAME HERE
{ 
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        Cms ob = new Cms(); //object for the class cms
        public static string usn;
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

            private void button1_Click(object sender, EventArgs e)

        {

            string var, var1, var2;
            adloginform frm1 = new adloginform();
            guardpage frm2 = new guardpage();
            resiloginform frm3 = new resiloginform();

            var = comboBox1.GetItemText(comboBox1.SelectedItem);
            var1 = comboBox1.GetItemText (comboBox1.SelectedItem);
            var2 = comboBox1.GetItemText(comboBox1.SelectedItem);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter User name");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                textBox2.Focus();
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Select User Type");
                comboBox1.Focus();
                return;
            }
            //string salt = MD5Hash(textBox2.Text);
            //MessageBox.Show(salt);

                MySqlDataAdapter da = new MySqlDataAdapter("Select * from logintbl_guard where username='" + textBox1.Text + "' and usertype='" + comboBox1.Text + "' and binary password='"+textBox2.Text+"'", ob.cmscon);
                DataTable dt = new DataTable(); 
                MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from logintbl_resi where username='" + textBox1.Text + "' and usertype='" + comboBox1.Text + "' and binary password='" + textBox2.Text + "'", ob.cmscon);
                MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from logintbl_admin where username='" + textBox1.Text + "' and usertype='" + comboBox1.Text + "' and binary password='" + textBox2.Text + "'", ob.cmscon);
                da.Fill(dt);
                da1.Fill(dt);
                da2.Fill(dt);
                if (dt.Rows.Count > 0)
                { 

                if (dt.Rows.Count > 0 && comboBox1.Text == "Guard")
                    {
                        frm2.Show();
                        this.Hide();
                    }

                    if (dt.Rows.Count > 0 && comboBox1.Text == "Resident")
                    {
                      usn = textBox1.Text;
                      frm3.Show();
                      this.Hide();
                       
                    }

                    if (dt.Rows.Count > 0 && comboBox1.Text == "Admin")
                    {
                        frm1.Show();
                        this.Hide();
                    }
            }
            else
           
            { 
             MessageBox.Show("Invalid Username or Password");
            }
        }
            

        private void comboBox1_Enter(object sender, EventArgs e)

        {

            comboBox1.DroppedDown = true;

        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {

            comboBox1.DroppedDown = false;

        }

        private void loginform_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            comboBox1.Text = "--SELECT USER--";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    