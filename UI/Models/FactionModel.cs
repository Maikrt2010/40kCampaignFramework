using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace UI.Models
{
    public class FactionModel
    {
        public int FactionId { get; set; }
        public string FactionName { get; set; }

        public FactionModel(FactionDTO factionDto)
        {
            FactionId = factionDto.FactionId;
            FactionName = factionDto.FactionName;
        }
    }

}
