using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormStatii : Form
    {
        public FormStatii()
        {
            InitializeComponent();
        }

        private void FormStatii_Load(object sender, EventArgs e)
        {
            IncarcaStatii();
        }

        private void IncarcaStatii()
        {
            var statii = DatabaseHelper.GetAllStatii();
            dataGridView.DataSource = statii;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["IdStatie"].Visible = false;
                dataGridView.Columns["Denumire"].HeaderText = "Denumire";
                dataGridView.Columns["Adresa"].HeaderText = "Adresă";
                dataGridView.Columns["Oras"].HeaderText = "Oraș";
                dataGridView.Columns["NrPompe"].HeaderText = "Nr. Pompe";
                dataGridView.Columns["Status"].HeaderText = "Status";
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string termen = txtCautare.Text.Trim();
            if (string.IsNullOrEmpty(termen))
            {
                IncarcaStatii();
                return;
            }
            var rezultate = DatabaseHelper.SearchStatii(termen);
            dataGridView.DataSource = rezultate;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormStatieEdit form = new FormStatieEdit();
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaStatii();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectați o stație pentru modificare!",
                    "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var statie = (StatiePeco)dataGridView.CurrentRow.DataBoundItem;
            FormStatieEdit form = new FormStatieEdit(statie);
            if (form.ShowDialog() == DialogResult.OK)
                IncarcaStatii();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectați o stație pentru ștergere!",
                    "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var statie = (StatiePeco)dataGridView.CurrentRow.DataBoundItem;
            var confirmare = MessageBox.Show(
                $"Sigur doriți să ștergeți stația '{statie.Denumire}'?",
                "Confirmare ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                if (DatabaseHelper.StatiaAreTranzactii(statie.IdStatie))
                {
                    MessageBox.Show(
                        $"Stația '{statie.Denumire}' nu poate fi ștearsă deoarece are tranzacții asociate!",
                        "Ștergere imposibilă",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                DatabaseHelper.DeleteStatie(statie.IdStatie);
                IncarcaStatii();
            }
        }

        private void txtCautare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCauta_Click(sender, e);
        }


    }
}