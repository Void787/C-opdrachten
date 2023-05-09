using System.Runtime.CompilerServices;

namespace C_opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new timer
            Timer timer = new(100);
            bool issixty = false;
            // Loop until you cancel the loop.
            // You can cancel with the CTRL + C
            while (issixty == false)
            {
                issixty = timer.StopTimer();
                Console.WriteLine(timer);
                timer.Advance();
                // Some error proving, we'll talk about this later.
                // Known as try-catch.
                try
                {
                    // Wait 100th of a second. 
                    // Sleep(1000) waits one second, if you want to test at slower pace.
                    Thread.Sleep(10);
                }
                // Other half of try-catch pair. 
                catch (Exception e)
                {
                    Console.WriteLine("Error happened: +" + e);
                }
            }
        }
    }
}