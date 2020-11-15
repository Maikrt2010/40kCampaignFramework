using DAL.Interfaces;
using DAL.MemeryContextInterfaces;

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
            
        }
    }
}