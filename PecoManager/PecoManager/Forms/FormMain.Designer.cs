namespace PecoManager.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            stațiiPECOToolStripMenuItem = new ToolStripMenuItem();
            combustibiliToolStripMenuItem = new ToolStripMenuItem();
            tranzacțiiToolStripMenuItem = new ToolStripMenuItem();
            rapoarteToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewStatii = new DataGridView();
            lblTitlu = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatii).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stațiiPECOToolStripMenuItem, combustibiliToolStripMenuItem, tranzacțiiToolStripMenuItem, rapoarteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1029, 30);
            menuStrip1.TabIndex = 0;
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
            // dataGridViewStatii
            // 
            dataGridViewStatii.AllowUserToAddRows = false;
            dataGridViewStatii.AllowUserToDeleteRows = false;
            dataGridViewStatii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatii.Location = new Point(14, 93);
            dataGridViewStatii.Margin = new Padding(3, 4, 3, 4);
            dataGridViewStatii.Name = "dataGridViewStatii";
            dataGridViewStatii.ReadOnly = true;
            dataGridViewStatii.RowHeadersVisible = false;
            dataGridViewStatii.RowHeadersWidth = 51;
            dataGridViewStatii.Size = new Size(983, 533);
            dataGridViewStatii.TabIndex = 1;
            // 
            // lblTitlu
            // 
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitlu.Location = new Point(14, 47);
            lblTitlu.Name = "lblTitlu";
            lblTitlu.Size = new Size(229, 32);
            lblTitlu.TabIndex = 0;
            lblTitlu.Text = "Stații PECO — Listă";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 667);
            Controls.Add(lblTitlu);
            Controls.Add(dataGridViewStatii);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Load += FormMain_Load;
            Text = "PecoManager — Sistem de gestionare stații PECO";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatii).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stațiiPECOToolStripMenuItem;
        private ToolStripMenuItem combustibiliToolStripMenuItem;
        private ToolStripMenuItem tranzacțiiToolStripMenuItem;
        private ToolStripMenuItem rapoarteToolStripMenuItem;
        private DataGridView dataGridViewStatii;
        private Label lblTitlu;
    }
}