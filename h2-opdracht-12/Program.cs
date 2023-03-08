namespace h2_opdracht_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintUntilNumber(5);
        }

        static void PrintUntilNumber(int number)
        {
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
        }
    }
}