namespace Datos
{
    internal class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail(string senderMail, string password)
        {
            SenderMail = senderMail;
            Password = password;
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            InitializeSmtpClient();
        }
    }
}