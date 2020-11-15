using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;

namespace DAL.MemoryContext
{
    public class WeaponCategoryMemoryContext : Databasemmsql ,IWeaponCategoryMemoryContext
    {
        public void createWeaponCategory(string weaponCategoryName)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo.WeaponCategory]([WeaponCategoryName]) VALUES (@WeaponCategoryName)", conn))
                {
                    command.Parameters.AddWithValue("@WeaponCategoryName", weaponCategoryName);
                    command.ExecuteNonQueryAsync();
                    conn.Close();
                }
            }
        }
    }
}