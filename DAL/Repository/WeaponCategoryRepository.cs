using DAL.MemeryContextInterfaces;

namespace DAL.Repository
{
    public class WeaponCategoryRepository : IWeaponCategoryMemoryContext
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
    }
}