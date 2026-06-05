namespace PecoManager.Forms
{
    partial class FormRaport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitlu = new Label();
            lblStatTotal = new Label();
            lblSumaTotal = new Label();
            lblMedia = new Label();
            lblStatieTop = new Label();
            lblValStatTotal = new Label();
            lblValSumaTotal = new Label();
            lblValMedia = new Label();
            lblValStatieTop = new Label();
            btnGenereaza = new Button();
            btnExportTxt = new Button();
            dataGridView = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

            // lblTitlu
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitlu.Location = new Point(12, 12);
            lblTitlu.Text = "Raport Sumar Vânzări";

            // Statistici — etichete
            lblStatTotal.AutoSize = true;
            lblStatTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatTotal.Location = new Point(12, 55);
            lblStatTotal.Text = "Total tranzacții:";

            lblValStatTotal.AutoSize = true;
            lblValStatTotal.Font = new Font("Segoe UI", 9F);
            lblValStatTotal.Location = new Point(160, 55);
            lblValStatTotal.Text = "-";

            lblSumaTotal.AutoSize = true;
            lblSumaTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSumaTotal.Location = new Point(12, 80);
            lblSumaTotal.Text = "Total încasat:";

            lblValSumaTotal.AutoSize = true;
            lblValSumaTotal.Font = new Font("Segoe UI", 9F);
            lblValSumaTotal.Location = new Point(160, 80);
            lblValSumaTotal.Text = "-";

            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedia.Location = new Point(12, 105);
            lblMedia.Text = "Media/tranzacție:";

            lblValMedia.AutoSize = true;
            lblValMedia.Font = new Font("Segoe UI", 9F);
            lblValMedia.Location = new Point(160, 105);
            lblValMedia.Text = "-";

            lblStatieTop.AutoSize = true;
            lblStatieTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatieTop.Location = new Point(12, 130);
            lblStatieTop.Text = "Stație top vânzări:";

            lblValStatieTop.AutoSize = true;
            lblValStatieTop.Font = new Font("Segoe UI", 9F);
            lblValStatieTop.Location = new Point(160, 130);
            lblValStatieTop.Text = "-";

            // btnGenereaza
            btnGenereaza.Location = new Point(12, 165);
            btnGenereaza.Size = new Size(150, 30);
            btnGenereaza.Text = "🔄 Generează Raport";
            btnGenereaza.BackColor = Color.FromArgb(70, 130, 180);
            btnGenereaza.ForeColor = Color.White;
            btnGenereaza.FlatStyle = FlatStyle.Flat;
            btnGenereaza.Click += btnGenereaza_Click;

            // btnExportTxt
            btnExportTxt.Location = new Point(172, 165);
            btnExportTxt.Size = new Size(120, 30);
            btnExportTxt.Text = "📄 Export TXT";
            btnExportTxt.BackColor = Color.FromArgb(60, 179, 113);
            btnExportTxt.ForeColor = Color.White;
            btnExportTxt.FlatStyle = FlatStyle.Flat;
            btnExportTxt.Click += btnExportTxt_Click;

            // dataGridView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 210);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(760, 380);

            // FormRaport
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(lblTitlu);
            Controls.Add(lblStatTotal);
            Controls.Add(lblValStatTotal);
            Controls.Add(lblSumaTotal);
            Controls.Add(lblValSumaTotal);
            Controls.Add(lblMedia);
            Controls.Add(lblValMedia);
            Controls.Add(lblStatieTop);
            Controls.Add(lblValStatieTop);
            Controls.Add(btnGenereaza);
            Controls.Add(btnExportTxt);
            Controls.Add(dataGridView);
            Name = "FormRaport";
            Text = "Raport Sumar Vânzări";
            Load += FormRaport_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitlu;
        private Label lblStatTotal, lblValStatTotal;
        private Label lblSumaTotal, lblValSumaTotal;
        private Label lblMedia, lblValMedia;
        private Label lblStatieTop, lblValStatieTop;
        private Button btnGenereaza;
        private Button btnExportTxt;
        private DataGridView dataGridView;
    }
}