namespace Projekat
{
    partial class FrmServerMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lblServerInfo = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.AutoSize = true;
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.Font = new Font("Segoe UI", 15F);
            btnStart.Location = new Point(112, 88);
            btnStart.MaximumSize = new Size(200, 100);
            btnStart.MinimumSize = new Size(50, 25);
            btnStart.Name = "btnStart";
            btnStart.Padding = new Padding(15, 10, 15, 10);
            btnStart.Size = new Size(93, 58);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.None;
            btnStop.AutoSize = true;
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.Font = new Font("Segoe UI", 15F);
            btnStop.Location = new Point(112, 227);
            btnStop.MaximumSize = new Size(200, 100);
            btnStop.MinimumSize = new Size(50, 25);
            btnStop.Name = "btnStop";
            btnStop.Padding = new Padding(15, 10, 15, 10);
            btnStop.Size = new Size(93, 58);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblServerInfo
            // 
            lblServerInfo.Anchor = AnchorStyles.None;
            lblServerInfo.AutoSize = true;
            lblServerInfo.Font = new Font("Segoe UI", 12F);
            lblServerInfo.Location = new Point(406, 185);
            lblServerInfo.Name = "lblServerInfo";
            lblServerInfo.Padding = new Padding(10);
            lblServerInfo.Size = new Size(176, 41);
            lblServerInfo.TabIndex = 2;
            lblServerInfo.Text = "Server nije pokretnut";
            // 
            // FrmServerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblServerInfo);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "FrmServerMain";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblServerInfo;
    }
}
