using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NSenderMail
    {
        private readonly DSenderMail Report = new DSenderMail();

        public bool SendMail(string SenderMail, string Password, List<string> Correo, string Asunto,string Cuerpo, List<string> Adjunto)
        {
            return Report.SendMail(SenderMail, Password, Correo, Asunto, Cuerpo, Adjunto);
        }
    }
}