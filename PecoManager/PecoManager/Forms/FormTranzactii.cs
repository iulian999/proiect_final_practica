using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormTranzactii : Form
    {
        private List<Combustibil> _combustibili = new();
        private List<StatiePeco> _statii = new();

        public FormTranzactii()
        {
            InitializeComponent();
        }

        private void FormTranzactii_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            IncarcaComboBoxuri();
            IncarcaTranzactii();
        }

        private void IncarcaComboBoxuri()
        {
            _statii = DatabaseHelper.GetAllStatii();
            cmbStatie.DataSource = new List<StatiePeco>(_statii);
            cmbStatie.DisplayMember = "Denumire";
            cmbStatie.ValueMember = "IdStatie";
            cmbStatie.SelectedIndex = -1;

            _combustibili = DatabaseHelper.GetAllCombustibili();
            cmbCombustibil.DataSource = new List<Combustibil>(_combustibili);
            cmbCombustibil.DisplayMember = "Tip";
            cmbCombustibil.ValueMember = "IdCombustibil";
            cmbCombustibil.SelectedIndex = -1;

            var statiiFiltu = new List<StatiePeco> { new StatiePeco { IdStatie = 0, Denumire = "Toate stațiile" } };
            statiiFiltu.AddRange(_statii);
            cmbFiltruStatie.DataSource = statiiFiltu;
            cmbFiltruStatie.DisplayMember = "Denumire";
            cmbFiltruStatie.ValueMember = "IdStatie";
            cmbFiltruStatie.SelectedIndex = 0;
        }

        private void IncarcaTranzactii()
        {
            var lista = DatabaseHelper.GetTranzactiiCuDetalii();
            dataGridView.DataSource = lista;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["IdTranzactie"].Visible = false;
                dataGridView.Columns["DenumireStatie"].HeaderText = "Stație";
                dataGridView.Columns["TipCombustibil"].HeaderText = "Combustibil";
                dataGridView.Columns["DataOra"].HeaderText = "Data și Ora";
                dataGridView.Columns["CantitateaLitri"].HeaderText = "Cantitate (L)";
                dataGridView.Columns["SumaTotala"].HeaderText = "Sumă (MDL)";
                dataGridView.Columns["ModPlata"].HeaderText = "Mod Plată";
            }
        }

        private void CalculeazaSuma()
        {
            if (cmbCombustibil.SelectedIndex == -1) return;
            var combustibil = (Combustibil)cmbCombustibil.SelectedItem!;
            decimal suma = numCantitate.Value * combustibil.PretPerLitru;
            txtSuma.Text = suma.ToString("F2");
        }

        private void cmbCombustibil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculeazaSuma();
        }

        private void numCantitate_ValueChanged(object sender, EventArgs e)
        {
            CalculeazaSuma();
        }

        private void cmbStatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatie.SelectedIndex == -1) return;
            var statie = (StatiePeco)cmbStatie.SelectedItem!;
            if (statie.Status == "Inactiva")
            {
                MessageBox.Show($"Stația '{statie.Denumire}' este inactivă! Selectați altă stație.",
                    "Stație inactivă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatie.SelectedIndex = -1;
            }
        }

        private void btnInregistreaza_Click(object sender, EventArgs e)
        {
            if (cmbStatie.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați stația!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCombustibil.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați combustibilul!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbModPlata.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați modul de plată!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numCantitate.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie mai mare decât 0!", "Validare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var statie = (StatiePeco)cmbStatie.SelectedItem!;
            var combustibil = (Combustibil)cmbCombustibil.SelectedItem!;

            var tranzactie = new Tranzactie
            {
                IdStatie = statie.IdStatie,
                IdCombustibil = combustibil.IdCombustibil,
                DataOra = DateTime.Now,
                CantitateaLitri = numCantitate.Value,
                SumaTotala = numCantitate.Value * combustibil.PretPerLitru,
                ModPlata = cmbModPlata.SelectedItem!.ToString()!
            };

            DatabaseHelper.AddTranzactie(tranzactie);
            MessageBox.Show("Tranzacție înregistrată cu succes!", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnReseteaza_Click(sender, e);
            IncarcaTranzactii();
        }

        private void btnReseteaza_Click(object sender, EventArgs e)
        {
            cmbStatie.SelectedIndex = -1;
            cmbCombustibil.SelectedIndex = -1;
            cmbModPlata.SelectedIndex = -1;
            numCantitate.Value = 1;
            txtSuma.Text = "0.00";
            txtData.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            var statie = (StatiePeco)cmbFiltruStatie.SelectedItem!;

            if (statie.IdStatie == 0)
            {
                IncarcaTranzactii();
                return;
            }

            var lista = DatabaseHelper.GetTranzactiiCuDetaliiByStatie(statie.IdStatie);
            dataGridView.DataSource = lista;
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Selectați o tranzacție pentru anulare!",
                    "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tranzactie = (TranzactieDetalii)dataGridView.CurrentRow.DataBoundItem;
            var confirmare = MessageBox.Show(
                $"Sigur doriți să anulați tranzacția de {tranzactie.SumaTotala} MDL?",
                "Confirmare anulare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmare == DialogResult.Yes)
            {
                DatabaseHelper.DeleteTranzactie(tranzactie.IdTranzactie);
                IncarcaTranzactii();
            }
        }
    }
}