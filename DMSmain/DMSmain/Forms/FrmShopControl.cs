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

namespace DMSmain.Forms
{
    public partial class FrmShopControl : Form
    {
        public FrmShopControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Shop shop = (Shop)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                dataGridView1.DataSource = null;
                List<Shop> updatedList = ShopDL.deleteProduct(shop);
                ProductDL.writeInFile();
                MessageBox.Show("Shop Deleted");
                DataBind();
            }
            if (dataGridView1.Columns["Update"].Index == e.ColumnIndex)
            {
                Form f = new FrmShopUpdate(shop);
                f.ShowDialog();
                ShopDL.writeInFile();
                DataBindUpdate();
            }
        }

        private void DataBindUpdate()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ShopDL.shops;
            dataGridView1.Refresh();
        }
        private void DataBind()
        {

            dataGridView1.DataSource = ShopDL.shops;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FrmRiderHomePage(null);
            this.Hide(); f.Show();
        }

        private void FrmShopControl_Load(object sender, EventArgs e)
        {
            ShopDL.LoadFromFile();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ShopDL.shops;
            dataGridView1.Refresh();
        }

        private void panelRiderGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmShopControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
