using System;
using System.Transactions;

namespace Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose options");
            Console.WriteLine("Choose 1 for all times-table");
            Console.WriteLine("Choose 2 to print times table till n th number");

            string option = Console.ReadLine();

            if (option == "1")
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    Console.WriteLine("----------");
                }
            }
            else if (option == "2")
            {
                Console.WriteLine("Enter the number to print the time table untill it");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    Console.WriteLine("----------");
                }
            }

            Console.WriteLine("Choose 1 to continue");
            Console.WriteLine("Click anything to quit");

            option = Console.ReadLine();
            if (option == "1")
                Main(args);
            else return;
        }
    }
}