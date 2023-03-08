namespace h2_opdracht_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintUntilNumber(5);
        }

        static void PrintUntilNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
        }
    }
}