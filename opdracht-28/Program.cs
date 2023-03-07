namespace opdracht_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("you're a adult!");
            } else
            {
                Console.WriteLine("you're under age!");
            }
        }
    }
}