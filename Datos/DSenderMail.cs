using System.Collections.Generic;

namespace Datos
{
    public class DSenderMail
    {
        public bool SendMail(string SenderMail,string Password, List<string> Correo, string Asunto, string Cuerpo, List<string> Adjunto)
        {
            var mailService = new SystemSupportMail(SenderMail,Password);
            return mailService.SendMail(
            subject: Asunto,
            body: Cuerpo,
            attachment: Adjunto,
            recipientMail: Correo);
        }
    }
}