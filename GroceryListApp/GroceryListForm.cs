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
                listList.DisplayMember = "Name";
                //the reference column for when we're using the data
                listList.ValueMember = "Id";
                listList.DataSource = listTable;
            }
        }

        private void PopulateCart()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM InCart", connection))
            {
                DataTable cartTable = new DataTable();
                adapter.Fill(cartTable);

                //the column in the table to display in the list
                listCart.DisplayMember = "Name";
                //the reference column for when we're using the data
                listCart.ValueMember = "Id";
                listCart.DataSource = cartTable;
            }
        }

        private void AddToCart()
        {
            string query = "";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

            }
        }

        private void RemoveFromList()
        {
            string query = "";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

            }
        }

        //fires whenever listList changes
        private void listList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(listList.SelectedValue.ToString());
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO List VALUES (@ItemName, @ItemType, @ItemAmount)";
            string query = "INSERT INTO List VALUES (@ItemName, 'dairy', '1 block')";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                //command.Parameters.AddWithValue("@ItemType", txtItemType.Text);
                //command.Parameters.AddWithValue("@ItemAmount", txtItemAmount.Text);

                

                command.ExecuteNonQuery();
            }
        }
    }
}
