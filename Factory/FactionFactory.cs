using DAL.MemoryContext;
using DAL.Repository;
using Logic;
using Logic.Interfaces;

namespace Factory
{
    public class FactionFactory
    {
        public static IFactionCollection GetFactionCollection()
        {
            return new FactionCollection(new FactionRepository(new FactionMemoryContext()));
        }
    }
}