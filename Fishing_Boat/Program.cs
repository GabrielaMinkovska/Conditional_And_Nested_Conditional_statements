namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            // Spring - 3000
            // Summer and Autumn - 4200
            // Winter - 2600

            double rent = 0.0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }

            // fishermen <= 6 - 10%
            // fishermen >= 7 && fishermen <= 11 - 15%
            // fishermen >= 12 - 25%

            if (fishermen <= 6)
            {
                rent -= rent * 0.1;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                rent -= rent * 0.15;
            }
            else
            {
                rent -= rent * 0.25;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }

            double difference = budget - rent;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! You have {difference:F2} leva left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
        }
    }
}