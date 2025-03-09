using System.Collections.Generic;

namespace Entidad
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Asunto { get; set; }
        public List<Recordatorio> Recordatorio { get; set; }
    }
}