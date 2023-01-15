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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           // ProductDL.getDataFromApi();
            MUserDL.LoadFromFile();
            txtPassword.textBoxBackColor = txtUsername.textBoxBackColor = panel1.BackColor;
            txtUsername.textBoxForeCol = txtPassword.textBoxForeCol = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.getText().Length < 8)
                {
                    throw new Exception("Password can not be less than 8 characters in Length");
                }
                BL.MUser inputUser = new BL.MUser(txtUsername.getText(), txtPassword.getText());
                if (txtUsername.getText().EndsWith("@gmail.com") || txtUsername.getText().EndsWith("@hotmail.com") || txtUsername.getText().EndsWith("@outlook.com") || txtUsername.getText().EndsWith("@yahoo.com"))
                {
                }
                else throw new Exception("Email is Not Valid");
                inputUser = MUserDL.Authenticate(inputUser);

                if (inputUser == null) 
                { 
                    throw new Exception("User Not Found"); 
                }
                else if (inputUser.isAdmin())
                {
                    Form f = new FrmAdminHomePage(MUserDL.currentUser);
                    this.Hide(); f.Show();
                }
                else if (inputUser.isRider())
                {
                    Rider r = RiderDL.getRiderBYUsername(inputUser);
                    Form f = new FrmRiderHomePage(r);
                    this.Hide(); f.Show();
                }
                else MessageBox.Show("Something unwanted happened");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Login Error Due To " + ex.Message);
            }
        }

        private void txtPassword_Load(object sender, EventArgs e)
        {
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
