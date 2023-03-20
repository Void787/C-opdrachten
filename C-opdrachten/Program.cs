namespace C_opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (username == "alex" && password == "sunshine" || username == "emma" && password == "haskell") 
            {
                Console.WriteLine("You have successfully logged in!");
            } else
            {
                Console.WriteLine("Incorrect username or password!");
            }
        }
    }
}