namespace On_Time_For_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            // examMinutes += examHour * 60;
            examMinutes = examMinutes + examHour * 60;

            //arivalMinutes += arivalHour * 60;
            arrivalMinutes = arrivalMinutes + arrivalHour * 60;

            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");

                int difference = arrivalMinutes - examMinutes;
                int lateHours = difference / 60;
                int lateMinutes = difference % 60;

                if (lateHours >= 1)
                {
                    if (lateMinutes < 10)
                    {
                        Console.WriteLine($"{lateHours}:0{lateMinutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{lateHours}:{lateMinutes} hours after the start");
                    }

                }
                else if (difference > 0 && lateHours >= 0)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
            }

            else if ((examMinutes >= arrivalMinutes) && (examMinutes - arrivalMinutes <= 30))
            {
                Console.WriteLine("On time");

                int onTimeMinutes = examMinutes - arrivalMinutes;

                if (onTimeMinutes > 0)
                {
                    Console.WriteLine($"{onTimeMinutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");

                int difference = examMinutes - arrivalMinutes;
                int earliHours = difference / 60;
                int earlyMinutes = difference % 60;

                if (earliHours >= 1)
                {
                    if (earlyMinutes < 10)
                    {
                        Console.WriteLine($"{earliHours}:0{earlyMinutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{earliHours}:{earlyMinutes} hours before the start");
                    }
                }
                else if (earliHours <= 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}