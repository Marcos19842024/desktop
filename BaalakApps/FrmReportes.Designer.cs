namespace Baalak_Apps
{
    partial class FrmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.PanelTotales = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TotalSubtotal = new System.Windows.Forms.Label();
            this.TotalIVA = new System.Windows.Forms.Label();
            this.TotalTotal = new System.Windows.Forms.Label();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelUsuarioActivo = new System.Windows.Forms.Panel();
            this.BtnSettings = new FontAwesome.Sharp.IconButton();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.Restaurar = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.FechaYHora = new System.Windows.Forms.Label();
            this.FechaYHoraActual = new System.Windows.Forms.Timer(this.components);
            this.Entrada = new System.Windows.Forms.Timer(this.components);
            this.Salida = new System.Windows.Forms.Timer(this.components);
            this.LblFDP = new System.Windows.Forms.Label();
            this.LblMes = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.CboAño = new CustomControls.CustomComboBox();
            this.CboMes = new CustomControls.CustomComboBox();
            this.CboFormaDePago = new CustomControls.CustomComboBox();
            this.LblLine = new System.Windows.Forms.Label();
            this.BtnTerminar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.Encabezado = new System.Windows.Forms.Label();
            this.TAbrir = new System.Windows.Forms.Timer(this.components);
            this.TCerrar = new System.Windows.Forms.Timer(this.components);
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.PSettings = new System.Windows.Forms.Panel();
            this.GbTema = new System.Windows.Forms.GroupBox();
            this.LblForeColor = new System.Windows.Forms.Label();
            this.LblForeColorPdf = new System.Windows.Forms.Label();
            this.LblBackColor = new System.Windows.Forms.Label();
            this.PanelPdfViewer = new System.Windows.Forms.Panel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCampo1 = new System.Windows.Forms.Label();
            this.LblCampo2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblLineFooter = new System.Windows.Forms.Label();
            this.LblFooter = new System.Windows.Forms.Label();
            this.LblSpace = new System.Windows.Forms.Label();
            this.LblLineHeader = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.PanelTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.PanelUsuarioActivo.SuspendLayout();
            this.PanelEncabezado.SuspendLayout();
            this.PSettings.SuspendLayout();
            this.GbTema.SuspendLayout();
            this.PanelPdfViewer.SuspendLayout();
            this.FLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTotales
            // 
            this.PanelTotales.BackColor = System.Drawing.Color.Transparent;
            this.PanelTotales.Controls.Add(this.LblTotal);
            this.PanelTotales.Controls.Add(this.TotalSubtotal);
            this.PanelTotales.Controls.Add(this.TotalIVA);
            this.PanelTotales.Controls.Add(this.TotalTotal);
            this.PanelTotales.Controls.Add(this.PBar);
            this.PanelTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelTotales.Location = new System.Drawing.Point(0, 335);
            this.PanelTotales.Name = "PanelTotales";
            this.PanelTotales.Size = new System.Drawing.Size(770, 15);
            this.PanelTotales.TabIndex = 7;
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblTotal.Location = new System.Drawing.Point(700, 0);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(49, 15);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "Total:";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSubtotal
            // 
            this.TotalSubtotal.AutoSize = true;
            this.TotalSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.TotalSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalSubtotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalSubtotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TotalSubtotal.Location = new System.Drawing.Point(749, 0);
            this.TotalSubtotal.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.TotalSubtotal.Name = "TotalSubtotal";
            this.TotalSubtotal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TotalSubtotal.Size = new System.Drawing.Size(7, 15);
            this.TotalSubtotal.TabIndex = 9;
            this.TotalSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalIVA
            // 
            this.TotalIVA.AutoSize = true;
            this.TotalIVA.BackColor = System.Drawing.Color.Transparent;
            this.TotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalIVA.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalIVA.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalIVA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TotalIVA.Location = new System.Drawing.Point(756, 0);
            this.TotalIVA.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TotalIVA.Name = "TotalIVA";
            this.TotalIVA.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TotalIVA.Size = new System.Drawing.Size(7, 15);
            this.TotalIVA.TabIndex = 11;
            this.TotalIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalTotal
            // 
            this.TotalTotal.AutoSize = true;
            this.TotalTotal.BackColor = System.Drawing.Color.Transparent;
            this.TotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TotalTotal.Location = new System.Drawing.Point(763, 0);
            this.TotalTotal.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.TotalTotal.Name = "TotalTotal";
            this.TotalTotal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TotalTotal.Size = new System.Drawing.Size(7, 15);
            this.TotalTotal.TabIndex = 10;
            this.TotalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PBar
            // 
            this.PBar.BackColor = System.Drawing.Color.Black;
            this.PBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PBar.Location = new System.Drawing.Point(0, 0);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(770, 15);
            this.PBar.TabIndex = 12;
            this.PBar.Visible = false;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Factura,
            this.Proveedor,
            this.Concepto,
            this.Subtotal,
            this.IVA,
            this.Total});
            this.DgvData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.DgvData.Location = new System.Drawing.Point(0, 95);
            this.DgvData.Margin = new System.Windows.Forms.Padding(1);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.ShowEditingIcon = false;
            this.DgvData.Size = new System.Drawing.Size(770, 240);
            this.DgvData.TabIndex = 6;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.DgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellDoubleClick);
            this.DgvData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvData_RowsAdded);
            this.DgvData.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvData_RowsRemoved);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Fecha.Width = 73;
            // 
            // Factura
            // 
            this.Factura.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Factura.DefaultCellStyle = dataGridViewCellStyle3;
            this.Factura.HeaderText = "Factura";
            this.Factura.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Factura.LinkColor = System.Drawing.Color.Blue;
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Factura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Factura.TrackVisitedState = false;
            this.Factura.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Factura.Width = 82;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Proveedor.Width = 99;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Concepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Concepto.Width = 94;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Subtotal.Width = 87;
            // 
            // IVA
            // 
            dataGridViewCellStyle5.NullValue = null;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle5;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IVA.Width = 54;
            // 
            // Total
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Total.Width = 66;
            // 
            // PanelUsuarioActivo
            // 
            this.PanelUsuarioActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelUsuarioActivo.Controls.Add(this.BtnSettings);
            this.PanelUsuarioActivo.Controls.Add(this.Minimizar);
            this.PanelUsuarioActivo.Controls.Add(this.Restaurar);
            this.PanelUsuarioActivo.Controls.Add(this.BtnCerrar);
            this.PanelUsuarioActivo.Controls.Add(this.FechaYHora);
            this.PanelUsuarioActivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUsuarioActivo.ForeColor = System.Drawing.Color.White;
            this.PanelUsuarioActivo.Location = new System.Drawing.Point(0, 0);
            this.PanelUsuarioActivo.Name = "PanelUsuarioActivo";
            this.PanelUsuarioActivo.Size = new System.Drawing.Size(770, 25);
            this.PanelUsuarioActivo.TabIndex = 8;
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
            this.BtnSettings.TabIndex = 9;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
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
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Minimizar.IconSize = 15;
            this.Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimizar.Location = new System.Drawing.Point(695, 0);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Restaurar.FlatAppearance.BorderSize = 0;
            this.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurar.ForeColor = System.Drawing.Color.White;
            this.Restaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.Restaurar.IconColor = System.Drawing.Color.White;
            this.Restaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Restaurar.IconSize = 15;
            this.Restaurar.Location = new System.Drawing.Point(720, 0);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(0);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.TabIndex = 4;
            this.Restaurar.UseVisualStyleBackColor = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
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
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCerrar.IconSize = 15;
            this.BtnCerrar.Location = new System.Drawing.Point(745, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.FechaYHora.Size = new System.Drawing.Size(770, 25);
            this.FechaYHora.TabIndex = 6;
            this.FechaYHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaYHoraActual
            // 
            this.FechaYHoraActual.Enabled = true;
            this.FechaYHoraActual.Tick += new System.EventHandler(this.FechaYHoraActual_Tick);
            // 
            // Entrada
            // 
            this.Entrada.Interval = 30;
            this.Entrada.Tick += new System.EventHandler(this.Entrada_Tick);
            // 
            // Salida
            // 
            this.Salida.Interval = 30;
            this.Salida.Tick += new System.EventHandler(this.Salida_Tick);
            // 
            // LblFDP
            // 
            this.LblFDP.BackColor = System.Drawing.Color.Transparent;
            this.LblFDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblFDP.Location = new System.Drawing.Point(181, 7);
            this.LblFDP.Margin = new System.Windows.Forms.Padding(0);
            this.LblFDP.Name = "LblFDP";
            this.LblFDP.Size = new System.Drawing.Size(175, 23);
            this.LblFDP.TabIndex = 9;
            this.LblFDP.Text = "Forma de pago";
            this.LblFDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMes
            // 
            this.LblMes.BackColor = System.Drawing.Color.Transparent;
            this.LblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblMes.Location = new System.Drawing.Point(356, 7);
            this.LblMes.Margin = new System.Windows.Forms.Padding(0);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(130, 23);
            this.LblMes.TabIndex = 10;
            this.LblMes.Text = "Mes";
            this.LblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAño
            // 
            this.LblAño.BackColor = System.Drawing.Color.Transparent;
            this.LblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblAño.Location = new System.Drawing.Point(486, 7);
            this.LblAño.Margin = new System.Windows.Forms.Padding(0);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(100, 23);
            this.LblAño.TabIndex = 11;
            this.LblAño.Text = "Año";
            this.LblAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.PanelEncabezado.Controls.Add(this.CboAño);
            this.PanelEncabezado.Controls.Add(this.CboMes);
            this.PanelEncabezado.Controls.Add(this.CboFormaDePago);
            this.PanelEncabezado.Controls.Add(this.LblLine);
            this.PanelEncabezado.Controls.Add(this.BtnTerminar);
            this.PanelEncabezado.Controls.Add(this.LblFDP);
            this.PanelEncabezado.Controls.Add(this.BtnNuevo);
            this.PanelEncabezado.Controls.Add(this.LblAño);
            this.PanelEncabezado.Controls.Add(this.LblMes);
            this.PanelEncabezado.Controls.Add(this.Encabezado);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PanelEncabezado.Location = new System.Drawing.Point(0, 25);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(770, 70);
            this.PanelEncabezado.TabIndex = 14;
            // 
            // CboAño
            // 
            this.CboAño.AllowDrop = true;
            this.CboAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboAño.BackColor = System.Drawing.Color.White;
            this.CboAño.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboAño.BorderSize = 0;
            this.CboAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CboAño.CaracterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CboAño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboAño.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboAño.ListBackColor = System.Drawing.Color.White;
            this.CboAño.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboAño.Location = new System.Drawing.Point(486, 30);
            this.CboAño.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CboAño.MinimumSize = new System.Drawing.Size(50, 20);
            this.CboAño.Name = "CboAño";
            this.CboAño.Size = new System.Drawing.Size(100, 23);
            this.CboAño.Sorted = false;
            this.CboAño.TabIndex = 3;
            this.CboAño.Texts = "";
            // 
            // CboMes
            // 
            this.CboMes.AllowDrop = true;
            this.CboMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboMes.BackColor = System.Drawing.Color.White;
            this.CboMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboMes.BorderSize = 0;
            this.CboMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CboMes.CaracterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CboMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboMes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.CboMes.ListBackColor = System.Drawing.Color.White;
            this.CboMes.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboMes.Location = new System.Drawing.Point(355, 30);
            this.CboMes.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CboMes.MinimumSize = new System.Drawing.Size(78, 20);
            this.CboMes.Name = "CboMes";
            this.CboMes.Size = new System.Drawing.Size(130, 23);
            this.CboMes.Sorted = false;
            this.CboMes.TabIndex = 2;
            this.CboMes.Texts = "";
            // 
            // CboFormaDePago
            // 
            this.CboFormaDePago.AllowDrop = true;
            this.CboFormaDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboFormaDePago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboFormaDePago.BackColor = System.Drawing.Color.White;
            this.CboFormaDePago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboFormaDePago.BorderSize = 0;
            this.CboFormaDePago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CboFormaDePago.CaracterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CboFormaDePago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboFormaDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboFormaDePago.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboFormaDePago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA DE CREDITO",
            "TARJETA DE DEBITO"});
            this.CboFormaDePago.ListBackColor = System.Drawing.Color.White;
            this.CboFormaDePago.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboFormaDePago.Location = new System.Drawing.Point(181, 30);
            this.CboFormaDePago.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CboFormaDePago.MinimumSize = new System.Drawing.Size(78, 20);
            this.CboFormaDePago.Name = "CboFormaDePago";
            this.CboFormaDePago.Size = new System.Drawing.Size(175, 23);
            this.CboFormaDePago.Sorted = false;
            this.CboFormaDePago.TabIndex = 1;
            this.CboFormaDePago.Texts = "";
            // 
            // LblLine
            // 
            this.LblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LblLine.Location = new System.Drawing.Point(2, 58);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(766, 3);
            this.LblLine.TabIndex = 12;
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTerminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTerminar.FlatAppearance.BorderSize = 0;
            this.BtnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTerminar.ForeColor = System.Drawing.Color.White;
            this.BtnTerminar.IconChar = FontAwesome.Sharp.IconChar.Eject;
            this.BtnTerminar.IconColor = System.Drawing.Color.White;
            this.BtnTerminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTerminar.IconSize = 15;
            this.BtnTerminar.Location = new System.Drawing.Point(635, 5);
            this.BtnTerminar.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(130, 23);
            this.BtnTerminar.TabIndex = 5;
            this.BtnTerminar.Text = "Terminar Reporte";
            this.BtnTerminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTerminar.UseVisualStyleBackColor = false;
            this.BtnTerminar.Visible = false;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 15;
            this.BtnNuevo.Location = new System.Drawing.Point(5, 5);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 23);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "Nuevo Reporte";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.Transparent;
            this.Encabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.Encabezado.Location = new System.Drawing.Point(2, 31);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(766, 20);
            this.Encabezado.TabIndex = 13;
            this.Encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Encabezado.Visible = false;
            this.Encabezado.TextChanged += new System.EventHandler(this.Encabezado_TextChanged);
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
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ColorDialog.FullOpen = true;
            // 
            // PSettings
            // 
            this.PSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PSettings.Controls.Add(this.GbTema);
            this.PSettings.ForeColor = System.Drawing.Color.White;
            this.PSettings.Location = new System.Drawing.Point(0, 25);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(0, 50);
            this.PSettings.TabIndex = 24;
            // 
            // GbTema
            // 
            this.GbTema.Controls.Add(this.LblForeColor);
            this.GbTema.Controls.Add(this.LblForeColorPdf);
            this.GbTema.Controls.Add(this.LblBackColor);
            this.GbTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTema.ForeColor = System.Drawing.Color.White;
            this.GbTema.Location = new System.Drawing.Point(0, 0);
            this.GbTema.Name = "GbTema";
            this.GbTema.Size = new System.Drawing.Size(0, 45);
            this.GbTema.TabIndex = 40;
            this.GbTema.TabStop = false;
            this.GbTema.Text = "Tema";
            // 
            // LblForeColor
            // 
            this.LblForeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblForeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForeColor.ForeColor = System.Drawing.Color.White;
            this.LblForeColor.Location = new System.Drawing.Point(83, 18);
            this.LblForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.LblForeColor.Name = "LblForeColor";
            this.LblForeColor.Padding = new System.Windows.Forms.Padding(1);
            this.LblForeColor.Size = new System.Drawing.Size(0, 24);
            this.LblForeColor.TabIndex = 40;
            this.LblForeColor.Text = "Color de texto";
            this.LblForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblForeColor.Click += new System.EventHandler(this.LblForeColor_Click);
            // 
            // LblForeColorPdf
            // 
            this.LblForeColorPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblForeColorPdf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblForeColorPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblForeColorPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblForeColorPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForeColorPdf.ForeColor = System.Drawing.Color.White;
            this.LblForeColorPdf.Location = new System.Drawing.Point(-97, 18);
            this.LblForeColorPdf.Margin = new System.Windows.Forms.Padding(0);
            this.LblForeColorPdf.Name = "LblForeColorPdf";
            this.LblForeColorPdf.Padding = new System.Windows.Forms.Padding(1);
            this.LblForeColorPdf.Size = new System.Drawing.Size(100, 24);
            this.LblForeColorPdf.TabIndex = 41;
            this.LblForeColorPdf.Text = "Color de texto Pdf";
            this.LblForeColorPdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblForeColorPdf.Click += new System.EventHandler(this.LblForeColorPdf_Click);
            // 
            // LblBackColor
            // 
            this.LblBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBackColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBackColor.ForeColor = System.Drawing.Color.White;
            this.LblBackColor.Location = new System.Drawing.Point(3, 18);
            this.LblBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.LblBackColor.Name = "LblBackColor";
            this.LblBackColor.Padding = new System.Windows.Forms.Padding(1);
            this.LblBackColor.Size = new System.Drawing.Size(80, 24);
            this.LblBackColor.TabIndex = 39;
            this.LblBackColor.Text = "Color de fondo";
            this.LblBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBackColor.Click += new System.EventHandler(this.LblBackColor_Click);
            // 
            // PanelPdfViewer
            // 
            this.PanelPdfViewer.BackColor = System.Drawing.Color.White;
            this.PanelPdfViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPdfViewer.Controls.Add(this.FLP);
            this.PanelPdfViewer.Controls.Add(this.LblLineFooter);
            this.PanelPdfViewer.Controls.Add(this.LblFooter);
            this.PanelPdfViewer.Controls.Add(this.LblSpace);
            this.PanelPdfViewer.Controls.Add(this.LblLineHeader);
            this.PanelPdfViewer.Controls.Add(this.LblHeader);
            this.PanelPdfViewer.Location = new System.Drawing.Point(50, 130);
            this.PanelPdfViewer.Name = "PanelPdfViewer";
            this.PanelPdfViewer.Size = new System.Drawing.Size(665, 180);
            this.PanelPdfViewer.TabIndex = 30;
            this.PanelPdfViewer.Visible = false;
            // 
            // FLP
            // 
            this.FLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP.Controls.Add(this.label1);
            this.FLP.Controls.Add(this.label2);
            this.FLP.Controls.Add(this.label3);
            this.FLP.Controls.Add(this.label4);
            this.FLP.Controls.Add(this.label5);
            this.FLP.Controls.Add(this.label6);
            this.FLP.Controls.Add(this.label7);
            this.FLP.Controls.Add(this.LblCampo1);
            this.FLP.Controls.Add(this.LblCampo2);
            this.FLP.Controls.Add(this.label8);
            this.FLP.Controls.Add(this.label9);
            this.FLP.Controls.Add(this.label10);
            this.FLP.Controls.Add(this.label11);
            this.FLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP.Location = new System.Drawing.Point(0, 28);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(661, 125);
            this.FLP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proveedor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Concepto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(460, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subtotal";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(530, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "IVA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(580, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCampo1
            // 
            this.LblCampo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCampo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo1.ForeColor = System.Drawing.Color.Black;
            this.LblCampo1.Location = new System.Drawing.Point(3, 20);
            this.LblCampo1.Name = "LblCampo1";
            this.LblCampo1.Size = new System.Drawing.Size(655, 20);
            this.LblCampo1.TabIndex = 8;
            this.LblCampo1.Text = "01/ene/2024       Example                      Baalak                            " +
    "            Servicios                        $123                   $45         " +
    "       $6789";
            this.LblCampo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCampo2
            // 
            this.LblCampo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCampo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCampo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo2.ForeColor = System.Drawing.Color.Black;
            this.LblCampo2.Location = new System.Drawing.Point(3, 40);
            this.LblCampo2.Name = "LblCampo2";
            this.LblCampo2.Size = new System.Drawing.Size(655, 20);
            this.LblCampo2.TabIndex = 16;
            this.LblCampo2.Text = "01/ene/2024       Example                      Baalak                            " +
    "            Servicios                        $123                   $45         " +
    "       $6789";
            this.LblCampo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label8.Location = new System.Drawing.Point(0, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(460, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total:  ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label9.Location = new System.Drawing.Point(460, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "$1234";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label10.Location = new System.Drawing.Point(530, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "$567";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.label11.Location = new System.Drawing.Point(580, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "$890123";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLineFooter
            // 
            this.LblLineFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblLineFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblLineFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblLineFooter.Location = new System.Drawing.Point(0, 153);
            this.LblLineFooter.Name = "LblLineFooter";
            this.LblLineFooter.Size = new System.Drawing.Size(661, 3);
            this.LblLineFooter.TabIndex = 7;
            this.LblLineFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFooter
            // 
            this.LblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblFooter.Location = new System.Drawing.Point(0, 156);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(661, 20);
            this.LblFooter.TabIndex = 8;
            this.LblFooter.Text = "Página 1 de 1";
            this.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSpace
            // 
            this.LblSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblSpace.Location = new System.Drawing.Point(0, 23);
            this.LblSpace.Name = "LblSpace";
            this.LblSpace.Size = new System.Drawing.Size(661, 5);
            this.LblSpace.TabIndex = 2;
            this.LblSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLineHeader
            // 
            this.LblLineHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblLineHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLineHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLineHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblLineHeader.Location = new System.Drawing.Point(0, 20);
            this.LblLineHeader.Name = "LblLineHeader";
            this.LblLineHeader.Size = new System.Drawing.Size(661, 3);
            this.LblLineHeader.TabIndex = 1;
            this.LblLineHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeader
            // 
            this.LblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.LblHeader.Location = new System.Drawing.Point(0, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(661, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Reporte de gastos efectivo enero 2024";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 350);
            this.Controls.Add(this.PanelPdfViewer);
            this.Controls.Add(this.PSettings);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.PanelEncabezado);
            this.Controls.Add(this.PanelUsuarioActivo);
            this.Controls.Add(this.PanelTotales);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportes";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de gastos";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.PanelTotales.ResumeLayout(false);
            this.PanelTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.PanelUsuarioActivo.ResumeLayout(false);
            this.PanelEncabezado.ResumeLayout(false);
            this.PSettings.ResumeLayout(false);
            this.GbTema.ResumeLayout(false);
            this.PanelPdfViewer.ResumeLayout(false);
            this.FLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.Panel PanelTotales;
        private System.Windows.Forms.Label TotalIVA;
        private System.Windows.Forms.Label TotalTotal;
        private System.Windows.Forms.Label TotalSubtotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvData;
        private FontAwesome.Sharp.IconButton BtnTerminar;
        private System.Windows.Forms.Panel PanelUsuarioActivo;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton Restaurar;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private System.Windows.Forms.Label FechaYHora;
        private System.Windows.Forms.Timer FechaYHoraActual;
        private System.Windows.Forms.Timer Entrada;
        private System.Windows.Forms.Timer Salida;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.Label LblFDP;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Panel PanelEncabezado;
        private System.Windows.Forms.Label LblLine;
        private System.Windows.Forms.Label Encabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewLinkColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private CustomControls.CustomComboBox CboFormaDePago;
        private CustomControls.CustomComboBox CboMes;
        private CustomControls.CustomComboBox CboAño;
        private FontAwesome.Sharp.IconButton BtnSettings;
        private System.Windows.Forms.Timer TAbrir;
        private System.Windows.Forms.Timer TCerrar;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.GroupBox GbTema;
        private System.Windows.Forms.Label LblForeColor;
        private System.Windows.Forms.Label LblForeColorPdf;
        private System.Windows.Forms.Label LblBackColor;
        private System.Windows.Forms.Panel PanelPdfViewer;
        private System.Windows.Forms.Label LblSpace;
        private System.Windows.Forms.Label LblLineHeader;
        private System.Windows.Forms.Label LblLineFooter;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblFooter;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCampo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblCampo2;
    }
}