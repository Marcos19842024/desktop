namespace Baalak_Apps
{
    partial class FrmTransportes
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransportes));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnDescargar = new FontAwesome.Sharp.IconButton();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.GbMascotas = new System.Windows.Forms.GroupBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbClientes = new System.Windows.Forms.ListBox();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.CBFDP = new CustomControls.CustomComboBox();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.LbFecha = new System.Windows.Forms.ListBox();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.T2 = new System.Windows.Forms.Timer(this.components);
            this.PPrincipal.SuspendLayout();
            this.GbMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.PanelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(330, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Lista de transportes";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PPrincipal.Controls.Add(this.BtnCerrar);
            this.PPrincipal.Controls.Add(this.BtnDescargar);
            this.PPrincipal.Controls.Add(this.LblTitulo);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(330, 25);
            this.PPrincipal.TabIndex = 12;
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
            this.BtnCerrar.Location = new System.Drawing.Point(305, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnDescargar
            // 
            this.BtnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescargar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDescargar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDescargar.FlatAppearance.BorderSize = 0;
            this.BtnDescargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.BtnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescargar.ForeColor = System.Drawing.Color.White;
            this.BtnDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.BtnDescargar.IconColor = System.Drawing.Color.White;
            this.BtnDescargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDescargar.IconSize = 15;
            this.BtnDescargar.Location = new System.Drawing.Point(0, 0);
            this.BtnDescargar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDescargar.Name = "BtnDescargar";
            this.BtnDescargar.Size = new System.Drawing.Size(25, 25);
            this.BtnDescargar.TabIndex = 7;
            this.BtnDescargar.UseVisualStyleBackColor = false;
            this.BtnDescargar.Click += new System.EventHandler(this.BtnDescargar_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(0, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(326, 23);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "lunes, 15 de marzo del 2024";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.LblNombreCliente.Location = new System.Drawing.Point(40, 23);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(286, 23);
            this.LblNombreCliente.TabIndex = 1;
            this.LblNombreCliente.Text = "Cliente example";
            this.LblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHora
            // 
            this.LblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.LblHora.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(0, 23);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(40, 189);
            this.LblHora.TabIndex = 2;
            this.LblHora.Text = "08:00";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GbMascotas
            // 
            this.GbMascotas.Controls.Add(this.DgvData);
            this.GbMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.GbMascotas.Location = new System.Drawing.Point(40, 46);
            this.GbMascotas.Name = "GbMascotas";
            this.GbMascotas.Size = new System.Drawing.Size(286, 117);
            this.GbMascotas.TabIndex = 13;
            this.GbMascotas.TabStop = false;
            this.GbMascotas.Text = "Mascotas";
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Raza,
            this.Asunto});
            this.DgvData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.DgvData.Location = new System.Drawing.Point(3, 16);
            this.DgvData.Margin = new System.Windows.Forms.Padding(1);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.ShowEditingIcon = false;
            this.DgvData.Size = new System.Drawing.Size(280, 98);
            this.DgvData.TabIndex = 7;
            this.DgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellEndEdit);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 77;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            this.Raza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Raza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Raza.Width = 63;
            // 
            // Asunto
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Asunto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Asunto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Asunto.Width = 73;
            // 
            // LbClientes
            // 
            this.LbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.LbClientes.FormattingEnabled = true;
            this.LbClientes.ItemHeight = 15;
            this.LbClientes.Location = new System.Drawing.Point(100, 241);
            this.LbClientes.Name = "LbClientes";
            this.LbClientes.ScrollAlwaysVisible = true;
            this.LbClientes.Size = new System.Drawing.Size(230, 156);
            this.LbClientes.TabIndex = 14;
            this.LbClientes.SelectedIndexChanged += new System.EventHandler(this.LbClientes_SelectedIndexChanged);
            // 
            // PanelCliente
            // 
            this.PanelCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelCliente.Controls.Add(this.GbMascotas);
            this.PanelCliente.Controls.Add(this.CBFDP);
            this.PanelCliente.Controls.Add(this.BtnEliminar);
            this.PanelCliente.Controls.Add(this.LblNombreCliente);
            this.PanelCliente.Controls.Add(this.LblHora);
            this.PanelCliente.Controls.Add(this.LblFecha);
            this.PanelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCliente.Location = new System.Drawing.Point(0, 25);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(330, 216);
            this.PanelCliente.TabIndex = 8;
            // 
            // CBFDP
            // 
            this.CBFDP.AllowDrop = true;
            this.CBFDP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBFDP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBFDP.BackColor = System.Drawing.Color.White;
            this.CBFDP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CBFDP.BorderSize = 0;
            this.CBFDP.CaracterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CBFDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBFDP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBFDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CBFDP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CBFDP.Items.AddRange(new object[] {
            "Efectivo",
            "T.C.",
            "T.D.",
            "Transferencia",
            "Paga en caja",
            "No definido"});
            this.CBFDP.ListBackColor = System.Drawing.Color.White;
            this.CBFDP.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.CBFDP.Location = new System.Drawing.Point(40, 163);
            this.CBFDP.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CBFDP.MinimumSize = new System.Drawing.Size(78, 20);
            this.CBFDP.Name = "CBFDP";
            this.CBFDP.Size = new System.Drawing.Size(286, 24);
            this.CBFDP.Sorted = false;
            this.CBFDP.TabIndex = 19;
            this.CBFDP.Texts = "No definido";
            this.CBFDP.OnSelectedIndexChanged += new System.EventHandler(this.CBFDP_OnSelectedIndexChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEliminar.IconSize = 15;
            this.BtnEliminar.Location = new System.Drawing.Point(40, 187);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(286, 25);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Quitar de la lista";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LbFecha
            // 
            this.LbFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.LbFecha.FormattingEnabled = true;
            this.LbFecha.ItemHeight = 15;
            this.LbFecha.Location = new System.Drawing.Point(0, 241);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.ScrollAlwaysVisible = true;
            this.LbFecha.Size = new System.Drawing.Size(100, 156);
            this.LbFecha.TabIndex = 15;
            this.LbFecha.SelectedIndexChanged += new System.EventHandler(this.LbFecha_SelectedIndexChanged);
            // 
            // T1
            // 
            this.T1.Interval = 30;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // T2
            // 
            this.T2.Interval = 30;
            this.T2.Tick += new System.EventHandler(this.T2_Tick);
            // 
            // FrmTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 397);
            this.Controls.Add(this.LbClientes);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.PPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de transportes";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            this.PPrincipal.ResumeLayout(false);
            this.GbMascotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.PanelCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PPrincipal;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnDescargar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.GroupBox GbMascotas;
        private System.Windows.Forms.ListBox LbClientes;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.ListBox LbFecha;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private CustomControls.CustomComboBox CBFDP;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.Timer T2;
    }
}