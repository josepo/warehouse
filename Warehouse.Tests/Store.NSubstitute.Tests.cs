using NSubstitute;
using Xunit;

namespace Warehouse
{
   public class StoreNSubtituteTests
   {
      [Fact]
      public void CanBuyIfUnitsEnoughInWarehouse()
      {
         IWarehouse warehouse = Substitute.For<IWarehouse>();
         warehouse.UnitsFor("P1").Returns(6);

         Store store = new Store(warehouse);

         Assert.True(store.CanBuy("P1", 5));
      }
   }
}