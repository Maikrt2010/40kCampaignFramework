namespace Domain
{
    public class FactionDTO
    {
        public int FactionId { get; protected set; }
        public string FactionName { get; protected set; }

        public FactionDTO(string factionName)
        {
            FactionName = factionName;
        }

        public FactionDTO(int factionId, string factionName)
        {
            FactionId = factionId;
            FactionName = factionName;
        }

        public FactionDTO()
        {
        }
    }
}