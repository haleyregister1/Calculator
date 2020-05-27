using System;

namespace CalculaterUIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values you'd like to use:");
            int num1 = int.Parse(Console.ReadLine()); int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Would you like to Add, Subtract, Multiply, or Divide these values?");
            string oper = Console.ReadLine().ToLower();

            Operations userAns = new Operations();

            Console.WriteLine();

            switch (oper)
            {
                case "add":

                    Console.WriteLine($"The Answer is: {userAns.AddMethod(num1, num2)}");
                    break;
                case "subtract":
                    Console.WriteLine($"The Answer is: {userAns.SubtractMethod(num1, num2)}");
                    break;
                case "multiply":
                    Console.WriteLine($"The Answer is: {userAns.MultiMethod(num1, num2)}");
                    break;
                case "divide":
                    Console.WriteLine($"The Answer is: {userAns.DivideMethod(num1, num2)}");
                    break;
                default:
                    Console.WriteLine($"{oper} is an Invalid Operation.");
                    break;
            }
        }
    }
}
