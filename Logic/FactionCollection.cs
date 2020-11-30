using System.Collections.Generic;
using DAL.Interfaces;
using Domain;
using Logic.Interfaces;

namespace Logic
{
    public class FactionCollection : IFactionCollection
    {
        private readonly IFactionRepository factionRepository;

        public FactionCollection(IFactionRepository factionRepository)
        {
            this.factionRepository = factionRepository;
        }


        public void createFaction(string factionName)
        {
            factionRepository.createFaction(factionName);
        }

        public void UpdateFactionName(string factionNameOld, string factionNameNew)
        {
            FactionLogic faction = new FactionLogic(factionRepository.GetFactionName(factionNameOld));
            faction.UpdateFactionName(factionNameNew);
            factionRepository.UpdateFaction(faction);
        }


        public IEnumerable<FactionDTO> GetAllFactions()
        {
            return factionRepository.GetAllFactions();
        }
    }
}