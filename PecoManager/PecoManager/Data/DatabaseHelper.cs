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
            catch (Exception ex) { MessageBox.Show("Eroare GetAllStatii: " + ex.Message); }
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
            catch (Exception ex) { MessageBox.Show("Eroare GetAllCombustibili: " + ex.Message); }
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
            catch (Exception ex) { MessageBox.Show("Eroare GetAllTranzactii: " + ex.Message); }
            return list;
        }

        public static void AddStatie(StatiePeco s)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"INSERT INTO StatiePeco (Denumire, Adresa, Oras, NrPompe, Status) 
                    VALUES (@Denumire, @Adresa, @Oras, @NrPompe, @Status)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Denumire", s.Denumire);
                cmd.Parameters.AddWithValue("@Adresa", s.Adresa);
                cmd.Parameters.AddWithValue("@Oras", s.Oras);
                cmd.Parameters.AddWithValue("@NrPompe", s.NrPompe);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Eroare AddStatie: " + ex.Message); }
        }

        public static void UpdateStatie(StatiePeco s)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"UPDATE StatiePeco 
                    SET Denumire=@Denumire, Adresa=@Adresa, Oras=@Oras, NrPompe=@NrPompe, Status=@Status 
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
            catch (Exception ex) { MessageBox.Show("Eroare UpdateStatie: " + ex.Message); }
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
            catch (Exception ex) { MessageBox.Show("Eroare DeleteStatie: " + ex.Message); }
        }

        public static List<StatiePeco> SearchStatii(string termen)
        {
            List<StatiePeco> list = new List<StatiePeco>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"SELECT IdStatie, Denumire, Adresa, Oras, NrPompe, Status 
                    FROM StatiePeco WHERE Denumire LIKE @Termen OR Oras LIKE @Termen";
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
            catch (Exception ex) { MessageBox.Show("Eroare SearchStatii: " + ex.Message); }
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
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex) { MessageBox.Show("Eroare verificare tranzacții: " + ex.Message); return false; }
        }

        // ── COMBUSTIBIL ──────────────────────────────────────────────

        public static void AddCombustibil(Combustibil c)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"INSERT INTO Combustibil (Tip, PretPerLitru, StocLitri) 
                    VALUES (@Tip, @PretPerLitru, @StocLitri)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tip", c.Tip);
                cmd.Parameters.AddWithValue("@PretPerLitru", c.PretPerLitru);
                cmd.Parameters.AddWithValue("@StocLitri", c.StocLitri);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Eroare AddCombustibil: " + ex.Message); }
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
            catch (Exception ex) { MessageBox.Show("Eroare UpdateCombustibil: " + ex.Message); }
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
            catch (Exception ex) { MessageBox.Show("Eroare DeleteCombustibil: " + ex.Message); }
        }

        public static List<Combustibil> FilterCombustibili(string tip)
        {
            List<Combustibil> list = new List<Combustibil>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "SELECT IdCombustibil, Tip, PretPerLitru, StocLitri FROM Combustibil WHERE Tip LIKE @Tip";
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
            catch (Exception ex) { MessageBox.Show("Eroare FilterCombustibili: " + ex.Message); }
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
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex) { MessageBox.Show("Eroare verificare tranzacții combustibil: " + ex.Message); return false; }
        }

        // ── TRANZACTII ──────────────────────────────────────────────

        public static void AddTranzactie(Tranzactie t)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"INSERT INTO Tranzactie 
                    (IdStatie, IdCombustibil, DataOra, CantitateaLitri, SumaTotala, ModPlata) 
                    VALUES (@IdStatie, @IdCombustibil, @DataOra, @CantitateaLitri, @SumaTotala, @ModPlata)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdStatie", t.IdStatie);
                cmd.Parameters.AddWithValue("@IdCombustibil", t.IdCombustibil);
                cmd.Parameters.AddWithValue("@DataOra", t.DataOra);
                cmd.Parameters.AddWithValue("@CantitateaLitri", t.CantitateaLitri);
                cmd.Parameters.AddWithValue("@SumaTotala", t.SumaTotala);
                cmd.Parameters.AddWithValue("@ModPlata", t.ModPlata);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Eroare AddTranzactie: " + ex.Message); }
        }

        public static void DeleteTranzactie(int id)
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "DELETE FROM Tranzactie WHERE IdTranzactie=@IdTranzactie";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTranzactie", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Eroare DeleteTranzactie: " + ex.Message); }
        }

        public static List<Tranzactie> GetTranzactiiByStatie(int idStatie)
        {
            List<Tranzactie> list = new List<Tranzactie>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"SELECT IdTranzactie, IdStatie, IdCombustibil, 
                    DataOra, CantitateaLitri, SumaTotala, ModPlata 
                    FROM Tranzactie WHERE IdStatie=@IdStatie ORDER BY DataOra DESC";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdStatie", idStatie);
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
            catch (Exception ex) { MessageBox.Show("Eroare GetTranzactiiByStatie: " + ex.Message); }
            return list;
        }

        public static List<TranzactieDetalii> GetTranzactiiCuDetalii()
        {
            List<TranzactieDetalii> list = new List<TranzactieDetalii>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"
                    SELECT t.IdTranzactie, s.Denumire, c.Tip, 
                           t.DataOra, t.CantitateaLitri, t.SumaTotala, t.ModPlata
                    FROM Tranzactie t
                    JOIN StatiePeco s ON t.IdStatie = s.IdStatie
                    JOIN Combustibil c ON t.IdCombustibil = c.IdCombustibil
                    ORDER BY t.DataOra DESC";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TranzactieDetalii
                    {
                        IdTranzactie = reader.GetInt32(0),
                        DenumireStatie = reader.GetString(1),
                        TipCombustibil = reader.GetString(2),
                        DataOra = reader.GetDateTime(3),
                        CantitateaLitri = reader.GetDecimal(4),
                        SumaTotala = reader.GetDecimal(5),
                        ModPlata = reader.GetString(6)
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare GetTranzactiiCuDetalii: " + ex.Message); }
            return list;
        }

        public static List<TranzactieDetalii> GetTranzactiiCuDetaliiByStatie(int idStatie)
        {
            List<TranzactieDetalii> list = new List<TranzactieDetalii>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"
                    SELECT t.IdTranzactie, s.Denumire, c.Tip,
                           t.DataOra, t.CantitateaLitri, t.SumaTotala, t.ModPlata
                    FROM Tranzactie t
                    JOIN StatiePeco s ON t.IdStatie = s.IdStatie
                    JOIN Combustibil c ON t.IdCombustibil = c.IdCombustibil
                    WHERE t.IdStatie = @IdStatie
                    ORDER BY t.DataOra DESC";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdStatie", idStatie);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TranzactieDetalii
                    {
                        IdTranzactie = reader.GetInt32(0),
                        DenumireStatie = reader.GetString(1),
                        TipCombustibil = reader.GetString(2),
                        DataOra = reader.GetDateTime(3),
                        CantitateaLitri = reader.GetDecimal(4),
                        SumaTotala = reader.GetDecimal(5),
                        ModPlata = reader.GetString(6)
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare GetTranzactiiCuDetaliiByStatie: " + ex.Message); }
            return list;
        }

        // ── RAPORT ──────────────────────────────────────────────

        public static List<RaportStatie> GetRaportStatii()
        {
            List<RaportStatie> list = new List<RaportStatie>();
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = @"
                    SELECT s.Denumire, s.Oras,
                           COUNT(t.IdTranzactie) AS NrTranzactii,
                           ISNULL(SUM(t.SumaTotala), 0) AS TotalIncasat
                    FROM StatiePeco s
                    LEFT JOIN Tranzactie t ON s.IdStatie = t.IdStatie
                    GROUP BY s.Denumire, s.Oras
                    ORDER BY TotalIncasat DESC";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RaportStatie
                    {
                        DenumireStatie = reader.GetString(0),
                        Oras = reader.GetString(1),
                        NrTranzactii = reader.GetInt32(2),
                        TotalIncasat = reader.GetDecimal(3)
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare GetRaportStatii: " + ex.Message);
            }
            return list;
        }

        public static (int totalTranzactii, decimal totalIncasat,
                       decimal medieTranzactie, string statieTop) GetStatisticiGenerale()
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();

                // Total tranzacții și sumă totală
                string q1 = "SELECT COUNT(*), ISNULL(SUM(SumaTotala), 0) FROM Tranzactie";
                using var cmd1 = new SqlCommand(q1, conn);
                using var r1 = cmd1.ExecuteReader();
                int totalTranzactii = 0;
                decimal totalIncasat = 0;
                if (r1.Read())
                {
                    totalTranzactii = r1.GetInt32(0);
                    totalIncasat = r1.GetDecimal(1);
                }
                r1.Close();

                // Media per tranzacție
                decimal medie = totalTranzactii > 0 ? totalIncasat / totalTranzactii : 0;

                // Stația cu cele mai multe tranzacții
                string q2 = @"
                    SELECT TOP 1 s.Denumire
                    FROM StatiePeco s
                    JOIN Tranzactie t ON s.IdStatie = t.IdStatie
                    GROUP BY s.Denumire
                    ORDER BY COUNT(t.IdTranzactie) DESC";
                using var cmd2 = new SqlCommand(q2, conn);
                var rezultat = cmd2.ExecuteScalar();
                string statieTop = rezultat != null ? rezultat.ToString()! : "N/A";

                return (totalTranzactii, totalIncasat, medie, statieTop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare GetStatisticiGenerale: " + ex.Message);
                return (0, 0, 0, "N/A");
            }
        }

    }
}