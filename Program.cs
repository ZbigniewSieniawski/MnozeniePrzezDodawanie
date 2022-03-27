using System;

namespace MnozeniePrzezDodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = Multiply(-3, 7);
            Console.WriteLine(total);
        }
        public static int Multiply(int multiplicand, int factor)
        {
            int result = 0;
            for (int i = 1; i <= Math.Abs(factor); i++)
            {
                result = result + multiplicand;    
            }
            if (factor > 0)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}