using System.Runtime.CompilerServices;

namespace opdracht_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool anwser = false;
            while (anwser == false) {
                Console.WriteLine("Do you want to continue?");
                string incomming = Console.ReadLine();
                if (incomming == "no")
                {
                    anwser = true;
                }
            }
        }
    }
}