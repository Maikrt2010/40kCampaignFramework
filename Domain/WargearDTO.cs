using System.Collections.Generic;

namespace Domain
{
    public class WargearDTO
    {
        public int WargearID { get; private set; }
        public string WargearName { get; private set; }

        public FactionDTO FactionBelongTo { get; private set; }

        public List<WargearCategoryDTO> WargearCategories { get; private set; }

        public WargearDTO(int wargearId, string wargearName, FactionDTO factionBelongTo, List<WargearCategoryDTO> wargearCategories)
        {
            WargearID = wargearId;
            WargearName = wargearName;
            FactionBelongTo = factionBelongTo;
            WargearCategories = wargearCategories;
        }

        public WargearDTO(string wargearName, FactionDTO factionBelongTo, List<WargearCategoryDTO> wargearCategories)
        {
            WargearName = wargearName;
            FactionBelongTo = factionBelongTo;
            WargearCategories = wargearCategories;
        }

        public WargearDTO()
        {
            WargearCategories = new List<WargearCategoryDTO>();
        }
    }
}