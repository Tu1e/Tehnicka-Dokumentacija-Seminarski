namespace Client.Paneli
{
    partial class TipInzenjeraPanel
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
            txtNazivTipa = new TextBox();
            txtIdSSpreme = new TextBox();
            btnObtisi = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            btnDodaj = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNazivTipa
            // 
            txtNazivTipa.Location = new Point(142, 52);
            txtNazivTipa.Name = "txtNazivTipa";
            txtNazivTipa.Size = new Size(137, 23);
            txtNazivTipa.TabIndex = 91;
            // 
            // txtIdSSpreme
            // 
            txtIdSSpreme.Location = new Point(142, 23);
            txtIdSSpreme.Name = "txtIdSSpreme";
            txtIdSSpreme.Size = new Size(137, 23);
            txtIdSSpreme.TabIndex = 90;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(284, 328);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 89;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(203, 328);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 88;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(365, 328);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 87;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(122, 328);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 86;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 55);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 84;
            label3.Text = "Naziv tipa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 26);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 83;
            label2.Text = "ID stručne spreme:";
            // 
            // TipInzenjeraPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNazivTipa);
            Controls.Add(txtIdSSpreme);
            Controls.Add(btnObtisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TipInzenjeraPanel";
            Size = new Size(549, 397);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazivTipa;
        private TextBox txtIdSSpreme;
        private Button btnObtisi;
        private Button btnIzmeni;
        private Button btnPretrazi;
        private Button btnDodaj;
        private Label label3;
        private Label label2;
    }
}
