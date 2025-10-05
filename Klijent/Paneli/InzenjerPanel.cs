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
        TableName currentPanel = TableName.Inzenjer;
        public InzenjerPanel()
        {
            InitializeComponent();
            TableDataBundle tdcb = ClientCommunication.Instance.LoadOtherTableData(currentPanel);
            cmbTipInzenjera.DataSource = tdcb.TipoviI;

            cmbTipInzenjera.DisplayMember = "Naziv";
            cmbTipInzenjera.ValueMember = "IdStrucnaSprema";

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

            cmbTipInzenjera.SelectedIndex = -1;

            cmbTipInzenjera.Enabled = action;
            txtIme.Enabled = action;
            txtPrezime.Enabled = action;
            txtUsername.Enabled = action;
            txtPassword.Enabled = action;
            txtLicenca.Enabled = action;
            btnSacuvaj.Enabled = action;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int id = ClientCommunication.Instance.GetNextFreeId(currentPanel);
            txtIdInzenjera.Text = id.ToString();

            EnableDisableFields(true);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            dgvInzenjer.Columns.Clear();
            TableDataBundle tdcb = ClientCommunication.Instance.GetTableData(currentPanel);
            dgvInzenjer.AutoGenerateColumns = false;
            dgvInzenjer.DataSource = tdcb.Inzenjeri;
            dgvInzenjer.Columns.Clear();

            foreach (var prop in typeof(Inzenjer).GetProperties())
            {
                if (prop.Name.Equals("Password", StringComparison.OrdinalIgnoreCase))
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
