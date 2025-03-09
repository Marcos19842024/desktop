using System;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmAppsBox : Form
    {
        public FrmAppsBox()
        {
            InitializeComponent();
        }        
        
        #region Private Methods
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        #endregion

        #region Botones
        private void Minimizar_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void IBRecordatorios_Click(object sender, EventArgs e)
        {
            FrmRecordatorios Frm1 = new FrmRecordatorios();
            Frm1.Show();
            Frm1.FormClosed += LogOut;
            Hide();
        }

        private void IBReportes_Click(object sender, EventArgs e)
        {
            FrmReportes Frm2 = new FrmReportes();
            Frm2.Show();
            Frm2.FormClosed += LogOut;
            Hide();
        }

        private void IBTransportes_Click(object sender, EventArgs e)
        {
            FrmTransportes Frm3 = new FrmTransportes();
            Frm3.Show();
            Frm3.FormClosed += LogOut;
            Hide();
        }
        #endregion        
    }
}