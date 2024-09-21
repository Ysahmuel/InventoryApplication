using System;
using System.Text.RegularExpressions;

namespace InventoryApplication
{
    public partial class frmAddProduct : Form
    {
        private BindingSource showProductList;
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
        }
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
            {
        "Beverages",
        "Bread/Bakery",
        "Canned/Jarred Goods",
        "Dairy",
        "Frozen Goods",
        "Meat",
        "Personal Care",
        "Other"
            };


            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }
        public class ProductClass
        {
            private int _Quantity;
            private double _SellPrice;
            private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;

            public ProductClass(string productName, string category, string mfgDate, string expDate,
                                double sellingPrice, int quantity, string description)
            {
                this._Quantity = quantity;
                this._SellPrice = sellingPrice;
                this._ProductName = productName;
                this._Category = category;
                this._MfgDate = mfgDate;
                this._ExpDate = expDate;
                this._Description = description;
            }

            public string ProductName
            {
                get { return _ProductName; }
                set { _ProductName = value; }
            }

            public string Category
            {
                get { return _Category; }
                set { _Category = value; }
            }

            public string ManufacturingDate
            {
                get { return _MfgDate; }
                set { _MfgDate = value; }
            }

            public string ExpirationDate
            {
                get { return _ExpDate; }
                set { _ExpDate = value; }
            }

            public string Description
            {
                get { return _Description; }
                set { _Description = value; }
            }

            public int Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; }
            }

            public double SellingPrice
            {
                get { return _SellPrice; }
                set { _SellPrice = value; }
            }
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                throw new StringFormatException("Product name must only contain letters and spaces.");
            }
            return name;

        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^\d+$"))  
            {
                throw new NumberFormatException("Quantity must be a valid integer.");
            }
            return Convert.ToInt32(qty);

        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^\d+(\.\d{1,2})?$"))  
            {
                throw new CurrencyFormatException("Price must be a valid decimal number with up to two decimal places.");
            }
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);  
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "String Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Currency Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }
    }
}
