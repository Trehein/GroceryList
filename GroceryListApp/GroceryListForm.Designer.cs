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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.listCart = new System.Windows.Forms.ListBox();
            this.listList = new System.Windows.Forms.ListBox();
            this.groceryListDataSet = new GroceryListApp.GroceryListDataSet();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnRemoveListItem = new System.Windows.Forms.Button();
            this.btnRemoveCartItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groceryListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Grocery List";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(15, 74);
            this.lblCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(49, 17);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "In Cart";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(321, 76);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(30, 17);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List";
            // 
            // listCart
            // 
            this.listCart.FormattingEnabled = true;
            this.listCart.ItemHeight = 16;
            this.listCart.Location = new System.Drawing.Point(17, 95);
            this.listCart.Margin = new System.Windows.Forms.Padding(4);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(193, 228);
            this.listCart.TabIndex = 3;
            // 
            // listList
            // 
            this.listList.FormattingEnabled = true;
            this.listList.ItemHeight = 16;
            this.listList.Location = new System.Drawing.Point(325, 96);
            this.listList.Margin = new System.Windows.Forms.Padding(4);
            this.listList.Name = "listList";
            this.listList.Size = new System.Drawing.Size(219, 228);
            this.listList.TabIndex = 4;
            this.listList.SelectedIndexChanged += new System.EventHandler(this.listList_SelectedIndexChanged);
            // 
            // groceryListDataSet
            // 
            this.groceryListDataSet.DataSetName = "GroceryListDataSet";
            this.groceryListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(217, 195);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 28);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(792, 94);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 28);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(585, 100);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(652, 96);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(132, 22);
            this.txtItemName.TabIndex = 8;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(652, 140);
            this.txtItemType.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(132, 22);
            this.txtItemType.TabIndex = 9;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(652, 185);
            this.txtItemAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.Size = new System.Drawing.Size(132, 22);
            this.txtItemAmount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount";
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(792, 140);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(186, 47);
            this.btnUpdateItem.TabIndex = 13;
            this.btnUpdateItem.Text = "Update Selected List Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnRemoveListItem
            // 
            this.btnRemoveListItem.Location = new System.Drawing.Point(324, 332);
            this.btnRemoveListItem.Name = "btnRemoveListItem";
            this.btnRemoveListItem.Size = new System.Drawing.Size(220, 23);
            this.btnRemoveListItem.TabIndex = 14;
            this.btnRemoveListItem.Text = "Remove Selected List Item";
            this.btnRemoveListItem.UseVisualStyleBackColor = true;
            this.btnRemoveListItem.Click += new System.EventHandler(this.btnRemoveListItem_Click);
            // 
            // btnRemoveCartItem
            // 
            this.btnRemoveCartItem.Location = new System.Drawing.Point(17, 330);
            this.btnRemoveCartItem.Name = "btnRemoveCartItem";
            this.btnRemoveCartItem.Size = new System.Drawing.Size(193, 23);
            this.btnRemoveCartItem.TabIndex = 15;
            this.btnRemoveCartItem.Text = "Remove Selected Cart Item";
            this.btnRemoveCartItem.UseVisualStyleBackColor = true;
            this.btnRemoveCartItem.Click += new System.EventHandler(this.btnRemoveCartItem_Click);
            // 
            // GroceryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 559);
            this.Controls.Add(this.btnRemoveCartItem);
            this.Controls.Add(this.btnRemoveListItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemAmount);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.listList);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnRemoveListItem;
        private System.Windows.Forms.Button btnRemoveCartItem;
    }
}

