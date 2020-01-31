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
        string connectionString;
        public GroceryListForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["GroceryListApp.Properties.Settings.GroceryListConnectionString"].ConnectionString;
        }

        private void GroceryListForm_Load(object sender, EventArgs e)
        {
            

        }
    }
}
