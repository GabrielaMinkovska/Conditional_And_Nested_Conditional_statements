namespace NewHome_2
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

            switch (type)
            {
                case "Roses":
                    purchase = count * 5.00;
                    if (count > 80)
                        purchase = purchase * 0.90;
                    break;
                case "Dahlias":
                    purchase = count * 3.80;
                    if (count > 90)
                        purchase = purchase * 0.85;
                    break;
                case "Tulips":
                    purchase = count * 2.80;
                    if (count > 80)
                        purchase = purchase * 0.85;
                    break;
                case "Narcissus":
                    purchase = count * 3.00;
                    if (count < 120)
                        purchase = purchase * 1.15;
                    break;
                case "Gladiolus":
                    purchase = count * 2.50;
                    if (count < 80)
                        purchase = purchase * 1.20;
                    break;
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