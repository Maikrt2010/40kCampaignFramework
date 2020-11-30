namespace Domain
{
    public class WeaponCategoryDTO
    {
        public int WeaponCategoryId { get; protected set; }
        public string WeaponCategoryName { get; protected set; }

        public WeaponCategoryDTO()
        {
        }

        public WeaponCategoryDTO(int weaponCategoryId)
        {
            WeaponCategoryId = weaponCategoryId;
        }

        public WeaponCategoryDTO(int weaponCategoryId, string weapenCategoryName)
        {
            WeaponCategoryId = weaponCategoryId;
            WeaponCategoryName = weapenCategoryName;
        }
    }
}