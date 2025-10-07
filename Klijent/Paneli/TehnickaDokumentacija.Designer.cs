namespace Client.Paneli
{
    partial class TehnickaDokumentacija
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
            txtIdDokumentacije = new TextBox();
            txtUkupanIznos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvDokumentacija = new DataGridView();
            dtpDatumPotpisivanja = new DateTimePicker();
            dtpDatumZavrsetka = new DateTimePicker();
            cmbInzenjer = new ComboBox();
            cmbKlijent = new ComboBox();
            btnKreiraj = new Button();
            btnPretrazi = new Button();
            btnIzmeni = new Button();
            btnSacuvaj = new Button();
            btnObtisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDokumentacija).BeginInit();
            SuspendLayout();
            // 
            // txtIdDokumentacije
            // 
            txtIdDokumentacije.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtIdDokumentacije.Location = new Point(155, 13);
            txtIdDokumentacije.Name = "txtIdDokumentacije";
            txtIdDokumentacije.ReadOnly = true;
            txtIdDokumentacije.Size = new Size(200, 23);
            txtIdDokumentacije.TabIndex = 0;
            // 
            // txtUkupanIznos
            // 
            txtUkupanIznos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUkupanIznos.Location = new Point(155, 100);
            txtUkupanIznos.Name = "txtUkupanIznos";
            txtUkupanIznos.Size = new Size(200, 23);
            txtUkupanIznos.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(21, 103);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Ukupan iznos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 7;
            label2.Text = "ID dokumentacije:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 8;
            label3.Text = "Datum potpisivanja:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(21, 74);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Datum završetka:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(21, 132);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Inženjer:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(21, 161);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Klijent:";
            // 
            // dgvDokumentacija
            // 
            dgvDokumentacija.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDokumentacija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDokumentacija.Location = new Point(25, 187);
            dgvDokumentacija.MaximumSize = new Size(1800, 540);
            dgvDokumentacija.MinimumSize = new Size(300, 90);
            dgvDokumentacija.Name = "dgvDokumentacija";
            dgvDokumentacija.Size = new Size(600, 180);
            dgvDokumentacija.TabIndex = 12;
            // 
            // dtpDatumPotpisivanja
            // 
            dtpDatumPotpisivanja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpDatumPotpisivanja.Location = new Point(155, 42);
            dtpDatumPotpisivanja.Name = "dtpDatumPotpisivanja";
            dtpDatumPotpisivanja.Size = new Size(200, 23);
            dtpDatumPotpisivanja.TabIndex = 13;
            // 
            // dtpDatumZavrsetka
            // 
            dtpDatumZavrsetka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpDatumZavrsetka.Location = new Point(155, 71);
            dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            dtpDatumZavrsetka.Size = new Size(200, 23);
            dtpDatumZavrsetka.TabIndex = 14;
            // 
            // cmbInzenjer
            // 
            cmbInzenjer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbInzenjer.FormattingEnabled = true;
            cmbInzenjer.Location = new Point(155, 129);
            cmbInzenjer.Name = "cmbInzenjer";
            cmbInzenjer.Size = new Size(200, 23);
            cmbInzenjer.TabIndex = 15;
            // 
            // cmbKlijent
            // 
            cmbKlijent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbKlijent.FormattingEnabled = true;
            cmbKlijent.Location = new Point(155, 158);
            cmbKlijent.Name = "cmbKlijent";
            cmbKlijent.Size = new Size(200, 23);
            cmbKlijent.TabIndex = 16;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnKreiraj.AutoSize = true;
            btnKreiraj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKreiraj.Location = new Point(544, 16);
            btnKreiraj.MaximumSize = new Size(160, 50);
            btnKreiraj.MinimumSize = new Size(40, 12);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Padding = new Padding(15, 0, 15, 0);
            btnKreiraj.Size = new Size(80, 25);
            btnKreiraj.TabIndex = 17;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnPretrazi.AutoSize = true;
            btnPretrazi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPretrazi.Location = new Point(544, 45);
            btnPretrazi.MaximumSize = new Size(160, 50);
            btnPretrazi.MinimumSize = new Size(40, 12);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Padding = new Padding(12, 0, 12, 0);
            btnPretrazi.Size = new Size(80, 25);
            btnPretrazi.TabIndex = 18;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnIzmeni.AutoSize = true;
            btnIzmeni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIzmeni.Location = new Point(544, 74);
            btnIzmeni.MaximumSize = new Size(160, 50);
            btnIzmeni.MinimumSize = new Size(40, 12);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Padding = new Padding(14, 0, 14, 0);
            btnIzmeni.Size = new Size(80, 25);
            btnIzmeni.TabIndex = 19;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSacuvaj.AutoSize = true;
            btnSacuvaj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSacuvaj.Location = new Point(544, 103);
            btnSacuvaj.MaximumSize = new Size(160, 50);
            btnSacuvaj.MinimumSize = new Size(40, 12);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Padding = new Padding(12, 0, 12, 0);
            btnSacuvaj.Size = new Size(81, 25);
            btnSacuvaj.TabIndex = 20;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnObtisi
            // 
            btnObtisi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnObtisi.AutoSize = true;
            btnObtisi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnObtisi.Location = new Point(544, 132);
            btnObtisi.MaximumSize = new Size(160, 50);
            btnObtisi.MinimumSize = new Size(40, 12);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Padding = new Padding(16, 0, 16, 0);
            btnObtisi.Size = new Size(80, 25);
            btnObtisi.TabIndex = 21;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // TehnickaDokumentacija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnObtisi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnKreiraj);
            Controls.Add(cmbKlijent);
            Controls.Add(cmbInzenjer);
            Controls.Add(dtpDatumZavrsetka);
            Controls.Add(dtpDatumPotpisivanja);
            Controls.Add(dgvDokumentacija);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUkupanIznos);
            Controls.Add(txtIdDokumentacije);
            Name = "TehnickaDokumentacija";
            Size = new Size(649, 379);
            ((System.ComponentModel.ISupportInitialize)dgvDokumentacija).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdDokumentacije;
        private TextBox txtDatumPotpisivanja;
        private TextBox txtDatumZavrsetka;
        private TextBox txtUkupanIznos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvDokumentacija;
        private DateTimePicker dtpDatumPotpisivanja;
        private DateTimePicker dtpDatumZavrsetka;
        private ComboBox cmbInzenjer;
        private ComboBox cmbKlijent;
        private Button btnKreiraj;
        private Button btnPretrazi;
        private Button btnIzmeni;
        private Button btnSacuvaj;
        private Button btnObtisi;
    }
}
