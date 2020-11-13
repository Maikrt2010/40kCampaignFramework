namespace Domain
{
    public class Faction
    {
        public string FactionName { get; private set; }

        public Faction(string factionName)
        {
            FactionName = factionName;
        }
    }
}