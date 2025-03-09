namespace Baalak_Apps
{
    partial class FrmReportesFloat
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
            this.LblIndice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.Label();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.PanelFYF = new System.Windows.Forms.Panel();
            this.TxtFactura = new CustomControls.CustomTextBox();
            this.PanelProv = new System.Windows.Forms.Panel();
            this.CboProveedor = new CustomControls.CustomComboBox();
            this.PanelConc = new System.Windows.Forms.Panel();
            this.CboConcepto = new CustomControls.CustomComboBox();
            this.PanelNumeros = new System.Windows.Forms.Panel();
            this.TxtDescuento = new CustomControls.CustomTextBox();
            this.TxtIVA = new CustomControls.CustomTextBox();
            this.TxtSubtotal = new CustomControls.CustomTextBox();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnEliminarProv = new FontAwesome.Sharp.IconButton();
            this.BtnEliminarConc = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.PanelBtns = new System.Windows.Forms.Panel();
            this.PanelFYF.SuspendLayout();
            this.PanelProv.SuspendLayout();
            this.PanelConc.SuspendLayout();
            this.PanelNumeros.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.PanelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblIndice
            // 
            this.LblIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LblIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LblIndice.Location = new System.Drawing.Point(0, 0);
            this.LblIndice.Margin = new System.Windows.Forms.Padding(0);
            this.LblIndice.Name = "LblIndice";
            this.LblIndice.Size = new System.Drawing.Size(24, 24);
            this.LblIndice.TabIndex = 59;
            this.LblIndice.Text = "-1";
            this.LblIndice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Datos de factura";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 4, 0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(107, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 4, 0, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Factura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.DtpFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.DtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.DtpFecha.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpFecha.CustomFormat = "dd/mm/yyyy";
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(5, 21);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(100, 20);
            this.DtpFecha.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 4, 0, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proveedor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 4, 0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Concepto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 4, 2, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "SubTotal";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(67, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 4, 2, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Desc.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(111, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 4, 2, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "IVA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(160, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 4, 0, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.White;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtTotal.Location = new System.Drawing.Point(160, 22);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 0);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(60, 18);
            this.TxtTotal.TabIndex = 8;
            this.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnCerrar.Location = new System.Drawing.Point(227, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelFYF
            // 
            this.PanelFYF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelFYF.Controls.Add(this.TxtFactura);
            this.PanelFYF.Controls.Add(this.DtpFecha);
            this.PanelFYF.Controls.Add(this.label6);
            this.PanelFYF.Controls.Add(this.label4);
            this.PanelFYF.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFYF.Location = new System.Drawing.Point(0, 25);
            this.PanelFYF.Name = "PanelFYF";
            this.PanelFYF.Size = new System.Drawing.Size(227, 47);
            this.PanelFYF.TabIndex = 62;
            // 
            // TxtFactura
            // 
            this.TxtFactura.BackColor = System.Drawing.Color.White;
            this.TxtFactura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtFactura.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtFactura.BorderRadius = 3;
            this.TxtFactura.BorderSize = 1;
            this.TxtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtFactura.IsReadOnly = false;
            this.TxtFactura.Location = new System.Drawing.Point(107, 21);
            this.TxtFactura.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.TxtFactura.Multiline = false;
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtFactura.PasswordChar = false;
            this.TxtFactura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtFactura.PlaceholderText = "";
            this.TxtFactura.Size = new System.Drawing.Size(113, 20);
            this.TxtFactura.TabIndex = 2;
            this.TxtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFactura.Texts = "";
            this.TxtFactura.UnderlinedStyle = true;
            // 
            // PanelProv
            // 
            this.PanelProv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelProv.Controls.Add(this.CboProveedor);
            this.PanelProv.Controls.Add(this.label7);
            this.PanelProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProv.Location = new System.Drawing.Point(0, 72);
            this.PanelProv.Name = "PanelProv";
            this.PanelProv.Size = new System.Drawing.Size(227, 42);
            this.PanelProv.TabIndex = 63;
            // 
            // CboProveedor
            // 
            this.CboProveedor.AllowDrop = true;
            this.CboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboProveedor.BackColor = System.Drawing.Color.White;
            this.CboProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboProveedor.BorderSize = 0;
            this.CboProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CboProveedor.CaracterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CboProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.CboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboProveedor.ListBackColor = System.Drawing.Color.White;
            this.CboProveedor.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboProveedor.Location = new System.Drawing.Point(0, 15);
            this.CboProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.CboProveedor.MinimumSize = new System.Drawing.Size(78, 20);
            this.CboProveedor.Name = "CboProveedor";
            this.CboProveedor.Size = new System.Drawing.Size(223, 20);
            this.CboProveedor.Sorted = true;
            this.CboProveedor.TabIndex = 3;
            this.CboProveedor.Texts = "";
            // 
            // PanelConc
            // 
            this.PanelConc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelConc.Controls.Add(this.CboConcepto);
            this.PanelConc.Controls.Add(this.label8);
            this.PanelConc.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConc.Location = new System.Drawing.Point(0, 114);
            this.PanelConc.Name = "PanelConc";
            this.PanelConc.Size = new System.Drawing.Size(227, 42);
            this.PanelConc.TabIndex = 64;
            // 
            // CboConcepto
            // 
            this.CboConcepto.AllowDrop = true;
            this.CboConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboConcepto.BackColor = System.Drawing.Color.White;
            this.CboConcepto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboConcepto.BorderSize = 0;
            this.CboConcepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CboConcepto.CaracterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CboConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboConcepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.CboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboConcepto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboConcepto.ListBackColor = System.Drawing.Color.White;
            this.CboConcepto.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.CboConcepto.Location = new System.Drawing.Point(0, 15);
            this.CboConcepto.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.CboConcepto.MinimumSize = new System.Drawing.Size(75, 20);
            this.CboConcepto.Name = "CboConcepto";
            this.CboConcepto.Size = new System.Drawing.Size(223, 20);
            this.CboConcepto.Sorted = true;
            this.CboConcepto.TabIndex = 4;
            this.CboConcepto.Texts = "";
            // 
            // PanelNumeros
            // 
            this.PanelNumeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelNumeros.Controls.Add(this.TxtDescuento);
            this.PanelNumeros.Controls.Add(this.TxtIVA);
            this.PanelNumeros.Controls.Add(this.TxtSubtotal);
            this.PanelNumeros.Controls.Add(this.label12);
            this.PanelNumeros.Controls.Add(this.TxtTotal);
            this.PanelNumeros.Controls.Add(this.label11);
            this.PanelNumeros.Controls.Add(this.label10);
            this.PanelNumeros.Controls.Add(this.label9);
            this.PanelNumeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNumeros.Location = new System.Drawing.Point(0, 156);
            this.PanelNumeros.Name = "PanelNumeros";
            this.PanelNumeros.Size = new System.Drawing.Size(227, 47);
            this.PanelNumeros.TabIndex = 65;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.AllowDrop = true;
            this.TxtDescuento.BackColor = System.Drawing.Color.White;
            this.TxtDescuento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtDescuento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtDescuento.BorderRadius = 3;
            this.TxtDescuento.BorderSize = 1;
            this.TxtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtDescuento.IsReadOnly = false;
            this.TxtDescuento.Location = new System.Drawing.Point(67, 21);
            this.TxtDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.TxtDescuento.Multiline = false;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtDescuento.PasswordChar = false;
            this.TxtDescuento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtDescuento.PlaceholderText = "";
            this.TxtDescuento.Size = new System.Drawing.Size(40, 20);
            this.TxtDescuento.TabIndex = 6;
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDescuento.Texts = "";
            this.TxtDescuento.UnderlinedStyle = true;
            this.TxtDescuento.TextsChanged += new System.EventHandler(this.TxtDescuento_TextsChanged);
            this.TxtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            // 
            // TxtIVA
            // 
            this.TxtIVA.AllowDrop = true;
            this.TxtIVA.BackColor = System.Drawing.Color.White;
            this.TxtIVA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtIVA.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtIVA.BorderRadius = 3;
            this.TxtIVA.BorderSize = 1;
            this.TxtIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtIVA.IsReadOnly = false;
            this.TxtIVA.Location = new System.Drawing.Point(111, 21);
            this.TxtIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.TxtIVA.Multiline = false;
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtIVA.PasswordChar = false;
            this.TxtIVA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtIVA.PlaceholderText = "";
            this.TxtIVA.Size = new System.Drawing.Size(45, 20);
            this.TxtIVA.TabIndex = 7;
            this.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtIVA.Texts = "";
            this.TxtIVA.UnderlinedStyle = true;
            this.TxtIVA.TextsChanged += new System.EventHandler(this.TxtIVA_TextsChanged);
            this.TxtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIVA_KeyPress);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.AllowDrop = true;
            this.TxtSubtotal.BackColor = System.Drawing.Color.White;
            this.TxtSubtotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtSubtotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtSubtotal.BorderRadius = 3;
            this.TxtSubtotal.BorderSize = 1;
            this.TxtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.TxtSubtotal.IsReadOnly = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(5, 21);
            this.TxtSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.TxtSubtotal.Multiline = false;
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtSubtotal.PasswordChar = false;
            this.TxtSubtotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtSubtotal.PlaceholderText = "";
            this.TxtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtSubtotal.Size = new System.Drawing.Size(58, 20);
            this.TxtSubtotal.TabIndex = 5;
            this.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSubtotal.Texts = "";
            this.TxtSubtotal.UnderlinedStyle = true;
            this.TxtSubtotal.TextsChanged += new System.EventHandler(this.TxtSubtotal_TextsChanged);
            this.TxtSubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSubtotal_KeyPress);
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.BtnEliminarProv);
            this.PanelBotones.Controls.Add(this.BtnEliminarConc);
            this.PanelBotones.Controls.Add(this.BtnGuardar);
            this.PanelBotones.Controls.Add(this.BtnLimpiar);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelBotones.Location = new System.Drawing.Point(227, 25);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(25, 180);
            this.PanelBotones.TabIndex = 66;
            // 
            // BtnEliminarProv
            // 
            this.BtnEliminarProv.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEliminarProv.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnEliminarProv.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminarProv.IconColor = System.Drawing.Color.White;
            this.BtnEliminarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarProv.IconSize = 18;
            this.BtnEliminarProv.Location = new System.Drawing.Point(0, 47);
            this.BtnEliminarProv.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminarProv.Name = "BtnEliminarProv";
            this.BtnEliminarProv.Size = new System.Drawing.Size(25, 42);
            this.BtnEliminarProv.TabIndex = 16;
            this.BtnEliminarProv.UseVisualStyleBackColor = false;
            this.BtnEliminarProv.Click += new System.EventHandler(this.BtnEliminarProv_Click);
            // 
            // BtnEliminarConc
            // 
            this.BtnEliminarConc.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarConc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarConc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEliminarConc.FlatAppearance.BorderSize = 0;
            this.BtnEliminarConc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminarConc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnEliminarConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarConc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnEliminarConc.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminarConc.IconColor = System.Drawing.Color.White;
            this.BtnEliminarConc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminarConc.IconSize = 18;
            this.BtnEliminarConc.Location = new System.Drawing.Point(0, 91);
            this.BtnEliminarConc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminarConc.Name = "BtnEliminarConc";
            this.BtnEliminarConc.Size = new System.Drawing.Size(25, 42);
            this.BtnEliminarConc.TabIndex = 17;
            this.BtnEliminarConc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarConc.UseVisualStyleBackColor = false;
            this.BtnEliminarConc.Click += new System.EventHandler(this.BtnEliminarConc_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 18;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 133);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(25, 47);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.AccessibleDescription = "";
            this.BtnLimpiar.AccessibleName = "";
            this.BtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(0, 0);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(25, 47);
            this.BtnLimpiar.TabIndex = 15;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // PanelBtns
            // 
            this.PanelBtns.Controls.Add(this.label14);
            this.PanelBtns.Controls.Add(this.BtnCerrar);
            this.PanelBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBtns.Location = new System.Drawing.Point(0, 0);
            this.PanelBtns.Name = "PanelBtns";
            this.PanelBtns.Size = new System.Drawing.Size(252, 25);
            this.PanelBtns.TabIndex = 61;
            // 
            // FrmReportesFloat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(252, 205);
            this.Controls.Add(this.PanelNumeros);
            this.Controls.Add(this.PanelConc);
            this.Controls.Add(this.PanelProv);
            this.Controls.Add(this.PanelFYF);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelBtns);
            this.Controls.Add(this.LblIndice);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportesFloat";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmReportesFloat";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmReportesFloat_Load);
            this.PanelFYF.ResumeLayout(false);
            this.PanelProv.ResumeLayout(false);
            this.PanelConc.ResumeLayout(false);
            this.PanelNumeros.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.PanelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label LblIndice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private CustomControls.CustomTextBox TxtFactura;
        private System.Windows.Forms.Label label7;
        private CustomControls.CustomComboBox CboProveedor;
        private System.Windows.Forms.Label label8;
        private CustomControls.CustomComboBox CboConcepto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private CustomControls.CustomTextBox TxtSubtotal;
        private CustomControls.CustomTextBox TxtDescuento;
        private CustomControls.CustomTextBox TxtIVA;
        private System.Windows.Forms.Label TxtTotal;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private System.Windows.Forms.Panel PanelFYF;
        private System.Windows.Forms.Panel PanelProv;
        private System.Windows.Forms.Panel PanelConc;
        private System.Windows.Forms.Panel PanelNumeros;
        private System.Windows.Forms.Panel PanelBtns;
        private System.Windows.Forms.Panel PanelBotones;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnEliminarProv;
        private FontAwesome.Sharp.IconButton BtnEliminarConc;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
    }
}