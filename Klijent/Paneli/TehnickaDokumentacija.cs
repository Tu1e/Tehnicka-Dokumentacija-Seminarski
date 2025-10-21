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

        // ------------------ PRIKAZ TEHNIČKIH DOKUMENTACIJA ------------------
        private void LoadTableTD(TableDataBundle tdcb)
        {
            dgvDokumentacija.DataSource = null;
            dgvDokumentacija.AutoGenerateColumns = false;
            dgvDokumentacija.Columns.Clear();

            foreach (var prop in typeof(DomainTD).GetProperties())
            {
                if (prop.Name.Equals("TableName", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("Values", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("UpdateValues", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("PrimaryKeyCondition", StringComparison.OrdinalIgnoreCase)) continue;

                string header = prop.Name;

                var displayAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                      .FirstOrDefault() as DisplayNameAttribute;

                if (displayAttr != null)
                    header = displayAttr.DisplayName;

                dgvDokumentacija.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = prop.Name,
                    HeaderText = header,
                    ReadOnly = true,
                });
            }

            dgvDokumentacija.DataSource = tdcb.TehnickeDokumentacije;
            dgvDokumentacija.AllowUserToAddRows = false;
            dgvDokumentacija.AllowUserToDeleteRows = false;
            dgvDokumentacija.ReadOnly = true;
        }

        // ------------------ PRIKAZ STAVKI ZA ODABRANU TD ------------------
        private void LoadTableStavke(List<StavkaTehnickaDokumentacija> stavke)
        {
            dgvDokumentacija.DataSource = null;
            dgvDokumentacija.AutoGenerateColumns = false;
            dgvDokumentacija.Columns.Clear();

            foreach (var prop in typeof(StavkaTehnickaDokumentacija).GetProperties())
            {
                if (prop.Name.Equals("TableName", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("Values", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("UpdateValues", StringComparison.OrdinalIgnoreCase)) continue;
                if (prop.Name.Equals("PrimaryKeyCondition", StringComparison.OrdinalIgnoreCase)) continue;

                string header = prop.Name;

                var displayAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                      .FirstOrDefault() as DisplayNameAttribute;

                if (displayAttr != null)
                    header = displayAttr.DisplayName;

                dgvDokumentacija.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = prop.Name,
                    HeaderText = header,
                    ReadOnly = true,
                });
            }

            dgvDokumentacija.DataSource = stavke;
            dgvDokumentacija.AllowUserToAddRows = false;
            dgvDokumentacija.AllowUserToDeleteRows = false;
            dgvDokumentacija.ReadOnly = true;
        }

        // ------------------ FUNKCIJE ZA RAD SA DOKUMENTACIJOM ------------------
        private void Kreiraj()
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdDokumentacije.Text = id.ToString();
            EnableDisableFields(true);
        }

        private void btnKreiraj_Click(object sender, EventArgs e) => Kreiraj();

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            TableDataBundle tdcb = ClientCommunication.Instance.GetTableData(currentPanel);
            LoadTableTD(tdcb);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvDokumentacija.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati dokumentaciju koju želite da izmenite.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDatumPotpisivanja.Value >= dtpDatumZavrsetka.Value)
            {
                MessageBox.Show("Datum završetka mora biti nakon datuma potpisivanja.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUkupanIznos.Text, out decimal ukupanIznos) || ukupanIznos <= 0)
            {
                MessageBox.Show("Ukupan iznos mora biti broj veći od 0.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbInzenjer.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati inženjera koji je odgovoran za dokumentaciju.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKlijent.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati klijenta koji naručuje dokumentaciju.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdDokumentacije.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID dokumentacije nije ispravan. Pokušajte ponovo učitati tabelu.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DomainTD selektovana = dgvDokumentacija.SelectedRows[0].DataBoundItem as DomainTD;
            if (selektovana == null)
            {
                MessageBox.Show("Nije moguće prepoznati selektovanu dokumentaciju.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selektovana.DatumPotpisivanja = dtpDatumPotpisivanja.Value;
            selektovana.DatumZavrsetka = dtpDatumZavrsetka.Value;
            selektovana.UkupanIznos = ukupanIznos;
            selektovana.IdInzenjer = ((Inzenjer)cmbInzenjer.SelectedItem).IdInzenjer;
            selektovana.IdKlijent = ((Common.Domain.Klijent)cmbKlijent.SelectedItem).IdKlijent;

            TableDataMember tdm = new TableDataMember
            {
                TehnickaDokumentacija = selektovana,
                TableName = currentPanel
            };

            try
            {
                TableDataBundle updated = ClientCommunication.Instance.ChangeTableMember(tdm);
                LoadTableTD(updated);
                MessageBox.Show("Dokumentacija je uspešno izmenjena!",
                                "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom izmene dokumentacije: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Kreiraj();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdDokumentacije.Text, out int idDokumentacije) || idDokumentacije <= 0)
            {
                MessageBox.Show("ID tehničke dokumentacije mora biti ceo broj veći od 0.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDatumPotpisivanja.Value >= dtpDatumZavrsetka.Value)
            {
                MessageBox.Show("Datum završetka mora biti nakon datuma potpisivanja.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUkupanIznos.Text, out decimal ukupanIznos) || ukupanIznos <= 0)
            {
                MessageBox.Show("Ukupan iznos mora biti broj veći od 0.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            LoadTableTD(tdcb);
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
                LoadTableTD(updated);

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

        // ------------------ DVOKLIK – UČITAVANJE STAVKI ------------------
        private void dgvDokumentacija_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DomainTD selektovana = dgvDokumentacija.Rows[e.RowIndex].DataBoundItem as DomainTD;

            if (selektovana == null)
            {
                MessageBox.Show("Greška pri učitavanju selektovane dokumentacije.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TableDataBundle tdb = ClientCommunication.Instance.GetAdditionalMemberData(currentPanel, selektovana.IdTehnickaDokumentacija);

                Debug.WriteLine($">>> [CLIENT] Broj stavki primljenih sa servera: {tdb.STehnickeDokumentacije.Count}");

                if (tdb.STehnickeDokumentacije.Count == 0)
                {
                    MessageBox.Show("Ova tehnička dokumentacija nema stavke.",
                                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LoadTableStavke(tdb.STehnickeDokumentacije);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju stavki: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
