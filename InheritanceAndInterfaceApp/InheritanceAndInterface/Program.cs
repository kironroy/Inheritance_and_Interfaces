using System;
using System.Collections.Generic;


namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentaltable> rentables = new List<IRentaltable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Tesla G series" };
            var book = new BookModel { ProductName = "Inherent Vice", NumberOfPages = 369 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle); // a vehicle is rentable
            rentables.Add(excavator); // a excavator is also rentable

            purchasables.Add(book); // a book is only purchasable

            // A vehicle can be both rented or purchased
            // a vehicle is from the Class VehicleModel it is a reference not a copy no memory issues!!!
            purchasables.Add(vehicle);

            Console.WriteLine("Do you want to rent or purchase something: (rent, purchase)" );
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: { item.ProductName }");
                    Console.Write("Do you want to rent this item (yes/no):");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() =="yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no):");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine(); // breakline
            Console.WriteLine("We are done here :)");

            Console.ReadLine();
        }
    }

}
