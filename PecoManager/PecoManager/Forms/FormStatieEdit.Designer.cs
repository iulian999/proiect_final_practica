namespace PecoManager.Forms
{
    partial class FormStatieEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDenumire = new Label();
            txtDenumire = new TextBox();
            lblAdresa = new Label();
            txtAdresa = new TextBox();
            lblOras = new Label();
            txtOras = new TextBox();
            lblNrPompe = new Label();
            numNrPompe = new NumericUpDown();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSalveaza = new Button();
            btnAnuleaza = new Button();

            ((System.ComponentModel.ISupportInitialize)numNrPompe).BeginInit();
            SuspendLayout();

            // lblDenumire
            lblDenumire.AutoSize = true;
            lblDenumire.Location = new Point(12, 20);
            lblDenumire.Text = "Denumire *";
            lblDenumire.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // txtDenumire
            txtDenumire.Location = new Point(12, 40);
            txtDenumire.Size = new Size(350, 23);
            txtDenumire.PlaceholderText = "ex: Peco Nord";

            // lblAdresa
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(12, 75);
            lblAdresa.Text = "Adresă *";
            lblAdresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // txtAdresa
            txtAdresa.Location = new Point(12, 95);
            txtAdresa.Size = new Size(350, 23);
            txtAdresa.PlaceholderText = "ex: Str. Ștefan cel Mare 12";

            // lblOras
            lblOras.AutoSize = true;
            lblOras.Location = new Point(12, 130);
            lblOras.Text = "Oraș *";
            lblOras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // txtOras
            txtOras.Location = new Point(12, 150);
            txtOras.Size = new Size(200, 23);
            txtOras.PlaceholderText = "ex: Chișinău";

            // lblNrPompe
            lblNrPompe.AutoSize = true;
            lblNrPompe.Location = new Point(230, 130);
            lblNrPompe.Text = "Nr. Pompe *";
            lblNrPompe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // numNrPompe
            numNrPompe.Location = new Point(230, 150);
            numNrPompe.Minimum = 1;
            numNrPompe.Maximum = 20;
            numNrPompe.Value = 1;
            numNrPompe.Size = new Size(80, 23);

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 185);
            lblStatus.Text = "Status *";
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // cmbStatus
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbStatus.Location = new Point(12, 205);
            cmbStatus.Size = new Size(150, 23);

            // btnSalveaza
            btnSalveaza.Location = new Point(12, 250);
            btnSalveaza.Size = new Size(100, 30);
            btnSalveaza.Text = "Salvează";
            btnSalveaza.BackColor = Color.FromArgb(60, 179, 113);
            btnSalveaza.ForeColor = Color.White;
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Click += btnSalveaza_Click;

            // btnAnuleaza
            btnAnuleaza.Location = new Point(122, 250);
            btnAnuleaza.Size = new Size(100, 30);
            btnAnuleaza.Text = "Anulează";
            btnAnuleaza.BackColor = Color.FromArgb(220, 53, 69);
            btnAnuleaza.ForeColor = Color.White;
            btnAnuleaza.FlatStyle = FlatStyle.Flat;
            btnAnuleaza.Click += btnAnuleaza_Click;

            // FormStatieEdit
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 300);
            Controls.Add(lblDenumire);
            Controls.Add(txtDenumire);
            Controls.Add(lblAdresa);
            Controls.Add(txtAdresa);
            Controls.Add(lblOras);
            Controls.Add(txtOras);
            Controls.Add(lblNrPompe);
            Controls.Add(numNrPompe);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSalveaza);
            Controls.Add(btnAnuleaza);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStatieEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adaugă Stație";

            ((System.ComponentModel.ISupportInitialize)numNrPompe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDenumire;
        private TextBox txtDenumire;
        private Label lblAdresa;
        private TextBox txtAdresa;
        private Label lblOras;
        private TextBox txtOras;
        private Label lblNrPompe;
        private NumericUpDown numNrPompe;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSalveaza;
        private Button btnAnuleaza;
    }
}