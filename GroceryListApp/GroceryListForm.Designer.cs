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
            ((System.ComponentModel.ISupportInitialize)(this.groceryListDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.lblList.Location = new System.Drawing.Point(217, 60);
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
            this.listList.Location = new System.Drawing.Point(220, 76);
            this.listList.Name = "listList";
            this.listList.Size = new System.Drawing.Size(120, 186);
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
            this.btnAddToCart.Location = new System.Drawing.Point(139, 157);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(674, 76);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(405, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(455, 78);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 8;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(455, 114);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(100, 20);
            this.txtItemType.TabIndex = 9;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(455, 150);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.Size = new System.Drawing.Size(100, 20);
            this.txtItemAmount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount";
            // 
            // GroceryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 454);
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
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

