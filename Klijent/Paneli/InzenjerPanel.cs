using Common;
using Common.Domain;
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
    public partial class InzenjerPanel : UserControl
    {
        TableName currentPanel = TableName.Inzenjer;
        public InzenjerPanel()
        {
            InitializeComponent();
            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(currentPanel);
            LoadCmb(tdcb);

            EnableDisableFields(false);
            dgvInzenjer.AutoGenerateColumns = false;
        }

        private void EnableDisableFields(bool action)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtLicenca.Text = "";
            txtOpis.Text = "";
            txtGodIskustva.Text = "";

            cmbTipInzenjera.SelectedIndex = -1;

            cmbTipInzenjera.Enabled = action;
            txtIme.Enabled = action;
            txtPrezime.Enabled = action;
            txtUsername.Enabled = action;
            txtPassword.Enabled = action;
            txtLicenca.Enabled = action;
            txtOpis.Enabled = action;
            txtGodIskustva.Enabled = action;
            btnSacuvaj.Enabled = action;
        }

        private void Kreiraj()
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdInzenjera.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void LoadCmb(TableDataBundle tdcb)
        {
            cmbTipInzenjera.DataSource = tdcb.TipoviI;

            cmbTipInzenjera.DisplayMember = "Naziv";
            cmbTipInzenjera.ValueMember = "IdStrucnaSprema";
        }

        private void LoadTable(TableDataBundle tdcb)
        {
            dgvInzenjer.DataSource = null;
            dgvInzenjer.AutoGenerateColumns = false;
            dgvInzenjer.DataSource = tdcb.Inzenjeri;
            dgvInzenjer.Columns.Clear();

            foreach (var prop in typeof(Inzenjer).GetProperties())
            {
                if (prop.Name.Equals("Password", StringComparison.OrdinalIgnoreCase))
                    continue;
                if (prop.Name.Equals("Values", StringComparison.OrdinalIgnoreCase))
                    continue;
                if (prop.Name.Equals("TableName", StringComparison.OrdinalIgnoreCase))
                    continue;
                if (prop.Name.Equals("UpdateValues", StringComparison.OrdinalIgnoreCase))
                    continue;
                if (prop.Name.Equals("PrimaryKeyCondition", StringComparison.OrdinalIgnoreCase))
                    continue;
                if (prop.Name.Equals("ImePrezime", StringComparison.OrdinalIgnoreCase))
                    continue;

                string header = prop.Name;

                var displayAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                      .FirstOrDefault() as DisplayNameAttribute;

                if (displayAttr != null)
                    header = displayAttr.DisplayName;

                dgvInzenjer.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = prop.Name,
                    HeaderText = header,
                    ReadOnly = true,
                });
            }

            dgvInzenjer.DataSource = tdcb.Inzenjeri;
            dgvInzenjer.AllowUserToAddRows = false;
            dgvInzenjer.AllowUserToDeleteRows = false;
            dgvInzenjer.ReadOnly = true;
        }

        private void btnKreiraj_Click(object sender, EventArgs e) => Kreiraj();

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

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Polje 'Korisničko ime' je obavezno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 2)
            {
                MessageBox.Show("Šifra mora imati najmanje 3 karaktera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipInzenjera.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tip inženjera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!int.TryParse(txtGodIskustva.Text, out int godine) || godine < 1)
            {
                MessageBox.Show("Godine iskustva moraju biti broj veći od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember();

            Debug.WriteLine($">>> cmbInzenjer:{cmbTipInzenjera.TabIndex}");
            Inzenjer inzenjer = new Inzenjer
            {
                IdInzenjer = int.Parse(txtIdInzenjera.Text),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Licenca = txtLicenca.Text,
            };

            TipInzenjera izabraniTip = (TipInzenjera)cmbTipInzenjera.SelectedItem;

            InzenjerTip inzenjerTip = new InzenjerTip
            {
                IdInzenjer = int.Parse(txtIdInzenjera.Text),
                IdStrucnaSprema = izabraniTip.IdStrucnaSprema,
                Opis = txtOpis.Text,
                GodineIskustva = int.Parse(txtGodIskustva.Text),
            };

            tdm.Inzenjer = inzenjer;
            tdm.InzenjerTip = inzenjerTip;
            tdm.TableName = currentPanel;

            TableDataBundle tdcb = ClientCommunication.Instance.AddTableMember(tdm);
            LoadTable(tdcb);
            Kreiraj();
        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (dgvInzenjer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati bar jednog inženjera za brisanje.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete {dgvInzenjer.SelectedRows.Count} inženjera?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                foreach (DataGridViewRow row in dgvInzenjer.SelectedRows)
                {
                    Inzenjer selektovani = row.DataBoundItem as Inzenjer;
                    if (selektovani == null) continue;

                    TableDataMember tdm = new TableDataMember
                    {
                        Inzenjer = selektovani,
                        TableName = currentPanel
                    };

                    ClientCommunication.Instance.DeleteTableMember(tdm);
                }

                TableDataBundle updated = ClientCommunication.Instance.GetTableData(currentPanel);
                LoadTable(updated);

                MessageBox.Show("Selektovani inženjeri su uspešno obrisani.",
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
