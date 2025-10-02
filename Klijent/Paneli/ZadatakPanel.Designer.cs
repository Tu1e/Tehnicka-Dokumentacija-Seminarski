namespace Client.Paneli
{
    partial class ZadatakPanel
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
            txtTrajanje = new TextBox();
            txtNazivZadatka = new TextBox();
            txtIdZadatka = new TextBox();
            btnObtisi = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            btnDodaj = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCena = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTrajanje
            // 
            txtTrajanje.Location = new Point(154, 93);
            txtTrajanje.Name = "txtTrajanje";
            txtTrajanje.Size = new Size(137, 23);
            txtTrajanje.TabIndex = 80;
            // 
            // txtNazivZadatka
            // 
            txtNazivZadatka.Location = new Point(154, 64);
            txtNazivZadatka.Name = "txtNazivZadatka";
            txtNazivZadatka.Size = new Size(137, 23);
            txtNazivZadatka.TabIndex = 79;
            // 
            // txtIdZadatka
            // 
            txtIdZadatka.Location = new Point(154, 35);
            txtIdZadatka.Name = "txtIdZadatka";
            txtIdZadatka.Size = new Size(137, 23);
            txtIdZadatka.TabIndex = 78;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(296, 340);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 77;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(215, 340);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 76;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(377, 340);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 75;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(134, 340);
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
            label4.Location = new Point(32, 96);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 73;
            label4.Text = "Trajanje (u satima):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 67);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 72;
            label3.Text = "Naziv zadatka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 71;
            label2.Text = "ID zadatka:";
            // 
            // txtCena
            // 
            txtCena.Location = new Point(154, 122);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(137, 23);
            txtCena.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 125);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 81;
            label1.Text = "Cena:";
            // 
            // ZadatakPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCena);
            Controls.Add(label1);
            Controls.Add(txtTrajanje);
            Controls.Add(txtNazivZadatka);
            Controls.Add(txtIdZadatka);
            Controls.Add(btnObtisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ZadatakPanel";
            Size = new Size(562, 403);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTrajanje;
        private TextBox txtNazivZadatka;
        private TextBox txtIdZadatka;
        private Button btnObtisi;
        private Button btnIzmeni;
        private Button btnPretrazi;
        private Button btnDodaj;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCena;
        private Label label1;
    }
}
