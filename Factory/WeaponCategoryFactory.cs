using DAL.MemoryContext;
using DAL.Repository;
using Logic;
using Logic.Interfaces;

namespace Factory
{
    public class WeaponCategoryFactory
    {
        public static IWeaponCategoryCollection GetWeaponCategoryCollection()
        {
            return new WeaponCategoryCollection(new WeaponCategoryRepository(new WeaponCategoryMemoryContext()));
        }
    }
}