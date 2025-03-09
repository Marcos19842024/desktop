using System.Drawing;
using System.Windows.Forms;

namespace Baalak_Apps
{
    public partial class FrmPdf : Form
    {
        public static Color ColorForeColorPdf;

        public FrmPdf()
        {
            InitializeComponent();
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
        }

        #region Private Methods
        private void ColoresForeColorPdf()
        {
            ColorForeColorPdf = BaalakApps.Properties.Settings.Default.ReminderForeColorPdf;
            LblHeader.ForeColor = ColorForeColorPdf;
            LblLine.BackColor = ColorForeColorPdf;
            LblTableEnviados.ForeColor = ColorForeColorPdf;
            LblTableECliente.BackColor = ColorForeColorPdf;
            LblTableETelefono.BackColor = ColorForeColorPdf;
            LblTableNEnviados.ForeColor = ColorForeColorPdf;
            LblTableNECliente.BackColor = ColorForeColorPdf;
            LblTableNETelefono.BackColor = ColorForeColorPdf;
            LblLineFooter.BackColor = ColorForeColorPdf;
            LblFooter.ForeColor = ColorForeColorPdf;
        }
        #endregion

        #region Events
        private void FrmPdf_Load(object sender, System.EventArgs e)
        {
            ColoresForeColorPdf();
        }

        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }        

        private void BtnColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog.Color = ColorForeColorPdf;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BaalakApps.Properties.Settings.Default.ReminderForeColorPdf = ColorDialog.Color;
                BaalakApps.Properties.Settings.Default.Save();
                ColoresForeColorPdf();
            }
        }

        private void Btn_Tick(object sender, System.EventArgs e)
        {
            if (BtnColor.BackColor == Color.FromArgb(11, 20, 26))
            {
                BtnColor.BackColor = Color.WhiteSmoke;
                BtnColor.ForeColor = Color.FromArgb(11, 20, 26);
            }
            else
            {
                BtnColor.BackColor = Color.FromArgb(11, 20, 26);
                BtnColor.ForeColor = Color.White;
            }
        }
        #endregion
    }
}