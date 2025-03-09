using System;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmStart : Form
    {
        private int Count = 0;

        public FrmStart()
        {
            InitializeComponent();
        }

        #region Private Methods
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Events        
        private void FrmStart_Load(object sender, EventArgs e)
        {
            In.Start();
        }

        #region Timers
        private void In_Tick(object sender, EventArgs e)
        {
            Count++;
            ProgressBar.Width += 3;
            ProgressBar.Text = Count.ToString() + " %";
            if (Count == 100)
            {
                In.Stop();
                Out.Start();
            }
        }

        private void Out_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.01;
            if (Opacity == 0)
            {
                Out.Stop();
                FrmAppsBox Frm = new FrmAppsBox();
                Frm.Show();
                Frm.FormClosed += LogOut;
                Hide();
            }
        }
        #endregion
        #endregion        
    }
}