using PecoManager.Data;
using PecoManager.Models;

namespace PecoManager.Forms
{
    public partial class FormRaport : Form
    {
        public FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            IncarcaRaport();
        }

        private void IncarcaRaport()
        {
            var raport = DatabaseHelper.GetRaportStatii();
            dataGridView.DataSource = raport;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["DenumireStatie"].HeaderText = "Stație PECO";
                dataGridView.Columns["Oras"].HeaderText = "Oraș";
                dataGridView.Columns["NrTranzactii"].HeaderText = "Nr. Tranzacții";
                dataGridView.Columns["TotalIncasat"].HeaderText = "Total Încasat (MDL)";
            }

            var (total, suma, medie, statieTop) = DatabaseHelper.GetStatisticiGenerale();
            lblValStatTotal.Text = total.ToString();
            lblValSumaTotal.Text = suma.ToString("F2") + " MDL";
            lblValMedia.Text = medie.ToString("F2") + " MDL";
            lblValStatieTop.Text = statieTop;
        }

        private void btnGenereaza_Click(object sender, EventArgs e)
        {
            IncarcaRaport();
            MessageBox.Show("Raportul a fost generat cu succes!", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = $"Raport_PecoManager_{DateTime.Now:yyyyMMdd_HHmm}.txt"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var (total, suma, medie, statieTop) = DatabaseHelper.GetStatisticiGenerale();
                var raport = DatabaseHelper.GetRaportStatii();

                using var writer = new StreamWriter(dialog.FileName, false, System.Text.Encoding.UTF8);

                writer.WriteLine("================================================");
                writer.WriteLine("       RAPORT SUMAR VANZARI — PECOMANAGER       ");
                writer.WriteLine("================================================");
                writer.WriteLine($"Data generarii: {DateTime.Now:dd.MM.yyyy HH:mm}");
                writer.WriteLine();
                writer.WriteLine("--- STATISTICI GENERALE ---");
                writer.WriteLine($"Total tranzactii:    {total}");
                writer.WriteLine($"Total incasat:       {suma:F2} MDL");
                writer.WriteLine($"Media/tranzactie:    {medie:F2} MDL");
                writer.WriteLine($"Statie top vanzari:  {statieTop}");
                writer.WriteLine();
                writer.WriteLine("--- VANZARI PER STATIE (descrescator) ---");
                writer.WriteLine($"{"Statie",-25} {"Oras",-15} {"Nr.Tranz",-10} {"Total MDL",-12}");
                writer.WriteLine(new string('-', 65));

                foreach (var r in raport)
                    writer.WriteLine($"{r.DenumireStatie,-25} {r.Oras,-15} {r.NrTranzactii,-10} {r.TotalIncasat,-12:F2}");

                writer.WriteLine(new string('=', 65));

                MessageBox.Show($"Raport exportat cu succes!\n{dialog.FileName}",
                    "Export reușit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}