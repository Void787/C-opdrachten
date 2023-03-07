namespace opdracht_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine("the sum is " + sum);
        }
    }
}