using System;
using System.Windows.Forms;

namespace Negocio
{
    public class NValidaciones
    {
        public static bool ValidarNumeros(string Cadena, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return e.Handled;
                }
                if ((e.KeyChar == 46) && Cadena == "")
                {
                    e.Handled = true;
                    return e.Handled;
                }
                bool IsDec = false;
                for (int i = 0; i < Cadena.Length; i++)
                {
                    if (Cadena[i] == '.')
                        IsDec = true;
                }
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec);
                else if (e.KeyChar == 22)
                {
                    if (Clipboard.ContainsText())
                    {
                        var TextoIn = Clipboard.GetText();
                        var TextoOut = ValidarNumeros(TextoIn, IsDec);
                        if (TextoOut != "")
                        {
                            Clipboard.SetText(TextoOut);
                            e.Handled = false;
                        }
                        else
                            e.Handled = true;
                    }
                    else
                        e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            return e.Handled;
        }

        public static string ValidarNumeros(string Texto, bool IsDec)
        {
            string TextoOut = string.Empty;
            string Numeros = "0123456789";
            for (int i = 0; i < Texto.Length; i++)
            {
                string Caracter = Texto.Substring(i, 1);
                if (IsDec == false && Caracter == ".")
                {
                    TextoOut += Caracter;
                    IsDec = true;
                }
                else
                {
                    if (Numeros.IndexOf(Caracter) != -1)
                    {
                        TextoOut += Caracter;
                    }
                }
            }
            return TextoOut;
        }
    }
}