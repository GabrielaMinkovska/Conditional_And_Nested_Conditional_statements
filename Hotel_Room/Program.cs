namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            switch (month)
            {
                case "May":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;

            }
            double studioTotal = studioPrice * nights;
            double apartmentTotal = apartmentPrice * nights;

            if ( nights > 14 )
            {
                if (month == "May" || month == "October")
                {
                    studioTotal = studioTotal * 0.70;
                }
                else if (month == "June" || month == "september")
                {
                    studioTotal = studioTotal * 0.80;
                }
                apartmentTotal = apartmentTotal * 0.90;
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                studioTotal = studioTotal * 0.95;
            }

            Console.WriteLine($"Apartment: {(apartmentTotal):F2} lv.");
            Console.WriteLine($"Studio: {(studioTotal):F2} lv.");
        }
    }
}