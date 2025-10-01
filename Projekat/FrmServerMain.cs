using Serverr;

namespace Projekat
{
    public partial class FrmServerMain : Form
    {
        private Server server;
        public FrmServerMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
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
