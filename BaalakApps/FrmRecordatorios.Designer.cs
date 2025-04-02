namespace Baalak_Apps
{
    partial class FrmRecordatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecordatorios));
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.FechaYHora = new System.Windows.Forms.Label();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.FechaYHoraActual = new System.Windows.Forms.Timer(this.components);
            this.T1Recordatorios = new System.Windows.Forms.Timer(this.components);
            this.T2Recordatorios = new System.Windows.Forms.Timer(this.components);
            this.LblMascotas = new System.Windows.Forms.Label();
            this.PSettings = new System.Windows.Forms.Panel();
            this.PanelType = new System.Windows.Forms.Panel();
            this.BtnUpload = new FontAwesome.Sharp.IconButton();
            this.CheckNot = new System.Windows.Forms.CheckBox();
            this.CheckRec = new System.Windows.Forms.CheckBox();
            this.BtnType = new FontAwesome.Sharp.IconButton();
            this.PanelConexion = new System.Windows.Forms.Panel();
            this.Linkqr = new System.Windows.Forms.LinkLabel();
            this.BtnConnection = new FontAwesome.Sharp.IconButton();
            this.BtnConexion = new FontAwesome.Sharp.IconButton();
            this.PanelMde = new System.Windows.Forms.Panel();
            this.IncluirMO = new System.Windows.Forms.CheckBox();
            this.CheckAdjuntar = new System.Windows.Forms.CheckBox();
            this.BtnMde = new FontAwesome.Sharp.IconButton();
            this.PanelTema = new System.Windows.Forms.Panel();
            this.LblForeColorPdf = new System.Windows.Forms.Label();
            this.LblBackColor = new System.Windows.Forms.Label();
            this.LblForeColor = new System.Windows.Forms.Label();
            this.BtnTema = new FontAwesome.Sharp.IconButton();
            this.PanelSub = new System.Windows.Forms.Panel();
            this.GbMensajeOpcional = new System.Windows.Forms.GroupBox();
            this.TxtMensajeOpcional = new System.Windows.Forms.TextBox();
            this.GbAdjuntar = new System.Windows.Forms.GroupBox();
            this.LbFileName = new System.Windows.Forms.ListBox();
            this.BtnAdjuntar = new FontAwesome.Sharp.IconButton();
            this.TAbrir = new System.Windows.Forms.Timer(this.components);
            this.TCerrar = new System.Windows.Forms.Timer(this.components);
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.CbClientes = new CustomControls.CustomComboBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.GbMensaje = new System.Windows.Forms.GroupBox();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.GbEnviados = new System.Windows.Forms.GroupBox();
            this.LbEnviados = new System.Windows.Forms.ListBox();
            this.GbNoEnviados = new System.Windows.Forms.GroupBox();
            this.LbNoEnviados = new System.Windows.Forms.ListBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.BtnIniciarEnvios = new FontAwesome.Sharp.IconButton();
            this.GbTelefono = new System.Windows.Forms.GroupBox();
            this.GbMascotas = new System.Windows.Forms.GroupBox();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.PanelENE = new System.Windows.Forms.Panel();
            this.PPrincipal.SuspendLayout();
            this.PSettings.SuspendLayout();
            this.PanelType.SuspendLayout();
            this.PanelConexion.SuspendLayout();
            this.PanelMde.SuspendLayout();
            this.PanelTema.SuspendLayout();
            this.PanelSub.SuspendLayout();
            this.GbMensajeOpcional.SuspendLayout();
            this.GbAdjuntar.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.GbMensaje.SuspendLayout();
            this.GbEnviados.SuspendLayout();
            this.GbNoEnviados.SuspendLayout();
            this.GbTelefono.SuspendLayout();
            this.GbMascotas.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.PanelENE.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PPrincipal.Controls.Add(this.BtnSettings);
            this.PPrincipal.Controls.Add(this.FechaYHora);
            this.PPrincipal.Controls.Add(this.Minimizar);
            this.PPrincipal.Controls.Add(this.BtnCerrar);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PPrincipal.ForeColor = System.Drawing.Color.White;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(782, 25);
            this.PPrincipal.TabIndex = 11;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.BtnSettings.IconColor = System.Drawing.Color.White;
            this.BtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSettings.IconSize = 15;
            this.BtnSettings.Location = new System.Drawing.Point(0, 0);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(25, 25);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // FechaYHora
            // 
            this.FechaYHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FechaYHora.Cursor = System.Windows.Forms.Cursors.Default;
            this.FechaYHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaYHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaYHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaYHora.ForeColor = System.Drawing.Color.White;
            this.FechaYHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FechaYHora.Location = new System.Drawing.Point(0, 0);
            this.FechaYHora.Name = "FechaYHora";
            this.FechaYHora.Size = new System.Drawing.Size(732, 25);
            this.FechaYHora.TabIndex = 6;
            this.FechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizar.ForeColor = System.Drawing.Color.White;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Minimizar.IconColor = System.Drawing.Color.White;
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizar.IconSize = 15;
            this.Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimizar.Location = new System.Drawing.Point(732, 0);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 7;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnCerrar.IconColor = System.Drawing.Color.White;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 15;
            this.BtnCerrar.Location = new System.Drawing.Point(757, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FechaYHoraActual
            // 
            this.FechaYHoraActual.Enabled = true;
            this.FechaYHoraActual.Tick += new System.EventHandler(this.FechaYHoraActual_Tick);
            // 
            // T1Recordatorios
            // 
            this.T1Recordatorios.Interval = 30;
            this.T1Recordatorios.Tick += new System.EventHandler(this.T1Recordatorios_Tick);
            // 
            // T2Recordatorios
            // 
            this.T2Recordatorios.Interval = 30;
            this.T2Recordatorios.Tick += new System.EventHandler(this.T2Recordatorios_Tick);
            // 
            // LblMascotas
            // 
            this.LblMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMascotas.ForeColor = System.Drawing.Color.White;
            this.LblMascotas.Location = new System.Drawing.Point(3, 18);
            this.LblMascotas.Name = "LblMascotas";
            this.LblMascotas.Size = new System.Drawing.Size(376, 24);
            this.LblMascotas.TabIndex = 22;
            this.LblMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PSettings
            // 
            this.PSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PSettings.Controls.Add(this.PanelType);
            this.PSettings.Controls.Add(this.BtnType);
            this.PSettings.Controls.Add(this.PanelConexion);
            this.PSettings.Controls.Add(this.BtnConexion);
            this.PSettings.Controls.Add(this.PanelMde);
            this.PSettings.Controls.Add(this.BtnMde);
            this.PSettings.Controls.Add(this.PanelTema);
            this.PSettings.Controls.Add(this.BtnTema);
            this.PSettings.Location = new System.Drawing.Point(0, 28);
            this.PSettings.Margin = new System.Windows.Forms.Padding(0);
            this.PSettings.Name = "PSettings";
            this.PSettings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PSettings.Size = new System.Drawing.Size(0, 304);
            this.PSettings.TabIndex = 23;
            // 
            // PanelType
            // 
            this.PanelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelType.Controls.Add(this.BtnUpload);
            this.PanelType.Controls.Add(this.CheckNot);
            this.PanelType.Controls.Add(this.CheckRec);
            this.PanelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelType.Location = new System.Drawing.Point(3, 100);
            this.PanelType.Margin = new System.Windows.Forms.Padding(0);
            this.PanelType.Name = "PanelType";
            this.PanelType.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.PanelType.Size = new System.Drawing.Size(0, 0);
            this.PanelType.TabIndex = 52;
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUpload.FlatAppearance.BorderSize = 0;
            this.BtnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.White;
            this.BtnUpload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnUpload.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.BtnUpload.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnUpload.IconSize = 20;
            this.BtnUpload.Location = new System.Drawing.Point(25, 46);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(0, 23);
            this.BtnUpload.TabIndex = 53;
            this.BtnUpload.Text = "Subir lista";
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            this.BtnUpload.MouseLeave += new System.EventHandler(this.BtnUpload_MouseLeave);
            this.BtnUpload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnUpload_MouseMove);
            // 
            // CheckNot
            // 
            this.CheckNot.BackColor = System.Drawing.Color.Transparent;
            this.CheckNot.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckNot.FlatAppearance.BorderSize = 0;
            this.CheckNot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CheckNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNot.ForeColor = System.Drawing.Color.White;
            this.CheckNot.Location = new System.Drawing.Point(25, 23);
            this.CheckNot.Margin = new System.Windows.Forms.Padding(0);
            this.CheckNot.Name = "CheckNot";
            this.CheckNot.Size = new System.Drawing.Size(0, 23);
            this.CheckNot.TabIndex = 51;
            this.CheckNot.Text = "Notificaciones";
            this.CheckNot.UseVisualStyleBackColor = false;
            this.CheckNot.CheckedChanged += new System.EventHandler(this.CheckNot_CheckedChanged);
            this.CheckNot.MouseLeave += new System.EventHandler(this.CheckNot_MouseLeave);
            this.CheckNot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckNot_MouseMove);
            // 
            // CheckRec
            // 
            this.CheckRec.BackColor = System.Drawing.Color.Transparent;
            this.CheckRec.Checked = true;
            this.CheckRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckRec.FlatAppearance.BorderSize = 0;
            this.CheckRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CheckRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRec.ForeColor = System.Drawing.Color.White;
            this.CheckRec.Location = new System.Drawing.Point(25, 0);
            this.CheckRec.Margin = new System.Windows.Forms.Padding(0);
            this.CheckRec.Name = "CheckRec";
            this.CheckRec.Size = new System.Drawing.Size(0, 23);
            this.CheckRec.TabIndex = 52;
            this.CheckRec.Text = "Recordatorios";
            this.CheckRec.UseVisualStyleBackColor = false;
            this.CheckRec.CheckedChanged += new System.EventHandler(this.CheckRec_CheckedChanged);
            this.CheckRec.MouseLeave += new System.EventHandler(this.CheckRec_MouseLeave);
            this.CheckRec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckRec_MouseMove);
            // 
            // BtnType
            // 
            this.BtnType.BackColor = System.Drawing.Color.Transparent;
            this.BtnType.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnType.FlatAppearance.BorderSize = 0;
            this.BtnType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnType.ForeColor = System.Drawing.Color.White;
            this.BtnType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnType.IconColor = System.Drawing.Color.White;
            this.BtnType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnType.IconSize = 20;
            this.BtnType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnType.Location = new System.Drawing.Point(3, 75);
            this.BtnType.Name = "BtnType";
            this.BtnType.Padding = new System.Windows.Forms.Padding(1);
            this.BtnType.Size = new System.Drawing.Size(0, 25);
            this.BtnType.TabIndex = 48;
            this.BtnType.Text = "Tipo de lista";
            this.BtnType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnType.UseVisualStyleBackColor = false;
            this.BtnType.Click += new System.EventHandler(this.BtnType_Click);
            // 
            // PanelConexion
            // 
            this.PanelConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelConexion.Controls.Add(this.Linkqr);
            this.PanelConexion.Controls.Add(this.BtnConnection);
            this.PanelConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConexion.Location = new System.Drawing.Point(3, 75);
            this.PanelConexion.Margin = new System.Windows.Forms.Padding(0);
            this.PanelConexion.Name = "PanelConexion";
            this.PanelConexion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.PanelConexion.Size = new System.Drawing.Size(0, 0);
            this.PanelConexion.TabIndex = 51;
            // 
            // Linkqr
            // 
            this.Linkqr.ActiveLinkColor = System.Drawing.Color.Lime;
            this.Linkqr.DisabledLinkColor = System.Drawing.Color.Gray;
            this.Linkqr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Linkqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linkqr.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.Linkqr.Location = new System.Drawing.Point(25, 23);
            this.Linkqr.Margin = new System.Windows.Forms.Padding(0);
            this.Linkqr.Name = "Linkqr";
            this.Linkqr.Size = new System.Drawing.Size(0, 23);
            this.Linkqr.TabIndex = 44;
            this.Linkqr.TabStop = true;
            this.Linkqr.Text = "Escanear qr";
            this.Linkqr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Linkqr.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.Linkqr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linkqr_LinkClicked);
            // 
            // BtnConnection
            // 
            this.BtnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConnection.FlatAppearance.BorderSize = 0;
            this.BtnConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnection.ForeColor = System.Drawing.Color.White;
            this.BtnConnection.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnConnection.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.BtnConnection.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnConnection.IconSize = 20;
            this.BtnConnection.Location = new System.Drawing.Point(25, 0);
            this.BtnConnection.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConnection.Name = "BtnConnection";
            this.BtnConnection.Size = new System.Drawing.Size(0, 23);
            this.BtnConnection.TabIndex = 26;
            this.BtnConnection.Text = "Conectarse a WhatsApp";
            this.BtnConnection.UseVisualStyleBackColor = false;
            this.BtnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            this.BtnConnection.MouseLeave += new System.EventHandler(this.BtnConnection_MouseLeave);
            this.BtnConnection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnConnection_MouseMove);
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackColor = System.Drawing.Color.Transparent;
            this.BtnConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConexion.FlatAppearance.BorderSize = 0;
            this.BtnConexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnConexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConexion.ForeColor = System.Drawing.Color.White;
            this.BtnConexion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnConexion.IconColor = System.Drawing.Color.White;
            this.BtnConexion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConexion.IconSize = 20;
            this.BtnConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConexion.Location = new System.Drawing.Point(3, 50);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Padding = new System.Windows.Forms.Padding(1);
            this.BtnConexion.Size = new System.Drawing.Size(0, 25);
            this.BtnConexion.TabIndex = 47;
            this.BtnConexion.Text = "Conexión";
            this.BtnConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConexion.UseVisualStyleBackColor = false;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PanelMde
            // 
            this.PanelMde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelMde.Controls.Add(this.IncluirMO);
            this.PanelMde.Controls.Add(this.CheckAdjuntar);
            this.PanelMde.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMde.Location = new System.Drawing.Point(3, 50);
            this.PanelMde.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMde.Name = "PanelMde";
            this.PanelMde.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.PanelMde.Size = new System.Drawing.Size(0, 0);
            this.PanelMde.TabIndex = 50;
            // 
            // IncluirMO
            // 
            this.IncluirMO.BackColor = System.Drawing.Color.Transparent;
            this.IncluirMO.Dock = System.Windows.Forms.DockStyle.Top;
            this.IncluirMO.FlatAppearance.BorderSize = 0;
            this.IncluirMO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.IncluirMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncluirMO.ForeColor = System.Drawing.Color.White;
            this.IncluirMO.Location = new System.Drawing.Point(25, 25);
            this.IncluirMO.Margin = new System.Windows.Forms.Padding(0);
            this.IncluirMO.Name = "IncluirMO";
            this.IncluirMO.Size = new System.Drawing.Size(0, 25);
            this.IncluirMO.TabIndex = 34;
            this.IncluirMO.Text = "Incluir msj. opcional";
            this.IncluirMO.UseVisualStyleBackColor = false;
            this.IncluirMO.CheckedChanged += new System.EventHandler(this.IncluirMO_CheckedChanged);
            this.IncluirMO.MouseLeave += new System.EventHandler(this.IncluirMO_MouseLeave);
            this.IncluirMO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IncluirMO_MouseMove);
            // 
            // CheckAdjuntar
            // 
            this.CheckAdjuntar.BackColor = System.Drawing.Color.Transparent;
            this.CheckAdjuntar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckAdjuntar.FlatAppearance.BorderSize = 0;
            this.CheckAdjuntar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CheckAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAdjuntar.ForeColor = System.Drawing.Color.White;
            this.CheckAdjuntar.Location = new System.Drawing.Point(25, 0);
            this.CheckAdjuntar.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAdjuntar.Name = "CheckAdjuntar";
            this.CheckAdjuntar.Size = new System.Drawing.Size(0, 25);
            this.CheckAdjuntar.TabIndex = 50;
            this.CheckAdjuntar.Text = "Incluir Adjunto";
            this.CheckAdjuntar.UseVisualStyleBackColor = false;
            this.CheckAdjuntar.CheckedChanged += new System.EventHandler(this.CheckAdjuntar_CheckedChanged_1);
            this.CheckAdjuntar.MouseLeave += new System.EventHandler(this.CheckAdjuntar_MouseLeave);
            this.CheckAdjuntar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckAdjuntar_MouseMove);
            // 
            // BtnMde
            // 
            this.BtnMde.BackColor = System.Drawing.Color.Transparent;
            this.BtnMde.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMde.FlatAppearance.BorderSize = 0;
            this.BtnMde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnMde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnMde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMde.ForeColor = System.Drawing.Color.White;
            this.BtnMde.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnMde.IconColor = System.Drawing.Color.White;
            this.BtnMde.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMde.IconSize = 20;
            this.BtnMde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMde.Location = new System.Drawing.Point(3, 25);
            this.BtnMde.Name = "BtnMde";
            this.BtnMde.Padding = new System.Windows.Forms.Padding(1);
            this.BtnMde.Size = new System.Drawing.Size(0, 25);
            this.BtnMde.TabIndex = 46;
            this.BtnMde.Text = "Modo de envío";
            this.BtnMde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMde.UseVisualStyleBackColor = false;
            this.BtnMde.Click += new System.EventHandler(this.BtnMde_Click);
            // 
            // PanelTema
            // 
            this.PanelTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.PanelTema.Controls.Add(this.LblForeColorPdf);
            this.PanelTema.Controls.Add(this.LblBackColor);
            this.PanelTema.Controls.Add(this.LblForeColor);
            this.PanelTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTema.Location = new System.Drawing.Point(3, 25);
            this.PanelTema.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTema.Name = "PanelTema";
            this.PanelTema.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.PanelTema.Size = new System.Drawing.Size(0, 0);
            this.PanelTema.TabIndex = 49;
            // 
            // LblForeColorPdf
            // 
            this.LblForeColorPdf.BackColor = System.Drawing.Color.Transparent;
            this.LblForeColorPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblForeColorPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblForeColorPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForeColorPdf.ForeColor = System.Drawing.Color.White;
            this.LblForeColorPdf.Location = new System.Drawing.Point(25, 40);
            this.LblForeColorPdf.Margin = new System.Windows.Forms.Padding(0);
            this.LblForeColorPdf.Name = "LblForeColorPdf";
            this.LblForeColorPdf.Size = new System.Drawing.Size(0, 20);
            this.LblForeColorPdf.TabIndex = 41;
            this.LblForeColorPdf.Text = "Color de texto Pdf";
            this.LblForeColorPdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblForeColorPdf.Click += new System.EventHandler(this.LblForeColorPdf_Click);
            this.LblForeColorPdf.MouseLeave += new System.EventHandler(this.LblForeColorPdf_MouseLeave);
            this.LblForeColorPdf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblForeColorPdf_MouseMove);
            // 
            // LblBackColor
            // 
            this.LblBackColor.BackColor = System.Drawing.Color.Transparent;
            this.LblBackColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBackColor.ForeColor = System.Drawing.Color.White;
            this.LblBackColor.Location = new System.Drawing.Point(25, 20);
            this.LblBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.LblBackColor.Name = "LblBackColor";
            this.LblBackColor.Size = new System.Drawing.Size(0, 20);
            this.LblBackColor.TabIndex = 39;
            this.LblBackColor.Text = "Color de fondo";
            this.LblBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBackColor.Click += new System.EventHandler(this.LblBackColor_Click);
            this.LblBackColor.MouseLeave += new System.EventHandler(this.LblBackColor_MouseLeave);
            this.LblBackColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblBackColor_MouseMove);
            // 
            // LblForeColor
            // 
            this.LblForeColor.BackColor = System.Drawing.Color.Transparent;
            this.LblForeColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForeColor.ForeColor = System.Drawing.Color.White;
            this.LblForeColor.Location = new System.Drawing.Point(25, 0);
            this.LblForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.LblForeColor.Name = "LblForeColor";
            this.LblForeColor.Size = new System.Drawing.Size(0, 20);
            this.LblForeColor.TabIndex = 40;
            this.LblForeColor.Text = "Color de texto";
            this.LblForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblForeColor.Click += new System.EventHandler(this.LblForeColor_Click);
            this.LblForeColor.MouseLeave += new System.EventHandler(this.LblForeColor_MouseLeave);
            this.LblForeColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblForeColor_MouseMove);
            // 
            // BtnTema
            // 
            this.BtnTema.BackColor = System.Drawing.Color.Transparent;
            this.BtnTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTema.FlatAppearance.BorderSize = 0;
            this.BtnTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTema.ForeColor = System.Drawing.Color.White;
            this.BtnTema.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnTema.IconColor = System.Drawing.Color.White;
            this.BtnTema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTema.IconSize = 20;
            this.BtnTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTema.Location = new System.Drawing.Point(3, 0);
            this.BtnTema.Name = "BtnTema";
            this.BtnTema.Padding = new System.Windows.Forms.Padding(1);
            this.BtnTema.Size = new System.Drawing.Size(0, 25);
            this.BtnTema.TabIndex = 45;
            this.BtnTema.Text = "Tema";
            this.BtnTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTema.UseVisualStyleBackColor = false;
            this.BtnTema.Click += new System.EventHandler(this.BtnTema_Click);
            // 
            // PanelSub
            // 
            this.PanelSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSub.Controls.Add(this.GbMensajeOpcional);
            this.PanelSub.Controls.Add(this.GbAdjuntar);
            this.PanelSub.Location = new System.Drawing.Point(195, 28);
            this.PanelSub.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PanelSub.Size = new System.Drawing.Size(195, 304);
            this.PanelSub.TabIndex = 53;
            this.PanelSub.Visible = false;
            // 
            // GbMensajeOpcional
            // 
            this.GbMensajeOpcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.GbMensajeOpcional.Controls.Add(this.TxtMensajeOpcional);
            this.GbMensajeOpcional.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbMensajeOpcional.Enabled = false;
            this.GbMensajeOpcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMensajeOpcional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.GbMensajeOpcional.Location = new System.Drawing.Point(3, 152);
            this.GbMensajeOpcional.Name = "GbMensajeOpcional";
            this.GbMensajeOpcional.Size = new System.Drawing.Size(185, 152);
            this.GbMensajeOpcional.TabIndex = 39;
            this.GbMensajeOpcional.TabStop = false;
            this.GbMensajeOpcional.Text = "Mensaje opcional";
            // 
            // TxtMensajeOpcional
            // 
            this.TxtMensajeOpcional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TxtMensajeOpcional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMensajeOpcional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMensajeOpcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensajeOpcional.ForeColor = System.Drawing.Color.White;
            this.TxtMensajeOpcional.Location = new System.Drawing.Point(3, 18);
            this.TxtMensajeOpcional.Multiline = true;
            this.TxtMensajeOpcional.Name = "TxtMensajeOpcional";
            this.TxtMensajeOpcional.Size = new System.Drawing.Size(179, 131);
            this.TxtMensajeOpcional.TabIndex = 23;
            this.TxtMensajeOpcional.TextChanged += new System.EventHandler(this.TxtMensajeOpcional_TextChanged);
            // 
            // GbAdjuntar
            // 
            this.GbAdjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.GbAdjuntar.Controls.Add(this.LbFileName);
            this.GbAdjuntar.Controls.Add(this.BtnAdjuntar);
            this.GbAdjuntar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbAdjuntar.Enabled = false;
            this.GbAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAdjuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.GbAdjuntar.Location = new System.Drawing.Point(3, 0);
            this.GbAdjuntar.Name = "GbAdjuntar";
            this.GbAdjuntar.Size = new System.Drawing.Size(185, 152);
            this.GbAdjuntar.TabIndex = 40;
            this.GbAdjuntar.TabStop = false;
            this.GbAdjuntar.Text = "Archivos adjuntos";
            // 
            // LbFileName
            // 
            this.LbFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LbFileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFileName.ForeColor = System.Drawing.Color.White;
            this.LbFileName.FormattingEnabled = true;
            this.LbFileName.Location = new System.Drawing.Point(3, 43);
            this.LbFileName.Name = "LbFileName";
            this.LbFileName.Size = new System.Drawing.Size(179, 121);
            this.LbFileName.Sorted = true;
            this.LbFileName.TabIndex = 1;
            this.LbFileName.SelectedIndexChanged += new System.EventHandler(this.LbFileName_SelectedIndexChanged);
            // 
            // BtnAdjuntar
            // 
            this.BtnAdjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnAdjuntar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdjuntar.FlatAppearance.BorderSize = 0;
            this.BtnAdjuntar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnAdjuntar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdjuntar.ForeColor = System.Drawing.Color.White;
            this.BtnAdjuntar.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.BtnAdjuntar.IconColor = System.Drawing.Color.White;
            this.BtnAdjuntar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdjuntar.IconSize = 18;
            this.BtnAdjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdjuntar.Location = new System.Drawing.Point(3, 18);
            this.BtnAdjuntar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdjuntar.Name = "BtnAdjuntar";
            this.BtnAdjuntar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnAdjuntar.Size = new System.Drawing.Size(179, 25);
            this.BtnAdjuntar.TabIndex = 0;
            this.BtnAdjuntar.Text = "Adjuntar archivo";
            this.BtnAdjuntar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdjuntar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdjuntar.UseVisualStyleBackColor = false;
            this.BtnAdjuntar.Click += new System.EventHandler(this.BtnAdjuntar_Click);
            this.BtnAdjuntar.MouseLeave += new System.EventHandler(this.BtnAdjuntar_MouseLeave);
            this.BtnAdjuntar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAdjuntar_MouseMove);
            // 
            // TAbrir
            // 
            this.TAbrir.Interval = 10;
            this.TAbrir.Tick += new System.EventHandler(this.TAbrir_Tick);
            // 
            // TCerrar
            // 
            this.TCerrar.Interval = 10;
            this.TCerrar.Tick += new System.EventHandler(this.TCerrar_Tick);
            // 
            // GbCliente
            // 
            this.GbCliente.BackColor = System.Drawing.Color.Transparent;
            this.GbCliente.Controls.Add(this.CbClientes);
            this.GbCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.ForeColor = System.Drawing.Color.White;
            this.GbCliente.Location = new System.Drawing.Point(0, 0);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(382, 45);
            this.GbCliente.TabIndex = 25;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
            // 
            // CbClientes
            // 
            this.CbClientes.AllowDrop = true;
            this.CbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbClientes.BackColor = System.Drawing.Color.White;
            this.CbClientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CbClientes.BorderSize = 0;
            this.CbClientes.CaracterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CbClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CbClientes.ListBackColor = System.Drawing.Color.White;
            this.CbClientes.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CbClientes.Location = new System.Drawing.Point(3, 18);
            this.CbClientes.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CbClientes.MinimumSize = new System.Drawing.Size(78, 20);
            this.CbClientes.Name = "CbClientes";
            this.CbClientes.Size = new System.Drawing.Size(376, 24);
            this.CbClientes.Sorted = false;
            this.CbClientes.TabIndex = 18;
            this.CbClientes.Texts = "";
            this.CbClientes.OnSelectedIndexChanged += new System.EventHandler(this.CbClientes_OnSelectedIndexChanged);
            // 
            // LblTelefono
            // 
            this.LblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.Color.White;
            this.LblTelefono.Location = new System.Drawing.Point(3, 18);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(376, 24);
            this.LblTelefono.TabIndex = 23;
            this.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GbMensaje
            // 
            this.GbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.GbMensaje.Controls.Add(this.TxtMensaje);
            this.GbMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMensaje.ForeColor = System.Drawing.Color.White;
            this.GbMensaje.Location = new System.Drawing.Point(0, 160);
            this.GbMensaje.Name = "GbMensaje";
            this.GbMensaje.Size = new System.Drawing.Size(782, 150);
            this.GbMensaje.TabIndex = 26;
            this.GbMensaje.TabStop = false;
            this.GbMensaje.Text = "Mensaje";
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.AcceptsReturn = true;
            this.TxtMensaje.AcceptsTab = true;
            this.TxtMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtMensaje.Location = new System.Drawing.Point(3, 18);
            this.TxtMensaje.Multiline = true;
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.ReadOnly = true;
            this.TxtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMensaje.Size = new System.Drawing.Size(776, 129);
            this.TxtMensaje.TabIndex = 28;
            // 
            // GbEnviados
            // 
            this.GbEnviados.Controls.Add(this.LbEnviados);
            this.GbEnviados.Dock = System.Windows.Forms.DockStyle.Left;
            this.GbEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEnviados.ForeColor = System.Drawing.Color.White;
            this.GbEnviados.Location = new System.Drawing.Point(0, 0);
            this.GbEnviados.Name = "GbEnviados";
            this.GbEnviados.Size = new System.Drawing.Size(200, 135);
            this.GbEnviados.TabIndex = 27;
            this.GbEnviados.TabStop = false;
            this.GbEnviados.Text = "Enviados";
            // 
            // LbEnviados
            // 
            this.LbEnviados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LbEnviados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbEnviados.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEnviados.ForeColor = System.Drawing.Color.DimGray;
            this.LbEnviados.FormattingEnabled = true;
            this.LbEnviados.Location = new System.Drawing.Point(3, 18);
            this.LbEnviados.Name = "LbEnviados";
            this.LbEnviados.Size = new System.Drawing.Size(194, 114);
            this.LbEnviados.Sorted = true;
            this.LbEnviados.TabIndex = 0;
            this.LbEnviados.SelectedIndexChanged += new System.EventHandler(this.LbEnviados_SelectedIndexChanged);
            // 
            // GbNoEnviados
            // 
            this.GbNoEnviados.Controls.Add(this.LbNoEnviados);
            this.GbNoEnviados.Dock = System.Windows.Forms.DockStyle.Left;
            this.GbNoEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNoEnviados.ForeColor = System.Drawing.Color.White;
            this.GbNoEnviados.Location = new System.Drawing.Point(200, 0);
            this.GbNoEnviados.Name = "GbNoEnviados";
            this.GbNoEnviados.Size = new System.Drawing.Size(200, 135);
            this.GbNoEnviados.TabIndex = 27;
            this.GbNoEnviados.TabStop = false;
            this.GbNoEnviados.Text = "No enviados";
            // 
            // LbNoEnviados
            // 
            this.LbNoEnviados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LbNoEnviados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbNoEnviados.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbNoEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbNoEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoEnviados.ForeColor = System.Drawing.Color.DimGray;
            this.LbNoEnviados.FormattingEnabled = true;
            this.LbNoEnviados.Location = new System.Drawing.Point(3, 18);
            this.LbNoEnviados.Name = "LbNoEnviados";
            this.LbNoEnviados.Size = new System.Drawing.Size(194, 114);
            this.LbNoEnviados.Sorted = true;
            this.LbNoEnviados.TabIndex = 1;
            this.LbNoEnviados.SelectedIndexChanged += new System.EventHandler(this.LbNoEnviados_SelectedIndexChanged);
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ColorDialog.FullOpen = true;
            // 
            // BtnIniciarEnvios
            // 
            this.BtnIniciarEnvios.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciarEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciarEnvios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarEnvios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIniciarEnvios.FlatAppearance.BorderSize = 0;
            this.BtnIniciarEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarEnvios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.BtnIniciarEnvios.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.BtnIniciarEnvios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.BtnIniciarEnvios.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BtnIniciarEnvios.IconSize = 20;
            this.BtnIniciarEnvios.Location = new System.Drawing.Point(0, 310);
            this.BtnIniciarEnvios.Name = "BtnIniciarEnvios";
            this.BtnIniciarEnvios.Size = new System.Drawing.Size(782, 25);
            this.BtnIniciarEnvios.TabIndex = 19;
            this.BtnIniciarEnvios.Text = "Enviar";
            this.BtnIniciarEnvios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciarEnvios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIniciarEnvios.UseVisualStyleBackColor = false;
            this.BtnIniciarEnvios.Click += new System.EventHandler(this.BtnIniciarEnvios_Click);
            this.BtnIniciarEnvios.MouseLeave += new System.EventHandler(this.BtnIniciarEnvios_MouseLeave);
            this.BtnIniciarEnvios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnIniciarEnvios_MouseMove);
            // 
            // GbTelefono
            // 
            this.GbTelefono.BackColor = System.Drawing.Color.Transparent;
            this.GbTelefono.Controls.Add(this.LblTelefono);
            this.GbTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTelefono.ForeColor = System.Drawing.Color.White;
            this.GbTelefono.Location = new System.Drawing.Point(0, 45);
            this.GbTelefono.Name = "GbTelefono";
            this.GbTelefono.Size = new System.Drawing.Size(382, 45);
            this.GbTelefono.TabIndex = 26;
            this.GbTelefono.TabStop = false;
            this.GbTelefono.Text = "Telefono";
            // 
            // GbMascotas
            // 
            this.GbMascotas.BackColor = System.Drawing.Color.Transparent;
            this.GbMascotas.Controls.Add(this.LblMascotas);
            this.GbMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMascotas.ForeColor = System.Drawing.Color.White;
            this.GbMascotas.Location = new System.Drawing.Point(0, 90);
            this.GbMascotas.Name = "GbMascotas";
            this.GbMascotas.Size = new System.Drawing.Size(382, 45);
            this.GbMascotas.TabIndex = 27;
            this.GbMascotas.TabStop = false;
            this.GbMascotas.Text = "Mascotas";
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.GbMascotas);
            this.PanelCliente.Controls.Add(this.GbTelefono);
            this.PanelCliente.Controls.Add(this.GbCliente);
            this.PanelCliente.Controls.Add(this.PanelENE);
            this.PanelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCliente.Location = new System.Drawing.Point(0, 25);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(782, 135);
            this.PanelCliente.TabIndex = 2;
            // 
            // PanelENE
            // 
            this.PanelENE.Controls.Add(this.GbNoEnviados);
            this.PanelENE.Controls.Add(this.GbEnviados);
            this.PanelENE.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelENE.Location = new System.Drawing.Point(382, 0);
            this.PanelENE.Name = "PanelENE";
            this.PanelENE.Size = new System.Drawing.Size(400, 135);
            this.PanelENE.TabIndex = 2;
            // 
            // FrmRecordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 335);
            this.Controls.Add(this.PanelSub);
            this.Controls.Add(this.PSettings);
            this.Controls.Add(this.BtnIniciarEnvios);
            this.Controls.Add(this.GbMensaje);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecordatorios";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRecordatorios";
            this.Load += new System.EventHandler(this.FrmRecordatorios_Load);
            this.PPrincipal.ResumeLayout(false);
            this.PSettings.ResumeLayout(false);
            this.PanelType.ResumeLayout(false);
            this.PanelConexion.ResumeLayout(false);
            this.PanelMde.ResumeLayout(false);
            this.PanelTema.ResumeLayout(false);
            this.PanelSub.ResumeLayout(false);
            this.GbMensajeOpcional.ResumeLayout(false);
            this.GbMensajeOpcional.PerformLayout();
            this.GbAdjuntar.ResumeLayout(false);
            this.GbCliente.ResumeLayout(false);
            this.GbMensaje.ResumeLayout(false);
            this.GbMensaje.PerformLayout();
            this.GbEnviados.ResumeLayout(false);
            this.GbNoEnviados.ResumeLayout(false);
            this.GbTelefono.ResumeLayout(false);
            this.GbMascotas.ResumeLayout(false);
            this.PanelCliente.ResumeLayout(false);
            this.PanelENE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PPrincipal;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private System.Windows.Forms.Label FechaYHora;
        private System.Windows.Forms.Timer FechaYHoraActual;
        private System.Windows.Forms.Timer T1Recordatorios;
        private System.Windows.Forms.Timer T2Recordatorios;
        private FontAwesome.Sharp.IconButton BtnIniciarEnvios;
        private CustomControls.CustomComboBox CbClientes;
        private System.Windows.Forms.Label LblMascotas;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.CheckBox IncluirMO;
        private System.Windows.Forms.TextBox TxtMensajeOpcional;
        private System.Windows.Forms.Timer TAbrir;
        private System.Windows.Forms.Timer TCerrar;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.GroupBox GbMensaje;
        private System.Windows.Forms.GroupBox GbEnviados;
        private System.Windows.Forms.ListBox LbEnviados;
        private System.Windows.Forms.GroupBox GbNoEnviados;
        private System.Windows.Forms.ListBox LbNoEnviados;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.GroupBox GbMensajeOpcional;
        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label LblBackColor;
        private System.Windows.Forms.Label LblForeColor;
        private System.Windows.Forms.Label LblForeColorPdf;
        private System.Windows.Forms.GroupBox GbTelefono;
        private System.Windows.Forms.GroupBox GbMascotas;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.Panel PanelENE;
        private FontAwesome.Sharp.IconButton BtnAdjuntar;
        private System.Windows.Forms.GroupBox GbAdjuntar;
        private System.Windows.Forms.ListBox LbFileName;
        private System.Windows.Forms.CheckBox CheckAdjuntar;
        private FontAwesome.Sharp.IconButton BtnConnection;
        private FontAwesome.Sharp.IconButton BtnUpload;
        private System.Windows.Forms.CheckBox CheckNot;
        private System.Windows.Forms.CheckBox CheckRec;
        private System.Windows.Forms.LinkLabel Linkqr;
        private FontAwesome.Sharp.IconButton BtnTema;
        private FontAwesome.Sharp.IconButton BtnType;
        private FontAwesome.Sharp.IconButton BtnConexion;
        private FontAwesome.Sharp.IconButton BtnMde;
        private System.Windows.Forms.Panel PanelTema;
        private System.Windows.Forms.Panel PanelMde;
        private System.Windows.Forms.Panel PanelConexion;
        private System.Windows.Forms.Panel PanelType;
        private System.Windows.Forms.Panel PanelSub;
    }
}