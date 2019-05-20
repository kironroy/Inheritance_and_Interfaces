using System;
using System.Collections.Generic;


namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentaltable> rentables;
            List<IPurchasable> purchasables;

            ListofPurchasablesAndRentables(out rentables, out purchasables);

            clientsRentOrBuyOptionMenu(rentables, purchasables);

            EndOfAppPrompmt();
        }


        private static void clientsRentOrBuyOptionMenu(List<IRentaltable> rentables, List<IPurchasable> purchasables)
        {
            Console.WriteLine(" *** Welcome to Funky Store ***");
            Console.WriteLine(); // breakline
            Console.WriteLine("Do you want to rent or purchase something: (rent, purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: { item.ProductName }");
                    Console.Write("Do you want to rent this item (yes/no):");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
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
        }

        private static void ListofPurchasablesAndRentables(out List<IRentaltable> rentables, out List<IPurchasable> purchasables)
        {
            rentables = new List<IRentaltable>();
            purchasables = new List<IPurchasable>();

            // Vechicles declared 
            var teslaVehicle = new VehicleModel { DealerFee = 100, ProductName = "Tesla G series" };
            var chevyVehicle = new VehicleModel { DealerFee = 25, ProductName = "Chevy Impala" };

            // Books declared
            var inherentViceBook = new BookModel { ProductName = "Inherent Vice", NumberOfPages = 369 };
            var nakedLunchBook = new BookModel { ProductName = "Naked Lunch", NumberOfPages = 304 };

            // Excavators declared
            var caterpillarExcavator = new ExcavatorModel { ProductName = "Caterpillar D11T", QuantityInStock = 3 };
            var komatsuExcavator = new ExcavatorModel { ProductName = "Komatsu D375A-6", QuantityInStock = 1 };

            // Add rentables to the Rentable list
            rentables.Add(teslaVehicle); // a vehicle is rentable
            rentables.Add(chevyVehicle);
            rentables.Add(caterpillarExcavator); // a excavator is also rentable
            rentables.Add(komatsuExcavator);

            // Add purchasables to the Purchasable list
            purchasables.Add(inherentViceBook); // a book is only purchasable
            purchasables.Add(nakedLunchBook);

            // A vehicle can be both rented or purchased
            // a vehicle is from the Class VehicleModel it is a reference not a copy, no memory issues!!!
            purchasables.Add(teslaVehicle);
            purchasables.Add(chevyVehicle);
        }

        private static void EndOfAppPrompmt()
        {
            Console.WriteLine(); // breakline
            Console.WriteLine("We are done here :)");

            Console.ReadLine();
        }

    }

}
