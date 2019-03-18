using System;

namespace PowerOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power of a Number!");
            Console.WriteLine("------------------");

            try
            {
                Console.WriteLine("Enter the number whose power is to be found");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the power value");
                int powerValue = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("The result is "+PrintPowerofANumber(number, powerValue));
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static float PrintPowerofANumber(float number, int powerValue) {
            float result = 0;

            if (powerValue == 0) {
                return 1;
            }
            if (powerValue == 1) {
                return number;
            }
            float half = PrintPowerofANumber(number, ((Math.Abs(powerValue)) / 2)); ;
            if (powerValue % 2 == 0)
            {
                result = half * half;
            }
            else {
                result = number * half * half ;
            }

            if (powerValue < 0) {
                result = 1 / result;
            }

            return result;
        }
    }
}
