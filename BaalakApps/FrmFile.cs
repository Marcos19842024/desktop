using Baalak_Apps;
using System;
using System.Windows.Forms;

namespace BaalakApps
{
    public partial class FrmFile : Form
    {
        private readonly string File = string.Empty;
        public string url;

        public FrmFile(string FileName)
        {
            File = FileName;
            InitializeComponent();
        }

        private void FrmFile_Load(object sender, EventArgs e)
        {
            url = "http://" + BaalakApps.Properties.Settings.Default.Url;
        }

        #region Botones
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Owner is FrmRecordatorios)
            {
                FrmRecordatorios form = Owner as FrmRecordatorios;
                await form.GetDeleteAsync(File);
            }
            Close();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (Owner is FrmRecordatorios)
            {
                FrmRecordatorios form = Owner as FrmRecordatorios;
                form.OpenTarget(url + "/media/" + File);
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