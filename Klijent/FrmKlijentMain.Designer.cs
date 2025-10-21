namespace Client
{
    partial class FrmKlijentMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opcijeToolStripMenuItem = new ToolStripMenuItem();
            dokumenitTSMItem = new ToolStripMenuItem();
            tehnickaDokumentacijaTSMItem = new ToolStripMenuItem();
            pružalacUslugeToolStripMenuItem = new ToolStripMenuItem();
            inzenjerTSMItem = new ToolStripMenuItem();
            primalacUslugeToolStripMenuItem = new ToolStripMenuItem();
            klijentTSMItem = new ToolStripMenuItem();
            šifarniciToolStripMenuItem = new ToolStripMenuItem();
            mestoTSMItem = new ToolStripMenuItem();
            zadatakTSMItem = new ToolStripMenuItem();
            tipInzenjeraTSMItem = new ToolStripMenuItem();
            podešavanjaSistemaTSMItem = new ToolStripMenuItem();
            oProgramuTSMItem = new ToolStripMenuItem();
            pnlMain = new Panel();
            stavkaTDToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcijeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(678, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            opcijeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dokumenitTSMItem, pružalacUslugeToolStripMenuItem, primalacUslugeToolStripMenuItem, šifarniciToolStripMenuItem, podešavanjaSistemaTSMItem, oProgramuTSMItem });
            opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            opcijeToolStripMenuItem.Size = new Size(53, 20);
            opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // dokumenitTSMItem
            // 
            dokumenitTSMItem.DropDownItems.AddRange(new ToolStripItem[] { tehnickaDokumentacijaTSMItem });
            dokumenitTSMItem.Name = "dokumenitTSMItem";
            dokumenitTSMItem.Size = new Size(183, 22);
            dokumenitTSMItem.Text = "Dokumeniti";
            // 
            // tehnickaDokumentacijaTSMItem
            // 
            tehnickaDokumentacijaTSMItem.Name = "tehnickaDokumentacijaTSMItem";
            tehnickaDokumentacijaTSMItem.Size = new Size(202, 22);
            tehnickaDokumentacijaTSMItem.Text = "Tehnička dokumentacija";
            tehnickaDokumentacijaTSMItem.Click += tehnickaDokumentacijaTSMItem_Click;
            // 
            // pružalacUslugeToolStripMenuItem
            // 
            pružalacUslugeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inzenjerTSMItem });
            pružalacUslugeToolStripMenuItem.Name = "pružalacUslugeToolStripMenuItem";
            pružalacUslugeToolStripMenuItem.Size = new Size(183, 22);
            pružalacUslugeToolStripMenuItem.Text = "Pružalac usluge";
            // 
            // inzenjerTSMItem
            // 
            inzenjerTSMItem.Name = "inzenjerTSMItem";
            inzenjerTSMItem.Size = new Size(115, 22);
            inzenjerTSMItem.Text = "Inženjer";
            inzenjerTSMItem.Click += inzenjerTSMItem_Click;
            // 
            // primalacUslugeToolStripMenuItem
            // 
            primalacUslugeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { klijentTSMItem });
            primalacUslugeToolStripMenuItem.Name = "primalacUslugeToolStripMenuItem";
            primalacUslugeToolStripMenuItem.Size = new Size(183, 22);
            primalacUslugeToolStripMenuItem.Text = "Primalac usluge";
            // 
            // klijentTSMItem
            // 
            klijentTSMItem.Name = "klijentTSMItem";
            klijentTSMItem.Size = new Size(107, 22);
            klijentTSMItem.Text = "Klijent";
            klijentTSMItem.Click += klijentTSMItem_Click;
            // 
            // šifarniciToolStripMenuItem
            // 
            šifarniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mestoTSMItem, zadatakTSMItem, tipInzenjeraTSMItem, stavkaTDToolStripMenuItem });
            šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            šifarniciToolStripMenuItem.Size = new Size(183, 22);
            šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // mestoTSMItem
            // 
            mestoTSMItem.Name = "mestoTSMItem";
            mestoTSMItem.Size = new Size(180, 22);
            mestoTSMItem.Text = "Mesto";
            mestoTSMItem.Click += mestoTSMItem_Click;
            // 
            // zadatakTSMItem
            // 
            zadatakTSMItem.Name = "zadatakTSMItem";
            zadatakTSMItem.Size = new Size(180, 22);
            zadatakTSMItem.Text = "Zadatak";
            zadatakTSMItem.Click += zadatakTSMItem_Click;
            // 
            // tipInzenjeraTSMItem
            // 
            tipInzenjeraTSMItem.Name = "tipInzenjeraTSMItem";
            tipInzenjeraTSMItem.Size = new Size(180, 22);
            tipInzenjeraTSMItem.Text = "Tip inženjera";
            tipInzenjeraTSMItem.Click += tipInzenjeraTSMItem_Click;
            // 
            // podešavanjaSistemaTSMItem
            // 
            podešavanjaSistemaTSMItem.Name = "podešavanjaSistemaTSMItem";
            podešavanjaSistemaTSMItem.Size = new Size(183, 22);
            podešavanjaSistemaTSMItem.Text = "Podešavanja sistema";
            podešavanjaSistemaTSMItem.Click += podešavanjaSistemaTSMItem_Click;
            // 
            // oProgramuTSMItem
            // 
            oProgramuTSMItem.Name = "oProgramuTSMItem";
            oProgramuTSMItem.Size = new Size(183, 22);
            oProgramuTSMItem.Text = "O programu";
            oProgramuTSMItem.Click += oProgramuTSMItem_Click;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(12, 38);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(654, 404);
            pnlMain.TabIndex = 1;
            // 
            // stavkaTDToolStripMenuItem
            // 
            stavkaTDToolStripMenuItem.Name = "stavkaTDToolStripMenuItem";
            stavkaTDToolStripMenuItem.Size = new Size(180, 22);
            stavkaTDToolStripMenuItem.Text = "Stavka TD";
            stavkaTDToolStripMenuItem.Click += stavkaTDToolStripMenuItem_Click;
            // 
            // FrmKlijentMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 465);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmKlijentMain";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcijeToolStripMenuItem;
        private ToolStripMenuItem dokumenitTSMItem;
        private ToolStripMenuItem tehnickaDokumentacijaTSMItem;
        private ToolStripMenuItem pružalacUslugeToolStripMenuItem;
        private ToolStripMenuItem inzenjerTSMItem;
        private ToolStripMenuItem primalacUslugeToolStripMenuItem;
        private ToolStripMenuItem klijentTSMItem;
        private ToolStripMenuItem šifarniciToolStripMenuItem;
        private ToolStripMenuItem mestoTSMItem;
        private ToolStripMenuItem zadatakTSMItem;
        private ToolStripMenuItem tipInzenjeraTSMItem;
        private ToolStripMenuItem podešavanjaSistemaTSMItem;
        private ToolStripMenuItem oProgramuTSMItem;
        private Panel pnlMain;
        private ToolStripMenuItem stavkaTDToolStripMenuItem;
    }
}