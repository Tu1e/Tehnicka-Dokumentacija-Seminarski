using Client;
using Common.Communication;
using Common.Domain;
using System.Net.Sockets;

namespace Klijent
{
    public partial class FrmKlijentLogin : Form
    {
        public FrmKlijentLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    ClientCommunication.Instance.Connect();
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("GRESKA PRI POVEZIVANJU SA SERVEROM");
                }

                try
                {
                    Response response = ClientCommunication.Instance.Login(txtUsername.Text, txtPassword.Text);
                    if (response.ExceptionMessage == null)
                    {
                        FrmKlijentMain frmKlijentMain = new FrmKlijentMain();
                        frmKlijentMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ovaj korisnik ne postoji!");
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("btnPrijaviSe_Click>>> " + ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("btnPrijaviSe_Click>>> " + ex.Message);
                }
            }

        }

        private bool Validate()
        {
            bool isValid = true;

            txtUsername.BackColor = Color.White;
            txtUsername.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.BackColor = Color.Salmon;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.Salmon;
                isValid = false;
            }

            return isValid;
        }
    }
}
