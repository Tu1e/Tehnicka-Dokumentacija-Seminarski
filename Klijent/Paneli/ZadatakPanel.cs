using Common;
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

namespace Client.Paneli
{
    public partial class ZadatakPanel : UserControl
    {
        TableName currentTable = TableName.Zadatak;

        public ZadatakPanel()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdZadatka.Text))
            {
                MessageBox.Show("Polje 'ID zadatka' je obavezno.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNazivZadatka.Text))
            {
                MessageBox.Show("Polje 'Naziv zadatka' je obavezno.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtIdZadatka.Text);
            int trajanje = int.Parse(txtTrajanje.Text);
            int cena = int.Parse(txtCena.Text);

            if (trajanje <= 0)
            {
                MessageBox.Show("Trajanje zadatka mora biti duže od 0h.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cena <= 0)
            {
                MessageBox.Show("Cena zadatka mora biti veća od 0.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember
            {
                Zadatak = new Zadatak
                {
                    IdZadatak = id,
                    Naziv = txtNazivZadatka.Text,
                    Trajanje = trajanje,
                    Cena = cena,
                },
                TableName = currentTable
            };

            TableDataBundle tdcb = ClientCommunication.Instance.AddTableMember(tdm);
            if (tdcb.OperationSucceeded)
            {
                MessageBox.Show("Novi zadatak je uspešno sačuvan.",
                             "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Novi zadatak nije sačuvano. ID je verovatno zauzet.",
                            "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdZadatka.Text))
            {
                MessageBox.Show("ID mesta nije definisan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember();
            Zadatak zadatak = new Zadatak();
            zadatak.IdZadatak = int.Parse(txtIdZadatka.Text);
            tdm.Zadatak = zadatak;
            tdm.TableName = currentTable;
            try
            {
                TableDataBundle tdb = ClientCommunication.Instance.DeleteTableMember(tdm);

                if (tdb.OperationSucceeded)
                {
                    MessageBox.Show("Izabran zadatak je uspešno obrisan.",
                                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mesto sa datim indeksom ne postoji.",
                                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtIdZadatka.Text = "";
        }
    }
}
