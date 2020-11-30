using System;
using System.Collections.Generic;
using Domain;

namespace DAL.Interfaces
{
    public interface IFactionRepository
    {
        void createFaction(string factionName);

        void UpdateFaction(FactionDTO faction);

        FactionDTO GetFactionName(string name);
        IEnumerable<FactionDTO> GetAllFactions();
    }
}