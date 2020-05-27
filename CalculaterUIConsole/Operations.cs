using System;
namespace CalculaterUIConsole
{
    public class Operations
    {
        public Operations()
        {
        }

        public int AddMethod(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int SubtractMethod(int min1, int sub2)
        {
            int diff = min1 - sub2;
            return diff;
        }

        public int MultiMethod(int num1, int num2)
        {
            int prod = num1 * num2;
            return prod;
        }

        public int DivideMethod(int num1, int num2)
        {
            int quo = num1 / num2;
            return quo;
        }
    }
}
