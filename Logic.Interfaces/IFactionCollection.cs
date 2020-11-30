using System.Collections.Generic;
using Domain;

namespace Logic.Interfaces
{
    public interface IFactionCollection
    {
        void createFaction(string factionName);

        void UpdateFactionName(string factionNameOld, string factionNameNew);

        IEnumerable<FactionDTO> GetAllFactions();
    }
}