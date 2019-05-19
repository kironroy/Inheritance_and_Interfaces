using System;
using System.Collections.Generic;

namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();

            inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Lexus ES 350" });
            inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 448 });

            Console.ReadLine();
        }
    }

    public interface IRentaltable
    {
        void Rent();
        void ReturnRental();
    }

    public interface IPurchasable
    {
        void Purchase();
    }

    public class InventoryItemModel
    {
        public string ProductName{ get; set; }
        public int QuantityInStock { get; set; }
    }

    public class VehicleModel : InventoryItemModel
    {
        public decimal DealerFee { get; set; }
    }

    public class BookModel : InventoryItemModel
    {
        public int NumberOfPages { get; set; }
    }

    public class Excavator : InventoryItemModel, IRentaltable
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
            throw new NotImplementedException();
        }
    }

}
