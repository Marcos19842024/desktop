using System.Collections.Generic;

namespace Entidad
{
    public class Cliente
    {
        public string Indice { get; set; }
        public string Hora { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Estatus { get; set; }
        public string Observaciones { get; set; }
        public List<Mascota> Mascota { get; set; }
    }
}