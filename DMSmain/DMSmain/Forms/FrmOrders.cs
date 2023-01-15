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
using DMSmain.DataStructures;

namespace DMSmain.Forms
{
    public partial class FrmOrders : Form
    {
        
        Rider r;
        double totalBill;
        //List<Orders> odr = new List<Orders>();
        public FrmOrders( Rider r)
        {
            InitializeComponent();
            
            this.r = r;
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            pnlOrderStatus.Visible = true;
            lblRiderArea.Text = r.Area;
            dataBind();
            LinkListNode<Orders> node = r.odrs.DataStruct.Head;
            while (node != null)
            {
                node.Data.calculateBill();
                this.totalBill += node.Data.Bill;
                node = node.Next;
            }
            this.lblBill.Text = this.totalBill.ToString();
            ShopDL.LoadFromFile();
            foreach(Shop shop in ShopDL.shops)
            {
                this.cmbAdresses.Items.Add(shop.ShopAddress+","+shop.ShopArea);
            }
        }

        private void pnlOrderStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex == 0)
            //{
            //    return;
            //}
            //if (AddOrderGV.Columns["Add To Cart"].Index == e.ColumnIndex)
            //{
            //    MessageBox.Show("here");
            //    odr.orderIDGenerator();
            //    Product isConsidering = (Product)AddOrderGV.CurrentRow.DataBoundItem;
            //    odr.OrderDate = DateTime.Today.ToString();

            //    odr.OrderedItems.Add(new LineItem(1, isConsidering));

            //    r.odrs.Enqueue(odr);
            //}

        }
        private void dataBind()
        {
            BindDataToGrid(ViewOrderGV,makeDataTable());
            ViewOrderGV.Refresh();  

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
            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
            Delete.HeaderText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Text = "Delete";
            dataGridView.Columns.Add(Delete);

            //Adding Quantity Drop Down menu

            //dataGridView.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
        }
        public DataTable makeDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Clear();
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Order Date", typeof(string));
            dataTable.Columns.Add("Delivery Date", typeof(string));
            dataTable.Columns.Add("Bill", typeof(string));
            
            LinkListNode<Orders> node = r.odrs.DataStruct.Head;
            while (node != null)
            {
                node.Data.orderIDGenerator();
                //node.Data.calculateBill();
                node.Data.OrderDate = DateTime.Today.Date.ToString();
                node.Data.DeliveryDate = DateTime.Today.AddDays(1).Date.ToString();
                dataTable.Rows.Add(node.Data.OrderID, node.Data.OrderDate, node.Data.DeliveryDate, node.Data.Bill);
                //this.totalBill += node.Data.Bill;
                node = node.Next;
            }
            //this.lblBill.Text = this.totalBill.ToString();
            return dataTable;

        }

        private void ViewOrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (4 == e.ColumnIndex) // Delete Order Functionality
            {
               
            }
            
        }
        private void CloseForm()
        {
            Form f = new FrmRiderHomePage(this.r);
            this.Hide(); f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void pnlAddOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Place Order Functionality
            try
            {
                // Traverse a while loop on order head, replace everything below
                //foreach (Orders odres in this.odr)
                //{
                //    string area = ShopDL.shops[cmbAdresses.SelectedIndex].ShopArea;
                //    if (area == r.Area) odres.Address = cmbAdresses.Text;
                //    else throw new InvalidOperationException("Shop other than Area assigned the order");
                //}
                //// replace this loop with the one above, same logic assign order area to rider
                //for (int i = 0; i < r.odrs.CheckPopulation(); i++)
                //{
                //    Orders o = r.odrs.Peek();
                //    o.Area = r.Area;
                //    OrdersDL.AddOrderToQueue(o);
                //    r.odrs.Dequeue();
                //}
                string area = ShopDL.shops[cmbAdresses.SelectedIndex].ShopArea;
                if (area != r.Area) 
                       throw new InvalidOperationException("Shop other than Area assigned the order");
                LinkListNode<Orders> head = r.odrs.DataStruct.Head;
                string id_o = "";
                while(head != null)
                {
                    head.Data.Area = r.Area;
                    head.Data.Address = ShopDL.shops[cmbAdresses.SelectedIndex].ShopAddress;
                    OrdersDL.queueDS.Enqueue(head.Data);
                    id_o += head.Data.OrderID;
                    r.odrs.Dequeue();
                    head = head.Next;
                }
                OrdersDL.writeInFile();
                ProductDL.writeInFile();

                string email = ShopDL.shops[cmbAdresses.SelectedIndex].ShopKeeper.ShopkeeperEmail;
                StringBuilder str = new StringBuilder();
                // email generation
                str.Append("Order ID");
                str.Append(id_o);
                str.Append("has been placed with total Bill");
                str.Append(this.totalBill.ToString());
                
               // Email_Sending.Email_sending(email, str.ToString());
                CloseForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAdresses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
