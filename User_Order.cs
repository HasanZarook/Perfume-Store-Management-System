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
    public partial class User_Order : Form
    {
        public User_Order()
        {
            InitializeComponent();
        }

        private void User_Order_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("User_Order_Load() called...");

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int customerID;
            using (SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS01;Initial Catalog=Perfume_store;Integrated Security=True"))
            {
                
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Customers (first_name,last_name,email,phone_number,address) values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "'); SELECT SCOPE_IDENTITY(); ";
                    customerID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            int orderId;

            using (SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS01;Initial Catalog=Perfume_store;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Orders (customer_id, order_date) VALUES (@customerID, GETDATE()); SELECT SCOPE_IDENTITY();";
                    command.Parameters.AddWithValue("@customerID", customerID);
                    orderId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            using (SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS01;Initial Catalog=Perfume_store;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO order_items (order_id, perfume_id, quantity) VALUES (@orderId, '" + textBox2.Text + "','" + textBox3.Text + "')";
                    command.Parameters.AddWithValue("@orderId", orderId);
             
                    command.ExecuteNonQuery();
                    this.Close();
                    connection.Close();
                }
            }

            MessageBox.Show("Order Added successfully!\n Only Cash on delivery \nWe will contact you shortly \n THANK YOU ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
