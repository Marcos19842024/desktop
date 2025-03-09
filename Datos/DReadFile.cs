using Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datos
{
    public class DReadFile
    {
        public bool ReadFile(string Filter, bool MultiSelect, out List<FileName> FileName)
        {
            using (OpenFileDialog OFD = new OpenFileDialog(){ Filter = Filter, Multiselect = MultiSelect })
            {
                FileName = new List<FileName>();
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int i = 0;
                        foreach (string File in OFD.FileNames)
                        {
                            FileName.Add(new FileName()
                            {
                                Path = File,
                            });
                        }
                        foreach (string File in OFD.SafeFileNames)
                        {
                            FileName[i].Name = File;
                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("¡No se eligió nungún documento!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }
    }
}