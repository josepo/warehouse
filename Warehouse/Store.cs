using System;

namespace Warehouse
{
   public class Store
   {
      private readonly IWarehouse _warehouse;

      public Store(IWarehouse warehouse)
      {
         _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
      }

      public bool CanBuy(string productId, int units)
      {
         return _warehouse.UnitsFor(productId) >= units;
      }
   }
}