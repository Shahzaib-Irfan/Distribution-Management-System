using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMSmain.BL;
using DMSmain.DL;

namespace DMSmain.Forms
{
    public partial class AddProduct : Form
    {
        string condition;
        MUser user;
        public AddProduct(string condition, MUser user)
        {
            InitializeComponent();
            this.condition = condition;
            this.user= user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                addProduct();
            }
            else MessageBox.Show("All Fields are not filled correctly");
        }
        private void addProduct()
        {
            try
            {
                //MessageBox.Show("Return Check");
                string name = txtproductname.getText();
                double price = double.Parse(txtPrice.getText());
                int stock = int.Parse(txtStock.getText());
                string id = txtID.getText();
                string category = txtCategory.getText();
                bool perishible = bool.Parse(txtPerishible.getText().ToLower());

                if(stock <= 0)
                {
                    throw new InvalidOperationException("Stock value inserted can not be zero");
                }
                if(id.Length < 3)
                {
                    throw new ArgumentNullException("ID of product can not be less than 3 in length");
                }
                if(category.Length < 3)
                {
                    throw new ArgumentException("Marred Category can not be less than 3 in Length");
                }
                Product product = new Product(name, price, stock, id, category, perishible ? true : false);
                ProductDL.addProductstoLinkedList(product);
                ProductDL.writeInFile();
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
        private bool check()
        {
            if (txtproductname.getText() != "" && txtPrice.getText() != "" && txtStock.getText() != "" && txtID.getText() != "" && txtCategory.getText() != "" && (txtPerishible.getText() != "true" || txtPerishible.getText() != "false")) return true;
            return false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ProductDL.LoadFromFile();
            //if(condition == "ADD")
            //{
            //    PnlView.Visible = false;
            //    Productpanel.Visible = true;
            //    Productpanel.Location = new Point(35, 39);
            //}
            //else if(condition == "VIEW")
            //{
            //    Productpanel.Visible = false;
            //    PnlView.Visible = true;
            //    PnlView.Location = new Point(35, 39);
            //    GridViewProduct.Visible = true;
            //    GridViewProduct.DataSource = null;
            //    GridViewProduct.DataSource = ProductDL.products;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new FrmAdminHomePage(user);
            this.Hide();
            f.Show();
        }

        private void GridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panelProductGrid_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new FrmAdminHomePage(user);
            this.Hide();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FrmAdminHomePage(user);
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Productpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
