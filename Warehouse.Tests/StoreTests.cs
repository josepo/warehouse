using Xunit;

namespace Warehouse
{
    public class StoreTests
    {
        [Fact]
        public void CanBuyIfUnitsEnoughInWarehouse()
        {
           Store store = new Store(new Warehouse());

           Assert.True(store.CanBuy("PROD-1", 5));
        }
    }
}
