namespace Domain
{
    public class FactionDTO
    {
        public string FactionName { get; private set; }

        public FactionDTO(string factionName)
        {
            FactionName = factionName;
        }
    }
}