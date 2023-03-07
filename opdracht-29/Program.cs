namespace opdracht_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the first number:");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine("they are equel!");
            } if (first > second) 
            {
                Console.WriteLine("The larger number is " + first + "!");
            } if (second > first)
            {
            Console.WriteLine("The larger number is " + second + "!");
            }
        }
    }
}