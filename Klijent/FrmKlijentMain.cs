using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Paneli;
using Klijent;

namespace Client
{
    public partial class FrmKlijentMain : Form
    {
        public FrmKlijentMain()
        {
            InitializeComponent();

            pnlMain.Dock = DockStyle.Fill;
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void tehnickaDokumentacijaTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Paneli.TehnickaDokumentacija());
        }

        private void inzenjerTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new InzenjerPanel());
        }

        private void klijentTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new KlijentPanel());
        }

        private void mestoTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MestoPanel());
        }

        private void zadatakTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ZadatakPanel());
        }

        private void tipInzenjeraTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TipInzenjeraPanel());
        }

        private void podešavanjaSistemaTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PodesavanjaSistema());
        }

        private void oProgramuTSMItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new OProgramu());
        }
    }
}
