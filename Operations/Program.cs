namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            int result = 0;
            string modularDivision = "";

            switch (operation)
            {
                case "+":
                    result = n1 + n2;
                    if (result % 2== 0)
                    {
                        modularDivision = "even";
                    }
                    else
                    {
                        modularDivision = "odd";
                    }
                    Console.WriteLine($"{n1} + {n2} = {result} - {modularDivision}");
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        modularDivision = "even";
                    }
                    else
                    {
                        modularDivision = "odd";
                    }
                    Console.WriteLine($"{n1} - {n2} = {result} - {modularDivision}");
                    break;
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        modularDivision = "even";
                    }
                    else
                    {
                        modularDivision = "odd";
                    }
                    Console.WriteLine($"{n1} * {n2} = {result} - {modularDivision}");
                    break;
                case "/":
                    double dresult = (double)n1 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {(dresult):F2}");
                    }
                    break;
                case "%":
                    result = n1 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    break;
            }
        }
    }
}