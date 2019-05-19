using System;


namespace InheritanceAndInterface
{
    public class ExcavatorModel : InventoryItemModel, IRentaltable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavatoe has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The excavator has been returned");
        }
    }

}
