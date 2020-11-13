using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IWargearMemoryContext
    {
        void createwargear(string wargearName, Faction faction, List<WargearCategory> wargearCategories);
    }
}