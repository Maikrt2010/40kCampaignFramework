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

        public void CreateWargear(string wargearName, FactionDTO faction, List<WeaponCategoryDTO> wargearCategories)
        {
            if (Exits(wargearName) == false)
            {
                IwargearContext.CreateWargear(wargearName);
            }
            IwargearContext.CreateWargearFaction(wargearName,faction);
            foreach (var VARIABLE in wargearCategories)
            {
                IwargearContext.CreateWargearFactionWeaponCategory(wargearName, faction, VARIABLE);
            }
            
        }

        public List<WargearDTO> GetAllWargear()
        {
            return IwargearContext.GetAllWargear();
        }

        public void UpdateAmmountAvaliable(int wargearid, int ammount)
        {
            IwargearContext.UpdateAmmountAvaliable(wargearid, ammount);
        }

        public void CreateExtraWeaponCategroyWargear(WargearDTO wargearDto, WeaponCategoryDTO WeaponCategoryDto)
        {
            IwargearContext.CreateWargearFactionWeaponCategory(wargearDto.WargearName, wargearDto.FactionBelongTo, WeaponCategoryDto);
        }

        private bool Exits(string wargearName)
        {
            bool Exits = false;
            foreach (var wargearDto in IwargearContext.GetAllWargear())
            {
                if (wargearDto.WargearName == wargearName)
                {
                    Exits = true;
                }
            }
            return Exits;
        }
    }
}