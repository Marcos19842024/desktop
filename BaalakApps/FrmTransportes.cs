using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmTransportes : Form
    {
        private List<Fecha> Lista;
        private int Count;

        public FrmTransportes()
        {
            InitializeComponent();
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        #region Private Methods
        private void LoadParameters()
        {
            Lista = new NClientes().ListarFechas(out bool Result);
            if (Result)
            {
                if (Lista.Count > 0)
                {
                    try
                    {
                        foreach (Fecha Dia in Lista)
                        {
                            LbFecha.Items.Add(Dia);
                        }
                        LbFecha.DisplayMember = "Dia";
                        LbClientes.DisplayMember = "Nombre";
                        LbFecha.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        T2.Start();
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos en la hoja", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    T2.Start();
                }
            }
            else
            {
                T2.Start();
            }
        }
        #endregion

        #region Events
        private void FrmLista_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            T1.Start();
            LoadParameters();            
        }        

        #region Botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            Lista.Clear();
            foreach (Fecha Fecha in LbFecha.Items)
            {
                Lista.Add(Fecha);
            }
            string Pdf = new NPdf().CrearPdf(Lista, BaalakApps.Properties.Settings.Default.ReminderForeColor.ToHex());
            if (Pdf != string.Empty)
            {
                try
                {
                    Process.Start(Pdf);
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
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (LbClientes.SelectedIndex >= 0)
            {
                ((Fecha)LbFecha.SelectedItem).Cliente.Remove((Cliente)LbClientes.SelectedItem);
                LbClientes.Items.RemoveAt(LbClientes.SelectedIndex);
                if (LbClientes.Items.Count == 0)
                {
                    LbFecha.Items.RemoveAt(LbFecha.SelectedIndex);
                    if (LbFecha.Items.Count > 0)
                    {
                        LbFecha.SelectedIndex = 0;
                    }
                }
                else
                {
                    LbClientes.SelectedIndex = 0;
                }
            }
        }
        #endregion

        #region DataGridViews
        private void DgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ((Fecha)LbFecha.SelectedItem).Cliente[LbClientes.SelectedIndex].Mascota[e.RowIndex].Asunto = DgvData.Rows[e.RowIndex].Cells["Asunto"].Value.ToString();
        }
        #endregion

        #region ComboBoxs
        private void CBFDP_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ((Fecha)LbFecha.SelectedItem).Cliente[LbClientes.SelectedIndex].Estatus = CBFDP.SelectedItem.ToString();
        }
        #endregion

        #region ListBoxs
        private void LbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbFecha.SelectedIndex >= 0)
            {
                LbClientes.Items.Clear();
                foreach (Cliente Nombre in ((Fecha)LbFecha.SelectedItem).Cliente)
                {
                    LbClientes.Items.Add(Nombre);
                }
                LbClientes.SelectedIndex = 0;
            }
        }

        private void LbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbClientes.SelectedIndex >= 0)
            {
                LblFecha.ResetText();
                LblNombreCliente.ResetText();
                LblHora.ResetText();
                DgvData.Rows.Clear();
                DgvData.Refresh();
                LblFecha.Text = ((Fecha)LbFecha.SelectedItem).Dia;
                LblNombreCliente.Text = ((Cliente)LbClientes.SelectedItem).Nombre;
                LblHora.Text = ((Cliente)LbClientes.SelectedItem).Hora;
                foreach (Mascota Mascotas in ((Cliente)LbClientes.SelectedItem).Mascota)
                {
                    DgvData.Rows.Add(new object[]
                    {
                        Mascotas.Nombre,
                        Mascotas.Raza,
                        Mascotas.Asunto
                    });
                }
                foreach (string Fdp in CBFDP.Items)
                {
                    if (Fdp == ((Cliente)LbClientes.SelectedItem).Estatus)
                    {
                        CBFDP.SelectedItem = Fdp;
                        break;
                    }
                }
                TxtCajero.Texts = ((Cliente)LbClientes.SelectedItem).Observaciones;
            }
        }
        #endregion

        #region TextBoxs
        private void TxtCajero_TextsChanged(object sender, EventArgs e)
        {
            ((Fecha)LbFecha.SelectedItem).Cliente[LbClientes.SelectedIndex].Observaciones = TxtCajero.Texts;
        }
        #endregion

        #region Timers
        private void T1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                Count += 1;
            }
            if (Count == 100)
            {
                T1.Stop();
            }
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                T2.Stop();
                Close();
            }
        }
        #endregion
        #endregion
    }
}