using DAL.Interfaces;
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
    }
}