namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double cost = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = budget * 0.30;
                    holidayType = "Camp";
                }
                else
                {
                    cost = budget * 0.70;
                    holidayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    cost = budget * 0.40;
                    holidayType = "Camp";
                }
                else
                {
                    cost = budget * 0.80;
                    holidayType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                cost = budget * 0.90;
                holidayType = "Hotel";

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {(cost):F2}");
        }            
    }
}