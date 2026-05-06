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