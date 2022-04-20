﻿using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
           

            while (input != "NoMoreMoney")
            {
                double total = double.Parse(input);

                if (total < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {total:f2}");
                    sum += total;
                    input = Console.ReadLine();
                }
                
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
