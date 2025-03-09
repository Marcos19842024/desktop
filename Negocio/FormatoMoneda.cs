using System;
using System.Globalization;
using System.Windows.Forms;

namespace Negocio
{
    public class FormatoMoneda
    {
        public string Moneda(decimal Cantidad)
        {
            try
            {
                string Precio = Cantidad.ToString("C", new CultureInfo("en-US"));
                return Precio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }
        }
    }
}
