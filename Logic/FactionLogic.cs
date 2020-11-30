using Domain;

namespace Logic
{
    public class FactionLogic : FactionDTO
    {
        public FactionLogic(string factionName) : base(factionName)
        {
        }

        public FactionLogic(int factionId, string factionName) : base(factionId, factionName)
        {
        }

        public FactionLogic(FactionDTO factionDto)
        {
            this.FactionId = factionDto.FactionId;
            this.FactionName = factionDto.FactionName;
        }

        public void UpdateFactionName(string name)
        {
            FactionName = name;
        }
    }
}