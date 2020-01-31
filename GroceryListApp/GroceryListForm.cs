using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GroceryListApp
{
    public partial class GroceryListForm : Form
    {
        SqlConnection connection;
        string connectionString;
        public GroceryListForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["GroceryListApp.Properties.Settings.GroceryListConnectionString"].ConnectionString;
        }

        private void GroceryListForm_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList() 
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM List", connection))
            {
                DataTable listTable = new DataTable();
                adapter.Fill(listTable);

                //the column in the table to display in the list
                listList.DisplayMember = "NAme";
                //the reference column for when we're using the data
                listList.ValueMember = "Id";
                listList.DataSource = listTable;
            }
        }

        private void listList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listList.SelectedValue.ToString());
        }
    }
}
