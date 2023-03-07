namespace opdracht_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int incomming = Convert.ToInt32(Console.ReadLine());
                if (incomming == 0)
                {
                    break;
                }
                count += incomming;
                count2++;
            }
            Console.WriteLine("Total sum of numbers: " + count);
            Console.WriteLine("Total amount of numbers: " + count2);
        }
    }
}