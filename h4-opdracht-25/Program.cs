using System.Reflection;

namespace h4_opdracht_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] lines = File.ReadAllLines("../../../names.txt");
            bool failed = false;
            Console.WriteLine("Enter names, an empty line quits.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                foreach (string line in lines)
                {
                    
                    if (line == input)
                    {
                        Console.WriteLine("The name is on the list.");
                        failed = false;
                        break;
                    }
                    else
                    {
                        failed = true;
                    }
                }
                if (failed)
                {
                    Console.WriteLine("The name is not on the list.");
                }
            }
            
        }
    }
}