using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.MemoryContext
{
    public class WeaponCategoryMemoryContext : Databasemmsql, IWeaponCategoryMemoryContext
    {
        public void createWeaponCategory(string weaponCategoryName)
        {
            string query = "INSERT INTO dbo.WeaponCategory(WeaponCategoryName) VALUES (@WeaponCategoryName)";
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@WeaponCategoryName", weaponCategoryName);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateCategory(WeaponCategoryDTO weaponCategory)
        {
            string query = "UPDATE dbo.WeaponCategory SET WeaponCategoryName = @WeaponCategoryName Where WeaponCategoryID = @WeaponCategoryId";
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@WeaponCategoryId", weaponCategory.WeaponCategoryId);
                    command.Parameters.AddWithValue("@WeaponCategoryName", weaponCategory.WeaponCategoryName);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
                
            }
        }

        public List<WeaponCategoryDTO> GetAllWeapomCategorys()
        {
            List<WeaponCategoryDTO> weaponCategorys = new List<WeaponCategoryDTO>();
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM WeaponCategory", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            weaponCategorys.Add(new WeaponCategoryDTO(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                    conn.Close();
                }
            }
            return weaponCategorys;
        }

        public WeaponCategoryDTO GetWeaponCategoryName(string name)
        {
                        WeaponCategoryDTO weaponCategory = null;
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM WeaponCategory Where WeaponCategoryName = @WeaponCategoryName", conn))
                {

                    command.Parameters.AddWithValue("@WeaponCategoryName", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            weaponCategory = new WeaponCategoryDTO(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                    conn.Close();
                }
                
            }
            return weaponCategory;
        }
    }
}