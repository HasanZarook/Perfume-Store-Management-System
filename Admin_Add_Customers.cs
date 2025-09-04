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
    public partial class Admin_Add_Customers : Form
    {
        public Admin_Add_Customers()
        {
            InitializeComponent();
        }

        private void Admin_Add_Customers_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Admin_Add_Customers_Load() called...");

            try
            {
                var datasource = @"(local)\SQLEXPRESS01";
                var database = "Perfume_store";

                string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    System.Diagnostics.Debug.WriteLine("Connection Successful on Startup");
                    // You can add code here to perform any additional tasks after a successful connection.
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                // You may choose to log the error or handle it in another way.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(local)\\SQLEXPRESS01;Initial Catalog=Perfume_store;Integrated Security=True";

            connection.Open();

            command.Connection = connection;
            command.CommandText = "insert into Customers (first_name,last_name,email,phone_number,address) values('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox1.Text + "')";
            command.ExecuteNonQuery();
            this.Close();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
