using System;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje()
        {
            InitializeComponent();
        }

        #region Botones
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Owner is FrmReportes)
            {
                FrmReportes form = Owner as FrmReportes;
                form.Eliminar();
            }
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Owner is FrmReportes)
            {
                FrmReportes form = Owner as FrmReportes;
                Hide();
                form.Editar();
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