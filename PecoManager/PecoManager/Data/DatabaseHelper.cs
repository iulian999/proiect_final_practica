using Microsoft.Data.SqlClient;

namespace PecoManager.Data
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =
            @"Server=IULIC\SQLEXPRESS;Database=PecoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static bool TestConnection()
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare conexiune: " + ex.Message, "PecoManager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}