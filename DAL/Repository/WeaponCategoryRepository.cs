using System.Collections.Generic;
using DAL.Interfaces;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.Repository
{
    public class WeaponCategoryRepository : IWeaponCategoryRepository
    {
        private readonly IWeaponCategoryMemoryContext weaponCategoryContext;

        public WeaponCategoryRepository(IWeaponCategoryMemoryContext weaponCategoryContext)
        {
            this.weaponCategoryContext = weaponCategoryContext;
        }

        public void createWeaponCategory(string weaponCategoryName)
        {
            weaponCategoryContext.createWeaponCategory(weaponCategoryName);
        }

        public void UpdateCategory(WeaponCategoryDTO wargearCategory)
        {
            weaponCategoryContext.UpdateCategory(wargearCategory);
        }

        public List<WeaponCategoryDTO> GetAllWeapomCategorys()
        {
            return weaponCategoryContext.GetAllWeapomCategorys();
        }

        public WeaponCategoryDTO GetWeaponCategoryName(string name)
        {
            return weaponCategoryContext.GetWeaponCategoryName(name);
        }
    }
}