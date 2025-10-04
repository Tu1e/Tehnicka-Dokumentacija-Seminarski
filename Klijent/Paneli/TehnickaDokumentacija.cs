using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Client.Paneli
{
    public partial class TehnickaDokumentacija : UserControl
    {
        public TehnickaDokumentacija()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            ClientCommunication.Instance.GetNextFreeId(TableName.TehnickaDokumentacija);

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //Provere polja

        }

        private void btnObtisi_Click(object sender, EventArgs e)
        {

        }
    }
}
