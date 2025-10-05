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
    public partial class KlijentPanel : UserControl
    {
        TableName currentPanel = TableName.Klijent;

        public KlijentPanel()
        {
            InitializeComponent();
            EnableDisableFields(false);

        }

        private void EnableDisableFields(bool action)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtMesto.Text = "";
            chbStranac.Checked = false;

            txtIme.Enabled = action;
            txtPrezime.Enabled = action;
            txtMesto.Enabled = action;
            chbStranac.Enabled = action;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdKlijenta.Text = id.ToString();

            EnableDisableFields(true);
        }

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

        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {

        }
    }
}
