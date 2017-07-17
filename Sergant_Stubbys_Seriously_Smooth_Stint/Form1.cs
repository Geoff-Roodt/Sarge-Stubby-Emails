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

        //THIS IS A COMMENTY SUCH DISCRIPTION MUCH WOW


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {




            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        void worker_DoWork() {
            try
            {
                //SEND EMAILS
                Email.SendEmail(email, messageTitle, messageContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


      
    }
}
