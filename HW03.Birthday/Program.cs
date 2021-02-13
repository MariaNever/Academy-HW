using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }
        public static void GetUserAge()
        {
            try
            {
                Console.WriteLine("Please, input your birth year: ");
                int birthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input your birth month: ");
                byte birthMonth = byte.Parse(Console.ReadLine());
                
                Console.WriteLine("Please, input current year: ");
                int currentYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Please, input current month: ");
                byte currentMonth = byte.Parse(Console.ReadLine());
                
                int userAge = new int();
                { 
                    if (currentMonth >= birthMonth)
                        userAge = currentYear - birthYear;
                    else
                        userAge = currentYear - birthYear - 1;

                    Console.WriteLine($"You are {userAge} years old");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}