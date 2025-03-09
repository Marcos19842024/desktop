using BaalakApps;
using Entidad;
using Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmRecordatorios : Form
    {        
        public ResponseServer ResponseServer { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        private readonly List<string> Adjunto = new List<string>();
        private readonly NReadFile Adjuntar = new NReadFile();
        private List<Cliente> Aprobados;
        private List<Cliente> Rechazados;
        private string MensajeOpcional;
        private int Count;
        //public string SenderMail = "baalakrecordatorios@gmail.com";//"animaliarecordatorios@gmail.com"
        //public string Password = "mnrvtcsbvqadmepv";//"kswj uvns iqen lliv
        public static Color ColorBackColor;
        public static Color ColorForeColor;
        public static Color ColorForeColorPdf;
        public string url;
        static readonly HttpClient Client = new HttpClient();

        public FrmRecordatorios()
        {
            InitializeComponent();
            //Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        #region Private Methods
        private void CargarMensajeOpcional()
        {
            int NumLine = 1;
            foreach (string Linea in TxtMensajeOpcional.Lines)
            {
                if (NumLine == 1)
                {
                    MensajeOpcional = Linea;
                    NumLine++;
                }
                else
                {
                    if (Linea == "")
                    {
                        MensajeOpcional += "\r\n";
                    }
                    else
                    {
                        MensajeOpcional += "\r\n" + Linea;
                    }
                }
            }
        }

        private void ColoresBackColor()
        {
            ColorBackColor = BaalakApps.Properties.Settings.Default.ReminderBackColor;
            BackColor = ColorBackColor;
            PanelCliente.BackColor = ColorBackColor;
            GbCliente.BackColor = ColorBackColor;
            CbClientes.BackColor = ColorBackColor;
            CbClientes.ListBackColor = ColorBackColor;
            GbTelefono.BackColor = ColorBackColor;
            LblTelefono.BackColor = ColorBackColor;
            GbMascotas.BackColor = ColorBackColor;
            LblMascotas.BackColor = ColorBackColor;
            PanelENE.BackColor = ColorBackColor;
            GbEnviados.BackColor = ColorBackColor;
            LbEnviados.BackColor = ColorBackColor;
            GbNoEnviados.BackColor = ColorBackColor;
            LbNoEnviados.BackColor = ColorBackColor;
            GbMensaje.BackColor = ColorBackColor;
            TxtMensaje.BackColor = ColorBackColor;
        }

        private void ColoresForeColor()
        {
            ColorForeColor = BaalakApps.Properties.Settings.Default.ReminderForeColor;
            ForeColor = ColorForeColor;
            PanelCliente.ForeColor = ColorForeColor;
            GbCliente.ForeColor = ColorForeColor;
            CbClientes.ForeColor = ColorForeColor;
            CbClientes.IconColor = ColorForeColor;
            CbClientes.ListTextColor = ColorForeColor;
            GbTelefono.ForeColor = ColorForeColor;
            LblTelefono.ForeColor = ColorForeColor;
            GbMascotas.ForeColor = ColorForeColor;
            LblMascotas.ForeColor = ColorForeColor;
            PanelENE.ForeColor = ColorForeColor;
            GbEnviados.ForeColor = ColorForeColor;
            LbEnviados.ForeColor = ColorForeColor;
            GbNoEnviados.ForeColor = ColorForeColor;
            LbNoEnviados.ForeColor = ColorForeColor;
            GbMensaje.ForeColor = ColorForeColor;
            TxtMensaje.ForeColor = ColorForeColor;
        }

        public async Task GetDeleteAsync(string FileName)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url + "/delete/" + FileName),
                    Method = HttpMethod.Delete
                };
                request.Headers.Add("Accept", "*/*");
                request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
                var response = await Client.SendAsync(request);
                var result = await response.Content.ReadAsStringAsync();
                ResponseServer = JsonConvert.DeserializeObject<ResponseServer>(result);
                if (!ResponseServer.Err)
                {
                    LbFileName.Items.Clear();
                    Adjunto.Clear();
                    foreach (string file in ResponseServer.StatusText)
                    {
                        Adjunto.Add(file);
                        LbFileName.Items.Add(file);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el archivo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No estas conectado al servidor.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async Task<bool> GetSendAsync()
        {
            bool Response;
            try
            {                 
                SendMessage JF = new SendMessage()
                {
                    message = TxtMensaje.Text,
                    phone = "521" + ((Cliente)CbClientes.SelectedItem).Telefono,
                    pathtofiles = Adjunto
                };
                var bodyString = JsonConvert.SerializeObject(JF);
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url + "/send/" + TxtCenter.Texts),
                    Method = HttpMethod.Post
                };
                request.Headers.Add("Accept", "*/*");
                request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
                var content = new StringContent(bodyString, Encoding.UTF8, "application/json");
                request.Content = content;
                var response = await Client.SendAsync(request);
                var result = await response.Content.ReadAsStringAsync();
                ResponseServer = JsonConvert.DeserializeObject<ResponseServer>(result);
                Response = ResponseServer.Err;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Response = true;
            }
            return Response;
        }

        public async Task GetStatusAsync()
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url + "/status/" + TxtCenter.Texts),
                    Method = HttpMethod.Get
                };
                request.Headers.Add("Accept", "*/*");
                request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
                var response = await Client.SendAsync(request);
                var result = await response.Content.ReadAsStringAsync();
                ResponseStatus = JsonConvert.DeserializeObject<ResponseStatus>(result);
                BtnConnection.Text = ResponseStatus.StatusText;
            }
            catch
            {
                MessageBox.Show("No estas conectado al servidor.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async Task GetUploadAsync(List<FileName> FileName)
        {
            try
            {
                var requestContent = new MultipartFormDataContent();
                foreach (FileName file in FileName)
                {
                    var fileStream = File.OpenRead(file.Path);
                    requestContent.Add(new StreamContent(fileStream), "files", file.Name);
                }
                var response = await Client.PostAsync(url + "/upload",requestContent);
                var result = await response.Content.ReadAsStringAsync();
                ResponseServer = JsonConvert.DeserializeObject<ResponseServer>(result);
                if (!ResponseServer.Err)
                {
                    LbFileName.Items.Clear();
                    Adjunto.Clear();
                    foreach (string file in ResponseServer.StatusText)
                    {
                        Adjunto.Add(file);
                        LbFileName.Items.Add(file);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el archivo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No estas conectado al servidor.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string ListPets()
        {
            string Pet = string.Empty;
            string DateReminder = string.Empty;
            try
            {
                List<Mascota> ListPets = ((Cliente)CbClientes.SelectedItem).Mascota;
                if (ListPets.Count == 1)
                {
                    LblMascotas.Text = ListPets[0].Nombre + ".";
                    Pet = "su mascota '" + ListPets[0].Nombre + "'," + ListReminders(0, out string Fecha);
                    DateReminder = Fecha;
                }
                else
                {
                    Pet = "sus mascotas: '";
                    for (int i = 0; i < ListPets.Count; i++)
                    {
                        if (i == 0)
                        {
                            LblMascotas.Text = ListPets[i].Nombre;
                            Pet += ListPets[i].Nombre + "'," + ListReminders(i, out string Fecha);
                            DateReminder = Fecha;
                        }
                        else
                        {
                            if (i == (ListPets.Count - 1))
                            {
                                LblMascotas.Text += " y " + ListPets[i].Nombre + ".";
                                Pet += " y '" + ListPets[i].Nombre + "'," + ListReminders(i, out string Fecha);
                                DateReminder = Fecha;
                            }
                            else
                            {
                                LblMascotas.Text += ", " + ListPets[i].Nombre;
                                Pet += ", '" + ListPets[i].Nombre + "'," + ListReminders(i, out string Fecha);
                                DateReminder = Fecha;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Pet + " el día " + DateReminder + ".";
        }

        private string ListReminders(int x, out string Fecha)
        {
            string Reminder = " tiene pendiente la aplicación de ";
            List<Recordatorio> ListReminders = ((Cliente)CbClientes.SelectedItem).Mascota[x].Recordatorio;
            try
            {
                if (ListReminders.Count == 1)
                {
                    Reminder += ListReminders[0].Tipo + " (" + ListReminders[0].Producto + ")";
                }
                else
                {
                    for (int i = 0; i < ListReminders.Count; i++)
                    {
                        if (i == 0)
                        {
                            Reminder += ListReminders[i].Tipo + " (" + ListReminders[i].Producto + ")";
                        }
                        else
                        {
                            if (i == (ListReminders.Count - 1))
                            {
                                Reminder += " y " + ListReminders[i].Tipo + " (" + ListReminders[i].Producto + ")";
                            }
                            else
                            {
                                Reminder += ", " + ListReminders[i].Tipo + " (" + ListReminders[i].Producto + ")";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Fecha = ListReminders[0].Fecha;
            return Reminder;
        }

        private void LoadList()
        {
            bool res;
            if (CheckRec.Checked)
            {
                Aprobados = new NClientes().ListarClientes1(out Rechazados, out bool Result);
                res = Result;
            }
            else
            {
                Aprobados = new NClientes().ListarClientes2(out Rechazados, out bool Result);
                res = Result;
            }
            if (res)
            {
                if (Aprobados.Count > 0 || Rechazados.Count > 0)
                {
                    try
                    {
                        if (Aprobados.Count > 0)
                        {
                            foreach (Cliente Client in Aprobados)
                            {
                                CbClientes.Items.Add(Client);
                            }
                            CbClientes.SelectedIndex = 0;
                            if (BtnConnection.Text == "Connected to " + TxtCenter.Texts)
                            {
                                BtnIniciarEnvios.Enabled = true;
                            }
                        }
                        if (Rechazados.Count > 0)
                        {
                            foreach (Cliente Client in Rechazados)
                            {
                                LbNoEnviados.Items.Add(Client);
                            }
                        }
                        int NumLine = 1;
                        foreach (string Line in BaalakApps.Properties.Settings.Default.MsjOpc)
                        {
                            if (NumLine == 1)
                            {
                                TxtMensajeOpcional.Text = Line;
                                NumLine++;
                            }
                            else
                            {
                                TxtMensajeOpcional.Text += "\r\n" + Line;
                            }
                        }
                        GbEnviados.Text = "Enviados     " + LbEnviados.Items.Count;
                        GbNoEnviados.Text = "No Enviados     " + LbNoEnviados.Items.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos en la hoja", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Mover(string Text)
        {
            if (Text == "¿Mover a No Enviados?")
            {
                if (LbEnviados.SelectedIndex >= 0)
                {
                    LbNoEnviados.Items.Add(LbEnviados.SelectedItem);
                    LbEnviados.Items.Remove(LbEnviados.SelectedItem);
                }
            }
            else
            {
                if (LbNoEnviados.SelectedIndex >= 0)
                {
                    LbEnviados.Items.Add(LbNoEnviados.SelectedItem);
                    LbNoEnviados.Items.Remove(LbNoEnviados.SelectedItem);
                }
            }
            GbEnviados.Text = "Enviados     " + LbEnviados.Items.Count;
            GbNoEnviados.Text = "No Enviados     " + LbNoEnviados.Items.Count;
        }

        public void OpenTarget(string Target)
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
        #endregion        

        #region Events
        private void FrmRecordatorios_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            ColoresBackColor();
            ColoresForeColor();
            ColorForeColorPdf = BaalakApps.Properties.Settings.Default.ReminderForeColorPdf;
            url = "http://" + BaalakApps.Properties.Settings.Default.Url;
            TxtCenter.Texts = BaalakApps.Properties.Settings.Default.Center;
            TxtIp.Texts = BaalakApps.Properties.Settings.Default.Url;
            T1Recordatorios.Start();
            CbClientes.DisplayMember = "Nombre";
            CbClientes.ValueMember = "Indice";
            LbEnviados.DisplayMember = "Nombre";
            LbEnviados.ValueMember = "Indice";
            LbNoEnviados.DisplayMember = "Nombre";
            LbNoEnviados.ValueMember = "Indice";
            LbFileName.DisplayMember = "Name";
            LbFileName.ValueMember = "Path";
            BtnIniciarEnvios.Enabled = false;
        }

        #region Botones
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (PSettings.Width < 195)
            {
                TAbrir.Start();
            }
            else
            {
                BtnTema.BackColor = Color.FromArgb(31, 31, 31);
                PanelTema.Height = 0;
                BtnMde.BackColor = Color.FromArgb(31, 31, 31);
                PanelMde.Height = 0;
                PanelSub.Visible = false;
                BtnConexion.BackColor = Color.FromArgb(31, 31, 31);
                PanelConexion.Height = 0;
                BtnType.BackColor = Color.FromArgb(31, 31, 31);
                PanelType.Height = 0;
                TCerrar.Start();
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (LbEnviados.Items.Count > 0 || LbNoEnviados.Items.Count > 0)
            {
                if (CbClientes.Items.Count > 0)
                {
                    if (MessageBox.Show("¡Aún quedan mensajes por enviar!" + "\r\n\r\n¿quieres salir sin terminar los envios?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                if (MessageBox.Show("¿Generar informe de mensajes enviados?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Pdf;
                    Aprobados.Clear();
                    Rechazados.Clear();
                    foreach (Cliente Client in LbEnviados.Items)
                    {
                        Aprobados.Add(Client);
                    }
                    foreach (Cliente Client in LbNoEnviados.Items)
                    {
                        Rechazados.Add(Client);
                    }
                    if (CheckRec.Checked)
                    {
                        Pdf = new NPdf().CrearPdf(Aprobados, Rechazados, ColorForeColorPdf.ToHex());
                    }
                    else
                    {
                        Pdf = new NPdf().CrearPdf(Aprobados, Rechazados, ColorForeColorPdf.ToHex(), "Notificaciones enviadas el día " + DateTime.Now.ToLongDateString());
                    }
                    if (Pdf != string.Empty)
                    {
                        OpenTarget(Pdf);
                    }
                }
            }
            BaalakApps.Properties.Settings.Default.MsjOpc.Clear();
            for (int i = 0; i < TxtMensajeOpcional.Lines.Length; i++)
            {
                BaalakApps.Properties.Settings.Default.MsjOpc.Add(TxtMensajeOpcional.Lines[i]);
            }
            BaalakApps.Properties.Settings.Default.Save();
            T2Recordatorios.Start();
        }

        private void BtnTema_Click(object sender, EventArgs e)
        {
            if (PanelTema.Height == 60)
            {
                PanelTema.Height = 0;
                BtnTema.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                BtnTema.BackColor = Color.FromArgb(60, 120, 160);
                PanelTema.Height = 60;
                BtnMde.BackColor = Color.FromArgb(31, 31, 31);
                PanelMde.Height = 0;
                PanelSub.Visible = false;
                BtnConexion.BackColor = Color.FromArgb(31, 31, 31);
                PanelConexion.Height = 0;
                BtnType.BackColor = Color.FromArgb(31, 31, 31);
                PanelType.Height = 0;
            }
        }

        private void BtnMde_Click(object sender, EventArgs e)
        {
            if (PanelMde.Height == 45)
            {
                PanelMde.Height = 0;
                PanelSub.Visible = false;
                BtnMde.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                BtnMde.BackColor = Color.FromArgb(60, 120, 160);
                PanelMde.Height = 45;
                PanelSub.Visible = true;
                BtnTema.BackColor = Color.FromArgb(31, 31, 31);
                PanelTema.Height = 0;
                BtnConexion.BackColor = Color.FromArgb(31, 31, 31);
                PanelConexion.Height = 0;
                BtnType.BackColor = Color.FromArgb(31, 31, 31);
                PanelType.Height = 0;
            }
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (PanelConexion.Height == 92)
            {
                PanelConexion.Height = 0;
                BtnConexion.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                BtnConexion.BackColor = Color.FromArgb(60, 120, 160);
                PanelConexion.Height = 92;
                BtnTema.BackColor = Color.FromArgb(31, 31, 31);
                PanelTema.Height = 0;
                BtnMde.BackColor = Color.FromArgb(31, 31, 31);
                PanelMde.Height = 0;
                PanelSub.Visible = false;
                BtnType.BackColor = Color.FromArgb(31, 31, 31);
                PanelType.Height = 0;
            }
        }

        private void BtnType_Click(object sender, EventArgs e)
        {
            if (PanelType.Height == 69)
            {
                PanelType.Height = 0;
                BtnType.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                BtnType.BackColor = Color.FromArgb(60, 120, 160);
                PanelType.Height = 69;
                BtnTema.BackColor = Color.FromArgb(31, 31, 31);
                PanelTema.Height = 0;
                BtnMde.BackColor = Color.FromArgb(31, 31, 31);
                PanelMde.Height = 0;
                PanelSub.Visible = false;
                BtnConexion.BackColor = Color.FromArgb(31, 31, 31);
                PanelConexion.Height = 0;
            }
        }

        private async void BtnAdjuntar_Click(object sender, EventArgs e)
        {
            if (Adjuntar.ReadFile("All files|*.*", true, out List<FileName> FileName))
            {
                await GetUploadAsync(FileName);
            }
        }

        private void BtnAdjuntar_MouseLeave(object sender, EventArgs e)
        {
            BtnAdjuntar.IconColor = Color.White;
            BtnAdjuntar.ForeColor = Color.White;
            BtnAdjuntar.BackColor = Color.FromArgb(60, 120, 160);
        }

        private void BtnAdjuntar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnAdjuntar.IconColor = Color.FromArgb(60, 120, 160);
            BtnAdjuntar.ForeColor = Color.FromArgb(60, 120, 160);
            BtnAdjuntar.BackColor = Color.White;
        }

        private async void BtnConnection_Click(object sender, EventArgs e)
        {
            if (TxtCenter.Texts != "" && TxtIp.Texts != "")
            {
                BtnConnection.Text = "Conectando...";
                await GetStatusAsync();
                if (BtnConnection.Text != "Connected to " + TxtCenter.Texts)
                {
                    Thread.Sleep(3000);
                    BtnConnection.Text = "Conectarse a WhatsApp";
                }
            }
            else
            {
                MessageBox.Show("Faltan información para conectarse al servidor.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnConnection_MouseLeave(object sender, EventArgs e)
        {
            BtnConnection.IconColor = Color.White;
            BtnConnection.ForeColor = Color.White;
            BtnConnection.BackColor = Color.FromArgb(60, 120, 160);
        }

        private void BtnConnection_MouseMove(object sender, MouseEventArgs e)
        {
            BtnConnection.IconColor = Color.FromArgb(60, 120, 160);
            BtnConnection.ForeColor = Color.FromArgb(60, 120, 160);
            BtnConnection.BackColor = Color.White;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void BtnUpload_MouseLeave(object sender, EventArgs e)
        {
            BtnUpload.IconColor = Color.White;
            BtnUpload.ForeColor = Color.White;
            BtnUpload.BackColor = Color.FromArgb(60, 120, 160);
        }

        private void BtnUpload_MouseMove(object sender, MouseEventArgs e)
        {
            BtnUpload.IconColor = Color.FromArgb(60, 120, 160);
            BtnUpload.ForeColor = Color.FromArgb(60, 120, 160);
            BtnUpload.BackColor = Color.White;
        }

        private async void BtnIniciarEnvios_Click(object sender, EventArgs e)
        {
            if (BtnConnection.Text == "Connected to " + TxtCenter.Texts)
            {
                if (TxtMensaje.Text != "")
                {
                    BtnIniciarEnvios.Enabled = false;
                    BtnIniciarEnvios.Text = "Enviando...";
                    bool Response = await GetSendAsync();
                    if (Response)
                    {
                        LbNoEnviados.Items.Add((Cliente)CbClientes.SelectedItem);
                    }
                    else
                    {
                        LbEnviados.Items.Add((Cliente)CbClientes.SelectedItem);
                    }
                    CbClientes.Items.RemoveAt(CbClientes.SelectedIndex);
                    CbClientes.Texts = "";
                    LblTelefono.ResetText();
                    LblMascotas.ResetText();
                    TxtMensaje.ResetText();
                    if (CbClientes.Items.Count > 0)
                    {
                        CbClientes.SelectedIndex = 0;
                        BtnIniciarEnvios.Enabled = true;
                    }
                    BtnIniciarEnvios.Text = "Enviar";
                    GbEnviados.Text = "Enviados     " + LbEnviados.Items.Count;
                    GbNoEnviados.Text = "No Enviados     " + LbNoEnviados.Items.Count;
                }
            }
            else
            {
                MessageBox.Show("No estas conectado al servidor.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnIniciarEnvios_MouseLeave(object sender, EventArgs e)
        {
            BtnIniciarEnvios.IconColor = Color.FromArgb(37, 211, 102);
            BtnIniciarEnvios.ForeColor = Color.FromArgb(37, 211, 102);
            BtnIniciarEnvios.BackColor = Color.Transparent;
        }

        private void BtnIniciarEnvios_MouseMove(object sender, MouseEventArgs e)
        {
            BtnIniciarEnvios.IconColor = Color.FromArgb(60, 120, 160);
            BtnIniciarEnvios.ForeColor = Color.FromArgb(60, 120, 160);
            BtnIniciarEnvios.BackColor = Color.White;
        }
        #endregion

        #region CheckBoxs
        private void IncluirMO_CheckedChanged(object sender, EventArgs e)
        {
            if (IncluirMO.Checked)
            {
                GbMensajeOpcional.Enabled = true;
            }
            else
            {
                GbMensajeOpcional.Enabled = false;
            }
            CbClientes_OnSelectedIndexChanged(null, null);
        }

        private void IncluirMO_MouseLeave(object sender, EventArgs e)
        {
            IncluirMO.ForeColor = Color.White;
        }

        private void IncluirMO_MouseMove(object sender, MouseEventArgs e)
        {
            IncluirMO.ForeColor = Color.FromArgb(60, 120, 160);
        }

        private async void CheckAdjuntar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckAdjuntar.Checked)
            {
                GbAdjuntar.Enabled = true;
                BtnAdjuntar.Enabled = true;
            }
            else
            {
                GbAdjuntar.Enabled = false;
                BtnAdjuntar.Enabled = false;
                if (Adjunto.Count > 0)
                {
                    foreach (string file in Adjunto)
                    {
                        await GetDeleteAsync(file);
                    }
                    LbFileName.Items.Clear();
                    Adjunto.Clear();
                }
            }
        }

        private void CheckAdjuntar_MouseLeave(object sender, EventArgs e)
        {
            CheckAdjuntar.ForeColor = Color.White;
        }

        private void CheckAdjuntar_MouseMove(object sender, MouseEventArgs e)
        {
            CheckAdjuntar.ForeColor = Color.FromArgb(60, 120, 160);
        }

        private void CheckRec_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckRec.Checked)
            {
                CheckNot.Checked = false;
                GbMascotas.Visible = true;
                TxtMensaje.ReadOnly = true;
                IncluirMO.Enabled = true;
            }
            else
            {   
                CheckNot.Checked = true;
                GbMascotas.Visible = false;
                TxtMensaje.ReadOnly = false;
                IncluirMO.Checked = false;
                IncluirMO.Enabled = false;
            }
            CbClientes.Items.Clear();
            CbClientes.Texts = "";
            LblTelefono.ResetText();
            LbEnviados.Items.Clear();
            LbNoEnviados.Items.Clear();
            TxtMensaje.ResetText();
            GbCliente.Text = "Cliente";
            GbEnviados.Text = "Enviados";
            GbNoEnviados.Text = "No Enviados";
            BtnIniciarEnvios.Enabled = false;
        }

        private void CheckRec_MouseLeave(object sender, EventArgs e)
        {
            CheckRec.ForeColor = Color.White;
        }

        private void CheckRec_MouseMove(object sender, MouseEventArgs e)
        {
            CheckRec.ForeColor = Color.FromArgb(60, 120, 160);
        }

        private void CheckNot_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNot.Checked)
            {
                CheckRec.Checked = false;
                GbMascotas.Visible = false;
                TxtMensaje.ReadOnly = false;
                IncluirMO.Checked = false;
                IncluirMO.Enabled = false;
            }
            else
            {
                CheckRec.Checked = true;
                GbMascotas.Visible = true;
                TxtMensaje.ReadOnly = true;
                IncluirMO.Enabled = true;
            }
            CbClientes.Items.Clear();
            CbClientes.Texts = "";
            LblTelefono.ResetText();
            LbEnviados.Items.Clear();
            LbNoEnviados.Items.Clear();
            TxtMensaje.ResetText();
            GbCliente.Text = "Cliente";
            GbEnviados.Text = "Enviados";
            GbNoEnviados.Text = "No Enviados";
            BtnIniciarEnvios.Enabled = false;
        }

        private void CheckNot_MouseLeave(object sender, EventArgs e)
        {
            CheckNot.ForeColor = Color.White;
        }

        private void CheckNot_MouseMove(object sender, MouseEventArgs e)
        {
            CheckNot.ForeColor = Color.FromArgb(60, 120, 160);
        }
        #endregion

        #region ComboBoxs
        private void CbClientes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbClientes.SelectedIndex >= 0)
            {
                try
                {
                    GbCliente.Text = "Cliente     " + (Convert.ToInt32(CbClientes.SelectedIndex) + 1) + "/" + Aprobados.Count;
                    if (CheckRec.Checked)
                    {
                        if (IncluirMO.Checked)
                        {
                            CargarMensajeOpcional();
                            TxtMensaje.Text = "¡Hola " + ((Cliente)CbClientes.SelectedItem).Nombre + "!\r\n\r\nLa Clínica Veterinaria " + TxtCenter.Texts + ", le informa que " + ListPets() + "\r\n\r\n" + MensajeOpcional;
                        }
                        else
                        {
                            TxtMensaje.Text = "¡Hola " + ((Cliente)CbClientes.SelectedItem).Nombre + "!\r\n\r\nLa Clínica Veterinaria " + TxtCenter.Texts + ", le informa que " + ListPets();
                        }
                    }
                    else
                    {
                        TxtMensaje.Text = "¡Hola " + ((Cliente)CbClientes.SelectedItem).Nombre + "!\r\n\r\n";
                    }
                    LblTelefono.Text = ((Cliente)CbClientes.SelectedItem).Telefono;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Labels
        private void LblBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = BaalakApps.Properties.Settings.Default.ReminderBackColor;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BaalakApps.Properties.Settings.Default.ReminderBackColor = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresBackColor();
            }
        }

        private void LblBackColor_MouseLeave(object sender, EventArgs e)
        {
            LblBackColor.ForeColor = Color.White;
        }

        private void LblBackColor_MouseMove(object sender, MouseEventArgs e)
        {
            LblBackColor.ForeColor = Color.FromArgb(60, 120, 160);
        }

        private void LblForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = BaalakApps.Properties.Settings.Default.ReminderForeColor;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {                
                BaalakApps.Properties.Settings.Default.ReminderForeColor = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresForeColor();
            }
        }

        private void LblForeColor_MouseLeave(object sender, EventArgs e)
        {
            LblForeColor.ForeColor = Color.White;
        }

        private void LblForeColor_MouseMove(object sender, MouseEventArgs e)
        {
            LblForeColor.ForeColor = Color.FromArgb(60, 120, 160);
        }

        private void LblForeColorPdf_Click(object sender, EventArgs e)
        {
            FrmPdf form = new FrmPdf();
            AddOwnedForm(form);
            form.ShowDialog();
        }

        private void LblForeColorPdf_MouseLeave(object sender, EventArgs e)
        {
            LblForeColorPdf.ForeColor = Color.White;
        }

        private void LblForeColorPdf_MouseMove(object sender, MouseEventArgs e)
        {
            LblForeColorPdf.ForeColor = Color.FromArgb(60, 120, 160);
        }
        #endregion

        #region LinkLabel
        private void Linkqr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTarget(url + "/qr.png");
        }
        #endregion

        #region ListBoxs
        private void LbFileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbFileName.SelectedIndex >= 0)
            {
                FrmFile form = new FrmFile(LbFileName.SelectedItem.ToString());
                AddOwnedForm(form);
                form.ShowDialog();
            }
        }

        private void LbEnviados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbEnviados.SelectedIndex >= 0)
            {
                FrmCliente form = new FrmCliente("¿Mover a No Enviados?");
                AddOwnedForm(form);
                form.ShowDialog();
            }
        }

        private void LbNoEnviados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbNoEnviados.SelectedIndex >= 0)
            {
                FrmCliente form = new FrmCliente("¿Mover a Enviados?");
                AddOwnedForm(form);
                form.ShowDialog();
            }
        }
        #endregion

        #region TextBoxs
        private void TxtCenter_TextsChanged(object sender, EventArgs e)
        {
            BaalakApps.Properties.Settings.Default.Center = TxtCenter.Texts;
            BaalakApps.Properties.Settings.Default.Save();
        }

        private void TxtIp_TextsChanged(object sender, EventArgs e)
        {
            url = "http://" + TxtIp.Texts;
            BaalakApps.Properties.Settings.Default.Url = TxtIp.Texts;
            BaalakApps.Properties.Settings.Default.Save();
        }

        //private void TxtMensaje_TextChanged(object sender, EventArgs e)
        //{
        //    int NumLine = 1;
        //    foreach (string Linea in TxtMensaje.Lines)
        //    {
        //        if (NumLine == 1)
        //        {
        //            Mensaje = Linea;
        //            NumLine++;
        //        }
        //        else
        //        {
        //            if (Linea == "")
        //            {
        //                Mensaje += "%0A";
        //            }
        //            else
        //            {
        //                Mensaje += "%0A" + Linea;
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Timers
        private void T1Recordatorios_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                Count += 1;
            }
            if (Count == 100)
            {
                T1Recordatorios.Stop();
            }
        }

        private void FechaYHoraActual_Tick(object sender, EventArgs e)
        {
            FechaYHora.Text = DateTime.Now.ToLongDateString() + "    " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void T2Recordatorios_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                T2Recordatorios.Stop();
                Close();
            }
        }

        private void TAbrir_Tick(object sender, EventArgs e)
        {
            if (PSettings.Width < 195)
            {
                PSettings.Width += 15;
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
                PSettings.Width -= 15;
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