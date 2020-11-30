using System.Collections.Generic;
using Domain;

namespace DAL.Interfaces
{
    public interface IWeaponCategoryRepository
    {
        void createWeaponCategory(string weaponCategoryName);
        void UpdateCategory(WeaponCategoryDTO wargearCategory); 
        List<WeaponCategoryDTO> GetAllWeapomCategorys();
        WeaponCategoryDTO GetWeaponCategoryName(string name);
    }
}