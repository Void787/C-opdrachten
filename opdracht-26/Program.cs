namespace opdracht_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your age");
            int orwel = Convert.ToInt32(Console.ReadLine());
            if (orwel < 1900)
            {
                Console.WriteLine("You're old");
            }
        }
    }
}