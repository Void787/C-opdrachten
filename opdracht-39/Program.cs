namespace opdracht_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int incomming = Convert.ToInt32(Console.ReadLine());
                if (incomming == 0)
                {
                    break;
                }
                count += incomming;
            }
            Console.WriteLine("Total sum of numbers: " + count);
        }
    }
}