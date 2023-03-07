namespace opdracht_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            int anwser = first * second;
            Console.WriteLine(first + " * " + second + " = " + anwser);

        }
    }
}