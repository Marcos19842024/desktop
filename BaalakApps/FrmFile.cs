using Baalak_Apps;
using System;
using System.Windows.Forms;

namespace BaalakApps
{
    public partial class FrmFile : Form
    {
        private readonly string File = string.Empty;
        public string url = "http://recordatorios.veterinariabaalak.com/media/";

        public FrmFile(string FileName)
        {
            File = FileName;
            InitializeComponent();
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
                form.OpenTarget(url + File);
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