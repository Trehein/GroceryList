using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryListApp
{
    public partial class GroceryListForm : Form
    {
        public GroceryListForm()
        {
            InitializeComponent();
        }

        private void listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryListDataSet);

        }

        private void GroceryListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryListDataSet.List' table. You can move, or remove it, as needed.
            this.listTableAdapter.Fill(this.groceryListDataSet.List);

        }
    }
}
