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
    public partial class FrmShopAdd : Form
    {
        Rider r;
        public FrmShopAdd(Rider r)
        {
            InitializeComponent();
            this.r = r;
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            //ShopDL.LoadFromFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check()) addShop();
            else MessageBox.Show("Some Fields Filled Uncorrectly");
        }

        private void addShop()
        {
            MessageBox.Show("Add Shop Entered");
            string name = txtName.getText();
            string area = "Multan Road";
            string address = txtArea.getText();
            string contact = txtContact.getText();
            string shopKeeperName = txtShopKeeperName.getText();
            string shopKeeperEmail = txtShopKeeperEmail.getText();
            float shopLongitude = 34.5F;
            float shopLatitude = 39.5F;
            Shop shop = new Shop(name, address, area, contact, new ShopKeeper(shopKeeperName, shopKeeperEmail), new Directions(shopLongitude, shopLatitude));
            ShopDL.AddShops(shop);
            ShopDL.writeInFile();
        }
        private bool check()
        {
            if (txtName.getText() != "" && txtArea.getText() != "" && txtContact.getText() != "" && txtShopKeeperName.getText() != "" && txtShopKeeperEmail.getText() != "") return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check()) addShop();
            else MessageBox.Show("Some Fields Filled Uncorrectly");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FrmRiderHomePage(r);
            this.Hide(); f.Show();
        }

        private void FrmShopAdd_Load(object sender, EventArgs e)
        {
            txtArea.textBoxBackColor = txtContact.textBoxBackColor = txtName.textBoxBackColor =
                txtShopKeeperEmail.textBoxBackColor = txtShopKeeperName.textBoxBackColor = panel1.BackColor;
        }

        private void FrmShopAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
