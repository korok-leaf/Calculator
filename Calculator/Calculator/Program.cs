using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("calculator start");
            Console.WriteLine("type a number and press enter");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("type a number and press enter");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose operator");
            Console.WriteLine("\t a - add");
            Console.WriteLine("\t s - subtract");
            Console.WriteLine("\t m - multiply");
            Console.WriteLine("\t d - divide");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("result: " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine("result: " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("result: " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine("result: " + (num1 / num2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
