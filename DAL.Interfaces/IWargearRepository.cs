using System;
using System.Collections.Generic;
using Domain;

namespace DAL.Interfaces
{
    public interface IWargearRepository
    {
        void CreateWargear(string wargearName, FactionDTO faction, List<WeaponCategoryDTO> wargearCategories);

        List<WargearDTO> GetAllWargear();
        void UpdateAmmountAvaliable(int wargearid, int ammount);
        void CreateExtraWeaponCategroyWargear(WargearDTO wargearDto, WeaponCategoryDTO WeaponCategoryDto);
    }
}