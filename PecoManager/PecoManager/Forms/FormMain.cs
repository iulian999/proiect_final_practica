using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            IncarcaStatii();
        }

        private void IncarcaStatii()
        {
            List<StatiePeco> statii = DatabaseHelper.GetAllStatii();
            dataGridViewStatii.DataSource = statii;

            if (dataGridViewStatii.Columns.Count > 0)
            {
                dataGridViewStatii.Columns["IdStatie"].Visible = false;
                dataGridViewStatii.Columns["Denumire"].HeaderText = "Denumire";
                dataGridViewStatii.Columns["Adresa"].HeaderText = "Adresă";
                dataGridViewStatii.Columns["Oras"].HeaderText = "Oraș";
                dataGridViewStatii.Columns["NrPompe"].HeaderText = "Nr. Pompe";
                dataGridViewStatii.Columns["Status"].HeaderText = "Status";
            }
        }

        private void stațiiPECOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatii form = new FormStatii();
            form.Show();
        }

        private void combustibiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCombustibil form = new FormCombustibil();
            form.Show();
        }

        private void tranzacțiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTranzactii form = new FormTranzactii();
            form.Show();
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaport form = new FormRaport();
            form.Show();
        }
    }
}