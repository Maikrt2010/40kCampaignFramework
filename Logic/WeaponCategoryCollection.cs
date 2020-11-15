using DAL.Interfaces;

namespace Logic
{
    public class WeaponCategoryCollection : IWeaponCategoryRepository
    {
        private readonly IWeaponCategoryRepository WeaponCategoryRepository;

        public WeaponCategoryCollection(IWeaponCategoryRepository weaponCategoryRepository)
        {
            this.WeaponCategoryRepository = weaponCategoryRepository;
        }

        public void createWeaponCategory(string weaponCategoryName)
        {
            WeaponCategoryRepository.createWeaponCategory(weaponCategoryName);
        }
    }
}