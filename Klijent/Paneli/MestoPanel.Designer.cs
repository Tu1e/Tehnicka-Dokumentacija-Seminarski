namespace Client.Paneli
{
    partial class MestoPanel
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
            txtNazivMesta = new TextBox();
            txtIdMesta = new TextBox();
            btnObtisi = new Button();
            btnIzmeni = new Button();
            btnPretrazi = new Button();
            btnDodaj = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(149, 96);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(137, 23);
            txtPrezime.TabIndex = 70;
            // 
            // txtNazivMesta
            // 
            txtNazivMesta.Location = new Point(149, 67);
            txtNazivMesta.Name = "txtNazivMesta";
            txtNazivMesta.Size = new Size(137, 23);
            txtNazivMesta.TabIndex = 69;
            // 
            // txtIdMesta
            // 
            txtIdMesta.Location = new Point(149, 38);
            txtIdMesta.Name = "txtIdMesta";
            txtIdMesta.Size = new Size(137, 23);
            txtIdMesta.TabIndex = 68;
            // 
            // btnObtisi
            // 
            btnObtisi.Location = new Point(291, 343);
            btnObtisi.Name = "btnObtisi";
            btnObtisi.Size = new Size(75, 23);
            btnObtisi.TabIndex = 67;
            btnObtisi.Text = "Obriši";
            btnObtisi.UseVisualStyleBackColor = true;
            btnObtisi.Click += btnObtisi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(210, 343);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 65;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(372, 343);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 64;
            btnPretrazi.Text = "Pretraži";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(129, 343);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 63;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 99);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 61;
            label4.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 70);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 60;
            label3.Text = "Naziv mesta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 41);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 59;
            label2.Text = "ID mesta:";
            // 
            // MestoPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPrezime);
            Controls.Add(txtNazivMesta);
            Controls.Add(txtIdMesta);
            Controls.Add(btnObtisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnPretrazi);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "MestoPanel";
            Size = new Size(570, 416);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrezime;
        private TextBox txtNazivMesta;
        private TextBox txtIdMesta;
        private Button btnObtisi;
        private Button btnIzmeni;
        private Button btnPretrazi;
        private Button btnDodaj;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
