namespace Client.Paneli
{
    partial class KlijentPanel
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
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            txtIdKlijenta = new TextBox();
            btnObtisi = new Button();
            btnSacuvaj = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            btnKreiraj = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chbStranac = new CheckBox();
            dgvKlijent = new DataGridView();
            cmbMesto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKlijent).BeginInit();
            SuspendLayout();
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(139, 72);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(137, 23);
            txtPrezime.TabIndex = 54;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(139, 43);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(137, 23);
            txtIme.TabIndex = 53;
            // 
            // txtIdKlijenta
            // 
            txtIdKlijenta.Enabled = false;
            txtIdKlijenta.Location = new Point(139, 14);
            txtIdKlijenta.Name = "txtIdKlijenta";
            txtIdKlijenta.Size = new Size(137, 23);
            txtIdKlijenta.TabIndex = 52;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(450, 75);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 51;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(369, 75);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 50;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(531, 46);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 49;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(450, 46);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 48;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(369, 46);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 47;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 104);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 45;
            label5.Text = "Mesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 75);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 44;
            label4.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 46);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 43;
            label3.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 42;
            label2.Text = "ID klijenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 131);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 41;
            label1.Text = "Stranac:";
            // 
            // chbStranac
            // 
            chbStranac.AutoSize = true;
            chbStranac.Location = new Point(139, 130);
            chbStranac.Name = "chbStranac";
            chbStranac.Size = new Size(15, 14);
            chbStranac.TabIndex = 57;
            chbStranac.UseVisualStyleBackColor = true;
            // 
            // dgvKlijent
            // 
            dgvKlijent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijent.Location = new Point(17, 175);
            dgvKlijent.Name = "dgvKlijent";
            dgvKlijent.Size = new Size(640, 207);
            dgvKlijent.TabIndex = 58;
            // 
            // cmbMesto
            // 
            cmbMesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(139, 101);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(137, 23);
            cmbMesto.TabIndex = 60;
            // 
            // KlijentPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbMesto);
            Controls.Add(dgvKlijent);
            Controls.Add(chbStranac);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(txtIdKlijenta);
            Controls.Add(btnObtisi);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnKreiraj);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KlijentPanel";
            Size = new Size(677, 397);
            ((System.ComponentModel.ISupportInitialize)dgvKlijent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrezime;
        private TextBox txtIme;
        private TextBox txtIdKlijenta;
        private Button btnObtisi;
        private Button btnSacuvaj;
        private Button btnIzmeni;
        private Button btnPretrazi;
        private Button btnKreiraj;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chbStranac;
        private DataGridView dgvKlijent;
        private ComboBox cmbMesto;
    }
}
