namespace InventoryApplication
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddProduct = new Label();
            lblProduct = new Label();
            lblCategory = new Label();
            lblMDate = new Label();
            lblEDate = new Label();
            lblQty = new Label();
            lblSPrice = new Label();
            lblDescription = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lblAddProduct
            // 
            lblAddProduct.AutoSize = true;
            lblAddProduct.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddProduct.Location = new Point(12, 9);
            lblAddProduct.Name = "lblAddProduct";
            lblAddProduct.Size = new Size(159, 35);
            lblAddProduct.TabIndex = 0;
            lblAddProduct.Text = "Add Product";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(12, 71);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product";
            lblProduct.Click += lblProduct_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 119);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblMDate
            // 
            lblMDate.AutoSize = true;
            lblMDate.Location = new Point(12, 163);
            lblMDate.Name = "lblMDate";
            lblMDate.Size = new Size(75, 20);
            lblMDate.TabIndex = 3;
            lblMDate.Text = "Mfg. Date";
            // 
            // lblEDate
            // 
            lblEDate.AutoSize = true;
            lblEDate.Location = new Point(12, 204);
            lblEDate.Name = "lblEDate";
            lblEDate.Size = new Size(72, 20);
            lblEDate.TabIndex = 4;
            lblEDate.Text = "Exp. Date";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(12, 246);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(35, 20);
            lblQty.TabIndex = 5;
            lblQty.Text = "Qty.";
            // 
            // lblSPrice
            // 
            lblSPrice.AutoSize = true;
            lblSPrice.Location = new Point(12, 287);
            lblSPrice.Name = "lblSPrice";
            lblSPrice.Size = new Size(69, 20);
            lblSPrice.TabIndex = 6;
            lblSPrice.Text = "Sell Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(455, 71);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(124, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(257, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(124, 246);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(257, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(124, 287);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(257, 27);
            txtSellPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(124, 119);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(257, 28);
            cbCategory.TabIndex = 11;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(124, 163);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(257, 27);
            dtPickerMfgDate.TabIndex = 12;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(124, 204);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(257, 27);
            dtPickerExpDate.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(455, 119);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(310, 195);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(641, 320);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(124, 29);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 355);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersWidth = 51;
            gridViewProductList.Size = new Size(753, 188);
            gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 551);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(lblDescription);
            Controls.Add(lblSPrice);
            Controls.Add(lblQty);
            Controls.Add(lblEDate);
            Controls.Add(lblMDate);
            Controls.Add(lblCategory);
            Controls.Add(lblProduct);
            Controls.Add(lblAddProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddProduct";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddProduct;
        private Label lblProduct;
        private Label lblCategory;
        private Label lblMDate;
        private Label lblEDate;
        private Label lblQty;
        private Label lblSPrice;
        private Label lblDescription;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
    }
}
