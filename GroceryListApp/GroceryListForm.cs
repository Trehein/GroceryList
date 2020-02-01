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
            PopulateCart();

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
            string query = "INSERT INTO InCart (Id, Name, Type, Amount) SELECT Id, Name, Type, Amount FROM List WHERE Id = @ItemId";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemId", listList.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateCart();
        }

        private void RemoveFromList()
        {
            string query = "DELETE FROM List WHERE Id = @ItemId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemId", listList.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateList();
        }

        private void RemoveFromCart()
        {
            string query = "DELETE FROM InCart WHERE Id = @ItemId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemId", listCart.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateCart();
        }

        //fires whenever listList changes
        private void listList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(listList.SelectedValue.ToString());
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO List VALUES (@ItemName, @ItemType, @ItemAmount)";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                command.Parameters.AddWithValue("@ItemType", txtItemType.Text);
                command.Parameters.AddWithValue("@ItemAmount", txtItemAmount.Text);

                command.ExecuteNonQuery();
            }

            PopulateList();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            string query = "UPDATE List SET Name = @ItemName, Type = @ItemType, Amount = @ItemAmount WHERE Id = @ItemId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                command.Parameters.AddWithValue("@ItemType", txtItemType.Text);
                command.Parameters.AddWithValue("@ItemAmount", txtItemAmount.Text);
                command.Parameters.AddWithValue("@ItemId", listList.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateList();
        }

        private void btnRemoveListItem_Click(object sender, EventArgs e)
        {
            RemoveFromList();
        }

        private void btnRemoveCartItem_Click(object sender, EventArgs e)
        {
            RemoveFromCart();
        }
    }
}
