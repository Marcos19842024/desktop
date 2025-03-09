using Entidad;
using Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmReportesFloat : Form
    {
        private static decimal Importe = 0;
        private readonly ProvConc Obj = null;
        bool Controlado;

        public FrmReportesFloat(ProvConc Fila)
        {
            if (Fila != null)
            {
                Obj = Fila;
            }
            InitializeComponent();
        }        

        #region Private Methods
        private void CargarCombos()
        {
            CboProveedor.Items.Clear();
            CboConcepto.Items.Clear();
            foreach (string item in BaalakApps.Properties.Settings.Default.Proveedores)
            {
                CboProveedor.Items.Add(item);
            }
            CboProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboProveedor.Texts = "";
            foreach (string item in BaalakApps.Properties.Settings.Default.Conceptos)
            {
                CboConcepto.Items.Add(item);
            }
            CboConcepto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboConcepto.AutoCompleteSource = AutoCompleteSource.ListItems;
            CboConcepto.Texts = "";
        }

        private void GuardarProvConc()
        {
            try
            {
                BaalakApps.Properties.Settings.Default.Proveedores.Clear();
                BaalakApps.Properties.Settings.Default.Conceptos.Clear();
                foreach (string item in CboProveedor.Items)
                {
                    BaalakApps.Properties.Settings.Default.Proveedores.Add(item);
                }
                foreach (string item in CboConcepto.Items)
                {
                    BaalakApps.Properties.Settings.Default.Conceptos.Add(item);
                }
                BaalakApps.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Limpiar()
        {
            LblIndice.Text = "-1";
            DtpFecha.Text = "";
            TxtFactura.Texts = "";
            CboProveedor.Texts = "";
            CboConcepto.Texts = "";
            TxtSubtotal.Texts = "";
            TxtDescuento.Texts = "";
            TxtIVA.Texts = "";
            TxtTotal.Text = "";
            Importe = 0;
        }

        private void Presentar()
        {
            try
            {
                LblIndice.Text = Obj.Indice;
                DtpFecha.Text = Obj.Fecha;
                TxtFactura.Texts = Obj.Factura;
                TxtSubtotal.Texts = NValidaciones.ValidarNumeros(Obj.Importe, false);
                TxtIVA.Texts = NValidaciones.ValidarNumeros(Obj.IVA, false);
                TxtTotal.Text = NValidaciones.ValidarNumeros(Obj.Total, false);
                foreach (string Proveedor in CboProveedor.Items)
                {
                    if (Proveedor == Obj.RazonSocial)
                    {
                        CboProveedor.SelectedItem = Proveedor;
                        break;
                    }
                }
                foreach (string Concepto in CboConcepto.Items)
                {
                    if (Concepto == Obj.Concepto)
                    {
                        CboConcepto.SelectedItem = Concepto;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Sumar()
        {
            try
            {
                decimal iva = 0;
                if (TxtSubtotal.Texts != "")
                {
                    Importe = Convert.ToDecimal(TxtSubtotal.Texts);
                }
                if (TxtDescuento.Texts != "")
                {
                    Importe -= Convert.ToDecimal(TxtDescuento.Texts);
                }
                if (TxtIVA.Texts != "")
                {
                    iva = Convert.ToDecimal(TxtIVA.Texts);
                }
                if (TxtSubtotal.Texts == "" && TxtDescuento.Texts == "" && TxtIVA.Texts == "")
                {
                    TxtTotal.Text = "";
                }
                else
                {
                    TxtTotal.Text = (Importe + iva).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        private void FrmReportesFloat_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(Location);
            Location = new Point(scr.WorkingArea.Right - Width, scr.WorkingArea.Height - Height);
            CargarCombos();
            if (Obj != null)
            {
                Presentar();
            }
        }

        #region Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            GuardarProvConc();
            FrmReportes form = Owner as FrmReportes;
            form.Show();
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEliminarProv_Click(object sender, EventArgs e)
        {
            if (CboProveedor.Texts != "")
            {
                CboProveedor.Items.Remove(CboProveedor.SelectedItem);
                CboProveedor.Texts = "";
            }
        }

        private void BtnEliminarConc_Click(object sender, EventArgs e)
        {
            if (CboConcepto.Texts != "")
            {
                CboConcepto.Items.Remove(CboConcepto.SelectedItem);
                CboConcepto.Texts = "";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtFactura.Texts != "" && CboProveedor.Texts != "" && CboConcepto.Texts != "" && TxtSubtotal.Texts != "")
            {
                string TxtI;
                if (TxtIVA.Texts == "")
                {
                    TxtI = new FormatoMoneda().Moneda(0);
                }
                else
                {
                    TxtI = new FormatoMoneda().Moneda(Convert.ToDecimal(TxtIVA.Texts));
                }
                string TxtSt = new FormatoMoneda().Moneda(Importe);
                string TxtT = new FormatoMoneda().Moneda(Convert.ToDecimal(TxtTotal.Text));
                ProvConc Registro = new ProvConc()
                {
                    Indice = LblIndice.Text,
                    Fecha = DtpFecha.Text,
                    Factura = TxtFactura.Texts,
                    RazonSocial = CboProveedor.Texts,
                    Concepto = CboConcepto.Texts,
                    Importe = TxtSt,
                    IVA = TxtI,
                    Total = TxtT
                };
                FrmReportes form = Owner as FrmReportes;
                form.Guardar(Registro, out bool Continuar);
                if (Continuar)
                {
                    if (CboProveedor.SelectedIndex == -1)
                    {
                        CboProveedor.Items.Add(CboProveedor.Texts);
                    }
                    if (CboConcepto.SelectedIndex == -1)
                    {
                        CboConcepto.Items.Add(CboConcepto.Texts);
                    }
                    if (Convert.ToInt32(Registro.Indice) != -1)
                    {
                        GuardarProvConc();
                        form.Show();
                        Limpiar();
                        Close();
                    }
                    else
                    {
                        GuardarProvConc();
                        Limpiar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TextBoxs
        private void TxtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlado = NValidaciones.ValidarNumeros(TxtSubtotal.Texts, e);
        }

        private void TxtSubtotal_TextsChanged(object sender, EventArgs e)
        {
            if (Controlado)
            {
                TxtSubtotal.Texts = NValidaciones.ValidarNumeros(TxtSubtotal.Texts, false);
            }
            Controlado = true;
            Sumar();
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlado = NValidaciones.ValidarNumeros(TxtDescuento.Texts, e);
        }

        private void TxtDescuento_TextsChanged(object sender, EventArgs e)
        {
            if (Controlado)
            {
                TxtDescuento.Texts = NValidaciones.ValidarNumeros(TxtDescuento.Texts, false);
            }
            Controlado = true;
            Sumar();
        }

        private void TxtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlado = NValidaciones.ValidarNumeros(TxtIVA.Texts, e);
        }

        private void TxtIVA_TextsChanged(object sender, EventArgs e)
        {
            if (Controlado)
            {
                TxtIVA.Texts = NValidaciones.ValidarNumeros(TxtIVA.Texts, false);
            }
            Controlado = true;
            Sumar();
        }
        #endregion
        #endregion
    }
}