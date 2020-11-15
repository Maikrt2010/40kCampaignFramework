using System;
using System.Collections.Generic;
using Domain;

namespace Logic.Interfaces
{
    public interface IWargearInventory
    {
        void CreateWargear(string wargearname, FactionDTO faction, List<WargearCategoryDTO> wargearCategories);

        List<WargearDTO> GetAllWargears();
    }
}