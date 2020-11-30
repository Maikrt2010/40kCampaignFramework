using System.Collections.Generic;
using DAL.Interfaces;
using DAL.MemeryContextInterfaces;
using Domain;

namespace DAL.Repository
{
    public class FactionRepository : IFactionRepository
    {
        private readonly IFactionMemoryContext factioncContext;

        public FactionRepository(IFactionMemoryContext factioncContext)
        {
            this.factioncContext = factioncContext;
        }

        public void createFaction(string factionName)
        {
            factioncContext.createFaction(factionName);
        }

        public void UpdateFaction(FactionDTO faction)
        {
            factioncContext.UpdateFaction(faction);
        }

        public FactionDTO GetFactionName(string name)
        {
            return factioncContext.GetFactionName(name);
        }

        public IEnumerable<FactionDTO> GetAllFactions()
        {
            return factioncContext.GetAllFaction();
        }
    }
}