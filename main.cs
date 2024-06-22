using System;

namespace HomeSalesApp
{
    class HomeSales
    {
        static void Main(string[] args)
        {
            double totalSalesD = 0;
            double totalSalesE = 0;
            double totalSalesF = 0;

            while (true)
            {
                Console.Write("Enter the salesperson's initial (D, E, F) or 'Z' to quit: ");
                string initialInput = Console.ReadLine().ToUpper();

                if (initialInput == "Z")
                {
                    break;
                }

                if (initialInput != "D" && initialInput != "E" && initialInput != "F")
                {
                    Console.WriteLine("Error: Invalid initial entered. Please enter D, E, F, or Z.");
                    continue;
                }

                Console.Write("Enter the amount of sale: ");
                if (!double.TryParse(Console.ReadLine(), out double saleAmount) || saleAmount < 0)
                {
                    Console.WriteLine("Error: Invalid sale amount entered. Please enter a positive number.");
                    continue;
                }

                switch (initialInput)
                {
                    case "D":
                        totalSalesD += saleAmount;
                        break;
                    case "E":
                        totalSalesE += saleAmount;
                        break;
                    case "F":
                        totalSalesF += saleAmount;
                        break;
                }
            }

            double grandTotal = totalSalesD + totalSalesE + totalSalesF;

            Console.WriteLine("\nSales Summary:");
            Console.WriteLine($"Total sales by Danielle (D): {totalSalesD:C}");
            Console.WriteLine($"Total sales by Edward (E): {totalSalesE:C}");
            Console.WriteLine($"Total sales by Francis (F): {totalSalesF:C}");
            Console.WriteLine($"Grand total sales: {grandTotal:C}");

            string highestSalesperson = "Danielle (D)";
            double highestSales = totalSalesD;

            if (totalSalesE > highestSales)
            {
                highestSalesperson = "Edward (E)";
                highestSales = totalSalesE;
            }

            if (totalSalesF > highestSales)
            {
                highestSalesperson = "Francis (F)";
                highestSales = totalSalesF;
            }

            Console.WriteLine($"Salesperson with the highest total: {highestSalesperson} with {highestSales:C}");
        }
    }
}
