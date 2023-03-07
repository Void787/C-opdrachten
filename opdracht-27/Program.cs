namespace opdracht_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
                Console.WriteLine("It is negative");
            }
        }
    }
}