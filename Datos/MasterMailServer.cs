using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Datos
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void InitializeSmtpClient()
        {
            smtpClient = new SmtpClient
            {
                Credentials = new NetworkCredential(SenderMail, Password),
                Host = Host,
                Port = Port,
                EnableSsl = Ssl
            };
        }

        public bool SendMail(string subject, string body, List<string> attachment, List<string> recipientMail)
        {
            bool Enviado = true;
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                if(attachment.Count >0)
                {
                    foreach (string File in attachment)
                    {
                        mailMessage.Attachments.Add(new Attachment(File));
                    }
                }
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enviado = false;
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
            return Enviado;
        }
    }
}