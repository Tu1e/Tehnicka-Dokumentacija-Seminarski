using Common;
using Common.Domain;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using TD = Common.Domain.TehnickaDokumentacija;

namespace Client.Paneli
{
    public partial class StavkeTDPanel : UserControl
    {
        TableName currentTable = TableName.StavkaTehnickaDokumentacija;

        public StavkeTDPanel()
        {
            InitializeComponent();

            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(currentTable);

            cmbTD.DataSource = tdcb.TehnickeDokumentacije;
            cmbTD.DisplayMember = "IdTehnickaDokumentacija";
            cmbTD.ValueMember = "IdTehnickaDokumentacija";

            cmbZadatak.DataSource = tdcb.Zadaci;
            cmbZadatak.DisplayMember = "Naziv";
            cmbZadatak.ValueMember = "IdZadatak";

            txtCenaZadatka.TextChanged += (s, e) => UpdateUkupanIznos();
            txtKolicina.TextChanged += (s, e) => UpdateUkupanIznos();
        }

        private void UpdateUkupanIznos()
        {
            if (decimal.TryParse(txtCenaZadatka.Text, out decimal cena) &&
                int.TryParse(txtKolicina.Text, out int kolicina))
            {
                decimal ukupan = cena * kolicina;
                txtUIStavke.Text = ukupan.ToString("0.00");
            }
            else
            {
                txtUIStavke.Text = "";
            }
        }

        // -------------------- DODAJ --------------------
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbTD.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tehničku dokumentaciju.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbZadatak.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati zadatak.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRb.Text, out int rb))
            {
                MessageBox.Show("Redni broj (Rb) mora biti ceo broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSadrzaj.Text))
            {
                MessageBox.Show("Polje 'Sadržaj' je obavezno.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCenaZadatka.Text, out decimal cena))
            {
                MessageBox.Show("Cena zadatka mora biti broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtKolicina.Text, out int kolicina))
            {
                MessageBox.Show("Količina mora biti ceo broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal ukupan = cena * kolicina;
            txtUIStavke.Text = ukupan.ToString("0.00");

            TD izabranaTD = (TD)cmbTD.SelectedItem;
            Zadatak izabraniZadatak = (Zadatak)cmbZadatak.SelectedItem;

            TableDataMember tdm = new TableDataMember();
            StavkaTehnickaDokumentacija std = new StavkaTehnickaDokumentacija
            {
                IdTD = izabranaTD.IdTehnickaDokumentacija,
                Rb = rb,
                Sadrzaj = txtSadrzaj.Text.Trim(),
                DatumKreiranja = dtpDatumKreiranja.Value,
                CenaZadataka = cena,
                Kolicina = kolicina,
                UkupanIznosStavke = ukupan,
                IdZadatak = izabraniZadatak.IdZadatak
            };
            tdm.STDokumentacija = std;
            tdm.TableName = currentTable;

            try
            {
                TableDataBundle result = ClientCommunication.Instance.AddTableMember(tdm);
                if (result?.OperationSucceeded == true)
                {
                    MessageBox.Show("Nova stavka je uspešno dodata.",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dodavanje stavke nije uspelo. Proverite ID, Rb i zadatak.",
                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja stavke: " + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------- IZMENI --------------------
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cmbTD.SelectedItem == null || cmbZadatak.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tehničku dokumentaciju i zadatak.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRb.Text, out int rb))
            {
                MessageBox.Show("Rb mora biti broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCenaZadatka.Text, out decimal cena) ||
                !int.TryParse(txtKolicina.Text, out int kolicina))
            {
                MessageBox.Show("Cena i količina moraju biti brojevi.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal ukupan = cena * kolicina;
            txtUIStavke.Text = ukupan.ToString("0.00");

            TD izabranaTD = (TD)cmbTD.SelectedItem;
            Zadatak izabraniZadatak = (Zadatak)cmbZadatak.SelectedItem;

            TableDataMember tdm = new TableDataMember
            {
                STDokumentacija = new StavkaTehnickaDokumentacija
                {
                    IdTD = izabranaTD.IdTehnickaDokumentacija,
                    Rb = rb,
                    Sadrzaj = txtSadrzaj.Text.Trim(),
                    DatumKreiranja = dtpDatumKreiranja.Value,
                    CenaZadataka = cena,
                    Kolicina = kolicina,
                    UkupanIznosStavke = ukupan,
                    IdZadatak = izabraniZadatak.IdZadatak
                },
                TableName = currentTable
            };

            try
            {
                TableDataBundle result = ClientCommunication.Instance.ChangeTableMember(tdm);
                if (result?.OperationSucceeded == true)
                {
                    MessageBox.Show("Stavka je uspešno izmenjena.",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Izmena nije uspela. Proverite podatke.",
                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom izmene stavke: " + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------- OBRIŠI --------------------
        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (cmbTD.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tehničku dokumentaciju.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRb.Text, out int rb))
            {
                MessageBox.Show("Rb mora biti broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TD izabranaTD = (TD)cmbTD.SelectedItem;

            TableDataMember tdm = new TableDataMember
            {
                STDokumentacija = new StavkaTehnickaDokumentacija
                {
                    IdTD = izabranaTD.IdTehnickaDokumentacija,
                    Rb = rb
                },
                TableName = currentTable
            };

            try
            {
                TableDataBundle result = ClientCommunication.Instance.DeleteTableMember(tdm);

                if (result?.OperationSucceeded == true)
                {
                    MessageBox.Show("Stavka je uspešno obrisana.",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Brisanje nije uspelo. Stavka ne postoji.",
                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja stavke: " + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
