using System.Reflection.PortableExecutable;

namespace Fishing_Boat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.0;
            
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            if (fishermen <= 6)
            {
                price = price * 0.90;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                price = price * 0.85;
            }
            else if (fishermen >= 12)
            {
                price = price * 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }
            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
            }
        }
    }
}