using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Paneli
{
    public partial class MestoPanel : UserControl
    {
        TableName currentTable = TableName.Mesto;
        public MestoPanel()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivMesta.Text))
            {
                MessageBox.Show("Polje 'Naziv mesta' je obavezno.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDrzava.Text))
            {
                MessageBox.Show("Polje 'Naziv države' je obavezno.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNazivMesta.Text.Length < 2)
            {
                MessageBox.Show("Naziv mesta mora sadržati najmanje 2 karaktera.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDrzava.Text.Length < 2)
            {
                MessageBox.Show("Naziv države mora sadržati najmanje 2 karaktera.",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember
            {
                Mesto = new Mesto
                {
                    IdMesto = int.Parse(txtIdMesta.Text),
                    NazivMesta = txtNazivMesta.Text.Trim(),
                    NazivDrzave = txtDrzava.Text.Trim()
                },
                TableName = currentTable
            };

            TableDataBundle tdcb = ClientCommunication.Instance.AddTableMember(tdm);
            if(tdcb.OperationSucceeded)
            {
               MessageBox.Show("Novo mesto je uspešno sačuvano.",
                            "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Novo mesto nije sačuvano. ID je verovatno zauzet.",
                            "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdMesta.Text))
            {
                MessageBox.Show("ID mesta nije definisan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TableDataMember tdm = new TableDataMember();
            Mesto mesto = new Mesto();
            mesto.IdMesto = int.Parse(txtIdMesta.Text);
            tdm.Mesto = mesto;
            tdm.TableName = currentTable;
            try
            {
                TableDataBundle tdb = ClientCommunication.Instance.DeleteTableMember(tdm);

                if (tdb.OperationSucceeded)
                {
                    MessageBox.Show("Selektovane dokumentacije su uspešno obrisane.", 
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

            txtIdMesta.Text = "";
        }
    }
}
