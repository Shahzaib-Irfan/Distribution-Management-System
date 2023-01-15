using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSmain.Forms
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Customers_Email = txtCustomerEmail.getText();
                // Credentials 
                var credentials = new NetworkCredential("hs249384@gmail.com", "wnxikmsfsrdzkmyv");

                // Mail message 
                var mail = new MailMessage()
                {
                    From = new MailAddress("hs249384@gmail.com"),
                    Subject = "Test Email",
                    Body = "This is for testing SMTP mail from GMAIL"
                };

                mail.To.Add(new MailAddress(Customers_Email));

                // Smtp client 
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in sending email: " + ex.Message);
            }
        }

        private void Email_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
