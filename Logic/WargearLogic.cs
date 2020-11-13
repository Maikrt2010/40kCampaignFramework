using System.Collections.Generic;
using Domain;

namespace Logic
{
    public class WargearLogic : Wargear
    {
        public WargearLogic(int wargearId, string wargearName, Faction factionBelongTo, List<WargearCategory> wargearCategories) : base(wargearId, wargearName, factionBelongTo, wargearCategories)
        {
        }
    }
}