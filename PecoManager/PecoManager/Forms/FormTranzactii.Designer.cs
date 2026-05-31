namespace PecoManager.Forms
{
    partial class FormTranzactii
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
            lblStatie = new Label();
            cmbStatie = new ComboBox();
            lblCombustibil = new Label();
            cmbCombustibil = new ComboBox();
            lblModPlata = new Label();
            cmbModPlata = new ComboBox();
            lblCantitate = new Label();
            numCantitate = new NumericUpDown();
            lblSuma = new Label();
            txtSuma = new TextBox();
            lblData = new Label();
            txtData = new TextBox();
            btnInregistreaza = new Button();
            btnReseteaza = new Button();
            lblIstoricTitlu = new Label();
            lblFiltruStatie = new Label();
            cmbFiltruStatie = new ComboBox();
            btnFiltreaza = new Button();
            btnAnuleaza = new Button();
            dataGridView = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)numCantitate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

            // lblTitlu
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitlu.Location = new Point(12, 12);
            lblTitlu.Text = "Tranzacții Alimentare";

            // lblStatie
            lblStatie.AutoSize = true;
            lblStatie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatie.Location = new Point(12, 50);
            lblStatie.Text = "Stație PECO *";

            // cmbStatie
            cmbStatie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatie.Location = new Point(12, 68);
            cmbStatie.Size = new Size(220, 23);
            cmbStatie.SelectedIndexChanged += cmbStatie_SelectedIndexChanged;

            // lblCombustibil
            lblCombustibil.AutoSize = true;
            lblCombustibil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCombustibil.Location = new Point(245, 50);
            lblCombustibil.Text = "Combustibil *";

            // cmbCombustibil
            cmbCombustibil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustibil.Location = new Point(245, 68);
            cmbCombustibil.Size = new Size(200, 23);
            cmbCombustibil.SelectedIndexChanged += cmbCombustibil_SelectedIndexChanged;

            // lblModPlata
            lblModPlata.AutoSize = true;
            lblModPlata.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModPlata.Location = new Point(460, 50);
            lblModPlata.Text = "Mod Plată *";

            // cmbModPlata
            cmbModPlata.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModPlata.Items.AddRange(new object[] { "Card", "Numerar" });
            cmbModPlata.Location = new Point(460, 68);
            cmbModPlata.Size = new Size(120, 23);

            // lblCantitate
            lblCantitate.AutoSize = true;
            lblCantitate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantitate.Location = new Point(12, 105);
            lblCantitate.Text = "Cantitate (L) *";

            // numCantitate
            numCantitate.DecimalPlaces = 2;
            numCantitate.Minimum = 0.01M;
            numCantitate.Maximum = 10000M;
            numCantitate.Value = 1M;
            numCantitate.Location = new Point(12, 123);
            numCantitate.Size = new Size(120, 23);
            numCantitate.ValueChanged += numCantitate_ValueChanged;

            // lblSuma
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSuma.Location = new Point(150, 105);
            lblSuma.Text = "Sumă Totală (MDL)";

            // txtSuma
            txtSuma.Location = new Point(150, 123);
            txtSuma.Size = new Size(150, 23);
            txtSuma.ReadOnly = true;
            txtSuma.BackColor = Color.FromArgb(240, 240, 240);
            txtSuma.Text = "0.00";

            // lblData
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblData.Location = new Point(320, 105);
            lblData.Text = "Data și ora";

            // txtData
            txtData.Location = new Point(320, 123);
            txtData.Size = new Size(180, 23);
            txtData.ReadOnly = true;
            txtData.BackColor = Color.FromArgb(240, 240, 240);

            // btnInregistreaza
            btnInregistreaza.Location = new Point(12, 165);
            btnInregistreaza.Size = new Size(130, 30);
            btnInregistreaza.Text = "✔ Înregistrează";
            btnInregistreaza.BackColor = Color.FromArgb(60, 179, 113);
            btnInregistreaza.ForeColor = Color.White;
            btnInregistreaza.FlatStyle = FlatStyle.Flat;
            btnInregistreaza.Click += btnInregistreaza_Click;

            // btnReseteaza
            btnReseteaza.Location = new Point(152, 165);
            btnReseteaza.Size = new Size(100, 30);
            btnReseteaza.Text = "Resetează";
            btnReseteaza.BackColor = Color.FromArgb(108, 117, 125);
            btnReseteaza.ForeColor = Color.White;
            btnReseteaza.FlatStyle = FlatStyle.Flat;
            btnReseteaza.Click += btnReseteaza_Click;

            // lblIstoricTitlu
            lblIstoricTitlu.AutoSize = true;
            lblIstoricTitlu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIstoricTitlu.Location = new Point(12, 210);
            lblIstoricTitlu.Text = "Istoricul Tranzacțiilor";

            // lblFiltruStatie
            lblFiltruStatie.AutoSize = true;
            lblFiltruStatie.Location = new Point(12, 240);
            lblFiltruStatie.Text = "Filtrează după stație:";

            // cmbFiltruStatie
            cmbFiltruStatie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltruStatie.Location = new Point(140, 237);
            cmbFiltruStatie.Size = new Size(200, 23);

            // btnFiltreaza
            btnFiltreaza.Location = new Point(350, 236);
            btnFiltreaza.Size = new Size(90, 25);
            btnFiltreaza.Text = "Filtrează";
            btnFiltreaza.BackColor = Color.FromArgb(70, 130, 180);
            btnFiltreaza.ForeColor = Color.White;
            btnFiltreaza.FlatStyle = FlatStyle.Flat;
            btnFiltreaza.Click += btnFiltreaza_Click;

            // btnAnuleaza
            btnAnuleaza.Location = new Point(450, 236);
            btnAnuleaza.Size = new Size(140, 25);
            btnAnuleaza.Text = "❌ Anulează tranzacție";
            btnAnuleaza.BackColor = Color.FromArgb(220, 53, 69);
            btnAnuleaza.ForeColor = Color.White;
            btnAnuleaza.FlatStyle = FlatStyle.Flat;
            btnAnuleaza.Click += btnAnuleaza_Click;

            // dataGridView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 270);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(860, 350);

            // FormTranzactii
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 640);
            Controls.Add(lblTitlu);
            Controls.Add(lblStatie);
            Controls.Add(cmbStatie);
            Controls.Add(lblCombustibil);
            Controls.Add(cmbCombustibil);
            Controls.Add(lblModPlata);
            Controls.Add(cmbModPlata);
            Controls.Add(lblCantitate);
            Controls.Add(numCantitate);
            Controls.Add(lblSuma);
            Controls.Add(txtSuma);
            Controls.Add(lblData);
            Controls.Add(txtData);
            Controls.Add(btnInregistreaza);
            Controls.Add(btnReseteaza);
            Controls.Add(lblIstoricTitlu);
            Controls.Add(lblFiltruStatie);
            Controls.Add(cmbFiltruStatie);
            Controls.Add(btnFiltreaza);
            Controls.Add(btnAnuleaza);
            Controls.Add(dataGridView);
            Name = "FormTranzactii";
            Text = "Tranzacții Alimentare";
            Load += FormTranzactii_Load;

            ((System.ComponentModel.ISupportInitialize)numCantitate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitlu;
        private Label lblStatie;
        private ComboBox cmbStatie;
        private Label lblCombustibil;
        private ComboBox cmbCombustibil;
        private Label lblModPlata;
        private ComboBox cmbModPlata;
        private Label lblCantitate;
        private NumericUpDown numCantitate;
        private Label lblSuma;
        private TextBox txtSuma;
        private Label lblData;
        private TextBox txtData;
        private Button btnInregistreaza;
        private Button btnReseteaza;
        private Label lblIstoricTitlu;
        private Label lblFiltruStatie;
        private ComboBox cmbFiltruStatie;
        private Button btnFiltreaza;
        private Button btnAnuleaza;
        private DataGridView dataGridView;
    }
}