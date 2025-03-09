using Datos;

namespace Negocio
{
    public class NCarpeta
    {
        private readonly DCarpeta Carpeta = new DCarpeta();

        public string CrearCarpetaTDR(string TipoDeReporte)
        {
            return Carpeta.CrearCarpetaTDR(TipoDeReporte);
        }

        public static void CrearCarpeta(string Carpeta)
        {
            DCarpeta.CrearCarpeta(Carpeta);
        }

        public static void EliminarCarpeta(string Carpeta)
        {
            DCarpeta.EliminarCarpeta(Carpeta);
        }

        public static void MoverArchivo(string Archivo, string Destino)
        {
            DCarpeta.MoverArchivo(Archivo, Destino);
        }

        public static void EliminarArchivo(string Archivo)
        {
            DCarpeta.EliminarArchivo(Archivo);
        }
    }
}