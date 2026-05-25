namespace PecoManager.Forms
{
    partial class FormCombustibilEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTip = new Label();
            cmbTip = new ComboBox();
            lblPret = new Label();
            numPret = new NumericUpDown();
            lblStoc = new Label();
            numStoc = new NumericUpDown();
            btnSalveaza = new Button();
            btnAnuleaza = new Button();

            ((System.ComponentModel.ISupportInitialize)numPret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStoc).BeginInit();
            SuspendLayout();

            // lblTip
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTip.Location = new Point(12, 20);
            lblTip.Text = "Tip Combustibil *";

            // cmbTip
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.Items.AddRange(new object[] { "Benzina 95", "Motorina", "GPL" });
            cmbTip.Location = new Point(12, 40);
            cmbTip.Size = new Size(200, 23);

            // lblPret
            lblPret.AutoSize = true;
            lblPret.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPret.Location = new Point(12, 80);
            lblPret.Text = "Preț per Litru (MDL) *";

            // numPret
            numPret.DecimalPlaces = 2;
            numPret.Minimum = 0.01M;
            numPret.Maximum = 100M;
            numPret.Value = 1M;
            numPret.Location = new Point(12, 100);
            numPret.Size = new Size(120, 23);

            // lblStoc
            lblStoc.AutoSize = true;
            lblStoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoc.Location = new Point(12, 140);
            lblStoc.Text = "Stoc (Litri) *";

            // numStoc
            numStoc.DecimalPlaces = 2;
            numStoc.Minimum = 0M;
            numStoc.Maximum = 50000M;
            numStoc.Value = 0M;
            numStoc.Location = new Point(12, 160);
            numStoc.Size = new Size(120, 23);

            // btnSalveaza
            btnSalveaza.Location = new Point(12, 210);
            btnSalveaza.Size = new Size(100, 30);
            btnSalveaza.Text = "Salvează";
            btnSalveaza.BackColor = Color.FromArgb(60, 179, 113);
            btnSalveaza.ForeColor = Color.White;
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Click += btnSalveaza_Click;

            // btnAnuleaza
            btnAnuleaza.Location = new Point(122, 210);
            btnAnuleaza.Size = new Size(100, 30);
            btnAnuleaza.Text = "Anulează";
            btnAnuleaza.BackColor = Color.FromArgb(220, 53, 69);
            btnAnuleaza.ForeColor = Color.White;
            btnAnuleaza.FlatStyle = FlatStyle.Flat;
            btnAnuleaza.Click += btnAnuleaza_Click;

            // FormCombustibilEdit
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 260);
            Controls.Add(lblTip);
            Controls.Add(cmbTip);
            Controls.Add(lblPret);
            Controls.Add(numPret);
            Controls.Add(lblStoc);
            Controls.Add(numStoc);
            Controls.Add(btnSalveaza);
            Controls.Add(btnAnuleaza);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCombustibilEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adaugă Combustibil";

            ((System.ComponentModel.ISupportInitialize)numPret).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTip;
        private ComboBox cmbTip;
        private Label lblPret;
        private NumericUpDown numPret;
        private Label lblStoc;
        private NumericUpDown numStoc;
        private Button btnSalveaza;
        private Button btnAnuleaza;
    }
}