using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;

namespace DAL.MemoryContext
{
    public class FactionMemoryContext : Databasemmsql , IFactionMemoryContext
    {
        public void createFaction(string FactionName)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo.Faction]([FactionName]) VALUES (@FactionName)", conn))
                {
                    command.Parameters.AddWithValue("@FactionName", FactionName);
                    command.ExecuteNonQueryAsync();
                    conn.Close();
                }
            }
        }
    }
}