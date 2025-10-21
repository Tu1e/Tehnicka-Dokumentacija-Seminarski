using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Client.Paneli
{
    public partial class PodesavanjaSistema : UserControl
    {
        private static bool _isLightThemeActive = false;
        private static Color _defaultFormColor = SystemColors.Control;

        public PodesavanjaSistema()
        {
            InitializeComponent();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var response = ClientCommunication.Instance.BackupDatabase();
                MessageBox.Show(response.ExceptionMessage ?? "Backup uspešno napravljen!",
                                "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri backupu: " + ex.Message);
            }
        }

        private void restoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                var response = ClientCommunication.Instance.RestoreDatabase();
                MessageBox.Show(response.ExceptionMessage ?? "Baza uspešno vraćena iz backupa!",
                                "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri restore-u: " + ex.Message);
            }
        }

        private void promenaTemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isLightThemeActive)
            {
                ApplyThemeToAllOpenForms(_defaultFormColor);
                _isLightThemeActive = false;

                MessageBox.Show("Tema vraćena na podrazumevanu boju.",
                                "Promena teme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Color lightBlue = Color.FromArgb(173, 216, 230);
                ApplyThemeToAllOpenForms(lightBlue);
                _isLightThemeActive = true;

                MessageBox.Show("Tema uspešno promenjena na svetlo plavu.",
                                "Promena teme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ApplyThemeToAllOpenForms(Color newColor)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = newColor;
                ApplyThemeToControls(form.Controls, newColor);
            }
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Color newColor)
        {
            foreach (Control control in controls)
            {
                control.BackColor = newColor;

                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls, newColor);
            }
        }
    }
}
