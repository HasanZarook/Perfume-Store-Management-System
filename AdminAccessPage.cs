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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Perfume_Store
{
    public partial class AdminAccessPage : Form
    {
        public AdminAccessPage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string currentTable;
        private void button1_Click(object sender, EventArgs e)
        {
             
            currentTable = GetSelectedTable();
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Table_View frm1 = new Admin_Table_View(currentTable);
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

        private string GetSelectedTable()
        {
            if (radBrands.Checked)
            {
                return "Brands";
            }
            else if (radPerfumes.Checked)
            {
                return "Perfumes";
            }
            else if (radCustomers.Checked)
            {
                return "Customers";
            }
            else if (radSales.Checked)
            {
                return "Sales";
            }

            else if (radOrders.Checked)
            {
                return "Orders";
            }

            else if (radOrderItems.Checked)
            {
                return "order_items";
            }

            else if (radSale_Items.Checked)
            {
                return "Sale_Items";
            }
            else { return null; }
        }
        private void AdminAccessPage_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AdminAccessPage_Load_Load() called...");
            
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
                Admin_Add_Brand frm1 = new Admin_Add_Brand();
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

        private void button3_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Perfumes frm1 = new Admin_Add_Perfumes();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Customers frm1 = new Admin_Add_Customers();
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

        private void button5_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Sales frm1 = new Admin_Add_Sales();
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

        private void button6_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Sales_Items frm1 = new Admin_Add_Sales_Items();
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

        private void button7_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Orders frm1 = new Admin_Add_Orders();
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

        private void button8_Click(object sender, EventArgs e)
        {
            var datasource = @"(local)\SQLEXPRESS01";
            var database = "Perfume_store";
            string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                // If you want to open a new form after a successful connection
                Admin_Add_Order_Items frm1 = new Admin_Add_Order_Items();
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

        private void radOrders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

