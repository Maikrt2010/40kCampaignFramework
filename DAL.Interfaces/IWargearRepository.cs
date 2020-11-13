using System;
using System.Collections.Generic;
using Domain;

namespace DAL.Interfaces
{
    public interface IWargearRepository
    {
        void CreateWargear(string wargearName, Faction faction, List<WargearCategory> wargearCategories);

        List<Wargear> GetAllWargear();

    }
}