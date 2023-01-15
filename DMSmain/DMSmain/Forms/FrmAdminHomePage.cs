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
    public partial class FrmAdminHomePage : Form
    {
        MUser currentUser;
        public FrmAdminHomePage(MUser currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void FrmAdminHomePage_Load(object sender, EventArgs e)
        {
            label2.Text = "Hello " + currentUser.Username;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new AddProduct("ADD", currentUser);
            this.Hide();
            f.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form f = new LoginPage();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new FrmInventory();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new FrmAddRider();
            this.Hide(); f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new FrmRiderControl();
            this.Hide(); f.Show();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
