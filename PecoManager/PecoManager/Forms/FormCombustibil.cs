using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormCombustibil : Form
    {
        public FormCombustibil()
        {
            InitializeComponent();
        }

        private void FormCombustibil_Load(object sender, EventArgs e)
        {
            IncarcaCombustibili();
        }

        private void IncarcaCombustibili()
        {
            var lista = DatabaseHelper.GetAllCombustibili();
            dataGridView.DataSource = lista;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["IdCombustibil"].Visible = false;
                dataGridView.Columns["Tip"].HeaderText = "Tip Combustibil";
                dataGridView.Columns["PretPerLitru"].HeaderText = "Preț/Litru (MDL)";
                dataGridView.Columns["StocLitri"].HeaderText = "Stoc (Litri)";
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            string tip = cmbFiltruTip.SelectedItem?.ToString() ?? "Toate";

            if (tip == "Toate")
            {
                IncarcaCombustibili();
                return;
            }

            var rezultate = DatabaseHelper.FilterCombustibili(tip);
            dataGridView.DataSource = rezultate;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormCombustibilEdit form = new FormCombustibilEdit();
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaCombustibili();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectați un combustibil pentru modificare!",
                    "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var combustibil = (Combustibil)dataGridView.CurrentRow.DataBoundItem;
            FormCombustibilEdit form = new FormCombustibilEdit(combustibil);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaCombustibili();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectați un combustibil pentru ștergere!",
                    "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var combustibil = (Combustibil)dataGridView.CurrentRow.DataBoundItem;

            if (DatabaseHelper.CombustibilAreTranzactii(combustibil.IdCombustibil))
            {
                MessageBox.Show(
                    $"Combustibilul '{combustibil.Tip}' nu poate fi șters deoarece are tranzacții asociate!",
                    "Ștergere imposibilă",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirmare = MessageBox.Show(
                $"Sigur doriți să ștergeți combustibilul '{combustibil.Tip}'?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                DatabaseHelper.DeleteCombustibil(combustibil.IdCombustibil);
                IncarcaCombustibili();
            }
        }
    }
}