using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.Domain;

namespace Client.Paneli
{
    public partial class TehnickaDokumentacija : UserControl
    {
        public TehnickaDokumentacija()
        {
            InitializeComponent();
            TehDokCmbData tdcb = ClientCommunication.Instance.LoadOtherTableData(TableName.TehnickaDokumentacija);
            cmbInzenjer.DataSource = tdcb.Inzenjeri;
            cmbKlijent.DataSource = tdcb.Klijenti;

            cmbInzenjer.DisplayMember = "ImePrezime";
            cmbInzenjer.ValueMember = "IdInzenjer";

            cmbKlijent.DisplayMember = "ImePrezime";
            cmbKlijent.ValueMember = "IdKlijent";

            EnableDisableFields(false);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int id = ClientCommunication.Instance.GetNextFreeId(TableName.TehnickaDokumentacija);
            txtIdDokumentacije.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void EnableDisableFields(bool action)
        {
            txtUkupanIznos.Text = "";
            cmbInzenjer.SelectedIndex = -1;
            cmbKlijent.SelectedIndex = -1;
            txtUkupanIznos.Enabled = action;
            dtpDatumPotpisivanja.Enabled = action;
            dtpDatumZavrsetka.Enabled = action;
            cmbInzenjer.Enabled = action;
            cmbKlijent.Enabled = action;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //Provere polja

        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {

        }
    }
}
