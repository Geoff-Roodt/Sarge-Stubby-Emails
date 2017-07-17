using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace Sergant_Stubbys_Seriously_Smooth_Stint
{
    class Email
    {

        public static void setDetails() {



        }




        /// <summary>
        /// Sends an email address
        /// </summary>
        /// <param name="emailFrom">Email to be used for sending</param>
        /// <param name="portNum">Port number to use</param>
        /// <param name="password">Password for the sending email address</param>
        /// <param name="smtpHost">Smtp Host</param>
        /// <param name="emailTo">Target Address</param>
        /// <param name="subjectText">Subject Text</param>
        /// <param name="bodyText">Email Content</param>
        public static void SendEmail(string emailFrom, int portNum, string password, string smtpHost, string emailTo, string subjectText, string bodyText)
        {
          
                MailMessage mail = new MailMessage(emailFrom, emailTo);
                SmtpClient client = new SmtpClient();

                client.Port = portNum;

                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                client.Credentials = new System.Net.NetworkCredential(emailFrom, password);
                client.Host = smtpHost;

                mail.Subject = subjectText;
                mail.Body = bodyText;

                client.Send(mail);
           
        }

    }
}
