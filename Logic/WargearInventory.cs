using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using DAL.Interfaces;
using Domain;
using Logic.Interfaces;

namespace Logic
{
    public class WargearInventory : IWargearInventory
        {
            private List<WargearDTO> wargearInventory = new List<WargearDTO>();
            private readonly IWargearRepository wargearRepository;

            public WargearInventory(IWargearRepository wargearRepository)
            {
                this.wargearRepository = wargearRepository;
                GetAllWargears();
            }


            public void CreateWargear(string wargearName, FactionDTO faction, List<WeaponCategoryDTO> wargearCategories)
            {
                wargearRepository.CreateWargear(wargearName, faction, wargearCategories);
            }

            public List<WargearDTO> GetAllWargears()
            {
            wargearInventory = wargearRepository.GetAllWargear();
            return wargearInventory;
            }

            public void UpdateAmmount(int wargearid, int ammount)
            {
                wargearRepository.UpdateAmmountAvaliable(wargearid, ammount);
            }

            public void UpdateWargearWeaponCategory(WargearDTO wargear, WeaponCategoryDTO waCategoryDto)
            {
                wargearRepository.CreateExtraWeaponCategroyWargear(wargear, waCategoryDto);
            }
        }
    }