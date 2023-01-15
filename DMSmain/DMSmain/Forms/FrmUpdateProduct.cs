using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DMSmain.BL;
using DMSmain.DL;
using DMSmain.DataStructures;

namespace DMSmain.Forms
{
    public partial class FrmUpdateProduct : Form
    {
        LinkListNode<Product> product;
        public FrmUpdateProduct(LinkListNode<Product> product)
        {
            InitializeComponent();
            this.product = product;
            setText(product);
        }
        private void setText(LinkListNode<Product> product)
        {
            txtUpdatename.setText(product.Data.Name);
            txtUpdatePrice.setText(product.Data.Price.ToString());
            txtUpdateStock.setText(product.Data.Stock.ToString());
            txtUpdateID.setText(product.Data.Id.ToString());
            txtUpdateCategory.setText(product.Data.Category);
            txtUpdatePerishible.setText(product.Data.IsPerishable.ToString());
        }
        private void updateProduct()
        {
            string name = txtUpdatename.getText();
            double price = double.Parse(txtUpdatePrice.getText());
            int stock = int.Parse(txtUpdateStock.getText());
            string id = txtUpdateID.getText();
            string category = txtUpdateCategory.getText();
            bool perishible = bool.Parse(txtUpdatePerishible.getText().ToLower());
            if (stock <= 0)
            {
                throw new InvalidOperationException("Stock value inserted can not be zero");
            }
            if (id.Length < 3)
            {
                throw new ArgumentNullException("ID of product can not be less than 3 in length");
            }
            if (category.Length < 3)
            {
                throw new ArgumentException("Marred Category can not be less than 3 in Length");
            }
            Product product1 = new Product(name, price, stock, id, category, perishible ? true : false);
            LinkListNode<Product> productUpdate = ProductDL.getProductBYid(product1);
            ////product.Data.Name = name; product.Data.Price = price; product.Data.Stock= stock; product.Data.Category = category;  product.Data.Id = id; product.Data.IsPerishable = perishible;
            //productUpdate.Data = product1;
            productUpdate.Data.Name = name; productUpdate.Data.Price = price; productUpdate.Data.Stock = stock; productUpdate.Data.Category = category; productUpdate.Data.Id = id; productUpdate.Data.IsPerishable = perishible;
        }
        private void pnlUpdate_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool check()
        {
            if (txtUpdatename.getText() != "" && txtUpdatePrice.getText() != "" && txtUpdateStock.getText() != "" && txtUpdateID.getText() != "" && txtUpdateCategory.getText() != "" && (txtUpdatePerishible.getText() != "true" || txtUpdatePerishible.getText() != "false")) return true;
            return false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            updateProduct();
            ProductDL.writeInFile();
            Form f = new FrmInventory();
            this.Hide();
            f.Show();
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FrmInventory();
            this.Hide();
            f.Show();
        }

        private void FrmUpdateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
