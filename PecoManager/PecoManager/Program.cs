using PecoManager.Data;

namespace PecoManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (DatabaseHelper.TestConnection())
                MessageBox.Show("Conexiune la PecoDB reușită!", "PecoManager",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Run(new Form1());
        }
    }
}