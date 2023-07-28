using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //header file for database connection


namespace CMS // CMS is project name
{
    class Cms //Cms is the class name which we created
    {
        public MySqlConnection cmscon; //declare a varible cmscon for connection
        public Cms() // creates a constructor in the name Cms for cheching the connection. class name and constructor name should be identical. c# is case sensitive.
        {
            try
            {
                String str = "server=localhost;userid=root;pwd=shreyaa19;database=cmsdb";
                cmscon = new MySqlConnection(str);
                cmscon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


