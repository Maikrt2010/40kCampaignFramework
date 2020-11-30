using System;
using System.Collections.Generic;
using Domain;

namespace Logic.Interfaces
{
    public interface IWargearInventory
    {
        void CreateWargear(string wargearname, FactionDTO faction, List<WeaponCategoryDTO> wargearCategories);

        List<WargearDTO> GetAllWargears();

        void UpdateAmmount(int wargearid, int ammount);

        void UpdateWargearWeaponCategory(WargearDTO wargear, WeaponCategoryDTO waCategoryDto);
    }
}