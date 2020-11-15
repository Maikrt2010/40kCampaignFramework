using System.Collections.Generic;
using DAL.Interfaces;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.Repository
{
    public class WargearRepository : IWargearRepository
    {
        private readonly IWargearMemoryContext IwargearContext;

        public WargearRepository(IWargearMemoryContext iwargearContext)
        {
            IwargearContext = iwargearContext;
        }

        public void CreateWargear(string wargearName, FactionDTO faction, List<WargearCategoryDTO> wargearCategories)
        {
            throw new System.NotImplementedException();
        }

        public List<WargearDTO> GetAllWargear()
        {
            throw new System.NotImplementedException();
        }
    }
}