namespace Warehouse
{
   public interface IWarehouse
   {
      int UnitsFor(string productId);
   }

   public class Warehouse
   {
      public int UnitsFor(string productId)
      {
         return 0;
      }
   }
}
