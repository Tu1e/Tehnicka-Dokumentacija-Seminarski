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
