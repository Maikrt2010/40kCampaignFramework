using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using DAL.Interfaces;
using Domain;
using Logic.Interfaces;

namespace Logic
{
    public class WargearInventory : IWargearInventory
        {
            public List<Wargear> WargearinInventory;
            private readonly IWargearRepository wargearRepository;

            public WargearInventory(IWargearRepository wargearRepository)
            {
                this.wargearRepository = wargearRepository;
                GetAllWargears();
            }


            public void CreateWargear(string wargearName, Faction faction, List<WargearCategory> wargearCategories)
            {
                wargearRepository.CreateWargear(wargearName, faction, wargearCategories);
            }

            public List<Wargear> GetAllWargears()
            {
                throw new System.NotImplementedException();
            }
        }
    }