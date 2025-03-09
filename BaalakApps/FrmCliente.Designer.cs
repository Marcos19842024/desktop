namespace BaalakApps
{
    partial class FrmCliente
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
            this.Btntext = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.BtnMover = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Btntext
            // 
            this.Btntext.AutoSize = true;
            this.Btntext.BackColor = System.Drawing.Color.Transparent;
            this.Btntext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btntext.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btntext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btntext.FlatAppearance.BorderSize = 0;
            this.Btntext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btntext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btntext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btntext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btntext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntext.ForeColor = System.Drawing.Color.White;
            this.Btntext.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.Btntext.IconColor = System.Drawing.Color.Cyan;
            this.Btntext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btntext.IconSize = 25;
            this.Btntext.Location = new System.Drawing.Point(0, 0);
            this.Btntext.Margin = new System.Windows.Forms.Padding(0);
            this.Btntext.Name = "Btntext";
            this.Btntext.Size = new System.Drawing.Size(165, 50);
            this.Btntext.TabIndex = 8;
            this.Btntext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btntext.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnCerrar.IconColor = System.Drawing.Color.White;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 15;
            this.BtnCerrar.Location = new System.Drawing.Point(85, 57);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMover
            // 
            this.BtnMover.AutoSize = true;
            this.BtnMover.BackColor = System.Drawing.Color.Transparent;
            this.BtnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMover.FlatAppearance.BorderSize = 0;
            this.BtnMover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnMover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.BtnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMover.ForeColor = System.Drawing.Color.White;
            this.BtnMover.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnMover.IconColor = System.Drawing.Color.White;
            this.BtnMover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMover.IconSize = 15;
            this.BtnMover.Location = new System.Drawing.Point(5, 57);
            this.BtnMover.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(75, 23);
            this.BtnMover.TabIndex = 10;
            this.BtnMover.Text = "Aceptar";
            this.BtnMover.UseVisualStyleBackColor = false;
            this.BtnMover.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(165, 82);
            this.Controls.Add(this.Btntext);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btntext;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnMover;
    }
}