namespace PecoManager.Forms
{
    partial class FormStatii
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
            txtCautare = new TextBox();
            btnCauta = new Button();
            btnAdauga = new Button();
            btnModifica = new Button();
            btnSterge = new Button();
            dataGridView = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

            // lblTitlu
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitlu.Location = new Point(12, 12);
            lblTitlu.Text = "Gestionare Stații PECO";

            // txtCautare
            txtCautare.Location = new Point(12, 55);
            txtCautare.PlaceholderText = "Caută după denumire sau oraș...";
            txtCautare.Size = new Size(350, 23);

            // btnCauta
            btnCauta.Location = new Point(370, 54);
            btnCauta.Size = new Size(80, 25);
            btnCauta.Text = "Caută";
            btnCauta.BackColor = Color.FromArgb(70, 130, 180);
            btnCauta.ForeColor = Color.White;
            btnCauta.FlatStyle = FlatStyle.Flat;
            btnCauta.Click += btnCauta_Click;

            // btnAdauga
            btnAdauga.Location = new Point(460, 54);
            btnAdauga.Size = new Size(90, 25);
            btnAdauga.Text = "+ Adaugă";
            btnAdauga.BackColor = Color.FromArgb(60, 179, 113);
            btnAdauga.ForeColor = Color.White;
            btnAdauga.FlatStyle = FlatStyle.Flat;
            btnAdauga.Click += btnAdauga_Click;

            // btnModifica
            btnModifica.Location = new Point(560, 54);
            btnModifica.Size = new Size(90, 25);
            btnModifica.Text = "✏ Modifică";
            btnModifica.BackColor = Color.FromArgb(255, 165, 0);
            btnModifica.ForeColor = Color.White;
            btnModifica.FlatStyle = FlatStyle.Flat;
            btnModifica.Click += btnModifica_Click;

            // btnSterge
            btnSterge.Location = new Point(660, 54);
            btnSterge.Size = new Size(80, 25);
            btnSterge.Text = "🗑 Șterge";
            btnSterge.BackColor = Color.FromArgb(220, 53, 69);
            btnSterge.ForeColor = Color.White;
            btnSterge.FlatStyle = FlatStyle.Flat;
            btnSterge.Click += btnSterge_Click;

            // dataGridView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 90);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(760, 420);
            dataGridView.TabIndex = 0;

            // FormStatii
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 531);
            Controls.Add(lblTitlu);
            Controls.Add(txtCautare);
            Controls.Add(btnCauta);
            Controls.Add(btnAdauga);
            Controls.Add(btnModifica);
            Controls.Add(btnSterge);
            Controls.Add(dataGridView);
            Name = "FormStatii";
            Text = "Gestionare Stații PECO";
            Load += FormStatii_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitlu;
        private TextBox txtCautare;
        private Button btnCauta;
        private Button btnAdauga;
        private Button btnModifica;
        private Button btnSterge;
        private DataGridView dataGridView;
    }
}