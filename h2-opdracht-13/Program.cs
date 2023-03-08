namespace h2_opdracht_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give th first number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the second number: ");
            double den = Convert.ToDouble(Console.ReadLine());
            Division(num, den);
        }

        public static void Division(double numerator, double denominator)
        {
            double answer = numerator / denominator;
            Console.WriteLine("answer: " + answer);
        }
    }
}