using Moq;
using Xunit;

namespace Warehouse
{
   public class StoreMoqTests
   {
      [Fact]
      public void CanBuyIfUnitsEnoughInWarehouse()
      {
         Mock<IWarehouse> warehouse = new Mock<IWarehouse>();
         warehouse.Setup(w => w.UnitsFor("P1")).Returns(6);

         Store store = new Store(warehouse.Object);

         Assert.True(store.CanBuy("P1", 5));
      }
   }
}
