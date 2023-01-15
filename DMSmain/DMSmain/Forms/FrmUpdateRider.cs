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
    public partial class FrmUpdateRider : Form
    {
        Rider rider;
        public FrmUpdateRider(Rider rider)
        {
            InitializeComponent();
            this.rider = rider;
            setText(rider);
        }

        private void setText(Rider rider)
        {
            txtName.setText(rider.getName());
            txtCnic.setText(rider.getCNIC());
            txtPhoneNo.setText(rider.getPhoneNo());
            txtEmail.setText(rider.getEmail());
            txtUsername.setText(rider.Username);
            txtPassword.setText(rider.Password);
        }
        private Rider updateRiderUi()
        {
            string name = txtName.getText();
            string cnic = txtCnic.getText();
            string phone = txtPhoneNo.getText();
            string email = txtEmail.getText();
            string username = txtUsername.getText();
            string password = txtPassword.getText();
            string area = cmbArea.Text;
            if(cmbArea.Text == null)
            {
                throw new InvalidConstraintException("Must Select Area of Rider");
            }
            foreach (var i in cnic)
            {
                if (((int)i < 48 || (int)i > 57) || cnic.Length != 13)
                    throw new Exception("Invalid CNIC");
            }
            foreach (var i in phone)
            {
                if (((int)i < 48 || (int)i > 57) || phone.Length != 11)
                    throw new Exception("Invalid Phone Number");
            }
            Rider rider = new Rider(name, cnic, phone, email,area, username, password, "RIDER");
            return rider;
        }
        private bool check()
        {
            if (txtName.getText() != "" && txtCnic.getText() != "" && txtPhoneNo.getText() != "" && txtEmail.getText() != "" && txtUsername.getText() != "" && txtPassword.getText() != "") return true;
            return false;
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (check()) { RiderDL.updateRider(rider, updateRiderUi()); }
                else MessageBox.Show("All Fields Not Filled Correctly");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Rider Not Updated Due To " + ex.Message);
            }
            Form f = new FrmAdminHomePage(MUserDL.currentUser);
            this.Hide(); f.Show();
        }

        private void pnlProdGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUpdateRider_Load(object sender, EventArgs e)
        {

        }

        private void FrmUpdateRider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
