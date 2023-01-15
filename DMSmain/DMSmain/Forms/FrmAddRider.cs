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
    public partial class FrmAddRider : Form
    {
        public FrmAddRider()
        {
            InitializeComponent();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddrider_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateRider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddRider_Load(object sender, EventArgs e)
        {
            txtCnic.textBoxBackColor = txtEmail.textBoxBackColor = txtName.textBoxBackColor
                = txtPassword.textBoxBackColor = txtPhoneNo.textBoxBackColor = txtUsername.textBoxBackColor =
                this.panel5.BackColor;

            RiderDL.LoadFromFile();
        }

        private void customTextBox8_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void addRider()
        {
            string name = txtName.getText();
            string cnic = txtCnic.getText();
            string phone = txtPhoneNo.getText();
            string email = txtEmail.getText();
            string username = txtUsername.getText();
            string password = txtPassword.getText();
            string area = cmbArea.Text;
            if(password.Length < 8)
            {
                throw new Exception("Short password Length");
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
            if (cmbArea.Text == null)
                throw new Exception("Area Cannot be Empty");
            if(emailValidator(email) && emailValidator(username))
            {
                Rider rider = new Rider(name, cnic, phone, email, area, username, password, "RIDER");
                RiderDL.AddRiderIntoList(rider);
                MUserDL.addintoList(new MUser(username, password, "RIDER"));
                MUserDL.writeInFile();
                RiderDL.writeInFile();
            }
            else
            {
                throw new Exception("Email or Username Was Incorrect");
            }
        }
        bool emailValidator(string email)
        {
            bool characterValidator = false; int index = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    index = i;
                    characterValidator = true;
                    break;
                }
            }
            bool emailValidatorHehe = false;
            if (characterValidator)
            {
                if (email.Slice(index, email.Length) == "@hotmail.com" || email.Slice(index, email.Length) == "@gmail.com" || email.Slice(index, email.Length) == "@outlook.com" || email.Slice(index, email.Length) == "@yahoo.com") { emailValidatorHehe = true; }
                else emailValidatorHehe = false;
            }
            else return false;
            return emailValidatorHehe;
        }
        private bool check()
        {
            if (txtName.getText() != "" && txtCnic.getText() != "" && txtPhoneNo.getText() != "" && txtEmail.getText() != "" && txtUsername.getText() != "" && txtPassword.getText() != "") return true;
            return false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (check())
                {
                    addRider();
                }
                else { MessageBox.Show("All Fields Not Filled Correctly"); }
            }
            catch(Exception error) { MessageBox.Show("Rider Not Added Due To " + error.Message); }
            Form f = new FrmAdminHomePage(MUserDL.currentUser);
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new FrmAdminHomePage(MUserDL.currentUser);
            this.Hide();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAddRider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    public static class Extensions
    {
        /// <summary>
        /// Get the string slice between the two indexes.
        /// Inclusive for start index, exclusive for end index.
        /// </summary>
        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
            {
                end = source.Length + end;
            }
            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }
    }
}
