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
    public partial class User_Table_View : Form
    {
        private string currentTable;
        public User_Table_View(string tableName)
        {
            InitializeComponent();
            currentTable = tableName;
            this.Load += new System.EventHandler(this.User_Table_View_Load);
        }
        
        private void User_Table_View_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                 
                var datasource = @"(local)\SQLEXPRESS01"; var database = "Perfume_store";
                string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                textBox.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                dataGridView1.DataSource = dt;
                textBox.Text = "Retrieval Successful! : " + currentTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                textBox.Text = "Error, " + ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
