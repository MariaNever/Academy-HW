using System;

namespace HW03.Calculator.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number operations with Convert");
            Console.WriteLine("Input the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{number1} + {number2} = {StatiсCalculator.Add(number1, number2)}");
            Console.WriteLine($"{number1} - {number2} = {StatiсCalculator.Subtract(number1, number2)}");
            Console.WriteLine($"{number1} * {number2} = {StatiсCalculator.Multiply(number1, number2)}");
            Console.WriteLine();

            Console.WriteLine("Number operations with Parse");
            Console.WriteLine("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{num1} / {num2} = {StatiсCalculator.Divide(num1, num2)}");
            Console.WriteLine($"{num1} % {num2} = {StatiсCalculator.Remainder(num1, num2)}");
            Console.WriteLine();

            Console.WriteLine("Input radius of the circle: ");
            int circleRadius = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"The area of the circle is: {StatiсCalculator.CircleArea(circleRadius)}");
        }
    }
    public static class StatiсCalculator
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }

        public static int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

        public static double CircleArea(double circleRadius)
        {
            return 3.14 * circleRadius * circleRadius;
        }
    }
}