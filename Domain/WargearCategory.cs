namespace Domain
{
    public class WargearCategory
    {
        public string WargearCategoryName { get; private set; }

        public WargearCategory(string wargearCategoryName)
        {
            WargearCategoryName = wargearCategoryName;
        }
    }
}