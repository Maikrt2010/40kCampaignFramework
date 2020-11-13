using System.Collections.Generic;

namespace Domain
{
    public class Wargear
    {
        public int WargearID { get; private set; }
        public string WargearName { get; private set; }

        public Faction FactionBelongTo { get; private set; }

        public List<WargearCategory> WargearCategories { get; private set; }

        public Wargear(int wargearId, string wargearName, Faction factionBelongTo, List<WargearCategory> wargearCategories)
        {
            WargearID = wargearId;
            WargearName = wargearName;
            FactionBelongTo = factionBelongTo;
            WargearCategories = wargearCategories;
        }
    }
}