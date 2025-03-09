using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NReadFile
    {
        private readonly DReadFile dReadFile = new DReadFile();

        public bool ReadFile(string Filter, bool MultiSelect, out List<FileName> FileName)
        {
            if (!dReadFile.ReadFile(Filter, MultiSelect, out FileName))
            {
                return false;
            }
            return true;
        }
    }
}