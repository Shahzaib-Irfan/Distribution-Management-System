using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSmain.BL
{
    public static class Email_Sending
    {
        public static void Email_sending(string Email_Address , string body)
        {
            try
            {
                string Customers_Email = Email_Address;
                // Credentials 
                var credentials = new NetworkCredential("hs249384@gmail.com", "wnxikmsfsrdzkmyv");

                // Mail message 
                var mail = new MailMessage()
                {
                    From = new MailAddress("hs249384@gmail.com"),
                    Subject = "Test Email",
                    Body = body
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
    }
}
