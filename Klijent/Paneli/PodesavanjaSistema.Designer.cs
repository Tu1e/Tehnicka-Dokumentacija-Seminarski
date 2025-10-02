namespace Client.Paneli
{
    partial class PodesavanjaSistema
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
            menuStrip1 = new MenuStrip();
            podešavanjaToolStripMenuItem = new ToolStripMenuItem();
            promenaLozinkeToolStripMenuItem = new ToolStripMenuItem();
            upravljanjeBazomToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            promenaTemeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { podešavanjaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // podešavanjaToolStripMenuItem
            // 
            podešavanjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { promenaLozinkeToolStripMenuItem, upravljanjeBazomToolStripMenuItem, promenaTemeToolStripMenuItem });
            podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            podešavanjaToolStripMenuItem.Size = new Size(85, 20);
            podešavanjaToolStripMenuItem.Text = "Podešavanja";
            // 
            // promenaLozinkeToolStripMenuItem
            // 
            promenaLozinkeToolStripMenuItem.Name = "promenaLozinkeToolStripMenuItem";
            promenaLozinkeToolStripMenuItem.Size = new Size(180, 22);
            promenaLozinkeToolStripMenuItem.Text = "Promena lozinke";
            // 
            // upravljanjeBazomToolStripMenuItem
            // 
            upravljanjeBazomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupToolStripMenuItem, restoreToolStripMenuItem });
            upravljanjeBazomToolStripMenuItem.Name = "upravljanjeBazomToolStripMenuItem";
            upravljanjeBazomToolStripMenuItem.Size = new Size(180, 22);
            upravljanjeBazomToolStripMenuItem.Text = "Upravljanje bazom";
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(180, 22);
            backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.Size = new Size(180, 22);
            restoreToolStripMenuItem.Text = "Restore";
            // 
            // promenaTemeToolStripMenuItem
            // 
            promenaTemeToolStripMenuItem.Name = "promenaTemeToolStripMenuItem";
            promenaTemeToolStripMenuItem.Size = new Size(185, 22);
            promenaTemeToolStripMenuItem.Text = "Promena izgleda app";
            // 
            // PodesavanjaSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "PodesavanjaSistema";
            Size = new Size(584, 372);
            Load += PodesavanjaSistema_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem podešavanjaToolStripMenuItem;
        private ToolStripMenuItem promenaLozinkeToolStripMenuItem;
        private ToolStripMenuItem upravljanjeBazomToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripMenuItem promenaTemeToolStripMenuItem;
    }
}
