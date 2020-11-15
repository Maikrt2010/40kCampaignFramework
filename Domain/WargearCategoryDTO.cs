namespace Domain
{
    public class WargearCategoryDTO
    {
        public string WargearCategoryName { get; private set; }

        public WargearCategoryDTO(string wargearCategoryName)
        {
            WargearCategoryName = wargearCategoryName;
        }
    }
}