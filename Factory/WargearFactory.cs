using System.Linq.Expressions;
using DAL.MemoryContext;
using DAL.Repository;
using Logic;
using Logic.Interfaces;


namespace Factory
{
    public class WargearFactory
    {
        public static IWargearInventory GetWargearInventory()
        {
            return new WargearInventory(new WargearRepository(new WargearMemoryContext()));
        }
    }
}