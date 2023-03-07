namespace opdracht_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]");
            int first = Convert.ToInt32(Console.ReadLine());
            if (first <= 0)
            {
                Console.WriteLine("Impossible");
            }
            if (first <= 49 && first >= 0)
            {
                Console.WriteLine("Fail");
            }
            if (first <= 59 && first >= 50)
            {
                Console.WriteLine("1");
            }
            if (first <= 69 && first >= 60)
            {
                Console.WriteLine("2");
            }
            if (first <= 79 && first >= 70)
            {
                Console.WriteLine("3");
            }
            if (first <= 89 && first >= 80)
            {
                Console.WriteLine("4");
            }
            if (first <= 100 && first >= 90)
            {
                Console.WriteLine("5");
            }
            if (first > 100)
            {
                Console.WriteLine("Outstanding");
            }
        }
    }
}