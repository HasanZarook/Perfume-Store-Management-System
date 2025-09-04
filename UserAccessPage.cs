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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perfume_Store
{
    public partial class UserAccessPage : Form
    {
        public UserAccessPage()
        {
            InitializeComponent();
        }

        private void UserAccessPage_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("UserAccessPage_Load() called...");

            try
            {
              
                var datasource = @"(local)\SQLEXPRESS01";
                var database = "Perfume_store";
                var thisUsername = FrontPage.Username;
                var thisPassword = FrontPage.Password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                System.Diagnostics.Debug.WriteLine("Connection Successful on Startup");
                conn.Close();

            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string currentTable;
        private void button1_Click(object sender, EventArgs e)
        {
            currentTable = GetSelectedTableUser();
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                User_Table_View frm1 = new User_Table_View(currentTable);
                frm1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always close the connection, whether an exception occurred or not
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private string GetSelectedTableUser()
        {
            if (radBrands.Checked)
            {
                return "Brands";
            }
            else if (radPerfumes.Checked)
            {
                return "Perfumes";
            }
 
            else { return null; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                User_Order frm1 = new User_Order();
                frm1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always close the connection, whether an exception occurred or not
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
