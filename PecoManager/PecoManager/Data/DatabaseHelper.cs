using Microsoft.Data.SqlClient;
using PecoManager.Models;

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
                MessageBox.Show("Eroare conexiune: " + ex.Message);
                return false;
            }
        }

        public static List<StatiePeco> GetAllStatii()
        {
            List<StatiePeco> list = new List<StatiePeco>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT IdStatie, Denumire, Adresa, Oras, NrPompe, Status FROM StatiePeco";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new StatiePeco
                    {
                        IdStatie = reader.GetInt32(0),
                        Denumire = reader.GetString(1),
                        Adresa = reader.GetString(2),
                        Oras = reader.GetString(3),
                        NrPompe = reader.GetInt32(4),
                        Status = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare GetAllStatii: " + ex.Message);
            }
            return list;
        }

        public static List<Combustibil> GetAllCombustibili()
        {
            List<Combustibil> list = new List<Combustibil>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT IdCombustibil, Tip, PretPerLitru, StocLitri FROM Combustibil";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Combustibil
                    {
                        IdCombustibil = reader.GetInt32(0),
                        Tip = reader.GetString(1),
                        PretPerLitru = reader.GetDecimal(2),
                        StocLitri = reader.GetDecimal(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare GetAllCombustibili: " + ex.Message);
            }
            return list;
        }

        public static List<Tranzactie> GetAllTranzactii()
        {
            List<Tranzactie> list = new List<Tranzactie>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT IdTranzactie, IdStatie, IdCombustibil, DataOra, CantitateaLitri, SumaTotala, ModPlata FROM Tranzactie";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Tranzactie
                    {
                        IdTranzactie = reader.GetInt32(0),
                        IdStatie = reader.GetInt32(1),
                        IdCombustibil = reader.GetInt32(2),
                        DataOra = reader.GetDateTime(3),
                        CantitateaLitri = reader.GetDecimal(4),
                        SumaTotala = reader.GetDecimal(5),
                        ModPlata = reader.GetString(6)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare GetAllTranzactii: " + ex.Message);
            }
            return list;
        }
    }
}