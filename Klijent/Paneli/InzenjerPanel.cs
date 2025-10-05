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
    public partial class InzenjerPanel : UserControl
    {
        public InzenjerPanel()
        {
            InitializeComponent();
            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(TableName.Inzenjer);
            cmbTipInzenjera.DataSource = tdcb.TipoviI;

            cmbTipInzenjera.DisplayMember = "Naziv";
            cmbTipInzenjera.ValueMember = "IdStrucnaSprema";

            EnableDisableFields(false);
        }

        private void EnableDisableFields(bool action)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtLicenca.Text = "";

            cmbTipInzenjera.SelectedIndex = -1;

            cmbTipInzenjera.Enabled = action;
            txtIme.Enabled = action;
            txtPrezime.Enabled = action;
            txtUsername.Enabled = action;
            txtPassword.Enabled = action;
            txtLicenca.Enabled = action;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int id = ClientCommunication.Instance.GetNextFreeId(TableName.Inzenjer);
            txtIdInzenjera.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

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
