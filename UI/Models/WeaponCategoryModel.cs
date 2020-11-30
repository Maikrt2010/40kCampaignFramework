using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace UI.Models
{
    public class WeaponCategoryModel
    {
        public int WeaponCategoryId { get; set; }
        public string WeaponCategoryName { get; set; }

        public WeaponCategoryModel(WeaponCategoryDTO weaponCategoryDto)
        {
            WeaponCategoryId = weaponCategoryDto.WeaponCategoryId;
            WeaponCategoryName = weaponCategoryDto.WeaponCategoryName;
        }
    }
}
