using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfume_Store
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }
        public static string Username = ""; public static string Password = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = txtUserID.Text;
            Password = txtPassword.Text;
            
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else if(Username == "User_Admin"|| Password == "User_Admin")
            {
                var datasource = @"(local)\SQLEXPRESS01";
                var database = "Perfume_store";
                var thisUsername = Username;
                var thisPassword = Password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + Username + ";Password=" + Password;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open(); 
                    AdminAccessPage frm2 = new AdminAccessPage();
                    frm2.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                var datasource = @"(local)\SQLEXPRESS01";
                var database = "Perfume_store";
                var thisUsername = Username;
                var thisPassword = Password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + Username + ";Password=" + Password;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();
                    UserAccessPage frm3 = new UserAccessPage();
                    frm3.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }
    }
}
