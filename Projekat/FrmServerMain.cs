
namespace Projekat
{
    public partial class FrmServerMain : Form
    {
        private Serverr.Server server;
        public FrmServerMain()
        {
            InitializeComponent();
            MessageBox.Show("Sistem je zapamtio inženjera.", "Ubacivanje inženjera", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Sistem ne može da zapamti inženjera.", "Ubacivanje inženjera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Serverr.Server();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblServerInfo.Text = "Server je pokrenut!";
            server.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblServerInfo.Text = "Server je zaustavljen!";
            server.Stop();
        }
    }
}
