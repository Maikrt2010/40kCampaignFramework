using System.Collections.Generic;
using Domain;

namespace DAL.MemeryContextInterfaces
{
    public interface IFactionMemoryContext
    {
        void createFaction(string FactionName);

        void UpdateFaction(FactionDTO wargearCategory);
        List<FactionDTO> GetAllFaction();
    }
}