namespace Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string accomodation = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0.0;
            double discount = 0.0;

            switch (accomodation)
            {
                case "room for one person":
                    price = nights * 118;
                    break;
                case "apartment":
                    price = nights * 155;

                    if (nights < 10)
                    {
                        discount = price * 0.3;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        discount = price * 0.35;
                    }
                    else
                    {
                        discount = price * 0.5;
                    }

                    break;
                case "president apartment":
                    price = nights * 235;

                    if (nights < 10)
                    {
                        discount = price * 0.1;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        discount = price * 0.15;
                    }
                    else
                    {
                        discount = price * 0.2;
                    }

                    break;
            }

            price -= discount;

            if (feedback == "positive")
            {
                price += price * 0.25;
            }
            else if (feedback == "negative")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}