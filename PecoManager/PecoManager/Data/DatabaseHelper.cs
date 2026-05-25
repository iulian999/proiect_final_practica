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

        public static void AddStatie(StatiePeco s)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"INSERT INTO StatiePeco 
                    (Denumire, Adresa, Oras, NrPompe, Status) 
                    VALUES (@Denumire, @Adresa, @Oras, @NrPompe, @Status)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Denumire", s.Denumire);
                cmd.Parameters.AddWithValue("@Adresa", s.Adresa);
                cmd.Parameters.AddWithValue("@Oras", s.Oras);
                cmd.Parameters.AddWithValue("@NrPompe", s.NrPompe);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare AddStatie: " + ex.Message);
            }
        }

        public static void UpdateStatie(StatiePeco s)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"UPDATE StatiePeco 
                    SET Denumire=@Denumire, Adresa=@Adresa, Oras=@Oras, 
                        NrPompe=@NrPompe, Status=@Status 
                    WHERE IdStatie=@IdStatie";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Denumire", s.Denumire);
                cmd.Parameters.AddWithValue("@Adresa", s.Adresa);
                cmd.Parameters.AddWithValue("@Oras", s.Oras);
                cmd.Parameters.AddWithValue("@NrPompe", s.NrPompe);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.Parameters.AddWithValue("@IdStatie", s.IdStatie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare UpdateStatie: " + ex.Message);
            }
        }

        public static void DeleteStatie(int id)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "DELETE FROM StatiePeco WHERE IdStatie=@IdStatie";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdStatie", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare DeleteStatie: " + ex.Message);
            }
        }

        public static List<StatiePeco> SearchStatii(string termen)
        {
            List<StatiePeco> list = new List<StatiePeco>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"SELECT IdStatie, Denumire, Adresa, Oras, NrPompe, Status 
                    FROM StatiePeco 
                    WHERE Denumire LIKE @Termen OR Oras LIKE @Termen";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Termen", "%" + termen + "%");
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
                MessageBox.Show("Eroare SearchStatii: " + ex.Message);
            }
            return list;
        }

        public static bool StatiaAreTranzactii(int idStatie)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT COUNT(*) FROM Tranzactie WHERE IdStatie=@IdStatie";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdStatie", idStatie);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare verificare tranzacții: " + ex.Message);
                return false;
            }
        }

        // ── COMBUSTIBIL ──────────────────────────────────────────────

        public static void AddCombustibil(Combustibil c)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"INSERT INTO Combustibil 
                    (Tip, PretPerLitru, StocLitri) 
                    VALUES (@Tip, @PretPerLitru, @StocLitri)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tip", c.Tip);
                cmd.Parameters.AddWithValue("@PretPerLitru", c.PretPerLitru);
                cmd.Parameters.AddWithValue("@StocLitri", c.StocLitri);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare AddCombustibil: " + ex.Message);
            }
        }

        public static void UpdateCombustibil(Combustibil c)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"UPDATE Combustibil 
                    SET Tip=@Tip, PretPerLitru=@PretPerLitru, StocLitri=@StocLitri 
                    WHERE IdCombustibil=@IdCombustibil";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tip", c.Tip);
                cmd.Parameters.AddWithValue("@PretPerLitru", c.PretPerLitru);
                cmd.Parameters.AddWithValue("@StocLitri", c.StocLitri);
                cmd.Parameters.AddWithValue("@IdCombustibil", c.IdCombustibil);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare UpdateCombustibil: " + ex.Message);
            }
        }

        public static void DeleteCombustibil(int id)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "DELETE FROM Combustibil WHERE IdCombustibil=@IdCombustibil";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCombustibil", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare DeleteCombustibil: " + ex.Message);
            }
        }

        public static List<Combustibil> FilterCombustibili(string tip)
        {
            List<Combustibil> list = new List<Combustibil>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"SELECT IdCombustibil, Tip, PretPerLitru, StocLitri 
                    FROM Combustibil WHERE Tip LIKE @Tip";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tip", "%" + tip + "%");
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
                MessageBox.Show("Eroare FilterCombustibili: " + ex.Message);
            }
            return list;
        }

        public static bool CombustibilAreTranzactii(int idCombustibil)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT COUNT(*) FROM Tranzactie WHERE IdCombustibil=@IdCombustibil";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCombustibil", idCombustibil);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare verificare tranzacții combustibil: " + ex.Message);
                return false;
            }
        }
    }
}