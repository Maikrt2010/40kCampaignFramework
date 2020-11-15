using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.MemoryContext
{
    public class WargearMemoryContext : Databasemmsql , IWargearMemoryContext
    {
        public void createwargear(string wargearName, FactionDTO faction, List<WargearCategoryDTO> wargearCategories)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo.Depot]([Location]) VALUES (@Location)", conn))
                {

                    conn.Close();
                }
            }
        }
    }
}