using System;

namespace Warehouse
{
   public class Store
   {
      private readonly Warehouse _warehouse;

      public Store(Warehouse warehouse)
      {
         _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
      }

      public bool CanBuy(Product product, int units)
      {
         return false;
      }
   }
}