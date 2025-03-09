using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmReportes : Form
    {
        private int Count;
        private string Ruta;
        private string CarpetaPrincipal;
        private string CarpetaFecha;
        private string CarpetaProveedor;
        private string NDFpdf;
        private string NDFxml;
        private ProvConc Fila = null;
        public static string SenderMail;
        public static string Password;
        public static Color ColorBackColor;
        public static Color ColorForeColor;
        public static Color ColorForeColorPdf;

        public FrmReportes()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            SenderMail = "soportesystemmi@gmail.com";
            Password = "uspw ajgx emmm qgfn";
        }

        #region Private Methods
        private void ColoresBackColor()
        {
            ColorBackColor = BaalakApps.Properties.Settings.Default.ReportBackColor;
            BackColor = ColorBackColor;
            BtnNuevo.ForeColor = ColorBackColor;
            BtnTerminar.ForeColor = ColorBackColor;
            CboFormaDePago.BackColor = ColorBackColor;
            CboFormaDePago.ListBackColor = ColorBackColor;
            CboMes.BackColor = ColorBackColor;
            CboMes.ListBackColor = ColorBackColor;
            CboAño.BackColor = ColorBackColor;
            CboAño.ListBackColor = ColorBackColor;
            LblLine.BackColor = ColorBackColor;
            DgvData.AlternatingRowsDefaultCellStyle.BackColor = ColorBackColor;
            DgvData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(100, ColorBackColor);
            DgvData.BackgroundColor = ColorBackColor;
            DgvData.ColumnHeadersDefaultCellStyle.ForeColor = ColorBackColor;
            DgvData.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorBackColor;
            DgvData.DefaultCellStyle.BackColor = ColorBackColor;
            DgvData.DefaultCellStyle.SelectionBackColor = ColorBackColor;
            DgvData.RowsDefaultCellStyle.BackColor = ColorBackColor;
            DgvData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(100, ColorBackColor);
        }

        private void ColoresForeColor()
        {
            ColorForeColor = BaalakApps.Properties.Settings.Default.ReportForeColor;
            ForeColor = ColorForeColor;
            BtnNuevo.BackColor = ColorForeColor;
            BtnTerminar.BackColor = ColorForeColor;
            LblFDP.ForeColor = ColorForeColor;
            LblMes.ForeColor = ColorForeColor;
            LblAño.ForeColor = ColorForeColor;
            CboFormaDePago.ForeColor = ColorForeColor;
            CboFormaDePago.IconColor = ColorForeColor;
            CboFormaDePago.ListTextColor = ColorForeColor;
            CboMes.ForeColor = ColorForeColor;
            CboMes.IconColor = ColorForeColor;
            CboMes.ListTextColor = ColorForeColor;
            CboAño.ForeColor = ColorForeColor;
            CboAño.IconColor = ColorForeColor;
            CboAño.ListTextColor = ColorForeColor;
            Encabezado.ForeColor = ColorForeColor;
            DgvData.AlternatingRowsDefaultCellStyle.ForeColor = ColorForeColor;
            DgvData.AlternatingRowsDefaultCellStyle.SelectionForeColor = ColorForeColor;
            DgvData.ColumnHeadersDefaultCellStyle.BackColor = ColorForeColor;
            DgvData.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorForeColor;
            DgvData.DefaultCellStyle.ForeColor = ColorForeColor;
            DgvData.DefaultCellStyle.SelectionForeColor = ColorForeColor;
            DgvData.GridColor = ColorForeColor;
            DgvData.RowsDefaultCellStyle.ForeColor = ColorForeColor;
            DgvData.RowsDefaultCellStyle.SelectionForeColor = ColorForeColor;
            LblTotal.ForeColor = ColorForeColor;
            TotalSubtotal.ForeColor = ColorForeColor;
            TotalIVA.ForeColor = ColorForeColor;
            TotalTotal.ForeColor = ColorForeColor;
        }

        private void ColoresForeColorPdf()
        {
            ColorForeColorPdf = BaalakApps.Properties.Settings.Default.ReportForeColorPdf;
            LblHeader.ForeColor = ColorForeColorPdf;
            LblLineHeader.BackColor = ColorForeColorPdf;
            LblLineFooter.BackColor = ColorForeColorPdf;
            LblFooter.ForeColor = ColorForeColorPdf;
            label1.BackColor = ColorForeColorPdf;
            label2.BackColor = ColorForeColorPdf;
            label3.BackColor = ColorForeColorPdf;
            label4.BackColor = ColorForeColorPdf;
            label5.BackColor = ColorForeColorPdf;
            label6.BackColor = ColorForeColorPdf;
            label7.BackColor = ColorForeColorPdf;
            label8.ForeColor = ColorForeColorPdf;
            label9.ForeColor = ColorForeColorPdf;
            label10.ForeColor = ColorForeColorPdf;
            label11.ForeColor = ColorForeColorPdf;
        }

        private void Comprimir(string Origen, string Destino)
        {
            try
            {
                ZipFile.CreateFromDirectory(Origen, Destino);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar()
        {
            if (Fila != null)
            {
                FrmReportesFloat form = new FrmReportesFloat(Fila);
                AddOwnedForm(form);
                form.ShowDialog();
            }
        }

        public void Eliminar()
        {
            if (Fila != null)
            {
                if (MessageBox.Show("¿Desea eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NCarpeta.EliminarArchivo(NDFpdf);
                    NCarpeta.EliminarArchivo(NDFxml);
                    NCarpeta.EliminarCarpeta(CarpetaProveedor);
                    NCarpeta.EliminarCarpeta(CarpetaFecha);
                    DgvData.Rows.RemoveAt(Convert.ToInt32(Fila.Indice));
                }
            }
        }

        private bool Enlace(int IndEnl)
        {
            try
            {
                string Dia = Convert.ToDateTime(DgvData.Rows[IndEnl].Cells["Fecha"].Value).Day.ToString();
                CarpetaFecha = Ruta + @"\" + CarpetaPrincipal + @"\" + Dia;
                CarpetaProveedor = CarpetaFecha + @"\" + DgvData.Rows[IndEnl].Cells["Proveedor"].Value.ToString();
                NDFpdf = CarpetaProveedor + @"\" + DgvData.Rows[IndEnl].Cells["Factura"].Value.ToString() + ".pdf";
                if (!File.Exists(NDFpdf))
                {
                    MessageBox.Show("El documento ''" + DgvData.Rows[IndEnl].Cells["Factura"].Value.ToString() + "'' no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void EnviarReporte()
        {
            var user = new NSenderMail();
            if (user.SendMail(SenderMail,Password,new List<string>(){ "baalak.compras@gmail.com" }, Encabezado.Text, "", new List<string>() { Ruta + @"\" + Encabezado.Text + ".zip" }))
            {
                string Result = "Se ha envado el reporte a: baalak.compras@gmail.com";
                MessageBox.Show(Result, "¡Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool FileExist(string Archivo)
        {
            try
            {
                if (File.Exists(Archivo))
                {
                    if (MessageBox.Show("El archivo ''" + Archivo + "'' ya existe." + "\r\n\r\n¿Desea reemplazarlo?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NCarpeta.EliminarArchivo(Archivo);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }

        public void Guardar(ProvConc Datos, out bool Continuar)
        {
            Continuar = true;
            string Mes = Convert.ToDateTime(Datos.Fecha).ToString("MMMM", new CultureInfo("es-ES"));
            string Año = Convert.ToDateTime(Datos.Fecha).Year.ToString();
            if (Mes.ToUpper() != CboMes.Texts || Año.ToUpper() != CboAño.Texts)
            {
                MessageBox.Show("La fecha del registro no coincide con la fecha del reporte." +
                    "\r\n\r\nLa fecha del reporte actual es: ''" + CboMes.Texts + " del " + CboAño.Texts + "''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Continuar = false;
                return;
            }
            else
            {
                if (DgvData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow Row in DgvData.Rows)
                    {
                        if (Row.Cells["Factura"].Value.ToString().Trim().ToUpper() == Datos.Factura.Trim().ToUpper())
                        {
                            if (Row.Index != Convert.ToInt32(Datos.Indice))
                            {
                                MessageBox.Show("Ya existe un registro con ese numero de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Continuar = false;
                                break;
                            }
                        }
                    }
                }
                if (Continuar)
                {
                    string Dia = Convert.ToDateTime(Datos.Fecha).Day.ToString();
                    string NuevaCarpetaFecha = Ruta + @"\" + CarpetaPrincipal + @"\" + Dia;
                    string NuevaCarpetaProveedor = NuevaCarpetaFecha + @"\" + Datos.RazonSocial;
                    NCarpeta.CrearCarpeta(NuevaCarpetaFecha);
                    NCarpeta.CrearCarpeta(NuevaCarpetaProveedor);
                    if (Datos.Indice is "-1")
                    {
                        DgvData.Rows.Add(new object[]
                        {
                        Datos.Fecha,
                        Datos.Factura,
                        Datos.RazonSocial,
                        Datos.Concepto,
                        Datos.Importe,
                        Datos.IVA,
                        Datos.Total
                        });
                    }
                    else
                    {
                        NCarpeta.MoverArchivo(NDFpdf, Ruta + @"\Temp.pdf");
                        NCarpeta.MoverArchivo(NDFxml, Ruta + @"\Temp.xml");
                        NCarpeta.EliminarCarpeta(CarpetaProveedor);
                        NCarpeta.EliminarCarpeta(CarpetaFecha);
                        DataGridViewRow Row = DgvData.Rows[Convert.ToInt32(Datos.Indice)];
                        Row.Cells["Fecha"].Value = Datos.Fecha;
                        Row.Cells["Factura"].Value = Datos.Factura;
                        Row.Cells["Proveedor"].Value = Datos.RazonSocial;
                        Row.Cells["Concepto"].Value = Datos.Concepto;
                        Row.Cells["Subtotal"].Value = Datos.Importe;
                        Row.Cells["IVA"].Value = Datos.IVA;
                        Row.Cells["Total"].Value = Datos.Total;
                        SumarTotales();
                        DgvData.Sort(DgvData.Columns["Fecha"], ListSortDirection.Ascending);
                        NCarpeta.MoverArchivo(Ruta + @"\Temp.pdf", NuevaCarpetaProveedor + @"\" + Datos.Factura + ".pdf");
                        NCarpeta.MoverArchivo(Ruta + @"\Temp.xml", NuevaCarpetaProveedor + @"\" + Datos.Factura + ".xml");
                    }
                }
            }
        }

        private void OpenTarget(string Target)
        {
            try
            {
                Process.Start(Target);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                {
                    MessageBox.Show(noBrowser.Message);
                }
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SumarTotales()
        {
            try
            {
                string Texto;
                decimal SumaSubtotal = DgvData.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(Texto = x.Cells["Subtotal"].Value.ToString().Substring(1)));
                decimal SumaIVA = DgvData.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(Texto = x.Cells["IVA"].Value.ToString().Substring(1)));
                decimal SumaTotal = DgvData.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(Texto = x.Cells["Total"].Value.ToString().Substring(1)));
                TotalSubtotal.Text = new FormatoMoneda().Moneda(SumaSubtotal);
                TotalIVA.Text = new FormatoMoneda().Moneda(SumaIVA);
                TotalTotal.Text = new FormatoMoneda().Moneda(SumaTotal);
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Events
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            ColoresBackColor();
            ColoresForeColor();
            ColoresForeColorPdf();
            Entrada.Start();
            FechaYHoraActual.Enabled = true;
            DgvData.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvData.Columns["IVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvData.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            CboAño.Items.Add(DateTime.Now.Year - 1);
            CboAño.Items.Add(DateTime.Now.Year);
        }

        #region Botones
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (PSettings.Width < 270)
            {
                PanelPdfViewer.Visible = true;
                TAbrir.Start();
            }
            else
            {
                PanelPdfViewer.Visible = false;
                TCerrar.Start();
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(Location);
            if (Height == 350)
            {
                Height = scr.WorkingArea.Height;
                Location = new Point((scr.WorkingArea.Width - Width) / 2, 0);
            }
            else
            {
                Height = 350;
                Location = new Point((scr.WorkingArea.Width - Width) / 2, (scr.WorkingArea.Height - Height) / 2);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                if (MessageBox.Show("¡Aún no se ha enviado el reporte!" + "\r\n\r\n¿quieres salir sin terminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            Salida.Start();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (BtnNuevo.Text == "Nuevo Reporte")
            {
                if ((CboFormaDePago.Texts != "") && (CboMes.Texts != "") && (CboAño.Texts != ""))
                {
                    CarpetaPrincipal = "REPORTE DE GASTOS " + CboFormaDePago.Texts + " " + CboMes.Texts + " " + CboAño.Texts;
                    Ruta = new NCarpeta().CrearCarpetaTDR(CarpetaPrincipal);
                    if (Ruta != string.Empty)
                    {
                        BtnNuevo.Text = "Nuevo Registro";
                        Encabezado.Text = CarpetaPrincipal;
                        Fila = null;
                        FrmReportesFloat form = new FrmReportesFloat(Fila);
                        AddOwnedForm(form);
                        Hide();
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Falta el encabezado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Fila = null;
                FrmReportesFloat form = new FrmReportesFloat(Fila);
                AddOwnedForm(form);
                Hide();
                form.ShowDialog();
            }
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            List<ProvConc> TablaDatos = new List<ProvConc>();
            PBar.Visible = true;
            PBar.Value = 20;
            foreach (DataGridViewRow DgvRow in DgvData.Rows)
            {
                int IndEnl = DgvRow.Index;
                if (!Enlace(IndEnl))
                {
                    PBar.Value = 0;
                    PBar.Visible = false;
                    TablaDatos.Clear();
                    return;
                }
                TablaDatos.Add(new ProvConc()
                {
                    Indice = IndEnl.ToString(),
                    Fecha = DgvData.Rows[IndEnl].Cells["Fecha"].Value.ToString(),
                    Factura = DgvData.Rows[IndEnl].Cells["Factura"].Value.ToString(),
                    RazonSocial = DgvData.Rows[IndEnl].Cells["Proveedor"].Value.ToString(),
                    Concepto = DgvData.Rows[IndEnl].Cells["Concepto"].Value.ToString(),
                    Importe = DgvData.Rows[IndEnl].Cells["Subtotal"].Value.ToString(),
                    IVA = DgvData.Rows[IndEnl].Cells["IVA"].Value.ToString(),
                    Total = DgvData.Rows[IndEnl].Cells["Total"].Value.ToString()
                });
            }
            PBar.Value = 40;
            if (!FileExist(Ruta + @"\" + CarpetaPrincipal + @"\" + Encabezado.Text + ".pdf"))
            {
                Pdf Datos = new Pdf()
                {
                    Ruta = Ruta + @"\" + CarpetaPrincipal + @"\" + Encabezado.Text + ".pdf",
                    Titulo = Encabezado.Text,
                    Tabla = TablaDatos,
                    Subtotal = TotalSubtotal.Text,
                    IVA = TotalIVA.Text,
                    Total = TotalTotal.Text
                };
                string Pdf = new NPdf().CrearPdf(Datos, ColorForeColorPdf.ToHex());
                if (!string.IsNullOrEmpty(Pdf))
                {
                    PBar.Value = 60;
                    if (!FileExist(Ruta + @"\" + Encabezado.Text + ".zip"))
                    {
                        Comprimir(Ruta + @"\" + CarpetaPrincipal, Ruta + @"\" + Encabezado.Text + ".zip");
                        PBar.Value = 80;
                        OpenTarget(Pdf);
                        EnviarReporte();
                        PBar.Value = 100;
                        if (MessageBox.Show("¿Crear otro reporte?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DgvData.Rows.Clear();
                            CboFormaDePago.Texts = "";
                            CboMes.Texts = "";
                            CboAño.Texts = "";
                            LblFDP.Visible = true;
                            LblMes.Visible = true;
                            LblAño.Visible = true;
                            CboFormaDePago.Visible = true;
                            CboMes.Visible = true;
                            CboAño.Visible = true;
                            Encabezado.Visible = false;
                            BtnNuevo.Text = "Nuevo Reporte";
                        }
                        else
                        {
                            Salida.Start();
                        }
                    }
                }
            }
            PBar.Value = 0;
            PBar.Visible = false;
            TablaDatos.Clear();
        }
        #endregion

        #region DataGridViews
        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int IndEnl = e.RowIndex;
                if (IndEnl >= 0)
                {
                    if (Enlace(IndEnl))
                    {
                        OpenTarget(NDFpdf);
                    }
                }
            }
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;
            if (Indice >= 0)
            {
                Fila = new ProvConc()
                {
                    Indice = Indice.ToString(),
                    Fecha = DgvData.Rows[Indice].Cells["Fecha"].Value.ToString(),
                    Factura = DgvData.Rows[Indice].Cells["Factura"].Value.ToString(),
                    RazonSocial = DgvData.Rows[Indice].Cells["Proveedor"].Value.ToString(),
                    Concepto = DgvData.Rows[Indice].Cells["Concepto"].Value.ToString(),
                    Importe = DgvData.Rows[Indice].Cells["Subtotal"].Value.ToString(),
                    IVA = DgvData.Rows[Indice].Cells["IVA"].Value.ToString(),
                    Total = DgvData.Rows[Indice].Cells["Total"].Value.ToString()
                };
                string Dia = Convert.ToDateTime(Fila.Fecha).Day.ToString();
                CarpetaFecha = Ruta + @"\" + CarpetaPrincipal + @"\" + Dia;
                CarpetaProveedor = CarpetaFecha + @"\" + Fila.RazonSocial;
                NDFpdf = CarpetaProveedor + @"\" + Fila.Factura + ".pdf";
                NDFxml = CarpetaProveedor + @"\" + Fila.Factura + ".xml";
                FrmMensaje form = new FrmMensaje();
                AddOwnedForm(form);
                form.ShowDialog();
            }
        }

        private void DgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DgvData.Rows.Count == 1)
            {
                BtnTerminar.Visible = true;
            }
            SumarTotales();
            DgvData.Sort(DgvData.Columns["Fecha"], ListSortDirection.Ascending);
        }

        private void DgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                SumarTotales();
                DgvData.Sort(DgvData.Columns["Fecha"], ListSortDirection.Ascending);
            }
            else
            {
                BtnTerminar.Visible = false;
                TotalSubtotal.Text = "$0.00";
                TotalIVA.Text = "$0.00";
                TotalTotal.Text = "$0.00";
            }
        }
        #endregion

        #region Labels
        private void LblBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = ColorBackColor;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BaalakApps.Properties.Settings.Default.ReportBackColor = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresBackColor();
            }
        }

        private void LblForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = ColorForeColor;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BaalakApps.Properties.Settings.Default.ReportForeColor = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresForeColor();
            }
        }

        private void LblForeColorPdf_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = ColorForeColorPdf;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BaalakApps.Properties.Settings.Default.ReportForeColorPdf = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresForeColorPdf();
            }
        }

        private void Encabezado_TextChanged(object sender, EventArgs e)
        {
            LblFDP.Visible = false;
            LblMes.Visible = false;
            LblAño.Visible = false;
            CboFormaDePago.Visible = false;
            CboMes.Visible = false;
            CboAño.Visible = false;
            Encabezado.Visible = true;
        }
        #endregion

        #region Timers
        private void FechaYHoraActual_Tick(object sender, EventArgs e)
        {
            FechaYHora.Text = DateTime.Now.ToLongDateString() + "    " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void Entrada_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                Count += 1;
            }
            if (Count == 100)
            {
                Entrada.Stop();
            }
        }

        private void Salida_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                Salida.Stop();
                Close();
            }
        }

        private void TAbrir_Tick(object sender, EventArgs e)
        {
            if (PSettings.Width < 270)
            {
                PSettings.Width += 27;
            }
            else
            {
                TAbrir.Stop();
            }
        }

        private void TCerrar_Tick(object sender, EventArgs e)
        {
            if (PSettings.Width > 0)
            {
                PSettings.Width -= 27;
            }
            else
            {
                TCerrar.Stop();
            }
        }
        #endregion
        #endregion
    }
}