using System.Collections.Generic;
using DAL.Interfaces;
using Domain;

namespace DAL.Repository
{
    public class WargearRepository : IWargearRepository
    {
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