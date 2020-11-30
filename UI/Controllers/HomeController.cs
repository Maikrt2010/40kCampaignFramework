using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Factory;

using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using UI.ViewModel;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFactionCollection factionCollection;
        private readonly IWeaponCategoryCollection weaponCategoryCollection;
        private readonly IWargearInventory wargearInventory;


        public HomeController()
        {
            factionCollection = FactionFactory.GetFactionCollection();
            weaponCategoryCollection = WeaponCategoryFactory.GetWeaponCategoryCollection();
            wargearInventory = WargearFactory.GetWargearInventory();
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public IActionResult Faction()
        {
            List<FactionModel> factions = new List<FactionModel>();
            foreach (var VARIABLE in factionCollection.GetAllFactions())
            {
                factions.Add(new FactionModel(VARIABLE));
            }
            ViewBag.Factions = factions;
            return View();
        }

        public IActionResult CreateFaction()
        {
            factionCollection.createFaction(Convert.ToString(HttpContext.Request.Form["factionName"]));
            return RedirectToAction("Faction", "Home");
        }

        public IActionResult UpdateFaction()
        {
            factionCollection.UpdateFactionName(Convert.ToString(HttpContext.Request.Form["factionNameOld"]), Convert.ToString(HttpContext.Request.Form["factionNameNew"]));
            return RedirectToAction("Faction", "Home");
        }

        public IActionResult WeaponCategory()
        {
            List<WeaponCategoryModel> weaponCategorys = new List<WeaponCategoryModel>();
            foreach (var VARIABLE in weaponCategoryCollection.GetAllWeaponCategorys())
            {
                weaponCategorys.Add(new WeaponCategoryModel(VARIABLE));
            }
            ViewBag.WeaponCategorys = weaponCategorys;
            return View();
        }


        public IActionResult CreateWeaponCategory()
        {
            weaponCategoryCollection.CreateWeaponCatergory(Convert.ToString(HttpContext.Request.Form["weaponCategoryName"]));
            return RedirectToAction("WeaponCategory", "Home");
        }

        public IActionResult UpdateWeaponCategory()
        {
            weaponCategoryCollection.UpdateWeaponCategoryName(Convert.ToString(HttpContext.Request.Form["weaponCategoryNameOld"]), Convert.ToString(HttpContext.Request.Form["weaponCategoryNameNew"]));
            return RedirectToAction("WeaponCategory", "Home");
        }

        public IActionResult Wargear()
        {
            WargearViewModel viewModel = new WargearViewModel();
            List<WargearModel> wargearModels = new List<WargearModel>();
            foreach (var VARIABLE in wargearInventory.GetAllWargears())
            {
                wargearModels.Add(new WargearModel(VARIABLE));
            }

            viewModel.Wargear = wargearModels;
            List<WeaponCategoryModel> weaponCategorys = new List<WeaponCategoryModel>();
            foreach (var VARIABLE in weaponCategoryCollection.GetAllWeaponCategorys())
            {
                weaponCategorys.Add(new WeaponCategoryModel(VARIABLE));
            }
            viewModel.WeaponCategory= weaponCategorys;
            List<FactionModel> factions = new List<FactionModel>();
            foreach (var VARIABLE in factionCollection.GetAllFactions())
            {
                factions.Add(new FactionModel(VARIABLE));
            }
            viewModel.Faction = factions;
            return View(viewModel);
        }

        public IActionResult CreateWargear()
        {
            List<WeaponCategoryDTO> weaponCategory = new List<WeaponCategoryDTO>();
            foreach (var VARIABLE in weaponCategoryCollection.GetAllWeaponCategorys())
            {
                if (VARIABLE.WeaponCategoryName == Convert.ToString(HttpContext.Request.Form["factionName"]))
                {
                    weaponCategory.Add(VARIABLE);
                }
            }
            FactionDTO faction = new FactionDTO();
            foreach (var VARIABLE in factionCollection.GetAllFactions())
            {
                faction = VARIABLE;
            }
            wargearInventory.CreateWargear(Convert.ToString(HttpContext.Request.Form["wargearName"]), faction, weaponCategory);
            return RedirectToAction("Wargear", "Home");
        }


        //TODO
        public IActionResult AddWeaponCategoryWargear()
        {
   
            string test = Convert.ToString(HttpContext.Request.Form["wargearName"]);
            string test3 = Convert.ToString(HttpContext.Request.Form["weaponCategoryName"]);
            return RedirectToAction("Wargear", "Home");
        }

        public IActionResult UpdateAmmount()
        {
            wargearInventory.UpdateAmmount(Convert.ToInt32(HttpContext.Request.Form["WargearID"]), Convert.ToInt32(HttpContext.Request.Form["AmmountTotal"]));
            return RedirectToAction("Wargear", "Home");
        }

        
    }

}
