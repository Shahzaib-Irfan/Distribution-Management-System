using DMSmain.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSmain.Forms
{
    public partial class FrmComplaintChannel : Form
    {
        Rider r;
        public FrmComplaintChannel(Rider r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmComplaintChannel_Load(object sender, EventArgs e)
        {
            txtEmail.BackColor = txtPhone.BackColor = this.BackColor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f = new FrmRiderHomePage(r);
            this.Hide(); f.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.getText();
                string phone = txtPhone.getText();
                string complaint = txtComplaint.Text;

                if (!email.EndsWith("@gmail.com"))
                {
                    throw new ArgumentNullException("Email is invalid.");
                }
                foreach(char i in phone)
                {
                    if (((int)i < 48 || (int)i > 57) || phone.Length != 11)
                        throw new Exception("Invalid Phone Number");
                }
                if(complaint.Length <= 30)
                {
                    throw new Exception("Dummy Complaints are not allowed");
                }
                StreamWriter str = new StreamWriter("complaint.txt", true);
                str.WriteLine(email + "," + phone + " :" + complaint);
                str.Flush();
                str.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmComplaintChannel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
