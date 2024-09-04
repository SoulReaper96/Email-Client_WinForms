using System.Net;
using System.Net.Mail;

namespace Email_Client_WinForms
{
    public partial class EmailClient : Form
    {
        public EmailClient()
        {
            InitializeComponent();
        }

        #region Textbox Enter and Leave

        private void Email_txtBox_Enter(object sender, EventArgs e)
        {
            if (Email_txtBox.Text == "Email")
            {
                Email_txtBox.Text = "";
                Email_txtBox.ForeColor = Color.Black;
            }
        }

        private void Email_txtBox_Leave(object sender, EventArgs e)
        {
            if (Email_txtBox.Text == "")
            {
                Email_txtBox.Text = "Email";
                Email_txtBox.ForeColor = Color.Gray;
            }
        }

        private void Subject_txtBox_Enter(object sender, EventArgs e)
        {
            if (Subject_txtBox.Text == "Subject")
            {
                Subject_txtBox.Text = "";
                Subject_txtBox.ForeColor = Color.Black;
            }
        }

        private void Subject_txtBox_Leave(object sender, EventArgs e)
        {
            if (Subject_txtBox.Text == "")
            {
                Subject_txtBox.Text = "Subject";
                Subject_txtBox.ForeColor = Color.Gray;
            }
        }

        private void Message_txtBox_Enter(object sender, EventArgs e)
        {
            if (Message_txtBox.Text == "Message")
            {
                Message_txtBox.Text = "";
                Message_txtBox.ForeColor = Color.Black;
            }
        }

        private void Message_txtBox_Leave(object sender, EventArgs e)
        {
            if (Message_txtBox.Text == "")
            {
                Message_txtBox.Text = "Message";
                Message_txtBox.ForeColor = Color.Gray;
            }
        }

        #endregion

        private void Send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string to = Email_txtBox.Text;
                string subject = Subject_txtBox.Text;
                string body = Message_txtBox.Text;

                string from = "email address";
                string pass = "application password";

                MailMessage message = new MailMessage(from, to, subject, body);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(from, pass),
                    EnableSsl = true,
                };
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (code == DialogResult.OK)
                {
                    Email_txtBox.Text = "Email";
                    Email_txtBox.ForeColor = Color.Gray;
                    Subject_txtBox.Text = "Subject";
                    Subject_txtBox.ForeColor = Color.Gray;
                    Message_txtBox.Text = "Message";
                    Message_txtBox.ForeColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
