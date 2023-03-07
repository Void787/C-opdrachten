namespace opdracht_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the second number");
            double second = Convert.ToDouble(Console.ReadLine());
            double FC = first + second;
            double SC = first - second;
            double TC = first * second;
            double FOC = first / second;

            Console.WriteLine(first + " + " + second + " = " + FC);
            Console.WriteLine(first + " - " + second + " = " + SC);
            Console.WriteLine(first + " * " + second + " = " + TC);
            Console.WriteLine(first + " / " + second + " = " + FOC);
        }
    }
}