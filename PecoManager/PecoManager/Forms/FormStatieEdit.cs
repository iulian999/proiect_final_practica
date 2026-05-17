using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormStatieEdit : Form
    {
        private StatiePeco? _statie;

        public FormStatieEdit()
        {
            InitializeComponent();
            _statie = null;
            this.Text = "Adaugă Stație Nouă";
        }

        public FormStatieEdit(StatiePeco statie)
        {
            InitializeComponent();
            _statie = statie;
            this.Text = "Modifică Stație";
            txtDenumire.Text = statie.Denumire;
            txtAdresa.Text = statie.Adresa;
            txtOras.Text = statie.Oras;
            numNrPompe.Value = statie.NrPompe;
            cmbStatus.SelectedItem = statie.Status;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Denumirea este obligatorie!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Adresa este obligatorie!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOras.Text))
            {
                MessageBox.Show("Orașul este obligatoriu!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați statusul stației!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var statie = new StatiePeco
            {
                Denumire = txtDenumire.Text.Trim(),
                Adresa = txtAdresa.Text.Trim(),
                Oras = txtOras.Text.Trim(),
                NrPompe = (int)numNrPompe.Value,
                Status = cmbStatus.SelectedItem!.ToString()!
            };

            if (_statie == null)
            {
                DatabaseHelper.AddStatie(statie);
                MessageBox.Show("Stație adăugată cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                statie.IdStatie = _statie.IdStatie;
                DatabaseHelper.UpdateStatie(statie);
                MessageBox.Show("Stație modificată cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}