using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.MemoryContext
{
    public class FactionMemoryContext : Databasemmsql, IFactionMemoryContext
    {
        public void createFaction(string factionName)
        {
            string query = "INSERT INTO dbo.Faction(FactionName) VALUES (@FactionName)";
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@FactionName", factionName);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateFaction(FactionDTO faction)
        {
            string query = "UPDATE dbo.Faction SET FactionName = @FactionName Where FactionID = @FactionId";
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@FactionId", faction.FactionId);
                    command.Parameters.AddWithValue("@FactionName", faction.FactionName);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public FactionDTO GetFactionName(string name)
        {
            FactionDTO faction = null;
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Faction Where FactionName = @FactionName", conn))
                {

                    command.Parameters.AddWithValue("@FactionName", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            faction = new FactionDTO(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                    conn.Close();
                }
            }
            return faction;
        }

        public IEnumerable<FactionDTO> GetAllFaction()
            {
                List<FactionDTO> factions = new List<FactionDTO>();
                using (SqlConnection conn = new SqlConnection(connenctionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Faction", conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                factions.Add(new FactionDTO(reader.GetInt32(0), reader.GetString(1)));
                            }
                        }
                        conn.Close();
                    }
                }

                return factions;
            }
        }
    }
