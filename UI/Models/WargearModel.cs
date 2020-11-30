using System.Collections.Generic;
using Domain;
using Logic.Interfaces;

namespace UI.Models
{
    public class WargearModel
    {
        public int WargearID { get; set; }
        public string WargearName { get; set; }

        public int AmmountTotal { get; set; }

        public FactionModel FactionBelongTo { get; set; }

        public List<WeaponCategoryModel> WeaponCategories { get;  set; }
        public WargearModel(WargearDTO wargear)
        {
            WargearID = wargear.WargearID;
            WargearName = wargear.WargearName;
            AmmountTotal = wargear.AmmountTotal;
            FactionBelongTo = new FactionModel(wargear.FactionBelongTo);
            List<WeaponCategoryModel> weaponCategories = new List<WeaponCategoryModel>();
            foreach (var VARIABLE in wargear.WeaponCategories)
            {
                weaponCategories.Add(new WeaponCategoryModel(VARIABLE));
            }
            WeaponCategories = weaponCategories;
        }

        public string categories()
        {
            string cat = "";
            foreach (var VARIABLE in WeaponCategories)
            {
                if (cat == "")
                {
                    cat = VARIABLE.WeaponCategoryName;
                }
                else
                {
                    cat = cat + ", " + VARIABLE.WeaponCategoryName;
                }
            }

            return cat;
        }
    }
}