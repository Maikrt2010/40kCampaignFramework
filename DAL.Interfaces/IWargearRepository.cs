using System;
using System.Collections.Generic;
using Domain;

namespace DAL.Interfaces
{
    public interface IWargearRepository
    {
        void CreateWargear(string wargearName, FactionDTO faction, List<WargearCategoryDTO> wargearCategories);

        List<WargearDTO> GetAllWargear();

    }
}