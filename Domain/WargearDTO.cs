using System.Collections.Generic;

namespace Domain
{
    public class WargearDTO
    {
        public int WargearID { get; protected set; }
        public string WargearName { get; private set; }

        public int AmmountTotal { get; private set; }

        public FactionDTO FactionBelongTo { get; private set; }

        public List<WeaponCategoryDTO> WeaponCategories { get; private set; }

        public WargearDTO(int wargearId, string wargearName, int ammountTotal, FactionDTO factionBelongTo, List<WeaponCategoryDTO> weaponCategories)
        {
            WargearID = wargearId;
            WargearName = wargearName;
            AmmountTotal = ammountTotal;
            FactionBelongTo = factionBelongTo;
            WeaponCategories = weaponCategories;
        }

        protected WargearDTO()
        {
        }
    }
}