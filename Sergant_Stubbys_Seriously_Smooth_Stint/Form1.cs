using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sergant_Stubbys_Seriously_Smooth_Stint
{
    public partial class Form1 : Form
    {
        private string emailFrom;
        private int portNum;
        private string password;
        private string smtpHost;
        private int numEmails;

        private string emailTo;
        private string subjectText;
        private string bodyText;

        private OutputLog outputLog;

        public Form1()
        {
            InitializeComponent();

            outputLog = new OutputLog();
            outputLog.Hide();

            labelSenderError.Visible = false; // used to hold text which will be passed to the output log
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControls())
                {
                    outputLog.handleLog(labelSenderError.Text);
                }

                worker_DoWork();

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void worker_DoWork() {
            try
            {
                //SEND EMAILS
                //Email.SendEmail(email, messageTitle, messageContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool validateControls()
        {
            labelSenderError.Text = string.Empty;

            if (!int.TryParse(textBoxMultiplier.Text, out numEmails))
            {
                labelSenderError.Text = "\r\n Please ensure the email multiplier is a valid integer";
            }
            if (!int.TryParse(textBoxPortNumber.Text, out portNum))
            {
                labelSenderError.Text += "\r\n Please ensure the port number is a valid integer";
            }
            if (string.IsNullOrWhiteSpace(textBoxEmailFrom.Text))
            {
                labelSenderError.Text += "\r\n Please supply a sender email address";
            }
            if (string.IsNullOrWhiteSpace(textBoxSmtpHost.Text))
            {
                labelSenderError.Text += "\r\n Please supply a smtp host address";
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                labelSenderError.Text += "\r\n Please supply a password";
            }
            if (string.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                labelSenderError.Text += "\r\n Please supply a subject for the target email";
            }
            if (string.IsNullOrWhiteSpace(textBoxContent.Text))
            {
                labelSenderError.Text += "\r\n Please write some text in the content for the target email";
            }
            if (string.IsNullOrWhiteSpace(textBoxTargetAddress.Text))
            {
                labelSenderError.Text += "\r\n Please supply a target email address";
            }

            return string.IsNullOrWhiteSpace(labelSenderError.Text);
        }

      
    }
}
