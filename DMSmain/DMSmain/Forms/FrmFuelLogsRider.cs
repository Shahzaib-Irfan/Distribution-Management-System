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
    public partial class FrmFuelLogsRider : Form
    {
        private Rider r;
        public FrmFuelLogsRider(Rider r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void FrmFuelLogsRider_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Today.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RiderBill rdrBl = new RiderBill();
            rdrBl.BillFuel = (int)this.numericUpDown1.Value * 100;

            r.Bills.Insert(r.Bills.Root,rdrBl);
            MessageBox.Show("Bill Inserted Successfully");
        }
        private void showBack()
        {
            Form f = new FrmRiderHomePage(r);
            this.Hide(); f.Show();
        }

        private void FrmFuelLogsRider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
