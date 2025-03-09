namespace Baalak_Apps
{
    partial class FrmAppsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppsBox));
            this.PPrincipal = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.IBReportes = new FontAwesome.Sharp.IconButton();
            this.IBTransportes = new FontAwesome.Sharp.IconButton();
            this.IBRecordatorios = new FontAwesome.Sharp.IconButton();
            this.PPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PPrincipal
            // 
            this.PPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PPrincipal.Controls.Add(this.LblTitulo);
            this.PPrincipal.Controls.Add(this.Minimizar);
            this.PPrincipal.Controls.Add(this.BtnCerrar);
            this.PPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PPrincipal.ForeColor = System.Drawing.Color.White;
            this.PPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PPrincipal.Name = "PPrincipal";
            this.PPrincipal.Size = new System.Drawing.Size(360, 25);
            this.PPrincipal.TabIndex = 12;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LblTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(310, 25);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Baalak Apps";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Minimizar.Location = new System.Drawing.Point(310, 0);
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
            this.BtnCerrar.Location = new System.Drawing.Point(335, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // IBReportes
            // 
            this.IBReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.IBReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IBReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IBReportes.FlatAppearance.BorderSize = 0;
            this.IBReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBReportes.ForeColor = System.Drawing.Color.White;
            this.IBReportes.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.IBReportes.IconColor = System.Drawing.Color.White;
            this.IBReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBReportes.IconSize = 60;
            this.IBReportes.Location = new System.Drawing.Point(120, 25);
            this.IBReportes.Name = "IBReportes";
            this.IBReportes.Size = new System.Drawing.Size(120, 95);
            this.IBReportes.TabIndex = 1;
            this.IBReportes.Text = "Reportes";
            this.IBReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IBReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IBReportes.UseVisualStyleBackColor = false;
            this.IBReportes.Click += new System.EventHandler(this.IBReportes_Click);
            // 
            // IBTransportes
            // 
            this.IBTransportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.IBTransportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IBTransportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTransportes.Dock = System.Windows.Forms.DockStyle.Right;
            this.IBTransportes.FlatAppearance.BorderSize = 0;
            this.IBTransportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBTransportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTransportes.ForeColor = System.Drawing.Color.White;
            this.IBTransportes.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.IBTransportes.IconColor = System.Drawing.Color.White;
            this.IBTransportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTransportes.IconSize = 60;
            this.IBTransportes.Location = new System.Drawing.Point(240, 25);
            this.IBTransportes.Name = "IBTransportes";
            this.IBTransportes.Size = new System.Drawing.Size(120, 95);
            this.IBTransportes.TabIndex = 2;
            this.IBTransportes.Text = "Transportes";
            this.IBTransportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IBTransportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IBTransportes.UseVisualStyleBackColor = false;
            this.IBTransportes.Click += new System.EventHandler(this.IBTransportes_Click);
            // 
            // IBRecordatorios
            // 
            this.IBRecordatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.IBRecordatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IBRecordatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBRecordatorios.Dock = System.Windows.Forms.DockStyle.Left;
            this.IBRecordatorios.FlatAppearance.BorderSize = 0;
            this.IBRecordatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBRecordatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.IBRecordatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBRecordatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBRecordatorios.ForeColor = System.Drawing.Color.White;
            this.IBRecordatorios.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.IBRecordatorios.IconColor = System.Drawing.Color.White;
            this.IBRecordatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBRecordatorios.IconSize = 60;
            this.IBRecordatorios.Location = new System.Drawing.Point(0, 25);
            this.IBRecordatorios.Name = "IBRecordatorios";
            this.IBRecordatorios.Size = new System.Drawing.Size(120, 95);
            this.IBRecordatorios.TabIndex = 0;
            this.IBRecordatorios.Text = "Recordatorios";
            this.IBRecordatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IBRecordatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IBRecordatorios.UseVisualStyleBackColor = false;
            this.IBRecordatorios.Click += new System.EventHandler(this.IBRecordatorios_Click);
            // 
            // FrmAppsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(360, 120);
            this.Controls.Add(this.IBReportes);
            this.Controls.Add(this.IBTransportes);
            this.Controls.Add(this.IBRecordatorios);
            this.Controls.Add(this.PPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAppsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAppsBox";
            this.PPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton IBRecordatorios;
        private FontAwesome.Sharp.IconButton IBReportes;
        private FontAwesome.Sharp.IconButton IBTransportes;
        private System.Windows.Forms.Panel PPrincipal;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton BtnCerrar;
    }
}