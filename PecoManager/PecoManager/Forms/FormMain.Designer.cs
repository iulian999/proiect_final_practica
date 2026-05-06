namespace PecoManager.Forms
{
    partial class FormMain
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
            stațiiPECOToolStripMenuItem = new ToolStripMenuItem();
            combustibiliToolStripMenuItem = new ToolStripMenuItem();
            tranzacțiiToolStripMenuItem = new ToolStripMenuItem();
            rapoarteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stațiiPECOToolStripMenuItem, combustibiliToolStripMenuItem, tranzacțiiToolStripMenuItem, rapoarteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // stațiiPECOToolStripMenuItem
            // 
            stațiiPECOToolStripMenuItem.Name = "stațiiPECOToolStripMenuItem";
            stațiiPECOToolStripMenuItem.Size = new Size(97, 24);
            stațiiPECOToolStripMenuItem.Text = "Stații PECO";
            stațiiPECOToolStripMenuItem.Click += stațiiPECOToolStripMenuItem_Click;
            // 
            // combustibiliToolStripMenuItem
            // 
            combustibiliToolStripMenuItem.Name = "combustibiliToolStripMenuItem";
            combustibiliToolStripMenuItem.Size = new Size(107, 24);
            combustibiliToolStripMenuItem.Text = "Combustibili";
            combustibiliToolStripMenuItem.Click += combustibiliToolStripMenuItem_Click;
            // 
            // tranzacțiiToolStripMenuItem
            // 
            tranzacțiiToolStripMenuItem.Name = "tranzacțiiToolStripMenuItem";
            tranzacțiiToolStripMenuItem.Size = new Size(86, 24);
            tranzacțiiToolStripMenuItem.Text = "Tranzacții";
            tranzacțiiToolStripMenuItem.Click += tranzacțiiToolStripMenuItem_Click;
            // 
            // rapoarteToolStripMenuItem
            // 
            rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            rapoarteToolStripMenuItem.Size = new Size(84, 24);
            rapoarteToolStripMenuItem.Text = "Rapoarte";
            rapoarteToolStripMenuItem.Click += rapoarteToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "PecoManager — Sistem de gestionare stații PECO\n";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stațiiPECOToolStripMenuItem;
        private ToolStripMenuItem combustibiliToolStripMenuItem;
        private ToolStripMenuItem tranzacțiiToolStripMenuItem;
        private ToolStripMenuItem rapoarteToolStripMenuItem;
    }
}