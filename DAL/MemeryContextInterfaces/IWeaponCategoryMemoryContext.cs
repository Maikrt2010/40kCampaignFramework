using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IWeaponCategoryMemoryContext
    {
        void createWeaponCategory(string weaponCategoryName);

        void UpdateCategory(WargearCategoryDTO wargearCategory);
        List<WargearCategoryDTO> GetAllWargearCategorys();
    }
}