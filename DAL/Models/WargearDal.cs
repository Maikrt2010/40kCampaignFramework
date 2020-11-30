using System.Collections.Generic;
using System.ComponentModel;
using Domain;

namespace DAL.Models
{
    public class WargearDal : WargearDTO
    {
        public WargearDal(int wargearId, string wargearName, int ammountTotal, FactionDTO factionBelongTo, List<WeaponCategoryDTO> weaponCategories) : base(wargearId, wargearName, ammountTotal, factionBelongTo, weaponCategories)
        {
        }

        public WargearDal()
        {
            this.WargearID = 0;
        }

        public void AddWeaponCategoryDTO(WeaponCategoryDTO weaponCategory)
        {
            this.WeaponCategories.Add(weaponCategory);
        }
    }
}