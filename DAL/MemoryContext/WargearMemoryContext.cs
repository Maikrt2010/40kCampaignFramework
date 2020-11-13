using System.Collections.Generic;
using DAL.Database;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.MemoryContext
{
    public class WargearMemoryContext : Databasemmsql , IWargearMemoryContext
    {
        public void createwargear(string wargearName, Faction faction, List<WargearCategory> wargearCategories)
        {
            
        }
    }
}