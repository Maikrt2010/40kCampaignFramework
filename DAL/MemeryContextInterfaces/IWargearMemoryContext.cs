using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IWargearMemoryContext
    {
        void createwargear(string wargearName, FactionDTO faction, List<WargearCategoryDTO> wargearCategories);
    }
}