using Common;
using Common.Domain;
using Kl = Common.Domain.Klijent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Paneli
{
    public partial class KlijentPanel : UserControl
    {
        TableName currentPanel = TableName.Klijent;

        public KlijentPanel()
        {
            InitializeComponent();
            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(currentPanel);
            cmbMesto.DataSource = tdcb.Mesta;

            cmbMesto.DisplayMember = "NazivMesta";
            cmbMesto.ValueMember = "IdMesto";

            EnableDisableFields(false);
        }

        private void EnableDisableFields(bool action)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            cmbMesto.SelectedIndex = -1;
            chbStranac.Checked = false;

            txtIme.Enabled = action;
            txtPrezime.Enabled = action;
            cmbMesto.Enabled = action;
            chbStranac.Enabled = action;
            btnSacuvaj.Enabled = action;
        }
        private void LoadTable(TableDataBundle tdcb)
        {
            dgvKlijent.DataSource = null;
            dgvKlijent.DataSource = tdcb.Klijenti;

            dgvKlijent.AllowUserToAddRows = false;
            dgvKlijent.AllowUserToDeleteRows = false;
            dgvKlijent.ReadOnly = true;
        }

        private void Kreiraj()
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdKlijenta.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void btnKreiraj_Click(object sender, EventArgs e) => Kreiraj();

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            TableDataBundle tdcb = ClientCommunication.Instance.GetTableData(currentPanel);
            dgvKlijent.DataSource = tdcb.Klijenti;

            dgvKlijent.AllowUserToAddRows = false;
            dgvKlijent.AllowUserToDeleteRows = false;
            dgvKlijent.ReadOnly = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Polje 'Ime' je obavezno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Polje 'Prezime' je obavezno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMesto.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati mesto.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var izabranoMesto = (Mesto)cmbMesto.SelectedItem;
            bool stranac = chbStranac.Checked;

            if (izabranoMesto.NazivDrzave == "Srbija" && stranac)
            {
                MessageBox.Show("Klijent iz Srbije ne može biti označen kao stranac.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (izabranoMesto.NazivDrzave != "Srbija" && !stranac)
            {
                MessageBox.Show("Klijent iz strane države mora biti označen kao stranac.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember();

            Kl klijent = new Kl
            {
                IdKlijent = int.Parse(txtIdKlijenta.Text),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Stranac = stranac,
                IdMesto = izabranoMesto.IdMesto
            };

            tdm.Klijent = klijent;
            tdm.TableName = currentPanel;

            TableDataBundle tdcb = ClientCommunication.Instance.AddTableMember(tdm);
            LoadTable(tdcb);
            Kreiraj();
        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (dgvKlijent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati bar jednu dokumentaciju za brisanje.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete {dgvKlijent.SelectedRows.Count} dokumentacija?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                foreach (DataGridViewRow row in dgvKlijent.SelectedRows)
                {
                    Kl selektovana = row.DataBoundItem as Kl;
                    if (selektovana == null) continue;

                    TableDataMember tdm = new TableDataMember
                    {
                        Klijent = selektovana,
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
