using System.Collections.Generic;
using Domain;

namespace Logic.Interfaces
{
    public interface IWeaponCategoryCollection
    {
        void CreateWeaponCatergory(string weaponCatergoryName);

        void UpdateWeaponCategoryName(string WeaponCategoryNameOld, string WeaponCategoryNameNew);

        List<WeaponCategoryDTO> GetAllWeaponCategorys();
    }
}