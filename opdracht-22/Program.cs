namespace opdracht_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("give the second number");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("give the third number");
            double digit = Convert.ToDouble(Console.ReadLine());
            double third = first + second + digit;
            double fourth = third / 3;
            Console.WriteLine("the average is: " + fourth);

        }
    }
}