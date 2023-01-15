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
using static System.Windows.Forms.MonthCalendar;

namespace DMSmain.Forms
{
    public partial class FrmShopUpdate : Form
    {
        Shop shop;
        public FrmShopUpdate(Shop shop)
        {
            InitializeComponent();
            this.shop = shop;
            setText(shop);
        }
        private void setText(Shop shop)
        {
            txtName.setText(shop.ShopName);
            txtArea.setText(shop.ShopAddress);
            txtContact.setText(shop.ShopContact);
            txtShopKeeperName.setText(shop.ShopKeeper.ShopkeeperName);
            txtShopKeeperEmail.setText(shop.ShopKeeper.ShopkeeperEmail);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Shop updateShopUi()
        {
            string name = txtName.getText();
            string area = (txtArea.getText());
            string address = "Shop #3";
            string contact = txtContact.getText();
            foreach(char i in contact)
            {
                if((int) i < 48 || (int) i > 57 || contact.Length != 11)
                {
                    throw new Exception("Invalid Contact");
                }
            }
            string shopKeeperName = txtShopKeeperName.getText();
            string shopKeeperEmail = txtShopKeeperEmail.getText();
            if(!shopKeeperEmail.EndsWith("@gmail.com"))
            {
                throw new Exception("Invalid Shopkeeper Email was provided");
            }
            float shopLongitude = 34.5F;
            float shopLatitude = 39.5F;
            Shop shop = new Shop(name, address, area, contact, new ShopKeeper(shopKeeperName, shopKeeperEmail), new Directions(shopLongitude, shopLatitude));
            return shop;
        }

        private bool check()
        {
            if (txtName.getText() != "" && txtArea.getText() != "" && txtContact.getText() != "" && txtShopKeeperName.getText() != "" && txtShopKeeperEmail.getText() != "") return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void FrmShop_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check()) { ShopDL.updateShop(shop, updateShopUi()); }
            else MessageBox.Show("All Fields are not filled Correctly");
            Form f = new FrmRiderHomePage(null);
            this.Hide();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f = new FrmShopControl();
            this.Hide();
            f.Show();
        }

        private void FrmShopUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
