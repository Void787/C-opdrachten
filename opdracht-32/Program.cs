namespace opdracht_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speak, friend, and enter ");
            string num = Console.ReadLine();

            if (num == "Mellon")
            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }
        }
    }
}