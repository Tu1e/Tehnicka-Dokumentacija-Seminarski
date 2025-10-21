namespace Client.Paneli
{
    partial class StavkeTDPanel
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
            txtSadrzaj = new TextBox();
            txtRb = new TextBox();
            btnObtisi = new Button();
            btnIzmeni = new Button();
            btnDodaj = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCenaZadatka = new TextBox();
            label1 = new Label();
            label5 = new Label();
            txtKolicina = new TextBox();
            label7 = new Label();
            txtUIStavke = new TextBox();
            label8 = new Label();
            cmbTD = new ComboBox();
            dtpDatumKreiranja = new DateTimePicker();
            label6 = new Label();
            cmbZadatak = new ComboBox();
            SuspendLayout();
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(194, 75);
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(195, 23);
            txtSadrzaj.TabIndex = 79;
            // 
            // txtRb
            // 
            txtRb.Location = new Point(194, 46);
            txtRb.Name = "txtRb";
            txtRb.Size = new Size(195, 23);
            txtRb.TabIndex = 78;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(314, 322);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 76;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(233, 322);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 75;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(152, 322);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 74;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 78);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 73;
            label4.Text = "Sadržaj:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 49);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 72;
            label3.Text = "Rb:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 20);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 71;
            label2.Text = "Tehnicka dokumentacija:";
            // 
            // txtCenaZadatka
            // 
            txtCenaZadatka.Location = new Point(194, 134);
            txtCenaZadatka.Name = "txtCenaZadatka";
            txtCenaZadatka.Size = new Size(195, 23);
            txtCenaZadatka.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 137);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 80;
            label1.Text = "Cena zadatka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 107);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 82;
            label5.Text = "Datum kreiranja:";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(194, 164);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(195, 23);
            txtKolicina.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 167);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 86;
            label7.Text = "Količina:";
            // 
            // txtUIStavke
            // 
            txtUIStavke.Location = new Point(194, 193);
            txtUIStavke.Name = "txtUIStavke";
            txtUIStavke.ReadOnly = true;
            txtUIStavke.Size = new Size(195, 23);
            txtUIStavke.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 196);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 88;
            label8.Text = "Ukupan iznos stavke:";
            // 
            // cmbTD
            // 
            cmbTD.FormattingEnabled = true;
            cmbTD.Location = new Point(194, 17);
            cmbTD.Name = "cmbTD";
            cmbTD.Size = new Size(195, 23);
            cmbTD.TabIndex = 90;
            // 
            // dtpDatumKreiranja
            // 
            dtpDatumKreiranja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpDatumKreiranja.Location = new Point(194, 104);
            dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            dtpDatumKreiranja.Size = new Size(195, 23);
            dtpDatumKreiranja.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 228);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 92;
            label6.Text = "Zadatak:";
            // 
            // cmbZadatak
            // 
            cmbZadatak.FormattingEnabled = true;
            cmbZadatak.Location = new Point(194, 225);
            cmbZadatak.Name = "cmbZadatak";
            cmbZadatak.Size = new Size(195, 23);
            cmbZadatak.TabIndex = 93;
            // 
            // StavkeTDPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbZadatak);
            Controls.Add(label6);
            Controls.Add(dtpDatumKreiranja);
            Controls.Add(cmbTD);
            Controls.Add(txtUIStavke);
            Controls.Add(label8);
            Controls.Add(txtKolicina);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtCenaZadatka);
            Controls.Add(label1);
            Controls.Add(txtSadrzaj);
            Controls.Add(txtRb);
            Controls.Add(btnObtisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "StavkeTDPanel";
            Size = new Size(465, 362);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSadrzaj;
        private TextBox txtRb;
        private Button btnObtisi;
        private Button btnIzmeni;
        private Button btnDodaj;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCenaZadatka;
        private Label label1;
        private Label label5;
        private TextBox txtKolicina;
        private Label label7;
        private TextBox txtUIStavke;
        private Label label8;
        private ComboBox cmbTD;
        private DateTimePicker dtpDatumKreiranja;
        private Label label6;
        private ComboBox cmbZadatak;
    }
}
