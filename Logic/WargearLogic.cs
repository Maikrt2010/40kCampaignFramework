using System.Collections.Generic;
using Domain;

namespace Logic
{
    public class WargearLogic : WargearDTO
    {
        public WargearLogic(int wargearId, string wargearName, int ammountTotal, FactionDTO factionBelongTo, List<WeaponCategoryDTO> weaponCategories) : base(wargearId, wargearName, ammountTotal, factionBelongTo, weaponCategories)
        {
        }
    }
}