namespace h2_opdracht_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            DivisibleByThreeInRange(num, num2);
        }

        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            for (int i = beginning; i < end; i++) 
            { 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}