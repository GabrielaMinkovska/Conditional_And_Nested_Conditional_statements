namespace Sky_Holiday_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string feedback= Console.ReadLine();

            double nightPrice = 0.0;

            switch (type)
            {
                case "room for one person":
                    nightPrice = 118;
                    break;
                case "apartment":
                    nightPrice = 155;
                    if (days < 10)
                    {
                        nightPrice *= 0.70;
                    }
                    else if (days >=10 && days <= 15)
                    {
                        nightPrice *= 0.65;
                    }
                    else if (days > 15)
                    {
                        nightPrice *= 0.5;
                    }
                    break;
                case "president apartment":
                    nightPrice = 235;
                    if (days < 10)
                    {
                        nightPrice *= 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        nightPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        nightPrice *= 0.80;
                    }
                    break;
            }
            double totalPrice = (days -1) * nightPrice;

            switch (feedback)
            {
                case "positive":
                    totalPrice *= 1.25;
                    break;
                case "negative":
                    totalPrice *= 0.90;
                    break;
            }

            Console.WriteLine($"{(totalPrice):F2}");
        }
    }
}