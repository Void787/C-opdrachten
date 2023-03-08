namespace h2_opdracht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times?");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < number)
            {
                PrintPhrase();
                i++;
            }
        }

        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
            Console.WriteLine();
        }
    }
}