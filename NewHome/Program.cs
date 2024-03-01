using System.Diagnostics;

namespace NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Flower	                Roses	Dahlias	Tulips	Narcissus	Gladiolus
            //Price per piece in BGN    5       3.80    2.80    3           2.50

            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double purchase = 0.0;

            if (type == "Roses")
            {
                purchase = count * 5.00;

                if (count > 80)
                {
                    purchase = purchase * 0.90;
                }
            }
            else if (type == "Dahlias")
            {
                purchase = count * 3.80;

                if (count > 90)
                {
                    purchase = purchase * 0.85;
                }
            }
            else if (type == "Tulips")
            {
                purchase = count * 2.80;

                if (count > 80)
                {
                    purchase = purchase * 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                purchase = count * 3.00;

                if (count < 120)
                {
                    purchase = purchase * 1.15;
                }
            }
            else if (type == "Gladiolus")
            {
                purchase = count * 2.50;

                if (count < 80)
                {
                    purchase = purchase * 1.20;
                } 
            }

            if (budget < purchase)
            {
                Console.WriteLine($"Not enough money, you need {(purchase - budget):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {(budget - purchase):F2} leva left.");
            }
        }
    }
}