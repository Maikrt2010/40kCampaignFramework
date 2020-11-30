using Domain;

namespace Logic
{
    public class WeaponCategoryLogic : WeaponCategoryDTO
    {
        public WeaponCategoryLogic(int weaponCategoryId) : base(weaponCategoryId)
        {
        }

        public WeaponCategoryLogic(int weaponCategoryId, string weapenCategoryName) : base(weaponCategoryId, weapenCategoryName)
        {
        }
        public WeaponCategoryLogic(WeaponCategoryDTO weaponCategoryDto)
        {
            this.WeaponCategoryId = weaponCategoryDto.WeaponCategoryId;
            this.WeaponCategoryName = weaponCategoryDto.WeaponCategoryName;
        }

        public void UpdateWeaponCategoryName(string name)
        {
            WeaponCategoryName = name;
        }
    }
}