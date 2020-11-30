using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.ViewModel
{
    public class WargearViewModel
    {
        public List<WargearModel> Wargear { get; set; }
        public List<FactionModel> Faction { get; set; }
        public List<WeaponCategoryModel> WeaponCategory { get; set; }
    }
}
