using System.Collections.Generic;
using DAL.Interfaces;
using Domain;

namespace DAL.Repository
{
    public class WargearRepository : IWargearRepository
    {
        public void CreateWargear(string wargearName, Faction faction, List<WargearCategory> wargearCategories)
        {
            throw new System.NotImplementedException();
        }

        public List<Wargear> GetAllWargear()
        {
            throw new System.NotImplementedException();
        }
    }
}