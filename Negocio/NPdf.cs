using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NPdf
    {
        private readonly DPdf Pdf = new DPdf();

        public string CrearPdf(List<Cliente> Enviados, List<Cliente> NoEnviados, string ColorForeColorPdf)
        {
            return Pdf.CrearPdf(Enviados, NoEnviados, ColorForeColorPdf);
        }

        public string CrearPdf(List<Cliente> Enviados, List<Cliente> NoEnviados, string ColorForeColorPdf,string Titulo)
        {
            return Pdf.CrearPdf(Enviados, NoEnviados, ColorForeColorPdf, Titulo);
        }

        public string CrearPdf(Pdf Datos, string ColorForeColorPdf)
        {
            return Pdf.CrearPdf(Datos, ColorForeColorPdf);
        }

        public string CrearPdf(List<Fecha> List, string ColorForeColorPdf)
        {
            return Pdf.CrearPdf(List, ColorForeColorPdf);
        }
    }
}