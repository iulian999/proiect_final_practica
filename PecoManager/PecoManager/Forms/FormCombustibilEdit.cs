using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormCombustibilEdit : Form
    {
        private Combustibil? _combustibil;

        public FormCombustibilEdit()
        {
            InitializeComponent();
            _combustibil = null;
            this.Text = "Adaugă Combustibil Nou";
        }

        public FormCombustibilEdit(Combustibil combustibil)
        {
            InitializeComponent();
            _combustibil = combustibil;
            this.Text = "Modifică Combustibil";
            cmbTip.SelectedItem = combustibil.Tip;
            numPret.Value = combustibil.PretPerLitru;
            numStoc.Value = combustibil.StocLitri;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați tipul combustibilului!",
                    "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numPret.Value <= 0)
            {
                MessageBox.Show("Prețul trebuie să fie mai mare decât 0!",
                    "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var combustibil = new Combustibil
            {
                Tip = cmbTip.SelectedItem!.ToString()!,
                PretPerLitru = numPret.Value,
                StocLitri = numStoc.Value
            };

            if (_combustibil == null)
            {
                DatabaseHelper.AddCombustibil(combustibil);
                MessageBox.Show("Combustibil adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                combustibil.IdCombustibil = _combustibil.IdCombustibil;
                DatabaseHelper.UpdateCombustibil(combustibil);
                MessageBox.Show("Combustibil modificat cu succes!", "Succes",
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