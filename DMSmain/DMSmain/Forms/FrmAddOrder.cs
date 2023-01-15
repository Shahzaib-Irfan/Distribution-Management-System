using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMSmain.DL;
using DMSmain.BL;
using DMSmain.DataStructures;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace DMSmain.Forms
{
    public partial class FrmAddOrder : Form
    {
        internal Rider r;
        Orders odr = new Orders();
        int quantity;
        public FrmAddOrder(Rider r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7) // 7 is the index assigned to Add To Cart button
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string name = row.Cells[0].Value.ToString();
                    double price = Convert.ToDouble(row.Cells[1].Value);
                    int stock = (int)row.Cells[2].Value;
                    string category = row.Cells[3].Value.ToString();
                    string id = row.Cells[4].Value.ToString();
                    bool perishable = Convert.ToBoolean(row.Cells[5].Value);
                    Product product = new Product(name, price, stock, id, category, perishable);
                    product = (Product)ProductDL.getProductBYid(product).Data;

                    string quantity = row.Cells[6].Value.ToString();
                    int q; bool parseable= int.TryParse(quantity,out q);
                    if (!parseable) throw new InvalidCastException("Wrong Input Nature of Quantity");

                    q = Convert.ToInt32(quantity);

                    if (q > product.Stock) throw new ArgumentException("Order quantity greater than stock is entered. Try again!!");

                    LineItem lnItem = new LineItem(q,product);
                    this.odr.OrderedItems.Insert(lnItem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDataToGrid(DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
            dataGridView.Columns.Clear();

            foreach (DataColumn dcol in dataTable.Columns)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = dcol.Caption;
                col.DataPropertyName = dcol.ColumnName;
                col.ValueType = dcol.DataType;
                dataGridView.Columns.Add(col);
            }

            //Adding Add To Cart Button
            DataGridViewButtonColumn addToCart = new DataGridViewButtonColumn();
            addToCart.HeaderText = "Add To Cart";
            addToCart.UseColumnTextForButtonValue = true;
            addToCart.Text = "Add To Cart";
            dataGridView.Columns.Add(addToCart);

            //Adding Quantity Drop Down menu
            
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
        }
        public DataTable makeDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Clear();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("Stock", typeof(int));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("id", typeof(string));
            dataTable.Columns.Add("Perishible", typeof(bool));
            dataTable.Columns.Add("Quantity", typeof(string));


            ProductDL.LoadFromFile();
            LinkListNode<Product> node = ProductDL.linkedListProducts.Head;
            while (node != null)
            {
                dataTable.Rows.Add(node.Data.Name, node.Data.Price, node.Data.Stock, node.Data.Category, node.Data.Id, node.Data.IsPerishable);
                node = node.Next;
            }
            return dataTable;

        }
        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            ProductDL.LoadFromFile();
            databind();
        }
        private void databind()
        {
            this.dataGridView1.DataSource = null;
            BindDataToGrid(dataGridView1 , makeDataTable());
            this.dataGridView1.Refresh();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.odrs.Enqueue(odr);
            Form f = new FrmRiderHomePage(r);
            this.Hide(); f.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void FrmAddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
