using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IWeaponCategoryMemoryContext
    {
        void createWeaponCategory(string weaponCategoryName);

        void UpdateCategory(WeaponCategoryDTO wargearCategory);
        List<WeaponCategoryDTO> GetAllWeapomCategorys();
        WeaponCategoryDTO GetWeaponCategoryName(string name);
    }
}