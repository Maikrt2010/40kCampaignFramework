using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IFactionMemoryContext
    {
        void createFaction(string factionName);

        void UpdateFaction(FactionDTO faction);
        FactionDTO GetFactionName(string name);
        IEnumerable<FactionDTO> GetAllFaction();
    }
}