namespace opdracht_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}