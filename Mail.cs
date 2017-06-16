using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DatabaseManagementProject
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
    
        }
        Sorgular sorgu = new Sorgular();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (formadi_Tb.Text == "Form3")
            {
                
                string mailgonderen=mailfrom.Text;
                string sifre=password.Text;
                
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");

                mail.From = new MailAddress(mailfrom.Text);
                mail.To.Add(mailto.Text);
                mail.Subject = konu.Text;
                mail.Body = Message.Text.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(mailgonderen, sifre);
                SmtpServer.EnableSsl = true;
                try
                {
                    SmtpServer.Send(mail);
                    MessageBox.Show("Gönderildi");
                    BolumYoneticiPaneli frm3 = new BolumYoneticiPaneli();
                    frm3.Show();
                    this.Close();
                }
                catch (Exception esr)
                {
                    MessageBox.Show(esr.ToString());
                }
            }
            if (formadi_Tb.Text=="Form2")
            {
                string mailgonderen = mailfrom.Text;
                string sifre = password.Text;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("Smtp.gmail.com");

                mail.From = new MailAddress(mailfrom.Text);
                mail.To.Add(mailto.Text);
                mail.Subject = konu.Text;
                mail.Body = Message.Text.ToString();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(mailgonderen, sifre);
                SmtpServer.EnableSsl = true;
                try
                {
                    SmtpServer.Send(mail);
                    MessageBox.Show("Gonderildi");
                    YoneticiPaneli frm2 = new YoneticiPaneli();
                    frm2.Show();
                    this.Close();
                    
                }
                catch (Exception esr)
                {
                    MessageBox.Show(esr.ToString());
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
