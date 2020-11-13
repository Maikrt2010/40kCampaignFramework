using System;
using System.Collections.Generic;
using Domain;

namespace Logic.Interfaces
{
    public interface IWargearInventory
    {
        void CreateWargear(string wargearname, Faction faction, List<WargearCategory> wargearCategories);

        List<Wargear> GetAllWargears();
    }
}