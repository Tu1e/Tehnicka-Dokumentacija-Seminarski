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
            dgvInzenjer = new DataGridView();
            txtOpis = new TextBox();
            txtGodIskustva = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInzenjer).BeginInit();
            SuspendLayout();
            // 
            // btnObtisi
            // 
            btnObtisi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnObtisi.AutoSize = true;
            btnObtisi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnObtisi.Location = new Point(586, 124);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Padding = new Padding(2, 0, 2, 0);
            btnObtisi.Size = new Size(52, 25);
            btnObtisi.TabIndex = 32;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSacuvaj.AutoSize = true;
            btnSacuvaj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSacuvaj.Location = new Point(516, 124);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Padding = new Padding(2, 0, 2, 0);
            btnSacuvaj.Size = new Size(61, 25);
            btnSacuvaj.TabIndex = 31;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIzmeni.AutoSize = true;
            btnIzmeni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIzmeni.Location = new Point(446, 124);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Padding = new Padding(2, 0, 2, 0);
            btnIzmeni.Size = new Size(56, 25);
            btnIzmeni.TabIndex = 30;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPretrazi.AutoSize = true;
            btnPretrazi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPretrazi.Location = new Point(376, 124);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Padding = new Padding(2, 0, 2, 0);
            btnPretrazi.Size = new Size(60, 25);
            btnPretrazi.TabIndex = 29;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKreiraj.AutoSize = true;
            btnKreiraj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKreiraj.Location = new Point(306, 124);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Padding = new Padding(2, 0, 2, 0);
            btnKreiraj.Size = new Size(54, 25);
            btnKreiraj.TabIndex = 28;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(304, 13);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 27;
            label6.Text = "Licenca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 129);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 26;
            label5.Text = "Šifra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 71);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 25;
            label4.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 42);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 24;
            label3.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 23;
            label2.Text = "ID inženjera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 100);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 22;
            label1.Text = "Korisničko ime:";
            // 
            // txtIdInzenjera
            // 
            txtIdInzenjera.Enabled = false;
            txtIdInzenjera.Location = new Point(137, 10);
            txtIdInzenjera.Name = "txtIdInzenjera";
            txtIdInzenjera.Size = new Size(128, 23);
            txtIdInzenjera.TabIndex = 33;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(137, 39);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(128, 23);
            txtIme.TabIndex = 34;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(137, 68);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(128, 23);
            txtPrezime.TabIndex = 35;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(137, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(128, 23);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(128, 23);
            txtPassword.TabIndex = 37;
            // 
            // txtLicenca
            // 
            txtLicenca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLicenca.Location = new Point(426, 10);
            txtLicenca.Name = "txtLicenca";
            txtLicenca.Size = new Size(128, 23);
            txtLicenca.TabIndex = 38;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(304, 42);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 39;
            label7.Text = "Tip inženjera:";
            // 
            // cmbTipInzenjera
            // 
            cmbTipInzenjera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTipInzenjera.FormattingEnabled = true;
            cmbTipInzenjera.Location = new Point(426, 39);
            cmbTipInzenjera.Name = "cmbTipInzenjera";
            cmbTipInzenjera.Size = new Size(128, 23);
            cmbTipInzenjera.TabIndex = 40;
            // 
            // dgvInzenjer
            // 
            dgvInzenjer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInzenjer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInzenjer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInzenjer.Location = new Point(20, 155);
            dgvInzenjer.MaximumSize = new Size(2000, 540);
            dgvInzenjer.MinimumSize = new Size(300, 90);
            dgvInzenjer.Name = "dgvInzenjer";
            dgvInzenjer.Size = new Size(642, 209);
            dgvInzenjer.TabIndex = 41;
            // 
            // txtOpis
            // 
            txtOpis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOpis.Location = new Point(426, 68);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(128, 23);
            txtOpis.TabIndex = 45;
            // 
            // txtGodIskustva
            // 
            txtGodIskustva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGodIskustva.Location = new Point(426, 97);
            txtGodIskustva.Name = "txtGodIskustva";
            txtGodIskustva.Size = new Size(128, 23);
            txtGodIskustva.TabIndex = 44;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(304, 100);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 43;
            label8.Text = "Godine iskustva:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(304, 71);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 42;
            label9.Text = "Opis:";
            // 
            // InzenjerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtOpis);
            Controls.Add(txtGodIskustva);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dgvInzenjer);
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
            Size = new Size(680, 382);
            ((System.ComponentModel.ISupportInitialize)dgvInzenjer).EndInit();
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
        private DataGridView dgvInzenjer;
        private TextBox txtOpis;
        private TextBox txtGodIskustva;
        private Label label8;
        private Label label9;
    }
}
