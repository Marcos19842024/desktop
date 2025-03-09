using Baalak_Apps;
using System;
using System.Windows.Forms;

namespace BaalakApps
{
    public partial class FrmCliente : Form
    {
        public FrmCliente(string Text)
        {
            InitializeComponent();
            Btntext.Text = Text;
        }

        #region Botones
        private void BtnMover_Click(object sender, EventArgs e)
        {
            if (Owner is FrmRecordatorios)
            {
                FrmRecordatorios form = Owner as FrmRecordatorios;
                form.Mover(Btntext.Text);
            }
            Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}