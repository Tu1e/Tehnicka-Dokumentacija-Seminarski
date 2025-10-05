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
using DomainTD = Common.Domain.TehnickaDokumentacija;

namespace Client.Paneli
{
    public partial class TehnickaDokumentacija : UserControl
    {
        TableName currentPanel = TableName.TehnickaDokumentacija;

        public TehnickaDokumentacija()
        {
            InitializeComponent();
            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(currentPanel);
            cmbInzenjer.DataSource = tdcb.Inzenjeri;
            cmbKlijent.DataSource = tdcb.Klijenti;

            cmbInzenjer.DisplayMember = "ImePrezime";
            cmbInzenjer.ValueMember = "IdInzenjer";

            cmbKlijent.DisplayMember = "ImePrezime";
            cmbKlijent.ValueMember = "IdKlijent";

            EnableDisableFields(false);
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
            btnSacuvaj.Enabled = action;
        }

        private void LoadTable(TableDataBundle tdcb)
        {
            dgvDokumentacija.DataSource = null;
            dgvDokumentacija.DataSource = tdcb.TehnickeDokumentacije;

            dgvDokumentacija.AllowUserToAddRows = false;
            dgvDokumentacija.AllowUserToDeleteRows = false;
            dgvDokumentacija.ReadOnly = true;
        }

        private void Kreiraj()
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdDokumentacije.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Kreiraj();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            TableDataBundle tdcb = ClientCommunication.Instance.GetTableData(currentPanel);
            LoadTable(tdcb);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (dtpDatumPotpisivanja.Value >= dtpDatumZavrsetka.Value)
            {
                MessageBox.Show("Datum završetka mora biti nakon datuma potpisivanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUkupanIznos.Text, out decimal ukupanIznos) || ukupanIznos <= 0)
            {
                MessageBox.Show("Ukupan iznos mora biti broj veći od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbInzenjer.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati inženjera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKlijent.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati klijenta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember();

            Debug.WriteLine($">>> cmbInzenjer:{cmbInzenjer.TabIndex}, cmbKlijent:{cmbKlijent.TabIndex}");
            DomainTD tehnickaDokumentacija = new DomainTD
            {
                IdTehnickaDokumentacija = int.Parse(txtIdDokumentacije.Text),
                DatumPotpisivanja = dtpDatumPotpisivanja.Value,
                DatumZavrsetka = dtpDatumZavrsetka.Value,
                UkupanIznos = decimal.Parse(txtUkupanIznos.Text),
                IdInzenjer = ((Inzenjer)cmbInzenjer.SelectedItem).IdInzenjer,
                IdKlijent = ((Common.Domain.Klijent)cmbKlijent.SelectedItem).IdKlijent
            };

            tdm.TehnickaDokumentacija = tehnickaDokumentacija;
            tdm.TableName = currentPanel;

            TableDataBundle tdcb = ClientCommunication.Instance.AddTableMember(tdm);
            LoadTable(tdcb);
            Kreiraj();
        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (dgvDokumentacija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati bar jednu dokumentaciju za brisanje.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete {dgvDokumentacija.SelectedRows.Count} dokumentacija?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                foreach (DataGridViewRow row in dgvDokumentacija.SelectedRows)
                {
                    DomainTD selektovana = row.DataBoundItem as DomainTD;
                    if (selektovana == null) continue;

                    TableDataMember tdm = new TableDataMember
                    {
                        TehnickaDokumentacija = selektovana,
                        TableName = currentPanel
                    };

                    ClientCommunication.Instance.DeleteTableMember(tdm);
                }

                TableDataBundle updated = ClientCommunication.Instance.GetTableData(currentPanel);
                LoadTable(updated);

                MessageBox.Show("Selektovane dokumentacije su uspešno obrisane.",
                                "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Kreiraj();
        }
    }
}
