using DMSmain.BL;
using DMSmain.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMSmain.Forms;
using DMSmain.DataStructures;
using GMap.NET.MapProviders;

namespace DMSmain.Forms
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            ProductDL.LoadFromFile();
            BindDataToGrid(GridViewProduct, makeDataTable());
        }
        private void GridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = GridViewProduct.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                double price = Convert.ToDouble(row.Cells[1].Value);
                int stock = (int)row.Cells[2].Value;
                string category = row.Cells[3].Value.ToString();
                string id = row.Cells[4].Value.ToString();
                bool perishable = Convert.ToBoolean(row.Cells[5].Value);
                Product product = new Product(name, price, stock, id, category, perishable);
                product = (Product) ProductDL.getProductBYid(product).Data;
                LinkList<Product> list = ProductDL.deleteProduct(product);
                ProductDL.writeInFile();
                DataBind();
            }
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow row = GridViewProduct.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                double price = Convert.ToDouble(row.Cells[1].Value);
                int stock = (int)row.Cells[2].Value;
                string category = row.Cells[3].Value.ToString();
                string id = row.Cells[4].Value.ToString();
                bool perishable = Convert.ToBoolean(row.Cells[5].Value);
                Product product = new Product(name, price, stock, id, category, perishable);

                LinkListNode<Product> product1 = ProductDL.getProductBYid(product);
                Form f = new FrmUpdateProduct(product1);
                this.Hide();
                f.Show();
                DataBindUpdate();
            }
            //Product product = (Product)GridViewProduct.CurrentRow.DataBoundItem;
            //if (GridViewProduct.Columns["Delete"].Index == e.ColumnIndex)
            //{
            //    GridViewProduct.DataSource = null;
            //    LinkList<Product> updatedList = ProductDL.deleteProduct(product);
            //    ProductDL.writeInFile();
            //    DataBind();
            //}
            //if (GridViewProduct.Columns["Update"].Index == e.ColumnIndex)
            //{
            //    Form f = new FrmUpdateProduct(product);
            //    f.ShowDialog();
            //    ProductDL.writeInFile();
            //    DataBindUpdate();
            //}
        }
        private void DataBind()
        {

            BindDataToGrid(GridViewProduct, makeDataTable());
            GridViewProduct.Refresh();
        }
        private void DataBindUpdate()
        {
            GridViewProduct.DataSource = null;
            BindDataToGrid(GridViewProduct, makeDataTable());
            GridViewProduct.Refresh();
        }
        public void BindDataToGrid(DataGridView dataGridView, DataTable dataTable)
        {
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
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Text = "Delete";
            dataGridView.Columns.Add(Delete);

            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.HeaderText = "Update";
            Update.UseColumnTextForButtonValue = true;
            Update.Text = "Update";
            dataGridView.Columns.Add(Update);
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
            


            LinkListNode<Product> node = ProductDL.linkedListProducts.Head;
            while(node != null)
            {
                dataTable.Rows.Add(node.Data.Name , node.Data.Price, node.Data.Stock, node.Data.Category, node.Data.Id, node.Data.IsPerishable);
                node = node.Next;
            }
            return dataTable;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new /*AddProduct("ADD", MUserDL.currentUser)*/ FrmAdminHomePage(MUserDL.currentUser);
            this.Hide();
            f.Show();
        }

        private void PnlView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(txtSearchBox.getText() != "")
            //{
            //    string name = txtSearchBox.getText();
            //    int key = ProductDL.hashTableProducts.HashCode(name);
            //    Product product = ProductDL.hashTableProducts.getObject(key);
            //    MessageBox.Show(product.Name);
            //}
            //else
            //{
            //}
        }
    }
}
