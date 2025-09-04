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
    public partial class Admin_Add_Sales_Items : Form
    {
        public Admin_Add_Sales_Items()
        {
            InitializeComponent();
        }

        private void Admin_Add_Sales_Items_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Admin_Add_Sales_Items_Load() called...");

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
            command.CommandText = "insert into Sale_Items (sale_id,perfume_id,quantity,unit_price) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            command.ExecuteNonQuery();
            this.Close();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
