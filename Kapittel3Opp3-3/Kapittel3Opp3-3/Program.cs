using System;
using System.Security.AccessControl;


namespace Kapittel3Opp3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Opt3av3();
        }
        private static void Opt3av3()
        {
            
            int[] numbers = { 3, 2, 1, 2, 9, 6, 8 };
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"sortert = {IsSorted(numbers)}");


            numbers = new[] { 1, 4, 6, 8, 10, 14 };
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"sortert = {IsSorted(numbers)}");
        }

        private static bool IsSorted(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }
            return true;
        }

      

    }
    }
