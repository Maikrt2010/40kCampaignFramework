using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DAL.Database;
using DAL.MemeryContextInterfaces;
using DAL.Models;
using Domain;

namespace DAL.MemoryContext
{
    public class WargearMemoryContext : Databasemmsql, IWargearMemoryContext
    {


        public void CreateWargear(string wargearName)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command =
                    new SqlCommand("INSERT INTO dbo.Wargear(WargearName) VALUES (@WargearName)", conn))
                {
                    command.Parameters.AddWithValue("@WargearName", wargearName);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void UpdateAmmountAvaliable(int wargearid, int ammount)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command =
                    new SqlCommand("UPDATE dbo.Wargear_Faction SET AmmountTotal = @AmmountTotal Where WargearFactionID = @WargearFactionID", conn))
                {
                    command.Parameters.AddWithValue("@WargearFactionID", wargearid);
                    command.Parameters.AddWithValue("@AmmountTotal", ammount);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<WargearDTO> GetAllWargear()
        {
            List<WargearDTO> wargears = new List<WargearDTO>();
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT Wargear_Faction.WargearFactionID, WargearName, Wargear_Faction.FactionID, FactionName, AmmountTotal, WeaponCategory.WeaponCategoryID, WeaponCategory.WeaponCategoryName From Wargear_Faction INNER JOIN Wargear ON Wargear_Faction.WargearID = Wargear.WargearID INNER JOIN Faction ON Wargear_Faction.FactionID = Faction.FactionID INNER JOIN Wargear_Faction_WeaponCategory on Wargear_Faction.WargearFactionID = Wargear_Faction_WeaponCategory.WargearFactionID INNER JOIN WeaponCategory on Wargear_Faction_WeaponCategory.WeaponCatagoryID = WeaponCategory.WeaponCategoryID", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        WargearDal wargearDal = new WargearDal();
                        while (reader.Read())
                        {
                            List<WeaponCategoryDTO> weaponCategory = new List<WeaponCategoryDTO>();
                            int id = reader.GetInt32(0);
                            if (wargearDal.WargearID == id)
                            {
                                wargearDal.AddWeaponCategoryDTO(new WeaponCategoryDTO(reader.GetInt32(5), reader.GetString(6)));
                            }
                            else
                            {
                                if (wargearDal.WargearID != 0)
                                {
                                    wargears.Add(wargearDal);
                                }
                                string name = reader.GetString(1);
                                FactionDTO faction = new FactionDTO(reader.GetInt32(2), reader.GetString(3));
                                int total;
                                if (!reader.IsDBNull(4))
                                {
                                    total = reader.GetInt32(4);
                                }
                                else
                                {
                                    total = 0;
                                }
                                weaponCategory.Add(new WeaponCategoryDTO(reader.GetInt32(5), reader.GetString(6)));
                                wargearDal = new WargearDal(id, name, total, faction, weaponCategory);
                            }
                          
                        }
                        wargears.Add(wargearDal);
                    }
                    conn.Close();
                }
            }

            return wargears;
        }


        public void CreateWargearFaction(string wargearName, FactionDTO faction)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO dbo.Wargear_Faction(WargearID, FactionID) VALUES ((select WargearID FROM Wargear Where WargearName = @WargearName), @FactionID)", conn))
                {
                    command.Parameters.AddWithValue("@WargearName", wargearName);
                    command.Parameters.AddWithValue("@FactionID", faction.FactionId);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void CreateWargearFactionWeaponCategory(string wargearName, FactionDTO faction  , WeaponCategoryDTO weaponCategory)
        {
            using (SqlConnection conn = new SqlConnection(connenctionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO dbo.Wargear_Faction_WeaponCategory(WargearFactionID, WeaponCatagoryID) VALUES((select WargearFactionID From Wargear_Faction Where WargearID = (select WargearID FROM Wargear Where WargearName = @WargearName) and FactionID = @FactionID), @WeaponCategoryID )",
                    conn))
                {
                    command.Parameters.AddWithValue("@WargearName", wargearName);
                    command.Parameters.AddWithValue("@FactionID", faction.FactionId);
                    command.Parameters.AddWithValue("@WeaponCategoryID", weaponCategory.WeaponCategoryId);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}