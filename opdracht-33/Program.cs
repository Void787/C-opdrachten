namespace opdracht_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the first string");
            string num = Console.ReadLine();
            Console.Write("Give the second string");
            string num2 = Console.ReadLine();

            if (num == num2)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }
        }
    }
}