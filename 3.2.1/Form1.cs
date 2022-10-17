using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._1
{
    public partial class Form1 : Form
    {
        static bool MailSent = false;
        static Regex ValidEmailRegex = CreateValidEmailRegex();
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ServerTxtBox.Focus();
        }
        public void SendMail(string toMailAddress, string fromMailAddress, string subject, string body, string password)
        {
            var mail = new MailMessage();
            mail.To.Add(new MailAddress($"{toMailAddress}", $"{toMailAddress}"));
            mail.From = new MailAddress($"{fromMailAddress}", $"{fromMailAddress}");
            SmtpClient smtp = new SmtpClient();
            mail.Subject = subject;
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;
            mail.Body = body;
            smtp.Port = 465;
            smtp.Host = ServerTxtBox.Text;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(fromMailAddress, password);           
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.SendMailAsync(mail);
            smtp.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("[{0}] Send canceled.");
            }
            if (e.Error != null)
            {
                MessageBox.Show("Couldn't send email");
            }
            else
            {
                MessageBox.Show("Message sent.");
                MailSent = true;
            }           
        }
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
        internal static bool IsEmailValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendMail(ToTxtBox.ToString(), FromTxtBox.ToString(), SubjectTxtBox.ToString(), MessageTxtBox.ToString(), PasswordTxtBox.ToString());
            if(MailSent == true)
            {
                MessageBox.Show("Email sent");
            }
            ToTxtBox.Clear();
            FromTxtBox.Clear();
            SubjectTxtBox.Clear();
            MessageTxtBox.Clear();
            PasswordTxtBox.Clear();
        }
        public void IsTextBoxEmpty(TextBox textBox, TextBox textBox1, TextBox textBox2,TextBox textBox3, Button button)
        {
            if(textBox.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text!="" && IsEmailValid(textBox.Text) && IsEmailValid(textBox1.Text))
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
        private void From_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox,ToTxtBox, FromTxtBox,PasswordTxtBox,SendBtn);
        }
        private void Pass_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox,ToTxtBox, FromTxtBox, PasswordTxtBox, SendBtn);
        }
        private void To_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox, ToTxtBox, FromTxtBox, PasswordTxtBox, SendBtn);
        }
        private void Sub_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox,ToTxtBox, FromTxtBox, PasswordTxtBox, SendBtn);
        }
        private void Message_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox,ToTxtBox, FromTxtBox, PasswordTxtBox, SendBtn);
        }
        private void Server_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(ServerTxtBox, ToTxtBox, FromTxtBox, PasswordTxtBox, SendBtn);
        }
    }
}
