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

namespace DMSmain.Forms
{
    public partial class FrmRiderHomePage : Form
    {
        internal Rider r;
        public FrmRiderHomePage(Rider r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmAddOrder(this.r);
            this.Hide(); f.Show();
        }

        private void ordersGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmOrders(this.r);
            this.Hide(); f.Show(); 
        }

        private void fuelLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("MenuStripClicked");
            Form f = new FrmFuelLogsRider(this.r);
            this.Hide();  f.Show();
        }

        private void s(object sender, EventArgs e)
        {
            MessageBox.Show("MenuStripClicked");
            Form f = new FrmFuelLogsRider(this.r);
            this.Hide(); f.Show();
        }

        private void FrmRiderHomePage_Load(object sender, EventArgs e)
        {

        }

        private void fuelBIllsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmComplaintChannel(r);
            this.Hide(); f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmShopAdd(r);
            this.Hide();
            f.Show();
        }

        private void controlShopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmShopControl();
            this.Hide(); f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigateRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Gmaps.Form1 frm = new Gmaps.Form1();
            /*this.Hide();*/frm.Show();
        }

        private void FrmRiderHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
