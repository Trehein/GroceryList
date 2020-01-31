namespace GroceryListApp
{
    partial class GroceryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groceryListDataSet = new GroceryListApp.GroceryListDataSet();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.listCart = new System.Windows.Forms.ListBox();
            this.listList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.groceryListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groceryListDataSet
            // 
            this.groceryListDataSet.DataSetName = "GroceryListDataSet";
            this.groceryListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Grocery List";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(11, 60);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(38, 13);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "In Cart";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(269, 60);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(23, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List";
            // 
            // listCart
            // 
            this.listCart.FormattingEnabled = true;
            this.listCart.Location = new System.Drawing.Point(13, 77);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(120, 186);
            this.listCart.TabIndex = 3;
            // 
            // listList
            // 
            this.listList.FormattingEnabled = true;
            this.listList.Location = new System.Drawing.Point(272, 77);
            this.listList.Name = "listList";
            this.listList.Size = new System.Drawing.Size(120, 186);
            this.listList.TabIndex = 4;
            this.listList.SelectedIndexChanged += new System.EventHandler(this.listList_SelectedIndexChanged);
            // 
            // GroceryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 454);
            this.Controls.Add(this.listList);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GroceryListForm";
            this.Text = "GroceryList";
            this.Load += new System.EventHandler(this.GroceryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groceryListDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroceryListDataSet groceryListDataSet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox listCart;
        private System.Windows.Forms.ListBox listList;
    }
}

