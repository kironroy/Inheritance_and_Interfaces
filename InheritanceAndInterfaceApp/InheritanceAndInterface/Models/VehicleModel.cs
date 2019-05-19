using System;


namespace InheritanceAndInterface
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentaltable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vechicle has been purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vechicle has been returned");
        }
    }

}
