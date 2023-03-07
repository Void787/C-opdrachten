namespace opdracht_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            int var1 = Convert.ToInt32(Console.ReadLine());
            int totalofseconds = var1 * 24 * 60 * 60;
            Console.WriteLine(totalofseconds);
        }
    }
}