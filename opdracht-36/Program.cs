using System;
using System.Globalization;

namespace opdracht_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int incomming = Convert.ToInt32(Console.ReadLine());
                if (incomming == 0)
                {
                    return;
                }
                if (incomming >= 0)
                {
                    int digit = incomming * incomming;
                    Console.WriteLine(digit);
                } else
                {
                    Console.WriteLine("That is negative");
                }
            }
        }
    }
}