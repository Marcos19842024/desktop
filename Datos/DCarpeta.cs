using System;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public class DCarpeta
    {
        public string CrearCarpetaTDR(string TipoDeReporte)
        {
            string Ruta = string.Empty;
            try
            {
                FolderBrowserDialog Path = new FolderBrowserDialog()
                {
                    Description = "Elegir carpeta",
                    ShowNewFolderButton = true
                };
                if (Path.ShowDialog() == DialogResult.OK)
                {
                    Ruta = Path.SelectedPath;
                    CrearCarpeta(Ruta + @"\" + TipoDeReporte);
                }
                else
                {
                    MessageBox.Show("¡No se eligió ninguna carpeta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Path.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Ruta;
        }

        public static void CrearCarpeta(string Carpeta)
        {
            if (!Directory.Exists(Carpeta))
            {
                try
                {
                    Directory.CreateDirectory(Carpeta);
                }
                catch
                {
                    return;
                }
            }
        }

        public static void EliminarCarpeta(string Carpeta)
        {
            try
            {
                Directory.Delete(Carpeta);
            }
            catch
            {
                return;
            }
        }

        public static void MoverArchivo(string Archivo, string Destino)
        {
            if (File.Exists(Archivo))
            {
                try
                {
                    File.Move(Archivo, Destino);
                }
                catch
                {
                    return;
                }
            }
        }

        public static void EliminarArchivo(string Archivo)
        {
            if (File.Exists(Archivo))
            {
                try
                {
                    File.Delete(Archivo);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}