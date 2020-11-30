using System;
using System.Collections.Generic;
using DAL.Models;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IWargearMemoryContext
    {
        void CreateWargear(string wargearName);
        void CreateWargearFaction(string wargearName, FactionDTO faction);

        void CreateWargearFactionWeaponCategory(string wargearName, FactionDTO faction,
            WeaponCategoryDTO weaponCategory);

        void UpdateAmmountAvaliable(int wargearid, int ammount);
        List<WargearDTO> GetAllWargear();

    }
}