using System.Collections.Generic;

namespace Entidad
{
    public class Pdf
    {
        public string Ruta { get; set; }
        public string Titulo { get; set; }
        public List<ProvConc> Tabla { get; set; }
        public string Subtotal { get; set; }
        public string IVA { get; set; }
        public string Total { get; set; }
    }
}