namespace h2_opdracht_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");
            double sum = 0;
            int Numbers;
            double A = 0;
            int even = 0;
            int odd = 0;
            for (int i = 0; true; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                if (number == -1) {
                    Numbers = i;
                    A = sum / i;
                    break; 
                }
                if (number % 2 == 0)
                {
                    even++;
                } else
                {
                    odd++;
                }
                sum += number;
            }
            Console.WriteLine();
            Console.WriteLine("thx bye!");
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine();
            Console.WriteLine("Numbers: " + Numbers);
            Console.WriteLine();
            Console.WriteLine("Average: " + A);
            Console.WriteLine();
            Console.WriteLine("Even: " + even);
            Console.WriteLine();
            Console.WriteLine("Odd: " + odd);
        }
    }
}