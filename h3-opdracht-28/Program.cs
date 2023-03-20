using static System.Net.Mime.MediaTypeNames;

namespace h3_opdracht_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("write");
                string phase = Console.ReadLine();
                if (phase == "")
                {
                    break;
                }
                string[] pieces = phase.Split(" ");
                int last = pieces.Length - 1;
                Console.WriteLine(pieces[last]);
            }
        }
    }
}