using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NClientes
    {
        private readonly DClientes Clientes = new DClientes();
        private readonly DClientes Fechas = new DClientes();

        public List<Cliente> ListarClientes1(out List<Cliente> Rechazados, out bool Result)
        {
            return Clientes.ListarClientes1(out Rechazados, out Result);
        }

        public List<Cliente> ListarClientes2(out List<Cliente> Rechazados, out bool Result)
        {
            return Clientes.ListarClientes2(out Rechazados, out Result);
        }

        public List<Fecha> ListarFechas(out bool Result)
        {
            return Fechas.ListarFechas(out Result);
        }
    }
}