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
            txtIdDokumentacije.Location = new Point(155, 13);
            txtIdDokumentacije.Name = "txtIdDokumentacije";
            txtIdDokumentacije.ReadOnly = true;
            txtIdDokumentacije.Size = new Size(200, 23);
            txtIdDokumentacije.TabIndex = 0;
            // 
            // txtUkupanIznos
            // 
            txtUkupanIznos.Location = new Point(155, 100);
            txtUkupanIznos.Name = "txtUkupanIznos";
            txtUkupanIznos.Size = new Size(200, 23);
            txtUkupanIznos.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 103);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Ukupan iznos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 7;
            label2.Text = "ID dokumentacije:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 8;
            label3.Text = "Datum potpisivanja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 74);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Datum završetka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 132);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Inženjer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 161);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Klijent:";
            // 
            // dgvDokumentacija
            // 
            dgvDokumentacija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDokumentacija.Location = new Point(21, 192);
            dgvDokumentacija.Name = "dgvDokumentacija";
            dgvDokumentacija.Size = new Size(601, 174);
            dgvDokumentacija.TabIndex = 12;
            // 
            // dtpDatumPotpisivanja
            // 
            dtpDatumPotpisivanja.Location = new Point(155, 42);
            dtpDatumPotpisivanja.Name = "dtpDatumPotpisivanja";
            dtpDatumPotpisivanja.Size = new Size(200, 23);
            dtpDatumPotpisivanja.TabIndex = 13;
            // 
            // dtpDatumZavrsetka
            // 
            dtpDatumZavrsetka.Location = new Point(155, 71);
            dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            dtpDatumZavrsetka.Size = new Size(200, 23);
            dtpDatumZavrsetka.TabIndex = 14;
            // 
            // cmbInzenjer
            // 
            cmbInzenjer.FormattingEnabled = true;
            cmbInzenjer.Location = new Point(155, 129);
            cmbInzenjer.Name = "cmbInzenjer";
            cmbInzenjer.Size = new Size(200, 23);
            cmbInzenjer.TabIndex = 15;
            // 
            // cmbKlijent
            // 
            cmbKlijent.FormattingEnabled = true;
            cmbKlijent.Location = new Point(155, 158);
            cmbKlijent.Name = "cmbKlijent";
            cmbKlijent.Size = new Size(200, 23);
            cmbKlijent.TabIndex = 16;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(547, 16);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 17;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(547, 45);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 18;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(547, 74);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 19;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(547, 103);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 20;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(547, 132);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
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
