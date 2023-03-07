namespace opdracht_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the third number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2 + number3;
            Console.WriteLine("the sum is " + sum);
        }
    }
}