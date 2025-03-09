using Entidad;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Datos
{
    public class DClientes
    {
        private readonly DReadFile dReadFile = new DReadFile();
        private readonly TextInfo Tcase = new CultureInfo("en-US", false).TextInfo;
        private string Dia;
        private string Hora;
        private string Client;
        private string Phone;
        private string Pet;
        private string Raza;
        private string Asunto;
        private string Reminder;
        private string Product;
        private string Date;
        private string LastDate;
        private string LastClient;
        private string LastPet;
        private string LastClientErr;

        public List<Cliente> ListarClientes1(out List<Cliente> Rechazados, out bool Result)
        {
            List<Cliente> Lista = new List<Cliente>();
            Rechazados = new List<Cliente>();
            if (dReadFile.ReadFile("Excel Workbook|*.xlsx", false, out List<FileName> FileName))
            {
                using (SLDocument Workbook = new SLDocument(FileName[0].Path))
                {
                    if (!Encabezado(Workbook, 1))
                    {
                        Result = false;
                        return Lista;
                    }
                    int IRow = 2;
                    while (!string.IsNullOrEmpty(Workbook.GetCellValueAsString(IRow, 1)))
                    {
                        Client = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 1).ToLower());
                        Phone = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 2).ToLower());
                        Pet = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 3).ToLower());
                        Reminder = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 4).ToLower());
                        Product = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 5).ToLower());
                        Date = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 6).ToLower());
                        if (ValidarNumeros(Phone, out string Telefono))
                        {
                            if (LastClient != Client)
                            {
                                Lista.Add(new Cliente()
                                {
                                    Nombre = Client,
                                    Telefono = Telefono,
                                    Mascota = new List<Mascota>
                                    {
                                        new Mascota()
                                        {
                                            Nombre = Pet,
                                            Recordatorio = new List<Recordatorio>
                                            {
                                                new Recordatorio()
                                                {
                                                    Tipo = Reminder,
                                                    Producto = Product,
                                                    Fecha = Date
                                                }
                                            }
                                        }
                                    }
                                });
                            }
                            else
                            {
                                if (LastPet != Pet)
                                {
                                    Lista.LastOrDefault().Mascota.Add(new Mascota()
                                    {
                                        Nombre = Pet,
                                        Recordatorio = new List<Recordatorio>
                                        {
                                            new Recordatorio()
                                            {
                                                Tipo = Reminder,
                                                Producto = Product,
                                                Fecha = Date
                                            }
                                        }
                                    });
                                }
                                else
                                {
                                    Lista.LastOrDefault().Mascota.LastOrDefault().Recordatorio.Add(new Recordatorio()
                                    {
                                        Tipo = Reminder,
                                        Producto = Product,
                                        Fecha = Date
                                    });
                                }
                            }
                            LastClient = Client;
                            LastPet = Pet;
                        }
                        else
                        {
                            if (LastClientErr != Client)
                            {
                                Rechazados.Add(new Cliente()
                                {
                                    Nombre = Client,
                                    Telefono = Telefono,
                                    Mascota = new List<Mascota>
                                    {
                                        new Mascota()
                                        {
                                            Nombre = Pet,
                                            Recordatorio = new List<Recordatorio>
                                            {
                                                new Recordatorio()
                                                {
                                                    Tipo = Reminder,
                                                    Producto = Product,
                                                    Fecha = Date
                                                }
                                            }
                                        }
                                    }
                                });
                                LastClientErr = Client;
                            }
                        }
                        IRow++;
                    }
                }
            }
            else
            {
                Result = false;
                return Lista;
            }
            Result = true;
            return Lista.OrderBy(x => x.Nombre).ThenBy(x => x.Mascota.OrderBy(xx => xx.Nombre).ThenBy(xx => xx.Recordatorio.OrderBy(xxx => xxx.Tipo).ThenBy(xxx => xxx.Producto).ThenBy(xxx => xxx.Fecha))).ToList();
        }

        public List<Cliente> ListarClientes2(out List<Cliente> Rechazados, out bool Result)
        {
            List<Cliente> Lista = new List<Cliente>();
            Rechazados = new List<Cliente>();
            if (dReadFile.ReadFile("Excel Workbook|*.xlsx", false, out List<FileName> FileName))
            {
                using (SLDocument Workbook = new SLDocument(FileName[0].Path))
                {
                    if (!Encabezado(Workbook, 2))
                    {
                        Result = false;
                        return Lista;
                    }
                    int IRow = 2;
                    while (!string.IsNullOrEmpty(Workbook.GetCellValueAsString(IRow, 1)))
                    {
                        Client = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 1).ToLower());
                        Phone = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 2).ToLower());
                        if (ValidarNumeros(Phone, out string Telefono))
                        {
                            if (LastClient != Client)
                            {
                                Lista.Add(new Cliente()
                                {
                                    Nombre = Client,
                                    Telefono = Telefono
                                });
                            }
                            LastClient = Client;
                            LastPet = Pet;
                        }
                        else
                        {
                            if (LastClientErr != Client)
                            {
                                Rechazados.Add(new Cliente()
                                {
                                    Nombre = Client,
                                    Telefono = Telefono
                                });
                                LastClientErr = Client;
                            }
                        }
                        IRow++;
                    }
                }
            }
            else
            {
                Result = false;
                return Lista;
            }
            Result = true;
            return Lista.OrderBy(x => x.Nombre).ToList();
        }

        public List<Fecha> ListarFechas(out bool Result)
        {
            List<Fecha> Lista = new List<Fecha>();
            if (dReadFile.ReadFile("Excel Workbook|*.xlsx", false, out List<FileName> FileName))
            {
                using (SLDocument Workbook = new SLDocument(FileName[0].Path))
                {
                    if (!Encabezado(Workbook, 3))
                    {
                        Result = false;
                        return Lista;
                    }
                    int IRow = 2;
                    int Index = 0;
                    while (!string.IsNullOrEmpty(Workbook.GetCellValueAsString(IRow, 1)))
                    {
                        Dia = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 1).ToLower());
                        Hora = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 2).ToLower());
                        Client = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 3).ToLower());
                        Pet = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 4).ToLower());
                        Raza = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 5).ToLower());
                        Asunto = Tcase.ToTitleCase(Workbook.GetCellValueAsString(IRow, 6).ToLower());
                        if (LastDate != Dia)
                        {
                            Lista.Add(new Fecha()
                            {
                                Dia = Dia,
                                Cliente = new List<Cliente>
                                {
                                    new Cliente()
                                    {
                                        Indice = Index.ToString(),
                                        Hora = Hora,
                                        Nombre = Client,
                                        Mascota = new List<Mascota>
                                        {
                                            new Mascota()
                                            {
                                                Nombre = Pet,
                                                Raza = Raza,
                                                Asunto = Asunto
                                            }
                                        }
                                    }
                                }
                            });
                        }
                        else
                        {
                            if (LastClient != Client)
                            {
                                Lista.LastOrDefault().Cliente.Add(new Cliente()
                                {
                                    Hora = Hora,
                                    Nombre = Client,
                                    Mascota = new List<Mascota>
                                    {
                                        new Mascota()
                                        {
                                            Nombre = Pet,
                                            Raza = Raza,
                                            Asunto = Asunto
                                        }
                                    }
                                });
                            }
                            else
                            {
                                if (LastPet != Pet)
                                {
                                    Lista.LastOrDefault().Cliente.LastOrDefault().Mascota.Add(new Mascota()
                                    {
                                        Nombre = Pet,
                                        Raza = Raza,
                                        Asunto = Asunto
                                    });
                                }
                                else
                                {
                                    Lista.LastOrDefault().Cliente.LastOrDefault().Mascota.LastOrDefault().Asunto += "," + Asunto;
                                }
                            }
                        }
                        LastDate = Dia;
                        LastClient = Client;
                        LastPet = Pet;
                        IRow++;
                        Index++;
                    }
                }
            }
            else
            {
                Result = false;
                return Lista;
            }
            Result = true;
            return Lista.OrderBy(x => x.Dia).ThenBy(x => x.Cliente.OrderBy(xx => xx.Hora).ThenBy(xx => xx.Nombre).ThenBy(xxx => xxx.Mascota.OrderBy(xxxx => xxxx.Nombre))).ToList();
        }

        private bool ValidarNumeros(string Celda, out string Telefono)
        {
            Telefono = string.Empty;
            if (!string.IsNullOrEmpty(Celda))
            {
                for (int i = 0; i < Celda.Length; i++)
                {
                    if (Char.IsDigit(Celda[i]))
                    {
                        Telefono += Celda[i];
                    }
                }
                if (Telefono.Length == 10)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool Encabezado(SLDocument Workbook, int Tipo)
        {
            if (Tipo == 1)
            {
                List<string> Campos = new List<string>()
                {
                    "CLIENTE", "TELÉFONO 1", "MASCOTA", "TIPO DE RECORDATORIO", "VACUNA", "PRÓXIMA FECHA"
                };
                for (int i = 1; i <= 6; i++)
                {
                    if (Workbook.GetCellValueAsString(1, i) != Campos[i - 1])
                    {
                        MessageBox.Show("La hoja no contiene los datos correctos." +
                        "\r\n\r\n" + "Debe  contener una tabla con los siguientes campos o encabezados: " +
                        "\r\n\r\n" + "CLIENTE | TELÉFONO 1 | MASCOTA | TIPO DE RECORDATORIO | VACUNA | PRÓXIMA FECHA", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            else if (Tipo == 2)
            {
                List<string> Campos = new List<string>()
                {
                    "CLIENTE", "TELÉFONO1"
                };
                for (int i = 1; i <= 2; i++)
                {
                    if (Workbook.GetCellValueAsString(1, i) != Campos[i - 1])
                    {
                        MessageBox.Show("La hoja no contiene los datos correctos." +
                        "\r\n\r\n" + "Debe  contener una tabla con los siguientes campos o encabezados: " +
                        "\r\n\r\n" + "CLIENTE | TELÉFONO1", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            else
            {
                List<string> Campos = new List<string>()
                {
                    "FECHA", "INICIO", "PROPIETARIO", "MASCOTA", "RAZA", "ASUNTO"
                };
                for (int i = 1; i <= 6; i++)
                {
                    if (Workbook.GetCellValueAsString(1, i) != Campos[i - 1])
                    {
                        MessageBox.Show("La hoja no contiene los datos correctos." +
                            "\r\n\r\n" + "Debe  contener una tabla con los siguientes campos o encabezados: " +
                            "\r\n\r\n" + "FECHA | INICIO | PROPIETARIO | MASCOTA | RAZA | ASUNTO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            ;
            return true;
        }
    }
}