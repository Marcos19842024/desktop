using Entidad;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Datos
{
    public class DPdf
    {
        public string CrearPdf(List<Cliente> Enviados, List<Cliente> NoEnviados, string ColorForeColorPdf)
        {
            int TotalFilas;
            List<DateTime> Fechas = new List<DateTime>();
            if (Enviados.Count > 0)
            {
                foreach (Cliente Client in Enviados)
                {
                    Fechas.Add(Convert.ToDateTime(Client.Mascota[0].Recordatorio[0].Fecha));
                }
            }
            if (NoEnviados.Count > 0)
            {
                foreach (Cliente Client in NoEnviados)
                {
                    Fechas.Add(Convert.ToDateTime(Client.Mascota[0].Recordatorio[0].Fecha));
                }
            }
            string Pdf = CrearDocumento(
            PageSizes.Letter.Landscape(),
            Header =>
            {
                Header.Item().AlignCenter().Text(CrearTitulo("Recordatorios ", Fechas)).FontColor(ColorForeColorPdf).Bold().FontSize(14);
                Header.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Header.Spacing(10f);
            },
            Content =>
            {
                Content.Item().Row(Fila =>
                {
                    Fila.RelativeItem().Table(Tabla =>
                    {
                        Tabla.ColumnsDefinition(Column =>
                        {
                            Column.RelativeColumn();
                            Column.ConstantColumn(60);
                            Column.ConstantColumn(10);
                            Column.RelativeColumn();
                            Column.ConstantColumn(60);
                        });
                        Tabla.Header(header =>
                        {
                            header.Cell().ColumnSpan(2).Padding(2).AlignCenter().Text(Enviados.Count + " Enviados").FontColor(ColorForeColorPdf).FontSize(10);
                            header.Cell().Padding(2);
                            header.Cell().ColumnSpan(2).Padding(2).AlignCenter().Text(NoEnviados.Count + " No Enviados").FontColor(ColorForeColorPdf).FontSize(10);
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Cliente").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Teléfono").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Padding(2);
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Cliente").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Teléfono").FontSize(9).SemiBold().FontColor("#fff");
                        });
                        if (Enviados.Count >= NoEnviados.Count)
                        {
                            TotalFilas = Enviados.Count;
                        }
                        else
                        {
                            TotalFilas = NoEnviados.Count;
                        }
                        for (int i = 0; i < TotalFilas; i++)
                        {
                            if (i < Enviados.Count)
                            {
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Enviados[i].Nombre).FontColor("#000000").FontSize(8);
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Enviados[i].Telefono).FontColor("#000000").FontSize(8);
                            }
                            else
                            {
                                Tabla.Cell().Padding(2);
                                Tabla.Cell().Padding(2);
                            }
                            Tabla.Cell().Padding(2);
                            if (i < NoEnviados.Count)
                            {
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(NoEnviados[i].Nombre).FontColor("#000000").FontSize(8);
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(NoEnviados[i].Telefono).FontColor("#000000").FontSize(8);
                            }
                            else
                            {
                                Tabla.Cell().Padding(2);
                                Tabla.Cell().Padding(2);
                            }
                        }
                    });
                });
            },
            Footer =>
            {
                Footer.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Footer.Spacing(5f);
                Footer.Item().AlignRight().Text(txt =>
                {
                    txt.Span("Página ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.CurrentPageNumber().FontSize(10).FontColor(ColorForeColorPdf);
                    txt.Span(" de ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.TotalPages().FontSize(10).FontColor(ColorForeColorPdf);
                });
            },
            true,
            "Enviado el " + DateTime.Now.ToLongDateString());
            return Pdf;
        }

        public string CrearPdf(List<Cliente> Enviados, List<Cliente> NoEnviados, string ColorForeColorPdf, string Titulo)
        {
            int TotalFilas;
            string Pdf = CrearDocumento(
            PageSizes.Letter.Landscape(),
            Header =>
            {
                Header.Item().AlignCenter().Text(Titulo).FontColor(ColorForeColorPdf).Bold().FontSize(14);
                Header.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Header.Spacing(10f);
            },
            Content =>
            {
                Content.Item().Row(Fila =>
                {
                    Fila.RelativeItem().Table(Tabla =>
                    {
                        Tabla.ColumnsDefinition(Column =>
                        {
                            Column.RelativeColumn();
                            Column.ConstantColumn(60);
                            Column.ConstantColumn(10);
                            Column.RelativeColumn();
                            Column.ConstantColumn(60);
                        });
                        Tabla.Header(header =>
                        {
                            header.Cell().ColumnSpan(2).Padding(2).AlignCenter().Text(Enviados.Count + " Enviados").FontColor(ColorForeColorPdf).FontSize(10);
                            header.Cell().Padding(2);
                            header.Cell().ColumnSpan(2).Padding(2).AlignCenter().Text(NoEnviados.Count + " No Enviados").FontColor(ColorForeColorPdf).FontSize(10);
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Cliente").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Teléfono").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Padding(2);
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Cliente").FontSize(9).SemiBold().FontColor("#fff");
                            header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Teléfono").FontSize(9).SemiBold().FontColor("#fff");
                        });
                        if (Enviados.Count >= NoEnviados.Count)
                        {
                            TotalFilas = Enviados.Count;
                        }
                        else
                        {
                            TotalFilas = NoEnviados.Count;
                        }
                        for (int i = 0; i < TotalFilas; i++)
                        {
                            if (i < Enviados.Count)
                            {
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Enviados[i].Nombre).FontColor("#000000").FontSize(8);
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Enviados[i].Telefono).FontColor("#000000").FontSize(8);
                            }
                            else
                            {
                                Tabla.Cell().Padding(2);
                                Tabla.Cell().Padding(2);
                            }
                            Tabla.Cell().Padding(2);
                            if (i < NoEnviados.Count)
                            {
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(NoEnviados[i].Nombre).FontColor("#000000").FontSize(8);
                                Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(NoEnviados[i].Telefono).FontColor("#000000").FontSize(8);
                            }
                            else
                            {
                                Tabla.Cell().Padding(2);
                                Tabla.Cell().Padding(2);
                            }
                        }
                    });
                });
            },
            Footer =>
            {
                Footer.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Footer.Spacing(5f);
                Footer.Item().AlignRight().Text(txt =>
                {
                    txt.Span("Página ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.CurrentPageNumber().FontSize(10).FontColor(ColorForeColorPdf);
                    txt.Span(" de ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.TotalPages().FontSize(10).FontColor(ColorForeColorPdf);
                });
            },
            true,
            "Enviado el " + DateTime.Now.ToLongDateString());
            return Pdf;
        }

        public string CrearPdf(Pdf Datos, string ColorForeColorPdf)
        {
            string Pdf = CrearDocumento(
            PageSizes.Letter.Landscape(),
            Header =>
            {
                Header.Item().AlignCenter().Text(Datos.Titulo).FontColor(ColorForeColorPdf).Bold().FontSize(14);
                Header.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
            },
            Content =>
            {
                Content.Item().Table(Tabla =>
                {
                    Tabla.ColumnsDefinition(Column =>
                    {
                        Column.ConstantColumn(70);
                        Column.ConstantColumn(90);
                        Column.RelativeColumn();
                        Column.RelativeColumn();
                        Column.ConstantColumn(70);
                        Column.ConstantColumn(60);
                        Column.ConstantColumn(70);
                    });
                    Tabla.Header(header =>
                    {
                        header.Cell().Background(ColorForeColorPdf).Padding(2).Text("Fecha").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).Text("Factura").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).Text("Proveedor").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).Text("Concepto").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Subtotal").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("IVA").FontColor("#fff");
                        header.Cell().Background(ColorForeColorPdf).Padding(2).AlignCenter().Text("Total").FontColor("#fff");
                    });
                    foreach (ProvConc Fila in Datos.Tabla)
                    {
                        string Dia = Convert.ToDateTime(Fila.Fecha).Day.ToString();
                        string HL = (@"\" + Dia + @"\" + Fila.RazonSocial + @"\" + Fila.Factura + ".pdf").ToString();
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignLeft().Text(Fila.Fecha.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignLeft().Hyperlink(HL).Text(Fila.Factura.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignLeft().Text(Fila.RazonSocial.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignLeft().Text(Fila.Concepto.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignRight().Text(Fila.Importe.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignRight().Text(Fila.IVA.ToString()).FontSize(10);
                        Tabla.Cell().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).Padding(2).AlignRight().Text(Fila.Total.ToString()).FontSize(10);
                    }
                });
                Content.Item().Row(row =>
                {
                    row.RelativeItem().AlignRight().Text("Total: ").FontColor(ColorForeColorPdf).Bold().FontSize(11);
                    row.ConstantItem(70).ExtendHorizontal().AlignRight().Text(Datos.Subtotal).FontColor(ColorForeColorPdf).Bold().FontSize(11);
                    row.ConstantItem(60).ExtendHorizontal().AlignRight().Text(Datos.IVA).FontColor(ColorForeColorPdf).Bold().FontSize(11);
                    row.ConstantItem(70).ExtendHorizontal().AlignRight().Text(Datos.Total).FontColor(ColorForeColorPdf).Bold().FontSize(11);
                });
            },
            Footer =>
            {
                Footer.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Footer.Spacing(5f);
                Footer.Item().AlignRight().Text(txt =>
                {
                    txt.Span("Página ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.CurrentPageNumber().FontSize(10).FontColor(ColorForeColorPdf);
                    txt.Span(" de ").FontSize(10).FontColor(ColorForeColorPdf);
                    txt.TotalPages().FontSize(10).FontColor(ColorForeColorPdf);
                });
            },
            false,
            Datos.Ruta);
            return Pdf;
        }

        public string CrearPdf(List<Fecha> List, string ColorForeColorPdf)
        {
            List<DateTime> Fechas = new List<DateTime>();
            int Total = 0;
            if (List.Count > 0)
            {
                foreach (Fecha Fecha in List)
                {
                    Fechas.Add(Convert.ToDateTime(Fecha.Dia));
                    Total += Fecha.Cliente.Count;
                }
            }
            string Titulo = CrearTitulo("Lista de transportes ", Fechas);
            string Pdf = CrearDocumento(
            PageSizes.Letter.Portrait(),
            Header =>
            {
                Header.Item().AlignCenter().Text(Titulo).FontColor(ColorForeColorPdf).Bold().FontSize(14);
                Header.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
            },
            Content =>
            {
                if (List.Count > 0)
                {
                    foreach (Fecha Fecha in List)
                    {
                        Content.Spacing(10f);
                        Content.Item().AlignCenter().Text(Convert.ToDateTime(Fecha.Dia).ToLongDateString()).FontColor(ColorForeColorPdf).Bold().FontSize(12);
                        List<Cliente> Cliente = Fecha.Cliente.OrderBy(x => x.Hora).ToList();
                        foreach (Cliente Client in Cliente)
                        {
                            Content.Item().Row(Fila =>
                            {
                                Fila.ConstantItem(20).RotateLeft().BorderBottom(0.5f).BorderColor(ColorForeColorPdf).AlignCenter().Text(Client.Hora + " Hrs.").FontColor(ColorForeColorPdf).FontSize(9);
                                Fila.RelativeItem().Table(Tabla =>
                                {
                                    Tabla.ColumnsDefinition(Column =>
                                    {
                                        Column.RelativeColumn();
                                        Column.ConstantColumn(90);
                                        Column.ConstantColumn(90);
                                        Column.ConstantColumn(80);
                                        Column.ConstantColumn(80);
                                    });
                                    Tabla.Header(Header =>
                                    {
                                        Header.Cell().BorderHorizontal(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text("Cliente").FontSize(10).SemiBold();
                                        Header.Cell().BorderHorizontal(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text("Mascota").FontSize(10).SemiBold();
                                        Header.Cell().BorderHorizontal(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text("Raza").FontSize(10).SemiBold();
                                        Header.Cell().BorderHorizontal(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text("Asunto").FontSize(10).SemiBold();
                                        Header.Cell().BorderHorizontal(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text("Forma de pago").FontSize(10).SemiBold();
                                    });
                                    Tabla.ExtendLastCellsToTableBottom();
                                    Tabla.Cell().Column(1).RowSpan(Convert.ToUInt32(Client.Mascota.Count)).BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Client.Nombre).FontColor(ColorForeColorPdf).Bold().FontSize(12);
                                    for (int i = 0; i < Client.Mascota.Count; i++)
                                    {
                                        Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Client.Mascota[i].Nombre).FontColor(ColorForeColorPdf).FontSize(10);
                                        Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Client.Mascota[i].Raza).FontColor(ColorForeColorPdf).FontSize(10);
                                        Tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignLeft().Text(Client.Mascota[i].Asunto).FontColor(ColorForeColorPdf).FontSize(10);
                                        Tabla.Cell();
                                    }
                                    Tabla.Cell().Column(5).RowSpan(Convert.ToUInt32(Client.Mascota.Count)).BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).AlignCenter().Text(Client.Estatus).FontColor(ColorForeColorPdf).FontSize(10);
                                    Tabla.Footer(footer =>
                                    {
                                        footer.Cell().ColumnSpan(5).LineHorizontal(0.51f).LineColor(ColorForeColorPdf);
                                    });
                                });
                                Fila.ConstantItem(20).RotateRight().BorderBottom(0.5f).BorderColor(ColorForeColorPdf);
                            });
                        }
                    }
                }
            },
            Footer =>
            {
                Footer.Item().LineHorizontal(1f).LineColor(ColorForeColorPdf);
                Footer.Spacing(5f);
                Footer.Item().Row(Fila =>
                {
                    Fila.RelativeItem().AlignLeft().Text("Total " + Total + " Transportes").FontSize(10);
                    Fila.RelativeItem().AlignRight().Text(txt =>
                    {
                        txt.Span("Página ").FontSize(10).FontColor(ColorForeColorPdf);
                        txt.CurrentPageNumber().FontSize(10).FontColor(ColorForeColorPdf);
                        txt.Span(" de ").FontSize(10).FontColor(ColorForeColorPdf);
                        txt.TotalPages().FontSize(10).FontColor(ColorForeColorPdf);
                    });
                });
            },
            true,
            Titulo);
            return Pdf;
        }

        private string CrearTitulo(string Tipo, List<DateTime> Fechas)
        {
            string Titulo = string.Empty;
            if (Fechas.Count == 1)
            {
                Titulo += "del " + Fechas[0].Date.ToLongDateString();
            }
            else if (Fechas.Count == 2)
            {
                Fechas.OrderBy(x => x.Month).ThenBy(x => x.Day);
                Titulo += "del " + Fechas.Min().ToLongDateString() + " y " + Fechas.Max().ToLongDateString();
            }
            else
            {
                Fechas.OrderBy(x => x.Month).ThenBy(x => x.Day);
                Titulo += "del " + Fechas.Min().ToLongDateString() + " al " + Fechas.Max().ToLongDateString();
            }
            return Tipo + Titulo;
        }

        private string CrearDocumento(PageSize Orientacion, Action<ColumnDescriptor> Header, Action<ColumnDescriptor> Content, Action<ColumnDescriptor> Footer, bool DefinirRuta, string TituloDeDocumento)
        {
            string Pdf = string.Empty;
            try
            {
                var Documento = Document.Create(Container =>
                {
                    Container.Page(page =>
                    {
                        page.Margin(10);
                        page.Size(Orientacion);
                        page.Header().ShowOnce().Column(Header);
                        page.Content().PaddingVertical(5).Column(Content);
                        page.Footer().Column(Footer);
                    });
                });
                if (DefinirRuta)
                {
                    SaveFileDialog SaveAs = new SaveFileDialog
                    {
                        Title = "Guardar documento",
                        Filter = "pdf files (*.pdf)|*.pdf",
                        FileName = TituloDeDocumento,
                        DefaultExt = ".pdf",
                        AddExtension = true
                    };
                    if (SaveAs.ShowDialog() == DialogResult.OK)
                    {
                        Pdf = SaveAs.FileName;
                        Documento.GeneratePdf(Pdf);
                    }
                    SaveAs.Dispose();
                }
                else
                {
                    Pdf = TituloDeDocumento;
                    Documento.GeneratePdf(Pdf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Pdf;
        }
    }
}