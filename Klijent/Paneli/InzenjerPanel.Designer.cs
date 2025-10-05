namespace Client.Paneli
{
    partial class InzenjerPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnObtisi = new Button();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            btnKreiraj = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIdInzenjera = new TextBox();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtLicenca = new TextBox();
            label7 = new Label();
            cmbTipInzenjera = new ComboBox();
            SuspendLayout();
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(461, 327);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 32;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(380, 327);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 31;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(299, 327);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 30;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(218, 327);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 29;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(137, 327);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 28;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 158);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 27;
            label6.Text = "Licenca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 129);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 26;
            label5.Text = "Šifra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 71);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 25;
            label4.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 42);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 24;
            label3.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 23;
            label2.Text = "ID inženjera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 100);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 22;
            label1.Text = "Korisničko ime:";
            // 
            // txtIdInzenjera
            // 
            txtIdInzenjera.Enabled = false;
            txtIdInzenjera.Location = new Point(141, 10);
            txtIdInzenjera.Name = "txtIdInzenjera";
            txtIdInzenjera.Size = new Size(137, 23);
            txtIdInzenjera.TabIndex = 33;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(141, 39);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(137, 23);
            txtIme.TabIndex = 34;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(141, 68);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(137, 23);
            txtPrezime.TabIndex = 35;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(141, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(137, 23);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(137, 23);
            txtPassword.TabIndex = 37;
            // 
            // txtLicenca
            // 
            txtLicenca.Location = new Point(141, 155);
            txtLicenca.Name = "txtLicenca";
            txtLicenca.Size = new Size(137, 23);
            txtLicenca.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 13);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 39;
            label7.Text = "Tip inženjera:";
            // 
            // cmbTipInzenjera
            // 
            cmbTipInzenjera.FormattingEnabled = true;
            cmbTipInzenjera.Location = new Point(442, 10);
            cmbTipInzenjera.Name = "cmbTipInzenjera";
            cmbTipInzenjera.Size = new Size(137, 23);
            cmbTipInzenjera.TabIndex = 40;
            // 
            // InzenjerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbTipInzenjera);
            Controls.Add(label7);
            Controls.Add(txtLicenca);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(txtIdInzenjera);
            Controls.Add(btnObtisi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnKreiraj);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InzenjerPanel";
            Size = new Size(683, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObtisi;
        private Button btnSacuvaj;
        private Button btnIzmeni;
        private Button btnPretrazi;
        private Button btnKreiraj;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIdInzenjera;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtLicenca;
        private Label label7;
        private ComboBox cmbTipInzenjera;
    }
}
