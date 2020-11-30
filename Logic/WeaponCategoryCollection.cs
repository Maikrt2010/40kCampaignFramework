using System.Collections.Generic;
using DAL.Interfaces;
using Domain;
using Logic.Interfaces;

namespace Logic
{
    public class WeaponCategoryCollection : IWeaponCategoryCollection
    {
        private readonly IWeaponCategoryRepository WeaponCategoryRepository;

        public WeaponCategoryCollection(IWeaponCategoryRepository weaponCategoryRepository)
        {
            this.WeaponCategoryRepository = weaponCategoryRepository;
        }

        public void CreateWeaponCatergory(string weaponCatergoryName)
        {
            WeaponCategoryRepository.createWeaponCategory(weaponCatergoryName);
        }

        public void UpdateWeaponCategoryName(string WeaponCategoryNameOld, string WeaponCategoryNameNew)
        {
            WeaponCategoryLogic weaponCategory = new WeaponCategoryLogic(WeaponCategoryRepository.GetWeaponCategoryName(WeaponCategoryNameOld));
            weaponCategory.UpdateWeaponCategoryName(WeaponCategoryNameNew);
            WeaponCategoryRepository.UpdateCategory(weaponCategory);
        }


        public List<WeaponCategoryDTO> GetAllWeaponCategorys()
        {
            return WeaponCategoryRepository.GetAllWeapomCategorys();
        }
    }
}